# Changelog

## v0.8.0
- Updated core unit tests.
- Moved cli tests to cli project's folder.
- Updated APIs.
	- iam
		- updated endpoints
	- matchmaking
		- updated endpoints
	- platform
		- added new endpoints
		- updated endpoints
	- sessionbrowser
		- added new endpoints
	- social
		- added new endpoints
		- updated endpoints
	- ugc
		- updated endpoints

## v0.7.0
- Added support for cookie parameters
- Added fluent interface as an alternative way to access operations and wrappers object directly from sdk object.
- Updated integration tests.
- Updated readme and operation indexes.
- Updated APIs.
	- gametelemetry
		- updated endpoints (exposed optional cookie authentication)
	- iam
		- updated endpoints
		- **BREAKING CHANGES**
			- `PublicRemoveTrustedDeviceV4` now required device token to be specified.
	- platform
		- added new endpoints
	- ugc
		- added new endpoint.

## v0.6.0
- Updated integration tests.
- Renamed some operation wrappers for better clarity.
- Updated readme file.
- Added operation indexes at [docs](docs).
- Updated APIs.
	- cloudsave:
		- added new endpoints.
	- dslogmanager:
		- **BREAKING CHANGES**
			- Renamed wrapper Operations class to DslogmanagerOperations.
	- dsmc
		- **BREAKING CHANGES**
			- Renamed wrapper Operations class to DsmcOperations.
	- gametelemetry
		- added new endpoints.
		- **BREAKING CHANGES**
			- Renamed wrapper Operations class to GametelemetryOperations.
	- iam
		- updated endpoints.
	- legal
		- updated endpoints.
	- lobby
		- updated models.
		- **BREAKING CHANGES**
			- Renamed wrapper Operations class to LobbyOperations.
	- matchmaking
		- updated models.
		- **BREAKING CHANGES**
			- Renamed wrapper Operations class to MatchmakingOperations.
	- platform
		- updated endpoints.
	- ugc
		- updated endpoints.
		- added new endpoints.

## v0.5.0
- Fixed some of integration tests.
- Added new integration tests for legal service.
- Updated APIs.
	- cloudsave:
		- added new endpoints.
		- updated endpoints.
		- added models.
		- updated models.
		- BREAKING CHANGES (deleted some models related to game reord and player record).
	- dslogmanager:
		- updated models.
	- iam
		- added new endpoints.
		- added models.
		- updated endpoints.
	- legal
		- added new endpoint.
		- updated endpoints.
	- lobby
		- added new endpoints.
		- updated endpoints.
		- updated models.
		- BREAKING CHANGES (deleted some endpoints related to export/import config).
	- platform
		- updated models.
	- sessionbrowser
		- updated endpoints.
	- ugc
		- updated endpoints.

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
