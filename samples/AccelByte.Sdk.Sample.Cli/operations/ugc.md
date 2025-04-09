## C# Extend SDK CLI Sample App Operation Index for Ugc service.

### Operation SingleAdminGetChannel
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op singleadmingetchannel \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation AdminCreateChannel
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op admincreatechannel \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation SingleAdminUpdateChannel
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op singleadminupdatechannel \
    --channelId <channelId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation SingleAdminDeleteChannel
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op singleadmindeletechannel \
    --channelId <channelId value> \
    --namespace <namespace value>
```

### Operation AdminUploadContentS3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op adminuploadcontents3 \
    --channelId <channelId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation SingleAdminUpdateContentS3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op singleadminupdatecontents3 \
    --channelId <channelId value> \
    --contentId <contentId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminSearchChannelSpecificContent
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op adminsearchchannelspecificcontent \
    --channelId <channelId value> \
    --namespace <namespace value> \
    --creator <creator value - optional> \
    --ishidden <ishidden value - optional> \
    --isofficial <isofficial value - optional> \
    --limit <limit value - optional> \
    --name <name value - optional> \
    --offset <offset value - optional> \
    --orderby <orderby value - optional> \
    --sortby <sortby value - optional> \
    --subtype <subtype value - optional> \
    --tags <tags value - optional> \
    --type <type value - optional> \
    --userId <userId value - optional>
```

### Operation SingleAdminDeleteContent
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op singleadmindeletecontent \
    --channelId <channelId value> \
    --contentId <contentId value> \
    --namespace <namespace value>
```

### Operation SingleAdminGetContent
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op singleadmingetcontent \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation AdminGetContentBulk
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op admingetcontentbulk \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminSearchContent
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op adminsearchcontent \
    --namespace <namespace value> \
    --creator <creator value - optional> \
    --ishidden <ishidden value - optional> \
    --isofficial <isofficial value - optional> \
    --limit <limit value - optional> \
    --name <name value - optional> \
    --offset <offset value - optional> \
    --orderby <orderby value - optional> \
    --sortby <sortby value - optional> \
    --subtype <subtype value - optional> \
    --tags <tags value - optional> \
    --type <type value - optional> \
    --userId <userId value - optional>
```

### Operation AdminGetContentBulkByShareCodes
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op admingetcontentbulkbysharecodes \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetUserContentByShareCode
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op admingetusercontentbysharecode \
    --namespace <namespace value> \
    --shareCode <shareCode value>
```

### Operation AdminGetSpecificContent
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op admingetspecificcontent \
    --contentId <contentId value> \
    --namespace <namespace value>
```

### Operation AdminDownloadContentPreview
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op admindownloadcontentpreview \
    --contentId <contentId value> \
    --namespace <namespace value>
```

### Operation RollbackContentVersion
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op rollbackcontentversion \
    --contentId <contentId value> \
    --namespace <namespace value> \
    --versionId <versionId value>
```

### Operation AdminUpdateScreenshots
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op adminupdatescreenshots \
    --contentId <contentId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminUploadContentScreenshot
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op adminuploadcontentscreenshot \
    --contentId <contentId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminDeleteContentScreenshot
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op admindeletecontentscreenshot \
    --contentId <contentId value> \
    --namespace <namespace value> \
    --screenshotId <screenshotId value>
```

### Operation ListContentVersions
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op listcontentversions \
    --contentId <contentId value> \
    --namespace <namespace value>
```

### Operation SingleAdminGetAllGroups
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op singleadmingetallgroups \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation AdminCreateGroup
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op admincreategroup \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation SingleAdminGetGroup
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op singleadmingetgroup \
    --groupId <groupId value> \
    --namespace <namespace value>
```

### Operation SingleAdminUpdateGroup
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op singleadminupdategroup \
    --groupId <groupId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation SingleAdminDeleteGroup
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op singleadmindeletegroup \
    --groupId <groupId value> \
    --namespace <namespace value>
```

