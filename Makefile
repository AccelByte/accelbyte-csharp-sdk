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
			(DOCKER_RUN_ARGS="-t --rm -u $$(id -u):$$(id -g) -v  $$(readlink -f "$(SDK_MOCK_SERVER_PATH)"):/data -w /data --network host --name justice-codegen-sdk-mock-server" bash "$(SDK_MOCK_SERVER_PATH)/mock-server.sh" -s spec -g iam.json &) && \
			(for i in $$(seq 1 10); do bash -c "timeout 1 echo > /dev/tcp/127.0.0.1/8080" 2>/dev/null && exit 0 || sleep 10; done; exit 1) && \
			docker run --rm -v $$(pwd):/data/ -w /data/ --network host mcr.microsoft.com/dotnet/sdk:6.0 dotnet test'
