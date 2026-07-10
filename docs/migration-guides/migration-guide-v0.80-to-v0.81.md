<a name="v0.81.0"></a>
## [0.81.0] - 2026-07-10

### BREAKING CHANGES

#### AMS

The following operation(s) has been renamed.
- Operation `AccelByte.Sdk/Api/Ams/Operation/FleetCommander/Func1` renamed to `VersionInfo`

#### Challenge

The following operation(s) has been renamed.
- Operation `AccelByte.Sdk/Api/Challenge/Operation/ChallengeList/GetChallenges` renamed to `PublicGetChallenges`
- Operation `AccelByte.Sdk/Api/Challenge/Operation/ChallengeProgression/EvaluateMyProgress` renamed to `PublicEvaluateMyProgress`

#### CSM

The following model(s) has been updated.
- Model `AccelByte.Sdk/Api/Csm/Model/ApimodelAppItem`
    - Property `RedeploymentInfo` has been removed (models `ModelAppRedeploymentInfo`/`ModelAppRedeploymentDetail` removed).

#### GDPR

The following operation(s) has been moved.
- Operations `PublicCancelMyAccountDeletionRequest`, `PublicGetMyAccountDeletionStatus`, `PublicSubmitMyAccountDeletionRequest` moved from `DataDeletion` to new `DataDeletionHeadless` wrapper.
    - Before: `DataDeletion.PublicSubmitMyAccountDeletionRequest(...)`
    - After: `DataDeletionHeadless.PublicSubmitMyAccountDeletionRequest(...)`

#### IAM

The following operation(s) has been renamed.
- Operation `AccelByte.Sdk/Api/Iam/Operation/OAuth/PlatformTokenRequestHandler` renamed to `NamespaceScopedPlatformTokenGrant`

The following model(s) has been renamed.
- Model `AccelByte.Sdk/Api/Iam/Model/ModelLinkRequest` renamed to `ModelReAuthRequest`
    - Wrapper methods `Users.PublicGetAsyncStatus` and `Users.PublicProcessWebLinkPlatformV3` return type changed from `ModelLinkRequest` to `ModelReAuthRequest`.
