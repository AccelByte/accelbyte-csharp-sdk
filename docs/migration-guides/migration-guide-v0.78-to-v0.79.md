<a name="v0.79.1"></a>
## [0.79.1] - 2026-03-31

### BREAKING CHANGES

#### Basic

The following operation(s) has been updated.
- Operation `AccelByte.Sdk/Api/Basic/Operation/Namespace/GetNamespaces`
    - Constructor signature changed: a new parameter `bool? isTesting` has been added.
    - Before: `new GetNamespaces(bool? activeOnly)`
    - After: `new GetNamespaces(bool? activeOnly, bool? isTesting)`
    - Callers that construct this operation directly must add the new parameter (pass `null` to preserve previous behavior).

#### Challenge

The following operation(s) has been updated.
- Operation `AccelByte.Sdk/Api/Challenge/Operation/ChallengeProgression/AdminEvaluateProgress`
    - Constructor signature changed: a new parameter `string? includeOneTimeEvent` has been inserted between `challengeCode` and `body`.
    - Before: `new AdminEvaluateProgress(string namespace_, List<string>? challengeCode, ModelEvaluatePlayerProgressionRequest body)`
    - After: `new AdminEvaluateProgress(string namespace_, List<string>? challengeCode, string? includeOneTimeEvent, ModelEvaluatePlayerProgressionRequest body)`
    - Callers that construct this operation directly must insert the new parameter (pass `null` to preserve previous behavior).
- Operation `AccelByte.Sdk/Api/Challenge/Operation/ChallengeProgression/EvaluateMyProgress`
    - Constructor signature changed: a new parameter `string? includeOneTimeEvent` has been added.
    - Before: `new EvaluateMyProgress(string namespace_, List<string>? challengeCode)`
    - After: `new EvaluateMyProgress(string namespace_, List<string>? challengeCode, string? includeOneTimeEvent)`
    - Callers that construct this operation directly must add the new parameter (pass `null` to preserve previous behavior).
