# Copyright (c) 2021 AccelByte Inc. All Rights Reserved.
# This is licensed software from AccelByte Inc, for limitations
# and restrictions contact your company contract manager.

SHELL := /bin/bash

.PHONY: build test

build:
	docker run --rm -u $$(id -u):$$(id -g) -v $$(pwd):/data/ -w /data/ -e DOTNET_CLI_HOME="/data" mcr.microsoft.com/dotnet/sdk:6.0 dotnet build

test:
	@test -n "$(SDK_MOCK_SERVER_PATH)" || (echo "SDK_MOCK_SERVER_PATH is not set" ; exit 1)
	bash -c 'sed -i "s/\r//" "$(SDK_MOCK_SERVER_PATH)/mock-server.sh" && \
			trap "docker stop -t 1 justice-codegen-sdk-mock-server" EXIT && \
			(DOCKER_RUN_ARGS="-t --rm -u $$(id -u):$$(id -g) -v $$(pwd):/data -w /data --network host --name justice-codegen-sdk-mock-server" bash "$(SDK_MOCK_SERVER_PATH)/mock-server.sh" -s /data/spec -g iam.json &) && \
			(for i in $$(seq 1 10); do bash -c "timeout 1 echo > /dev/tcp/127.0.0.1/8080" 2>/dev/null && exit 0 || sleep 10; done; exit 1) && \
			docker run --rm -u $$(id -u):$$(id -g) -v $$(pwd):/data/ -w /data/ --network host -e DOTNET_CLI_HOME="/data" mcr.microsoft.com/dotnet/sdk:6.0 dotnet test'

test_cli:
	@test -n "$(SDK_MOCK_SERVER_PATH)" || (echo "SDK_MOCK_SERVER_PATH is not set" ; exit 1)
	rm -f test.err
	docker run --rm -u $$(id -u):$$(id -g) -v $$(pwd):/data/ -w /data/ -e DOTNET_CLI_HOME="/data" mcr.microsoft.com/dotnet/sdk:6.0 dotnet publish -r linux-x64
	sed -i "s/\r//" "$(SDK_MOCK_SERVER_PATH)/mock-server.sh" && \
			trap "docker stop -t 1 justice-codegen-sdk-mock-server" EXIT && \
			(DOCKER_RUN_ARGS="-t --rm -u $$(id -u):$$(id -g) -v $$(pwd):/data -w /data --network host --name justice-codegen-sdk-mock-server" bash "$(SDK_MOCK_SERVER_PATH)/mock-server.sh" -s /data/spec &) && \
			(for i in $$(seq 1 10); do bash -c "timeout 1 echo > /dev/tcp/127.0.0.1/8080" 2>/dev/null && exit 0 || sleep 10; done; exit 1) && \
			sed -i "s/\r//" tests/sh/* && \
			rm -f tests/sh/*.tap && \
			(for FILE in $$(ls tests/sh/*.sh); do \
					(set -o pipefail; PATH="samples/AccelByte.Sdk.Sample.Cli/bin/Debug/net6.0/linux-x64/publish:$$PATH" bash $$FILE | tee "$${FILE}.tap") || touch test.err; \
			done)
	[ ! -f test.err ]

test_integration:
	@test -n "$(TEST_ENV_FILE)" || (echo "TEST_ENV_FILE is not set" ; exit 1)
	bash -c 'docker run --rm -u $$(id -u):$$(id -g) -v $$(pwd):/data/ -w /data/ \
		--network host mcr.microsoft.com/dotnet/sdk:6.0 \\
		-e DOTNET_CLI_HOME="/data" \
		--env-file "$(TEST_ENV_FILE)" \
		dotnet test --nologo --filter "TestCategory=Integration" --verbosity n'
