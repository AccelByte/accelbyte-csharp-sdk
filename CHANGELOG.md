<a name="v0.73.0"></a>
## [v0.73.0]
### ci
- **:** consolidate build label lima
- **:** consolidate extend-builder-batch linux-amd64
- **github:** change label to extend-builder-ci
- **integration:** remove redundant Jenkinsfile.integration
- **generate:** remove cli and integration test stage
- **nightly:** add params for cli and integration test
- **nightly-starter:** remove redundant Jenkinsfile.nightly-starter
### docs
- **:** fix url
### chore
- **:** remove armada related apis


<a name="v0.72.0"></a>
## [v0.72.0]
### REMOVED SERVICE APIS
- The Matchmaking (V1), Sessionbrowser, and Sessionhistory APIs have been removed in this release.
### fix
- **test:** use create test user endpoint for integration test
- **:** delete iam client after csm test
- **test:** use admin create user v4 for test
- **:** check getappv2 response against null
### chore
- **:** remove mmv1 related apis
- **:** remove deprecated api cli tests


<a name="v0.71.0"></a>
## [v0.71.0]
### ci
- **coverity:** add arm64 build machine support
- **coverity:** this job often stuck in ec2 build machine for certain language
- **coverity:** change coverity download path
- **coverity:** workaround to avoid hangs
### test
- **integration:** gametelemetry - remove deprecated endpoints
- **integration:** csm - update changed model
### docs
- **common use cases:** update
- **:** add cli sample app operation list
### chore
- **sdk:** generated from openapi spec commit: a2c66653b15e9f6a946f1b0f72073f508f4f1299


<a name="v0.70.0"></a>
## [v0.70.0]
### test
- **integration:** skip login queue in ags shared cloud
### fix
- **cli:** fix no stored token message


<a name="v0.69.0"></a>
## [v0.69.0]
### fix
- **ams:** replace deleteAt type with string
### docs
- **readme:** update doc links


<a name="v0.68.0"></a>
## [v0.68.0]
### chore
- **:** generate csm service sdk
- **test:** disable gametelemetry test for shared cloud
- **test:** integration - add unique display name and login with email
- **makefile:** cli - increase waiting time
### feat
- **test:** add csm integration tests
- **test:** add role override test
- **core:** update get role permission endpoint
### docs
- **:** update common use case to add csm part
- **readme:** update links
### fix
- **:** update all project to net8 so publish works correctly
- **:** force publish to use debug config for test cli
- **:** update test cli dotnet publish command


<a name="v0.67.0"></a>
## [v0.67.0]
### feat
- **:** add challenge service integration tests
- **:** add net8 support for sdk and tests
### chore
- **:** use net8 for docker build
### ci
- **coverity:** update to .net 8.0


<a name="v0.66.0"></a>
## [v0.66.0]
### chore
- **test:** remove event log integration test
- **:** repull branch
- **:** refactor inventory test to cleanup warnings
- **:** remove eventlog support
- **:** remove mmv1 and sessionbrowser test
- **integration:** add player record cloudsave test
- **docs:** add player record cloudsave integration test
### docs
- **:** update common use case to remove eventlog
- **common use case:** remove deprecated services
### fix
- **test:** fill name for match option in match pool integration test
- **:** update ws reconnect test code
- **test:** attempt to fix issue found by coverity


<a name="v0.65.0"></a>
## [v0.65.0]
### feat
- **core:** implement ws reconnect
- **lobby:** implement lobby session id process
- **test:** add ws reconnect test for lobby service
- **:** add binary upload and download helper
- **test:** add integration test for upload and download
### docs
- **:** add ws usage in readme
- **:** add migration guide draft for 0.65
- **:** update platform service op index
### fix
- **:** set ws default deflate option
- **cli:** add delay after ws connect
- **cli:** merge connect and listen async and add delay before send
- **cli:** move delay to before send ws message
- **test:** update any integration tests that use create store
- **cli:** allow parse of int list input param
- **cli:** handle json array format for list int
### chore
- **cli:** change ws mock logging level
- **makefile:** clean up test_core target commands
- **makefile:** update test_cli to use standalone ws mock server
- **:** regenerate platform service for 3.77 adjustment
### test
- **cli:** lobby - use standalone ws mock server
- **integration:** match2 - fix ruleset test payload
- **integration:** add inventory test


