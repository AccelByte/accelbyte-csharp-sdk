## C# Extend SDK CLI Sample App Operation Index for Session service.

### Operation GetHealthcheckInfo
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op gethealthcheckinfo \

```

### Operation GetHealthcheckInfoV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op gethealthcheckinfov1 \

```

### Operation AdminGetLogConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op admingetlogconfig \

```

### Operation AdminPatchUpdateLogConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op adminpatchupdatelogconfig \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminListEnvironmentVariables
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op adminlistenvironmentvariables \

```

### Operation AdminListGlobalConfiguration
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op adminlistglobalconfiguration \

```

### Operation AdminUpdateGlobalConfiguration
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op adminupdateglobalconfiguration \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminDeleteGlobalConfiguration
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op admindeleteglobalconfiguration \

```

### Operation AdminGetConfigurationAlertV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op admingetconfigurationalertv1 \
    --namespace <namespace value>
```

### Operation AdminUpdateConfigurationAlertV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op adminupdateconfigurationalertv1 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminCreateConfigurationAlertV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op admincreateconfigurationalertv1 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminDeleteConfigurationAlertV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op admindeleteconfigurationalertv1 \
    --namespace <namespace value>
```

### Operation AdminCreateConfigurationTemplateV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op admincreateconfigurationtemplatev1 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetAllConfigurationTemplatesV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op admingetallconfigurationtemplatesv1 \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --name <name value - optional> \
    --offset <offset value - optional> \
    --order <order value - optional> \
    --orderBy <orderBy value - optional>
```

### Operation AdminGetConfigurationTemplateV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op admingetconfigurationtemplatev1 \
    --name <name value> \
    --namespace <namespace value>
```

### Operation AdminUpdateConfigurationTemplateV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op adminupdateconfigurationtemplatev1 \
    --name <name value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminDeleteConfigurationTemplateV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op admindeleteconfigurationtemplatev1 \
    --name <name value> \
    --namespace <namespace value>
```

### Operation AdminGetMemberActiveSession
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op admingetmemberactivesession \
    --name <name value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AdminReconcileMaxActiveSession
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op adminreconcilemaxactivesession \
    --name <name value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminQueryGameSessions
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op adminquerygamesessions \
    --namespace <namespace value> \
    --configurationName <configurationName value - optional> \
    --dsPodName <dsPodName value - optional> \
    --fromTime <fromTime value - optional> \
    --gameMode <gameMode value - optional> \
    --isPersistent <isPersistent value - optional> \
    --isSoftDeleted <isSoftDeleted value - optional> \
    --joinability <joinability value - optional> \
    --limit <limit value - optional> \
    --matchPool <matchPool value - optional> \
    --memberID <memberID value - optional> \
    --offset <offset value - optional> \
    --order <order value - optional> \
    --orderBy <orderBy value - optional> \
    --sessionID <sessionID value - optional> \
    --status <status value - optional> \
    --statusV2 <statusV2 value - optional> \
    --toTime <toTime value - optional>
```

### Operation AdminQueryGameSessionsByAttributes
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op adminquerygamesessionsbyattributes \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminDeleteBulkGameSessions
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op admindeletebulkgamesessions \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminSetDSReady
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op adminsetdsready \
    --namespace <namespace value> \
    --sessionId <sessionId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminUpdateDSInformation
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op adminupdatedsinformation \
    --namespace <namespace value> \
    --sessionId <sessionId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminKickGameSessionMember
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op adminkickgamesessionmember \
    --memberId <memberId value> \
    --namespace <namespace value> \
    --sessionId <sessionId value>
```

### Operation AdminUpdateGameSessionMember
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op adminupdategamesessionmember \
    --memberId <memberId value> \
    --namespace <namespace value> \
    --sessionId <sessionId value> \
    --statusType <statusType value>
```

