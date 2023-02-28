<a name="v0.29.0"></a>
## [v0.29.0] - 2023-02-28

## BREAKING CHANGE

### Achievement
The following operation builder's method are renamed.
```
- PublicListGlobalAchievementsBuilder.{ SetAchievementCodes -> SetAchievementCodes }
```

### Group
The following models are renamed.
```
- AccelByte.Sdk/Api/Group/Model/{ ModelsPublicGetGroupListRequestV2 -> ModelsGetGroupListRequestV2 }
```

### Lobby
The following operations are moved to a different package and the corresponding wrapper methods follows.
```
- AccelByte.Sdk/Api/Lobby/Operation/ { Notification → Admin } /CreateTemplate
- AccelByte.Sdk/Api/Lobby/Operation/ { Notification → Admin } /DeleteTemplateLocalization
- AccelByte.Sdk/Api/Lobby/Operation/ { Notification → Admin } /DeleteTemplateSlug
- AccelByte.Sdk/Api/Lobby/Operation/ { Notification → Admin } /FreeFormNotification
- AccelByte.Sdk/Api/Lobby/Operation/ { Notification → Admin } /GetGameTemplate
- AccelByte.Sdk/Api/Lobby/Operation/ { Notification → Admin } /GetLocalizationTemplate
- AccelByte.Sdk/Api/Lobby/Operation/ { Notification → Admin } /GetSlugTemplate
- AccelByte.Sdk/Api/Lobby/Operation/ { Notification → Admin } /NotificationWithTemplate
- AccelByte.Sdk/Api/Lobby/Operation/ { Notification → Admin } /PublishTemplate
- AccelByte.Sdk/Api/Lobby/Operation/ { Notification → Admin } /UpdateLocalizationTemplate
```

### Platform
The following models are renamed.
```
- AccelByte.Sdk/Api/Platform/Model/{ AvailablePredicateObject -> AvailablePredicate }
- AccelByte.Sdk/Api/Platform/Model/{ ADTOObjectForUnlockSteamAchievementAPI -> SteamAchievementUpdateRequest }
- AccelByte.Sdk/Api/Platform/Model/{ ADTOObjectForUpdateXboxAchievementCompletePercentageAPI -> XblAchievementUpdateRequest }
- AccelByte.Sdk/Api/Platform/Model/{ ADTOObjectForQueryingXboxUserAchievements -> XblUserAchievements }
```

### Social
The following models are renamed.
```
- AccelByte.Sdk/Api/Social/Model/{ BulkStatItemOperationResult -> BulkStatOperationResult }
```

[v0.29.0]: https://github.com/AccelByte/accelbyte-csharp-sdk/compare/v0.28.0...v0.29.0