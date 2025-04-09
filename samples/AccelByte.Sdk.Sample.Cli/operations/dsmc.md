## C# Extend SDK CLI Sample App Operation Index for Dsmc service.

### Operation ListConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op listconfig \

```

### Operation UpdateImage
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op updateimage \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation CreateImage
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op createimage \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation CreateImagePatch
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op createimagepatch \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetLowestInstanceSpec
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op getlowestinstancespec \

```

### Operation GetWorkerConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op getworkerconfig \
    --namespace <namespace value>
```

### Operation UpdateWorkerConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op updateworkerconfig \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation CreateWorkerConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op createworkerconfig \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op getconfig \
    --namespace <namespace value>
```

### Operation CreateConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op createconfig \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op deleteconfig \
    --namespace <namespace value>
```

### Operation UpdateConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op updateconfig \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation ClearCache
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op clearcache \
    --namespace <namespace value>
```

### Operation GetAllDeployment
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op getalldeployment \
    --namespace <namespace value> \
    --name <name value - optional> \
    --count <count value> \
    --offset <offset value>
```

### Operation GetDeployment
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op getdeployment \
    --deployment <deployment value> \
    --namespace <namespace value>
```

### Operation CreateDeployment
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op createdeployment \
    --deployment <deployment value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteDeployment
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op deletedeployment \
    --deployment <deployment value> \
    --namespace <namespace value>
```

### Operation UpdateDeployment
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op updatedeployment \
    --deployment <deployment value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation CreateRootRegionOverride
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op createrootregionoverride \
    --deployment <deployment value> \
    --namespace <namespace value> \
    --region <region value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteRootRegionOverride
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op deleterootregionoverride \
    --deployment <deployment value> \
    --namespace <namespace value> \
    --region <region value>
```

### Operation UpdateRootRegionOverride
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op updaterootregionoverride \
    --deployment <deployment value> \
    --namespace <namespace value> \
    --region <region value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation CreateDeploymentOverride
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op createdeploymentoverride \
    --deployment <deployment value> \
    --namespace <namespace value> \
    --version <version value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteDeploymentOverride
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op deletedeploymentoverride \
    --deployment <deployment value> \
    --namespace <namespace value> \
    --version <version value>
```

### Operation UpdateDeploymentOverride
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op updatedeploymentoverride \
    --deployment <deployment value> \
    --namespace <namespace value> \
    --version <version value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation CreateOverrideRegionOverride
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op createoverrideregionoverride \
    --deployment <deployment value> \
    --namespace <namespace value> \
    --region <region value> \
    --version <version value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteOverrideRegionOverride
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op deleteoverrideregionoverride \
    --deployment <deployment value> \
    --namespace <namespace value> \
    --region <region value> \
    --version <version value>
```

### Operation UpdateOverrideRegionOverride
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op updateoverrideregionoverride \
    --deployment <deployment value> \
    --namespace <namespace value> \
    --region <region value> \
    --version <version value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteCreatingServerCountQueue
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op deletecreatingservercountqueue \
    --deployment <deployment value> \
    --namespace <namespace value> \
    --version <version value>
```

### Operation GetAllPodConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op getallpodconfig \
    --namespace <namespace value> \
    --count <count value> \
    --offset <offset value>
```

### Operation GetPodConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op getpodconfig \
    --name <name value> \
    --namespace <namespace value>
```

### Operation CreatePodConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op createpodconfig \
    --name <name value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeletePodConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op deletepodconfig \
    --name <name value> \
    --namespace <namespace value>
```

### Operation UpdatePodConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op updatepodconfig \
    --name <name value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AddPort
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op addport \
    --name <name value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeletePort
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op deleteport \
    --name <name value> \
    --namespace <namespace value>
```

### Operation UpdatePort
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op updateport \
    --name <name value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation ListImages
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op listimages \
    --namespace <namespace value> \
    --q <q value - optional> \
    --sortBy <sortBy value - optional> \
    --sortDirection <sortDirection value - optional> \
    --count <count value> \
    --offset <offset value>
```

### Operation DeleteImage
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op deleteimage \
    --namespace <namespace value> \
    --imageURI <imageURI value> \
    --version <version value>
```

### Operation GetImageLimit
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op getimagelimit \
    --namespace <namespace value>
```

### Operation DeleteImagePatch
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op deleteimagepatch \
    --namespace <namespace value> \
    --imageURI <imageURI value> \
    --version <version value> \
    --versionPatch <versionPatch value>
```

### Operation GetImageDetail
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op getimagedetail \
    --namespace <namespace value> \
    --version <version value>
```

### Operation GetImagePatches
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op getimagepatches \
    --namespace <namespace value> \
    --version <version value>
