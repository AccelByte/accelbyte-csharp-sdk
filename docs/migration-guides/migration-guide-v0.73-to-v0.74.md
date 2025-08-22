<a name="v0.74.0"></a>
## [0.74.0] - 2025-08-22

### BEHAVIOR CHANGE

Automatic token refresh is now configured using `.UseBackgroundTokenRefresh()` or `.UseOnDemandTokenRefresh()` when building the SDK object.
The default configuration can be overridden via environment variables or by passing an options object as a parameter.
The old builder methods are still available but deprecated. Using them will apply the default configuration for automatic token refresh.

In addition, the extended login methods are deprecated. Any values set for `autoRefresh` or `refreshThreshold` will be ignored in favor of the new configuration values.