<a name="v0.64.1"></a>
## [v0.64.1]
### fix
- **:** fix access token validation condition
- **:** disable session history xray metric test
- **test:** improve group integration test
- **test:** add more wait for session tests
- **test:** add missing wait in session party test
- **:** add tc cmd to nightly integration test script
- **:** remove junit in post step for integration test
### chore
- **:** bump up hotfix version 0.63.1
- **:** sync from master
### ci
- **:** use extend-builder-batch
- **:** update commitlint
- **generate:** use stage_extend-sdk
- **:** use extend-builder-ci for all stages
- **generate:** integration test - add tc delay
- **:** configurable slack channel env var
### feat
- **:** add wait for some integration tests
- **:** add integration test only jenkinsfile
### test
- **integration:** session history - remove xray
### docs
- **:** update links


<a name="v0.63.0"></a>
## [v0.63.0]
### fix
- **:** resolve latest coverity issues
- **docs:** update create namespace doc link in sample app


<a name="v0.62.0"></a>
## [v0.62.0]
### fix
- **:** temporarily disable session browser test
### ci
- **makefile:** rename test target to test_core


<a name="v0.61.0"></a>
## [v0.61.0]
### ci
- **:** do not use jenkins master


<a name="v0.60.0"></a>
## [v0.60.0]
### feat
- **sample:** add async sample app


<a name="v0.59.0"></a>
## [v0.59.0]
### chore
- **:** update 0.58 changelog


<a name="v0.58.0"></a>
## [v0.58.0]
### feat
- **:** add session history integration tests
- **:** add async methods for http client
- **:** add async support to auth and op process
- **:** feat: add achievement async test
### chore
- **:** regenerate async wrappers

<a name="v0.57.0"></a>
## [v0.57.0]
### feat
- **:** add websocket token refresh


<a name="v0.56.0"></a>
## [v0.56.0]
### ci
- **:** switch to extend-builder-ci


<a name="v0.55.0"></a>
## [v0.55.0]
### chore
- **sdk:** generated from openapi spec commit: 6a349250bfce7059426dd062035e36dd00033778
- **:** revert version due to cherry-pick
- **github:** update github creds
### feat
- **:** add dsartifact explicit integration test
### docs
- **:** remove new version entry in changelog due to cherry-pick
- **common-use-case:** update
### fix
- **:** clean published store in platform and seasonpass tests
### ci
- **generate:** update comon use case doc


<a name="v0.54.0"></a>
## [v0.54.0]
### docs
- **samples:** tic tac toe - update create game namespace link
### ci
- **nightly-starter:** separate from nightly
### test
- **integration:** temporarily disable configuration template tests in ags starter
### fix
- **clitest:** add support for multiple file uploads
### chore
- **:** regenerate cli tests
### feat
- **:** added namespace revamp support


<a name="v0.53.0"></a>
## [v0.53.0]
### feat
- **:** add chat service common use case markers
- **:** add core flightid support
- **:** add flightid httpbin test
### fix
- **:** update vulnerable dependency
- **:** move default flightid to config class
- **:** change httpbin op static builder field to static prop
### chore
- **:** regenerate sdk to implement flightid
### docs
- **:** add flightid info to readme


<a name="v0.52.0"></a>
## [v0.52.0]
### fix
- **test:** move armada related test to different category
- **test:** disable gdpr integration test for ags starter


<a name="v0.51.0"></a>
## [v0.51.0]
### ci
- **coverity:** update cov-analysis to 2023.6.2
### test
- **integration:** fix qosm test when there is no server


<a name="v0.50.0"></a>
## [v0.50.0]
### chore
- **git:** ignore macOS files
### test
- **base:** reduce retries to 3
- **core:** add using AGS starter flag
- **eventlog:** remove count assert
- **integration:** adjust tests to use client credentials for AGS starter environments
- **integration:** disable some tests for AGS starter environments
### ci
- **nightly:** add integration tests for AGS starter
### docs
- **:** update accelbyte doc portal links
### feat
- **:** add extend namespace to access token payload model
- **api:** bootstrap chat service support
- **:** add chatv2 integration tests


<a name="v0.49.0"></a>
## [v0.49.0]
### fix
- **:** fix token data is not cleared when RemoveToken is called


