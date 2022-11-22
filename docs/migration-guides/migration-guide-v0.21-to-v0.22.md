<a name="v0.22.0"></a>
## [v0.22.0] - 2022-11-21

### BREAKING CHANGE
```
Following changes in AB Cloud Platform Service:

Model `OptionBoxItem` changed to `EntitlementLootBoxReward`.
Model `TrackedEntitlementInfo` changed to `EntitlementDecrementResult`.
Model `PlayStationReconcileResult` changed to `LootBoxReward`.

The new models above are not fully compatible with it previous version.
So, if you are affected, make sure the fields are compatible.
```

[v0.22.0]: https://github.com/AccelByte/accelbyte-csharp-sdk/compare/v0.21.0...v0.22.0