### Operation AdminGetListNativeSession
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op admingetlistnativesession \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --order <order value - optional>
```

### Operation AdminQueryParties
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op adminqueryparties \
    --namespace <namespace value> \
    --fromTime <fromTime value - optional> \
    --isSoftDeleted <isSoftDeleted value - optional> \
    --joinability <joinability value - optional> \
    --key <key value - optional> \
    --leaderID <leaderID value - optional> \
    --limit <limit value - optional> \
    --memberID <memberID value - optional> \
    --memberStatus <memberStatus value - optional> \
    --offset <offset value - optional> \
    --order <order value - optional> \
    --orderBy <orderBy value - optional> \
    --partyID <partyID value - optional> \
    --toTime <toTime value - optional> \
    --value <value value - optional>
```

### Operation AdminDeleteBulkParties
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op admindeletebulkparties \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminReadPartySessionStorage
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op adminreadpartysessionstorage \
    --namespace <namespace value> \
    --partyId <partyId value>
```

### Operation AdminGetPlatformCredentials
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op admingetplatformcredentials \
    --namespace <namespace value>
```

### Operation AdminUpdatePlatformCredentials
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op adminupdateplatformcredentials \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminDeletePlatformCredentials
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op admindeleteplatformcredentials \
    --namespace <namespace value>
```

### Operation AdminDeletePlatformCredentialsByPlatformId
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op admindeleteplatformcredentialsbyplatformid \
    --namespace <namespace value> \
    --platformId <platformId value>
```

### Operation AdminSyncPlatformCredentials
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op adminsyncplatformcredentials \
    --namespace <namespace value> \
    --platformId <platformId value>
```

### Operation AdminGetRecentPlayer
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op admingetrecentplayer \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --userId <userId value - optional>
```

### Operation AdminGetRecentTeamPlayer
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op admingetrecentteamplayer \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --userId <userId value - optional>
```

### Operation AdminReadSessionStorage
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op adminreadsessionstorage \
    --namespace <namespace value> \
    --sessionId <sessionId value>
```

### Operation AdminDeleteUserSessionStorage
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op admindeleteusersessionstorage \
    --namespace <namespace value> \
    --sessionId <sessionId value>
```

### Operation AdminReadUserSessionStorage
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op adminreadusersessionstorage \
    --namespace <namespace value> \
    --sessionId <sessionId value> \
    --userId <userId value>
```

### Operation AdminQueryPlayerAttributes
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op adminqueryplayerattributes \
    --namespace <namespace value> \
    --users <users value - optional>
```

### Operation AdminGetPlayerAttributes
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op admingetplayerattributes \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AdminSyncNativeSession
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op adminsyncnativesession \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation CreateGameSession
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op creategamesession \
    --namespace <namespace value> \
    --resolveMaxActiveSession <resolveMaxActiveSession value - optional> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicQueryGameSessionsByAttributes
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op publicquerygamesessionsbyattributes \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicSessionJoinCode
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op publicsessionjoincode \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetGameSessionByPodName
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op getgamesessionbypodname \
    --namespace <namespace value> \
    --podName <podName value>
```

### Operation GetGameSession
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op getgamesession \
    --namespace <namespace value> \
    --sessionId <sessionId value>
```

### Operation UpdateGameSession
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op updategamesession \
    --namespace <namespace value> \
    --sessionId <sessionId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteGameSession
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op deletegamesession \
    --namespace <namespace value> \
    --sessionId <sessionId value>
```

### Operation PatchUpdateGameSession
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op patchupdategamesession \
    --namespace <namespace value> \
    --sessionId <sessionId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation UpdateGameSessionBackfillTicketID
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op updategamesessionbackfillticketid \
    --namespace <namespace value> \
    --sessionId <sessionId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GameSessionGenerateCode
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op gamesessiongeneratecode \
    --namespace <namespace value> \
    --sessionId <sessionId value>
```

### Operation PublicRevokeGameSessionCode
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op publicrevokegamesessioncode \
    --namespace <namespace value> \
    --sessionId <sessionId value>
```

### Operation PublicGameSessionInvite
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op publicgamesessioninvite \
    --namespace <namespace value> \
    --sessionId <sessionId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation JoinGameSession
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op joingamesession \
    --namespace <namespace value> \
    --sessionId <sessionId value>
```

### Operation PublicPromoteGameSessionLeader
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op publicpromotegamesessionleader \
    --namespace <namespace value> \
    --sessionId <sessionId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation LeaveGameSession
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op leavegamesession \
    --namespace <namespace value> \
    --sessionId <sessionId value>
```

