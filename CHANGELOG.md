# Changelog

## v0.4.0
- Added AWS Lambda sample app. See it's README in samples/AccelByte.Sdk.Sample.Aws.Lambda
- Added integration tests.
- Enabled builder pattern for creating AccelByteSDK object.
- Added optional credential repository to store credential used by client.
- Added logging feature (disabled by default).
- Fixed awesome message parsing.
- Updated APIs.
	- iam:
		- added new endpoints.
		- updated some endpoints.
	- lobby: updated endpoints.
	- platform: updated endpoints.

## v0.3.0
- Added lobby service feature.
- Added amazon trace id in every request.
- Added user agent info in every request.
- Added app name in config repository.
- Enabled builder pattern in operation classes.
- Updated APIs.
	- dsmc: added new endpoints.
	- platform: added new endpoints

## v0.2.0
- Added CLI sample application.
- Updated tests.
- Added file extension to MIME type converter for file upload.
- Updated APIs.
	- Added summary on each operation
	- iam: added new parameter in TokenGrantV3
	- lobby: added new endpoint.
	- platform: 
		- added new endpoints.
		- updated endpoints.
	- seasonpass: added new endpoint.
	- social: added new endpoint.


## v0.1.0

Initial release of C# SDK for AccelByte platform.

Supported APIs:

- achievement
- basic
- cloudsave
- dslogmanager
- dsmc
- eventlog
- gametelemetry
- gdpr
- group
- iam
- leaderboard
- legal
- lobby
- matchmaking
- platform
- qosm
- seasonpass
- sessionbrowser
- social
- ugc