### Operation SingleAdminGetGroupContents
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op singleadmingetgroupcontents \
    --groupId <groupId value> \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation AdminGetTag
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op admingettag \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation AdminCreateTag
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op admincreatetag \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminUpdateTag
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op adminupdatetag \
    --namespace <namespace value> \
    --tagId <tagId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminDeleteTag
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op admindeletetag \
    --namespace <namespace value> \
    --tagId <tagId value>
```

### Operation AdminGetType
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op admingettype \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation AdminCreateType
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op admincreatetype \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminUpdateType
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op adminupdatetype \
    --namespace <namespace value> \
    --typeId <typeId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminDeleteType
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op admindeletetype \
    --namespace <namespace value> \
    --typeId <typeId value>
```

### Operation AdminGetChannel
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op admingetchannel \
    --namespace <namespace value> \
    --userId <userId value> \
    --limit <limit value - optional> \
    --name <name value - optional> \
    --offset <offset value - optional>
```

### Operation AdminDeleteAllUserChannels
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op admindeletealluserchannels \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AdminUpdateChannel
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op adminupdatechannel \
    --channelId <channelId value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminDeleteChannel
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op admindeletechannel \
    --channelId <channelId value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AdminUpdateContentS3ByShareCode
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op adminupdatecontents3bysharecode \
    --channelId <channelId value> \
    --namespace <namespace value> \
    --shareCode <shareCode value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminUpdateContentS3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op adminupdatecontents3 \
    --channelId <channelId value> \
    --contentId <contentId value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteContentByShareCode
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op deletecontentbysharecode \
    --channelId <channelId value> \
    --namespace <namespace value> \
    --shareCode <shareCode value> \
    --userId <userId value>
```

### Operation AdminDeleteContent
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op admindeletecontent \
    --channelId <channelId value> \
    --contentId <contentId value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AdminGetContent
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op admingetcontent \
    --namespace <namespace value> \
    --userId <userId value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation AdminDeleteAllUserContents
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op admindeleteallusercontents \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AdminHideUserContent
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op adminhideusercontent \
    --contentId <contentId value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetAllGroups
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op admingetallgroups \
    --namespace <namespace value> \
    --userId <userId value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation AdminDeleteAllUserGroup
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op admindeleteallusergroup \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AdminGetGroup
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op admingetgroup \
    --groupId <groupId value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AdminUpdateGroup
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op adminupdategroup \
    --groupId <groupId value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminDeleteGroup
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op admindeletegroup \
    --groupId <groupId value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AdminGetGroupContents
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op admingetgroupcontents \
    --groupId <groupId value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation AdminDeleteAllUserStates
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op admindeletealluserstates \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation SearchChannelSpecificContent
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op searchchannelspecificcontent \
    --channelId <channelId value> \
    --namespace <namespace value> \
    --creator <creator value - optional> \
    --ishidden <ishidden value - optional> \
    --isofficial <isofficial value - optional> \
    --limit <limit value - optional> \
    --name <name value - optional> \
    --offset <offset value - optional> \
    --orderby <orderby value - optional> \
    --sortby <sortby value - optional> \
    --subtype <subtype value - optional> \
    --tags <tags value - optional> \
    --type <type value - optional> \
    --userId <userId value - optional>
```

### Operation PublicSearchContent
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op publicsearchcontent \
    --namespace <namespace value> \
    --creator <creator value - optional> \
    --ishidden <ishidden value - optional> \
    --isofficial <isofficial value - optional> \
    --limit <limit value - optional> \
    --name <name value - optional> \
    --offset <offset value - optional> \
    --orderby <orderby value - optional> \
    --sortby <sortby value - optional> \
    --subtype <subtype value - optional> \
    --tags <tags value - optional> \
    --type <type value - optional> \
    --userId <userId value - optional>
```

### Operation PublicGetContentBulk
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op publicgetcontentbulk \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetFollowedContent
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op getfollowedcontent \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation GetLikedContent
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op getlikedcontent \
    --namespace <namespace value> \
    --isofficial <isofficial value - optional> \
    --limit <limit value - optional> \
    --name <name value - optional> \
    --offset <offset value - optional> \
    --orderby <orderby value - optional> \
    --sortby <sortby value - optional> \
    --subtype <subtype value - optional> \
    --tags <tags value - optional> \
    --type <type value - optional>
