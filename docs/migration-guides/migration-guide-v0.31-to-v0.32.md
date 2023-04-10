<a name="v0.32.0"></a>
## [v0.32.0] - 2023-04-10

### BREAKING CHANGE

Platform: Operation getPaymentCallbackConfig_1 is renamed to getRevocationConfig
Platform: Operation QueryChanges now returns CatalogChangePagingSlicedResult as response
Ugc: Operation SingleAdminUpdateContentS3 now uses ModelsUpdateContentRequest model as request body
Ugc: Operation AdminUpdateContentS3 now uses ModelsUpdateContentRequest model as request body
Ugc: Operation AdminUpdateChannel now uses ModelsUpdateChannelRequest model as request body
Ugc: Operation SingleAdminUpdateChannel now uses ModelsUpdateChannelRequest model as request body 
Ugc: Operation UpdateContentS3 now uses ModelsUpdateContentRequest model as request body 
Ugc: Operation CreateContentS3 now uses ModelsPublicCreateContentRequestS3 model as request body
Ugc: Operation UpdateChannel now uses ModelsUpdateChannelRequest model as request body
Ugc: Operation CreateChannel is renamed to PublicCreateChannel and now uses ModelsPublicChannelRequest request body

[v0.32.0]: https://github.com/AccelByte/accelbyte-csharp-sdk/compare/v0.31.0...v0.32.0