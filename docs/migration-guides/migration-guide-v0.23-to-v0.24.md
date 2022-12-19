<a name="v0.24.0"></a>
## [v0.24.0] - 2022-12-20

### BREAKING CHANGE
```
Operation's namespace changed for following endpoints:

- AccelByte.Sdk/Api/Achievement/Operation/ { Achievements → UserAchievements } /AdminListUserAchievements
- AccelByte.Sdk/Api/Achievement/Operation/ { Achievements → UserAchievements } /AdminResetAchievement
- AccelByte.Sdk/Api/Achievement/Operation/ { Achievements → UserAchievements } /AdminUnlockAchievement
- AccelByte.Sdk/Api/Achievement/Operation/ { Achievements → UserAchievements } /PublicListUserAchievements
- AccelByte.Sdk/Api/Achievement/Operation/ { Achievements → UserAchievements } /PublicUnlockAchievement

Following operation and model moved from `Dsmc` to `Dslogmanager`:
- AccelByte.Sdk/Api/ { Dsmc → Dslogmanager } /Model/ModelsServerLogs.cs
- AccelByte.Sdk/Api/ { Dsmc → Dslogmanager } /Operation/Admin/GetServerLogs.cs
```

[v0.24.0]: https://github.com/AccelByte/accelbyte-csharp-sdk/compare/v0.21.0...v0.24.0