```

### Operation PublicGetContentBulkByShareCodes
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op publicgetcontentbulkbysharecodes \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicDownloadContentByShareCode
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op publicdownloadcontentbysharecode \
    --namespace <namespace value> \
    --shareCode <shareCode value>
```

### Operation PublicDownloadContentByContentID
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op publicdownloadcontentbycontentid \
    --contentId <contentId value> \
    --namespace <namespace value>
```

### Operation AddDownloadCount
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op adddownloadcount \
    --contentId <contentId value> \
    --namespace <namespace value>
```

### Operation UpdateContentLikeStatus
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op updatecontentlikestatus \
    --contentId <contentId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicDownloadContentPreview
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op publicdownloadcontentpreview \
    --contentId <contentId value> \
    --namespace <namespace value>
```

### Operation GetTag
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op gettag \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation GetType
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op gettype \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation PublicSearchCreator
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op publicsearchcreator \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --orderby <orderby value - optional> \
    --sortby <sortby value - optional>
```

### Operation GetFollowedUsers
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op getfollowedusers \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation PublicGetCreator
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op publicgetcreator \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation GetChannels
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op getchannels \
    --namespace <namespace value> \
    --userId <userId value> \
    --limit <limit value - optional> \
    --name <name value - optional> \
    --offset <offset value - optional>
```

### Operation PublicCreateChannel
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op publiccreatechannel \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteAllUserChannel
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op deletealluserchannel \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation UpdateChannel
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op updatechannel \
    --channelId <channelId value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteChannel
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op deletechannel \
    --channelId <channelId value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation CreateContentS3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op createcontents3 \
    --channelId <channelId value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicUpdateContentByShareCode
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op publicupdatecontentbysharecode \
    --channelId <channelId value> \
    --namespace <namespace value> \
    --shareCode <shareCode value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation UpdateContentS3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op updatecontents3 \
    --channelId <channelId value> \
    --contentId <contentId value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicDeleteContentByShareCode
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op publicdeletecontentbysharecode \
    --channelId <channelId value> \
    --namespace <namespace value> \
    --shareCode <shareCode value> \
    --userId <userId value>
```

### Operation DeleteContent
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op deletecontent \
    --channelId <channelId value> \
    --contentId <contentId value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation UpdateContentShareCode
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op updatecontentsharecode \
    --channelId <channelId value> \
    --contentId <contentId value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicGetUserContent
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op publicgetusercontent \
    --namespace <namespace value> \
    --userId <userId value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation DeleteAllUserContents
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op deleteallusercontents \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation UpdateScreenshots
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op updatescreenshots \
    --contentId <contentId value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation UploadContentScreenshot
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op uploadcontentscreenshot \
    --contentId <contentId value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteContentScreenshot
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op deletecontentscreenshot \
    --contentId <contentId value> \
    --namespace <namespace value> \
    --screenshotId <screenshotId value> \
    --userId <userId value>
```

### Operation UpdateUserFollowStatus
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op updateuserfollowstatus \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetPublicFollowers
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op getpublicfollowers \
    --namespace <namespace value> \
    --userId <userId value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation GetPublicFollowing
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op getpublicfollowing \
    --namespace <namespace value> \
    --userId <userId value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation GetGroups
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op getgroups \
    --namespace <namespace value> \
    --userId <userId value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation CreateGroup
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op creategroup \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteAllUserGroup
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op deleteallusergroup \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation GetGroup
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op getgroup \
    --groupId <groupId value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation UpdateGroup
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op updategroup \
    --groupId <groupId value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteGroup
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op deletegroup \
    --groupId <groupId value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation GetGroupContent
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op getgroupcontent \
    --groupId <groupId value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation DeleteAllUserStates
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op deletealluserstates \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AdminGetContentByChannelIDV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op admingetcontentbychannelidv2 \
    --channelId <channelId value> \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --name <name value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional>
```