```

### Operation GetImagePatchDetail
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op getimagepatchdetail \
    --namespace <namespace value> \
    --version <version value> \
    --versionPatch <versionPatch value>
```

### Operation AddBuffer
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op addbuffer \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetRepository
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op getrepository \
    --namespace <namespace value>
```

### Operation ListServer
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op listserver \
    --namespace <namespace value> \
    --region <region value - optional> \
    --count <count value> \
    --offset <offset value>
```

### Operation CountServer
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op countserver \
    --namespace <namespace value>
```

### Operation CountServerDetailed
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op countserverdetailed \
    --namespace <namespace value> \
    --region <region value - optional>
```

### Operation ListLocalServer
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op listlocalserver \
    --namespace <namespace value>
```

### Operation DeleteLocalServer
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op deletelocalserver \
    --name <name value> \
    --namespace <namespace value>
```

### Operation GetServer
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op getserver \
    --namespace <namespace value> \
    --podName <podName value>
```

### Operation DeleteServer
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op deleteserver \
    --namespace <namespace value> \
    --podName <podName value>
```

### Operation ListSession
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op listsession \
    --namespace <namespace value> \
    --region <region value - optional> \
    --withServer <withServer value - optional> \
    --count <count value> \
    --offset <offset value>
```

### Operation CountSession
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op countsession \
    --namespace <namespace value> \
    --region <region value - optional>
```

### Operation DeleteSession
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op deletesession \
    --namespace <namespace value> \
    --sessionID <sessionID value>
```

### Operation RunGhostCleanerRequestHandler
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op runghostcleanerrequesthandler \
    --namespace <namespace value>
```

### Operation RunZombieCleanerRequestHandler
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op runzombiecleanerrequesthandler \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation CreateRepository
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op createrepository \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation ExportConfigV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op exportconfigv1 \
    --namespace <namespace value>
```

### Operation ImportConfigV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op importconfigv1 \
    --namespace <namespace value> \
    --upload file <file to upload>
```

### Operation GetAllDeploymentClient
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op getalldeploymentclient \
    --namespace <namespace value> \
    --name <name value - optional> \
    --count <count value> \
    --offset <offset value>
```

### Operation GetDeploymentClient
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op getdeploymentclient \
    --deployment <deployment value> \
    --namespace <namespace value>
```

### Operation CreateDeploymentClient
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op createdeploymentclient \
    --deployment <deployment value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteDeploymentClient
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op deletedeploymentclient \
    --deployment <deployment value> \
    --namespace <namespace value>
```

### Operation GetAllPodConfigClient
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op getallpodconfigclient \
    --namespace <namespace value> \
    --count <count value> \
    --offset <offset value>
```

### Operation CreatePodConfigClient
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op createpodconfigclient \
    --name <name value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeletePodConfigClient
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op deletepodconfigclient \
    --name <name value> \
    --namespace <namespace value>
```

### Operation ListImagesClient
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op listimagesclient \
    --namespace <namespace value> \
    --count <count value - optional> \
    --offset <offset value - optional> \
    --q <q value - optional> \
    --sortBy <sortBy value - optional> \
    --sortDirection <sortDirection value - optional>
```

### Operation ImageLimitClient
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op imagelimitclient \
    --namespace <namespace value>
```

### Operation ImageDetailClient
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op imagedetailclient \
    --namespace <namespace value> \
    --version <version value>
```

### Operation ListServerClient
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op listserverclient \
    --namespace <namespace value> \
    --region <region value - optional> \
    --count <count value> \
    --offset <offset value>
```

### Operation CountServerDetailedClient
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op countserverdetailedclient \
    --namespace <namespace value> \
    --region <region value - optional>
```

### Operation ServerHeartbeat
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op serverheartbeat \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeregisterLocalServer
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op deregisterlocalserver \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation RegisterLocalServer
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op registerlocalserver \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation RegisterServer
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op registerserver \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation ShutdownServer
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op shutdownserver \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetServerSessionTimeout
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op getserversessiontimeout \
    --namespace <namespace value> \
    --podName <podName value>
```

### Operation GetServerSession
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op getserversession \
    --namespace <namespace value> \
    --podName <podName value>
```

### Operation CreateSession
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op createsession \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation ClaimServer
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op claimserver \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetSession
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op getsession \
    --namespace <namespace value> \
    --sessionID <sessionID value>
```

### Operation CancelSession
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op cancelsession \
    --namespace <namespace value> \
    --sessionID <sessionID value>
```

### Operation GetDefaultProvider
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op getdefaultprovider \

```

### Operation ListProviders
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op listproviders \

```

### Operation ListProvidersByRegion
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op listprovidersbyregion \
    --region <region value>
```

### Operation PublicGetMessages
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsmc \
    --op publicgetmessages \

```

