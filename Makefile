# Copyright (c) 2021 AccelByte Inc. All Rights Reserved.
# This is licensed software from AccelByte Inc, for limitations
# and restrictions contact your company contract manager.

.PHONY: build test

build:
	docker run --rm -v $$(pwd):/data/ -w /data/ mcr.microsoft.com/dotnet/sdk:6.0 dotnet build
  
test:
	docker run --rm -v $$(pwd):/data/ -w /data/ mcr.microsoft.com/dotnet/sdk:6.0 dotnet test