### Operation AdminCreateContentV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op admincreatecontentv2 \
    --channelId <channelId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminDeleteOfficialContentV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op admindeleteofficialcontentv2 \
    --channelId <channelId value> \
    --contentId <contentId value> \
    --namespace <namespace value>
```

### Operation AdminUpdateOfficialContentV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op adminupdateofficialcontentv2 \
    --channelId <channelId value> \
    --contentId <contentId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminCopyContent
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op admincopycontent \
    --channelId <channelId value> \
    --contentId <contentId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminUpdateOfficialContentFileLocation
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op adminupdateofficialcontentfilelocation \
    --channelId <channelId value> \
    --contentId <contentId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGenerateOfficialContentUploadURLV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op admingenerateofficialcontentuploadurlv2 \
    --channelId <channelId value> \
    --contentId <contentId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetConfigs
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op admingetconfigs \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation AdminUpdateConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op adminupdateconfig \
    --key <key value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminListContentV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op adminlistcontentv2 \
    --namespace <namespace value> \
    --isOfficial <isOfficial value - optional> \
    --limit <limit value - optional> \
    --name <name value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional> \
    --subType <subType value - optional> \
    --tags <tags value - optional> \
    --type <type value - optional>
```

### Operation AdminBulkGetContentByIDsV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op adminbulkgetcontentbyidsv2 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetContentBulkByShareCodesV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op admingetcontentbulkbysharecodesv2 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetContentByShareCodeV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op admingetcontentbysharecodev2 \
    --namespace <namespace value> \
    --shareCode <shareCode value>
```

### Operation AdminGetContentByContentIDV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op admingetcontentbycontentidv2 \
    --contentId <contentId value> \
    --namespace <namespace value>
```

### Operation RollbackContentVersionV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op rollbackcontentversionv2 \
    --contentId <contentId value> \
    --namespace <namespace value> \
    --versionId <versionId value>
```

### Operation AdminUpdateScreenshotsV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op adminupdatescreenshotsv2 \
    --contentId <contentId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminUploadContentScreenshotV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op adminuploadcontentscreenshotv2 \
    --contentId <contentId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminDeleteContentScreenshotV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op admindeletecontentscreenshotv2 \
    --contentId <contentId value> \
    --namespace <namespace value> \
    --screenshotId <screenshotId value>
```

### Operation ListContentVersionsV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op listcontentversionsv2 \
    --contentId <contentId value> \
    --namespace <namespace value>
```

### Operation AdminGetOfficialGroupContentsV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op admingetofficialgroupcontentsv2 \
    --groupId <groupId value> \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation AdminListStagingContents
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op adminliststagingcontents \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional> \
    --status <status value - optional>
```

### Operation AdminGetStagingContentByID
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op admingetstagingcontentbyid \
    --contentId <contentId value> \
    --namespace <namespace value>
```

### Operation AdminApproveStagingContent
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op adminapprovestagingcontent \
    --contentId <contentId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminUpdateContentByShareCodeV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op adminupdatecontentbysharecodev2 \
    --channelId <channelId value> \
    --namespace <namespace value> \
    --shareCode <shareCode value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminDeleteContentByShareCodeV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op admindeletecontentbysharecodev2 \
    --channelId <channelId value> \
    --namespace <namespace value> \
    --shareCode <shareCode value> \
    --userId <userId value>
```

### Operation AdminDeleteUserContentV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op admindeleteusercontentv2 \
    --channelId <channelId value> \
    --contentId <contentId value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AdminUpdateUserContentV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op adminupdateusercontentv2 \
    --channelId <channelId value> \
    --contentId <contentId value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminUpdateUserContentFileLocation
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op adminupdateusercontentfilelocation \
    --channelId <channelId value> \
    --contentId <contentId value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGenerateUserContentUploadURLV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op admingenerateusercontentuploadurlv2 \
    --channelId <channelId value> \
    --contentId <contentId value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetContentByUserIDV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op admingetcontentbyuseridv2 \
    --namespace <namespace value> \
    --userId <userId value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional>