<a name="v0.48.0"></a>
## [v0.48.0]


<a name="v0.47.0"></a>
## [v0.47.0]
### feat
- **:** add permission validation function


<a name="v0.46.0"></a>
## [v0.46.0]
### feat
- **:** added login user with configurable scopes
- **:** update inventory service for ags 3.59
### fix
- **:** fix session tests due to op rename
- **:** update integration test and sample app to replace deprecated endpoints


<a name="v0.45.0"></a>
## [v0.45.0]
### fix
- **test:** remove match2 health check test
- **test:** remove ams health test line
- **:** added public oauth client test


<a name="v0.44.0"></a>
## [v0.44.0]
### ci
- **generate:** use demo_extend-sdk


<a name="v0.43.0"></a>
## [v0.43.0]


<a name="v0.42.0"></a>
## [v0.42.0]
### feat
- **:** added parse access token function
### docs
- **:** updated readme for parse access token info
### chore
- **:** regenerate ams sdk
### fix
- **integration:** fix ams integration test due to spec changes


<a name="v0.41.0"></a>
## [v0.41.0]
### docs
- **:** use docs-old for now for some docs
### fix
- **ams:** fix ams integration test due to op renaming
- **lobby:** disable lobby presence integration test temporarily


<a name="v0.40.0"></a>
## [v0.40.0]
### feat
- **integration:** add lobby presence test
### fix
- **integration:** add lobby connect before start session browser test
- **integration:** use admin delete session endpoint for session browser test


<a name="v0.39.0"></a>
## [v0.39.0]
### feat
- **core:** added on demand refresh token option
- **test:** added integration test for on demand refresh token
- **sample:** added sample app for on deman refresh token
- **mock-server:** change jenkinfile for new mock-server path
### docs
- **:** updated readme with on demand refresh token info
### fix
- **integration:** fix get match pool detail integration test


<a name="v0.38.0"></a>
## [v0.38.0]
### feat
- **core:** added json serialization options and its tests


<a name="v0.37.0"></a>
## [v0.37.0]
### fix
- **test:** try fix seasonpass init store fail in integration test


<a name="v0.36.0"></a>
## [v0.36.0]
### fix
- **tests:** fixed remaining hardcoded httpbin config
### chore
- **sdk:** generated from openapi spec commit: c30f5d94054e605e482f1877ff7238f721d561de
- bump down version to 0.35
### feat
- **test:** added initial AMS integration test
- added AMS service


<a name="v0.35.0"></a>
## [v0.35.0]
### chore
- **jenkinsfile:** update generate spec target
### fix
- **tests:** fixed leaderboard integration test

<a name="v0.34.0"></a>
## [v0.34.0]
### fix
- change agent for github jenkins job
- **ci:** add HOME env to pack push action
- **sample:** updated tic tac toe sample due to custom op implementation
- **sample:** adjust deps version for custom op test project
- make custom op test explicit
### ci
- **generate:** refactor jenkinsfile.generate
- **generate:** generate changelog also
### feat
- **sample:** added custom op sample projects
- added support for custom sdk and its builder
### docs
- **guide:** updated custom operation guide
- added migration guide draft for 0.34.0


<a name="v0.33.0"></a>
## [v0.33.0]

## integration
- test: due to code level breaking change caused by openapi spec changes in platform service

## makefile
- ci: add outstanding_deprecation target

## jenkinsfile.generate
- ci: add outstanding deprecation check
- ci: fix error when no outstanding deprecation

## github
- ci: add publish to nuget step for github jenkin job

## sdk
- chore: - generated from source sdk spec commit: 833206f541b49d45e4d1a5d1f5ea5acb1b9c1688



<a name="v0.32.0"><a>
## [v0.32.0]
- Sample: update CLI sample app to use op builder pattern
- Docs: add enable http logging in README
- Docs: updated migration guide link in README

<a name="v0.31.1"><a>
## [v0.31.1]
- Hotfix: fixed image size model's property for DSMC service.

<a name="v0.31.0"></a>
## [v0.31.0]
- Removed title matchmaking sample app.
- Updated Basic and Session service integration tests.
- Fixed refresh token integration test.

<a name="v0.30.0"></a>
## [v0.30.0]
- Updated documentations due to name change.

