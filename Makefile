# Copyright (c) 2021 AccelByte Inc. All Rights Reserved.
# This is licensed software from AccelByte Inc, for limitations
# and restrictions contact your company contract manager.

.PHONY: build test

build:
	docker run --rm -v $$(pwd):/data/ -w /data/ mcr.microsoft.com/dotnet/sdk:6.0 dotnet build

test:
	@test -n "$(SDK_MOCK_SERVER_PATH)" || (echo "SDK_MOCK_SERVER_PATH is not set" ; exit 1)
	bash -c 'sed -i "s/\r//" "$(SDK_MOCK_SERVER_PATH)/mock-server.sh" && \
			trap "docker stop justice-codegen-sdk-mock-server" EXIT && \
			(DOCKER_RUN_ARGS="-t --rm -u $$(id -u):$$(id -g) -v $$(pwd):/data -w /data --network host --name justice-codegen-sdk-mock-server" bash "$(SDK_MOCK_SERVER_PATH)/mock-server.sh" -s /data/spec -g iam.json &) && \
			(for i in $$(seq 1 10); do bash -c "timeout 1 echo > /dev/tcp/127.0.0.1/8080" 2>/dev/null && exit 0 || sleep 10; done; exit 1) && \
			docker run --rm -v $$(pwd):/data/ -w /data/ --network host mcr.microsoft.com/dotnet/sdk:6.0 dotnet test'

test_cli:
	@test -n "$(SDK_MOCK_SERVER_PATH)" || (echo "SDK_MOCK_SERVER_PATH is not set" ; exit 1)
	rm -f test.err
	docker run --rm -v $$(pwd):/data/ -w /data/ mcr.microsoft.com/dotnet/sdk:6.0 dotnet publish -r linux-x64
	bash -c 'sed -i "s/\r//" "$(SDK_MOCK_SERVER_PATH)/mock-server.sh" && \
			trap "docker stop justice-codegen-sdk-mock-server" EXIT && \
			(DOCKER_RUN_ARGS="-t --rm -u $$(id -u):$$(id -g) -v $$(pwd):/data -w /data --network host --name justice-codegen-sdk-mock-server" bash "$(SDK_MOCK_SERVER_PATH)/mock-server.sh" -s /data/spec &) && \
			(for i in $$(seq 1 10); do bash -c "timeout 1 echo > /dev/tcp/127.0.0.1/8080" 2>/dev/null && exit 0 || sleep 10; done; exit 1) && \
			sed -i "s/\r//" tests/sh/* && \
			(for FILE in $$(ls tests/sh/*.sh | grep -v run-cli-all-tests.sh); do PATH="samples/AccelByte.Sdk.Sample.Cli/bin/Debug/net6.0/linux-x64/publish:$$PATH" bash $$FILE || touch /data/test.err; done)'
	[ ! -f test.err ]