### Operation PublicKickGameSessionMember
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op publickickgamesessionmember \
    --memberId <memberId value> \
    --namespace <namespace value> \
    --sessionId <sessionId value>
```

### Operation PublicGameSessionReject
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op publicgamesessionreject \
    --namespace <namespace value> \
    --sessionId <sessionId value>
```

### Operation GetSessionServerSecret
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op getsessionserversecret \
    --namespace <namespace value> \
    --sessionId <sessionId value>
```

### Operation PublicGameSessionCancel
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op publicgamesessioncancel \
    --namespace <namespace value> \
    --sessionId <sessionId value> \
    --userId <userId value>
```

### Operation PublicPartyJoinCode
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op publicpartyjoincode \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicGetParty
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op publicgetparty \
    --namespace <namespace value> \
    --partyId <partyId value>
```

### Operation PublicUpdateParty
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op publicupdateparty \
    --namespace <namespace value> \
    --partyId <partyId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicPatchUpdateParty
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op publicpatchupdateparty \
    --namespace <namespace value> \
    --partyId <partyId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicGeneratePartyCode
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op publicgeneratepartycode \
    --namespace <namespace value> \
    --partyId <partyId value>
```

### Operation PublicRevokePartyCode
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op publicrevokepartycode \
    --namespace <namespace value> \
    --partyId <partyId value>
```

### Operation PublicPartyInvite
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op publicpartyinvite \
    --namespace <namespace value> \
    --partyId <partyId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicPromotePartyLeader
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op publicpromotepartyleader \
    --namespace <namespace value> \
    --partyId <partyId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicReadPartySessionStorage
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op publicreadpartysessionstorage \
    --namespace <namespace value> \
    --partyId <partyId value>
```

### Operation PublicUpdateInsertPartySessionStorageReserved
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op publicupdateinsertpartysessionstoragereserved \
    --namespace <namespace value> \
    --partyId <partyId value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicPartyJoin
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op publicpartyjoin \
    --namespace <namespace value> \
    --partyId <partyId value>
```

### Operation PublicPartyLeave
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op publicpartyleave \
    --namespace <namespace value> \
    --partyId <partyId value>
```

### Operation PublicPartyReject
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op publicpartyreject \
    --namespace <namespace value> \
    --partyId <partyId value>
```

### Operation PublicPartyCancel
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op publicpartycancel \
    --namespace <namespace value> \
    --partyId <partyId value> \
    --userId <userId value>
```

### Operation PublicPartyKick
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op publicpartykick \
    --namespace <namespace value> \
    --partyId <partyId value> \
    --userId <userId value>
```

### Operation PublicCreateParty
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op publiccreateparty \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicGetRecentPlayer
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op publicgetrecentplayer \
    --namespace <namespace value> \
    --limit <limit value - optional>
```

### Operation PublicGetRecentTeamPlayer
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op publicgetrecentteamplayer \
    --namespace <namespace value> \
    --limit <limit value - optional>
```

### Operation PublicUpdateInsertSessionStorageLeader
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op publicupdateinsertsessionstorageleader \
    --namespace <namespace value> \
    --sessionId <sessionId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicUpdateInsertSessionStorage
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op publicupdateinsertsessionstorage \
    --namespace <namespace value> \
    --sessionId <sessionId value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicGetBulkPlayerCurrentPlatform
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op publicgetbulkplayercurrentplatform \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicGetPlayerAttributes
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op publicgetplayerattributes \
    --namespace <namespace value>
```

### Operation PublicStorePlayerAttributes
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op publicstoreplayerattributes \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicDeletePlayerAttributes
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op publicdeleteplayerattributes \
    --namespace <namespace value>
```

### Operation PublicQueryMyGameSessions
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op publicquerymygamesessions \
    --namespace <namespace value> \
    --order <order value - optional> \
    --orderBy <orderBy value - optional> \
    --status <status value - optional>
```

### Operation PublicQueryMyParties
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn session \
    --op publicquerymyparties \
    --namespace <namespace value> \
    --order <order value - optional> \
    --orderBy <orderBy value - optional> \
    --status <status value - optional>
```