<a name="v0.29.0"></a>
## [v0.29.0]
- API models and endpoints changed. See affected items [here](docs/migration-guides/migration-guide-v0.28-to-v0.29.md)
- Updated AWS Lambda sample app to allow both local tests and FunctionURL invocation.
- Update Lobby integration tests.
- Fixed some minor defects detected by Coverity Scan.
- Added reporting service integration test.

<a name="v0.28.0"></a>
## [v0.28.0]
- Changed operation's static var for builder object to static property.
- Added new generic method for operation that has response with object data type in it.

<a name="v0.27.0"></a>
## [v0.27.0]
- Updated local OAuth Client token validation.
- Fixed Platform integration tests.

<a name="v0.26.0"></a>
## [v0.26.0]
- Fixed MatchV2 integration test for MatchPool.
- Added local OAuth Client token validation (PREVIEW FEATURE).

<a name="v0.25.0"></a>
## [v0.25.0]
- Fixed deprecated messages.

<a name="v0.24.0"></a>
## [v0.24.0]
- Added Create User V3 integration test.
- Namespace changed for some endpoints. See affected endpoint's [here](docs/migration-guides/migration-guide-v0.23-to-v0.24.md)

<a name="v0.23.0"></a>
## [v0.23.0]
- Added [getting started](samples/AccelByte.Sdk.Sample.GettingStarted) sample app.
- Added OpenAPI 2.0 vendor extension [information](spec/openapi-2.0-vendor-extensions.md).
- Make `AB_APP_NAME` optional in `DefaultConfigRepository`.
- Updated OIDC integration test.

<a name="v0.22.0"></a>
## [v0.22.0]
- Added new Matchmaking V2 API
- Added new Session API
- Added integration tests for both Matchmaking V2 and Session API.
- Updated APIs
	- dslogmanager:
		- updated endpoints
	- dsmc
		- updated endpoints
		- updated model
	- iam
		- added new endpoints
		- updated endpoints
	- matchmaking
		- updated endpoints
	- platform
		- updated models
		- **BREAKING CHANGE** `OptionBoxItem` changed to `EntitlementLootBoxReward`
		- **BREAKING CHANGE** `TrackedEntitlementInfo` changed to `EntitlementDecrementResult`
		- **BREAKING CHANGE** `PlayStationReconcileResult` changed to `LootBoxReward`
		- updated endpoints
	- seasonpass
		- updated model

<a name="v0.21.2"></a>
## [v0.21.2]
- Hotfix: revert breaking change on `TelemetryBody` model in gametelemetry API.

<a name="v0.21.1"></a>
## [v0.21.1]
- Hotfix: revert breaking change on `ModelsUserAchievementResponse` model in achievement API.

<a name="v0.21.0"></a>
## [v0.21.0]
- Updated getting started document.
- Fixed HTTP Clients that always send empty body on GET request.

<a name="v0.20.0"></a>
## [v0.20.0]
- Fixed HTTP Clients to handle upload stream handling.
- **BREAKING CHANGE** Fixed operation's response to output `Stream` object for most of export endpoints.

<a name="v0.19.0"></a>
## [v0.19.0]
- Changed doc folder structure.
- **BREAKING CHANGE** IAM TokenGrantV3 operation's response has changed from `OauthmodelTokenResponseV3` to `OauthmodelTokenWithDeviceCookieResponseV3`.
- **BREAKING CHANGE** `ITokenRepository` interface introduce new methods to accomodate `OauthmodelTokenWithDeviceCookieResponseV3`.

<a name="v0.18.0"></a>
## [v0.18.0]
- Fixed issues detected by coverity scan
- Fixed service integration tests due to retry policy used by all request that expect exception.
- Replaced deprecated operations in IAM service integration tests.
- Fixed WS CLI issues when running on specific AMI image used by jenkins worker.

<a name="v0.17.0"></a>
## [v0.17.0]
- Added Tic Tac Toe sample apps (Local Server, Game Client, and AWS Lambda)
- Fixed awesome message parsing
- Moved integration tests into different classes respective to AB Cloud service name
- Added common use cases documents [here](docs/common_use_cases.md)

<a name="v0.16.0"></a>
## [v0.16.0]
- Fixed bug on web socket execute routing in CLI sample app
- Added web socket interactive mode in CLI sample app
- Added Title Matchmaking sample apps (AWS Lambda, Local Server, and Client)
- Added Json file configuration and credential repository

