# Copyright (c) 2021 AccelByte Inc. All Rights Reserved.
# This is licensed software from AccelByte Inc, for limitations
# and restrictions contact your company contract manager.

SHELL := /bin/bash

.PHONY: build test

build:
	docker run --rm -u $$(id -u):$$(id -g) -v $$(pwd):/data/ -w /data/ -e DOTNET_CLI_HOME="/data" mcr.microsoft.com/dotnet/sdk:6.0 dotnet build

pack:
	docker run --rm -u $$(id -u):$$(id -g) -v $$(pwd):/data/ -w /data/ -e DOTNET_CLI_HOME="/data" mcr.microsoft.com/dotnet/sdk:6.0 dotnet pack AccelByte.Sdk/AccelByte.Sdk.csproj -c Release

pack_push:
	@test -n "$(NUGET_API_KEY)" || (echo "NUGET_API_KEY is not set" ; exit 1)
	docker run --rm -u $$(id -u):$$(id -g) -v $$(pwd):/data/ -w /data/ \
		-e DOTNET_CLI_HOME="/data" \
		mcr.microsoft.com/dotnet/sdk:6.0 \
		dotnet pack AccelByte.Sdk/AccelByte.Sdk.csproj -c Release
	docker run --rm -u $$(id -u):$$(id -g) -v $$(pwd):/data/ -w /data/ \
		-e DOTNET_CLI_HOME="/data" \
		mcr.microsoft.com/dotnet/sdk:6.0 \
		dotnet nuget push "AccelByte.Sdk/bin/Release/*.nupkg" --skip-duplicate --api-key "$(NUGET_API_KEY)" --source "https://api.nuget.org/v3/index.json"

test:
	@test -n "$(SDK_MOCK_SERVER_PATH)" || (echo "SDK_MOCK_SERVER_PATH is not set" ; exit 1)
	sed -i "s/\r//" "$(SDK_MOCK_SERVER_PATH)/mock-server.sh" && \
			trap "docker stop -t 1 justice-codegen-sdk-mock-server && docker rm -f mylocal_httpbin" EXIT && \
			docker run -d --name mylocal_httpbin --network host -p 8070:80 kennethreitz/httpbin && \
			(bash "$(SDK_MOCK_SERVER_PATH)/mock-server.sh" -s /data/spec &) && \
			(for i in $$(seq 1 10); do bash -c "timeout 1 echo > /dev/tcp/127.0.0.1/8080" 2>/dev/null && exit 0 || sleep 10; done; exit 1) && \
			docker run --rm -u $$(id -u):$$(id -g) -v $$(pwd):/data/ -w /data/ --network host -e AB_HTTPBIN_URL=http://localhost -e DOTNET_CLI_HOME="/data" mcr.microsoft.com/dotnet/sdk:6.0 dotnet test && \
			docker run --rm -u $$(id -u):$$(id -g) -v $$(pwd):/data/ -w /data/ --network host -e AB_HTTPBIN_URL=http://localhost -e DOTNET_CLI_HOME="/data" mcr.microsoft.com/dotnet/sdk:6.0 dotnet test --filter="TestCategory=ReliableHttpClient"

test_cli:
	@test -n "$(SDK_MOCK_SERVER_PATH)" || (echo "SDK_MOCK_SERVER_PATH is not set" ; exit 1)
	rm -f test.err
	docker run --rm -u $$(id -u):$$(id -g) -v $$(pwd):/data/ -w /data/ -e DOTNET_CLI_HOME="/data" mcr.microsoft.com/dotnet/sdk:6.0 dotnet publish -r linux-x64
	sed -i "s/\r//" "$(SDK_MOCK_SERVER_PATH)/mock-server.sh" && \
			trap "docker stop -t 1 justice-codegen-sdk-mock-server" EXIT && \
			(bash "$(SDK_MOCK_SERVER_PATH)/mock-server.sh" -s /data/spec &) && \
			(for i in $$(seq 1 10); do bash -c "timeout 1 echo > /dev/tcp/127.0.0.1/8080" 2>/dev/null && exit 0 || sleep 10; done; exit 1) && \
			sed -i "s/\r//" samples/AccelByte.Sdk.Sample.Cli/tests/* && \
			rm -f samples/AccelByte.Sdk.Sample.Cli/tests/*.tap && \
			(for FILE in $$(ls samples/AccelByte.Sdk.Sample.Cli/tests/*.sh); do \
					(set -o pipefail; PATH="samples/AccelByte.Sdk.Sample.Cli/bin/Debug/net6.0/linux-x64/publish:$$PATH" bash $$FILE | tee "$${FILE}.tap") || touch test.err; \
			done)
	[ ! -f test.err ]

test_integration:
	@test -n "$(ENV_FILE_PATH)" || (echo "ENV_FILE_PATH is not set" ; exit 1)
	bash -c 'docker run --rm -u $$(id -u):$$(id -g) -v $$(pwd):/data/ -w /data/ --network host -e DOTNET_CLI_HOME="/data" --env-file "$(ENV_FILE_PATH)" mcr.microsoft.com/dotnet/sdk:6.0 \
		dotnet test --nologo --filter "TestCategory=FluentIntegration" --verbosity n'