```

### Operation AdminUpdateContentHideStatusV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op adminupdatecontenthidestatusv2 \
    --contentId <contentId value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetUserGroupContentsV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op admingetusergroupcontentsv2 \
    --groupId <groupId value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation AdminListUserStagingContents
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op adminlistuserstagingcontents \
    --namespace <namespace value> \
    --userId <userId value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional> \
    --status <status value - optional>
```

### Operation PublicGetContentByChannelIDV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op publicgetcontentbychannelidv2 \
    --channelId <channelId value> \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --name <name value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional>
```

### Operation PublicListContentV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op publiclistcontentv2 \
    --namespace <namespace value> \
    --isOfficial <isOfficial value - optional> \
    --limit <limit value - optional> \
    --name <name value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional> \
    --subType <subType value - optional> \
    --tags <tags value - optional> \
    --type <type value - optional>
```

### Operation PublicBulkGetContentByIDV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op publicbulkgetcontentbyidv2 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicGetContentBulkByShareCodesV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op publicgetcontentbulkbysharecodesv2 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicGetContentByShareCodeV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op publicgetcontentbysharecodev2 \
    --namespace <namespace value> \
    --shareCode <shareCode value>
```

### Operation PublicGetContentByIDV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op publicgetcontentbyidv2 \
    --contentId <contentId value> \
    --namespace <namespace value>
```

### Operation PublicAddDownloadCountV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op publicadddownloadcountv2 \
    --contentId <contentId value> \
    --namespace <namespace value>
```

### Operation PublicListContentDownloaderV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op publiclistcontentdownloaderv2 \
    --contentId <contentId value> \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional> \
    --userId <userId value - optional>
```

### Operation PublicListContentLikeV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op publiclistcontentlikev2 \
    --contentId <contentId value> \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional>
```

### Operation UpdateContentLikeStatusV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op updatecontentlikestatusv2 \
    --contentId <contentId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicCreateContentV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op publiccreatecontentv2 \
    --channelId <channelId value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicUpdateContentByShareCodeV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op publicupdatecontentbysharecodev2 \
    --channelId <channelId value> \
    --namespace <namespace value> \
    --shareCode <shareCode value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicDeleteContentByShareCodeV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op publicdeletecontentbysharecodev2 \
    --channelId <channelId value> \
    --namespace <namespace value> \
    --shareCode <shareCode value> \
    --userId <userId value>
```

### Operation PublicDeleteContentV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op publicdeletecontentv2 \
    --channelId <channelId value> \
    --contentId <contentId value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation PublicUpdateContentV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op publicupdatecontentv2 \
    --channelId <channelId value> \
    --contentId <contentId value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicUpdateContentFileLocation
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op publicupdatecontentfilelocation \
    --channelId <channelId value> \
    --contentId <contentId value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation UpdateContentShareCodeV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op updatecontentsharecodev2 \
    --channelId <channelId value> \
    --contentId <contentId value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicGenerateContentUploadURLV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op publicgeneratecontentuploadurlv2 \
    --channelId <channelId value> \
    --contentId <contentId value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicGetContentByUserIDV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op publicgetcontentbyuseridv2 \
    --namespace <namespace value> \
    --userId <userId value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional>
```

### Operation UpdateScreenshotsV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op updatescreenshotsv2 \
    --contentId <contentId value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation UploadContentScreenshotV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op uploadcontentscreenshotv2 \
    --contentId <contentId value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteContentScreenshotV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op deletecontentscreenshotv2 \
    --contentId <contentId value> \
    --namespace <namespace value> \
    --screenshotId <screenshotId value> \
    --userId <userId value>
```

### Operation PublicGetGroupContentsV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op publicgetgroupcontentsv2 \
    --groupId <groupId value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation ListUserStagingContents
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op listuserstagingcontents \
    --namespace <namespace value> \
    --userId <userId value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional> \
    --status <status value - optional>
```

### Operation GetUserStagingContentByID
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op getuserstagingcontentbyid \
    --contentId <contentId value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation UpdateStagingContent
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op updatestagingcontent \
    --contentId <contentId value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteUserStagingContentByID
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ugc \
    --op deleteuserstagingcontentbyid \
    --contentId <contentId value> \
    --namespace <namespace value> \
    --userId <userId value>
```