<a name="v0.15.0"></a>
## [v0.15.0]
- Added integration test for SeasonPass
- Added integration test for QoSM
- Switch public HttpBin with locally deployed HttpBin image for core tests
- **POSSIBLE BREAKING CHANGE** Moved all deprecated operations back from its own namespace respective to each service.

<a name="v0.14.0"></a>
## [v0.14.0]
- Updated APIs
	- achievement
		- updated endpoints
	- cloudsave
		- updated endpoints
	- dsmc
		- updated model
	- eventlog
		- updated endpoints
	- gametelemetry
		- added new endpoints
	- gdpr
		- updated endpoints
	- group
		- updated endpoints
	- iam
		- added new endpoints
		- updated endpoints
	- leaderboard
		- updated endpoints
	- legal
		- updated endpoints
	- platform		
		- added new endpoints
		- updated endpoints
	- seasonpass
		- updated endpoints
	- social
		- updated endpoints
	- ugc
		- updated endpoints
		- added new endpoints

<a name="v0.13.0"></a>
## [v0.13.0]
- Fixed automatic token refresh performance issue.
- Added scheduled token refresh as an alternative to automatic token refresh.
- Added Platform login feature.
- Added OIDC sample web app.
- **BREAKING CHANGE** Moved all deprecated operations into its own namespace respective to each service.
- **POSSIBLE BREAKING CHANGE** There are some deprecated endpoints in IAM service.
- Added new endpoints in Platform service.
- Updated CLI sample app due to token refresh support and deprecation change.

<a name="v0.12.0"></a>
## [v0.12.0]
- Fixed basic user profile integration tests
- Updated gametelemetry integration test
- Updated APIs
	- basic
		- updated endpoints
		- updated model
	- dslogmanager
		- updated endpoints
	- dsmc
		- updated endpoints
	- group
		- updated model
	- iam
		- updated model
		- updated endpoints
	- legal
		- updated endpoints		
	- platform
		- updated models
		- added new endpoints
		- updated endpoints
	- seasonpass
		- updated models
	- social
		- updated models
	- ugc
		- updated model
		- updated endpoints

<a name="v0.11.0"></a>
## [v0.11.0]
- Implemented token auto refresh
- Updated APIs
	- achievement
		- updated endpoints
	- cloudsave
		- added new endpoints
		- updated endpoints
	- dsmc
		- updated endpoints
	- iam
		- updated models
		- updated endpoints
	- lobby
		- added new endpoints
	- platform
		- updated models
	- seasonpass
		- added new endpoints
		- updated models
		- updated endpoints

<a name="v0.10.0"></a>
## [v0.10.0]
- Implemented enum patches in operation's parameter
	- Possible **BREAKING CHANGES**
- Updated operation indexes
- Updated APIs
	- lobby
		- updated endpoints
		- **BREAKING CHANGES**
			- `ModelRequestFriendsRequest` replaced by `ModelUserRequestFriendRequest`

<a name="v0.9.0"></a>		
## [v0.9.0]
- Implemented enum in operation's parameter
	- Possible **BREAKING CHANGES**.
- `StringEnum::Create` function is renamed to `StringEnum::NewValue`.
- Updated APIs
	- dsmc
		- updated models
	- gametelemetry
		- updated endpoints
	- iam
		- updated models
	- platform
		- added new endpoints
		- updated endpoints
		- deprecation notice for some of wallet endpoints
	- ugc
		- updated endpoint

<a name="v0.8.0"></a>
## [v0.8.0]
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

<a name="v0.7.0"></a>
## [v0.7.0]
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

<a name="v0.6.0"></a>
## [v0.6.0]
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

<a name="v0.5.0"></a>
## [v0.5.0]
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

<a name="v0.4.0"></a>
## [v0.4.0]
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

<a name="v0.3.0"></a>
## [v0.3.0]
- Added lobby service feature.
- Added amazon trace id in every request.
- Added user agent info in every request.
- Added app name in config repository.
- Enabled builder pattern in operation classes.
- Updated APIs.
	- dsmc: added new endpoints.
	- platform: added new endpoints

<a name="v0.2.0"></a>
## [v0.2.0]
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

<a name="v0.1.0"></a>
## [v0.1.0]

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
