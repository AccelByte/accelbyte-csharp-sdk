# Copyright (c) 2021 AccelByte Inc. All Rights Reserved.
# This is licensed software from AccelByte Inc, for limitations
# and restrictions contact your company contract manager.

.PHONY: build

build:
	docker run -t --rm -v $$(pwd):/data/ -w /data/ mcr.microsoft.com/dotnet/sdk:6.0 dotnet build
