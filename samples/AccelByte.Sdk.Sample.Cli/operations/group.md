## C# Extend SDK CLI Sample App Operation Index for Group service.

### Operation ListGroupConfigurationAdminV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op listgroupconfigurationadminv1 \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation CreateGroupConfigurationAdminV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op creategroupconfigurationadminv1 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation InitiateGroupConfigurationAdminV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op initiategroupconfigurationadminv1 \
    --namespace <namespace value>
```

### Operation GetGroupConfigurationAdminV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op getgroupconfigurationadminv1 \
    --configurationCode <configurationCode value> \
    --namespace <namespace value>
```

### Operation DeleteGroupConfigurationV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op deletegroupconfigurationv1 \
    --configurationCode <configurationCode value> \
    --namespace <namespace value>
```

### Operation UpdateGroupConfigurationAdminV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op updategroupconfigurationadminv1 \
    --configurationCode <configurationCode value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation UpdateGroupConfigurationGlobalRuleAdminV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op updategroupconfigurationglobalruleadminv1 \
    --allowedAction <allowedAction value> \
    --configurationCode <configurationCode value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteGroupConfigurationGlobalRuleAdminV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op deletegroupconfigurationglobalruleadminv1 \
    --allowedAction <allowedAction value> \
    --configurationCode <configurationCode value> \
    --namespace <namespace value>
```

### Operation GetGroupListAdminV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op getgrouplistadminv1 \
    --namespace <namespace value> \
    --configurationCode <configurationCode value - optional> \
    --groupName <groupName value - optional> \
    --groupRegion <groupRegion value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation GetSingleGroupAdminV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op getsinglegroupadminv1 \
    --groupId <groupId value> \
    --namespace <namespace value>
```

### Operation DeleteGroupAdminV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op deletegroupadminv1 \
    --groupId <groupId value> \
    --namespace <namespace value>
```

### Operation GetGroupMembersListAdminV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op getgroupmemberslistadminv1 \
    --groupId <groupId value> \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --order <order value - optional>
```

### Operation GetMemberRolesListAdminV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op getmemberroleslistadminv1 \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation CreateMemberRoleAdminV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op creatememberroleadminv1 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetSingleMemberRoleAdminV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op getsinglememberroleadminv1 \
    --memberRoleId <memberRoleId value> \
    --namespace <namespace value>
```

### Operation DeleteMemberRoleAdminV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op deletememberroleadminv1 \
    --memberRoleId <memberRoleId value> \
    --namespace <namespace value>
```

### Operation UpdateMemberRoleAdminV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op updatememberroleadminv1 \
    --memberRoleId <memberRoleId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation UpdateMemberRolePermissionAdminV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op updatememberrolepermissionadminv1 \
    --memberRoleId <memberRoleId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetGroupListPublicV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op getgrouplistpublicv1 \
    --namespace <namespace value> \
    --groupName <groupName value - optional> \
    --groupRegion <groupRegion value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation CreateNewGroupPublicV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op createnewgrouppublicv1 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetSingleGroupPublicV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op getsinglegrouppublicv1 \
    --groupId <groupId value> \
    --namespace <namespace value>
```

### Operation UpdateSingleGroupV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op updatesinglegroupv1 \
    --groupId <groupId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteGroupPublicV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op deletegrouppublicv1 \
    --groupId <groupId value> \
    --namespace <namespace value>
```

### Operation UpdatePatchSingleGroupPublicV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op updatepatchsinglegrouppublicv1 \
    --groupId <groupId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation UpdateGroupCustomAttributesPublicV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op updategroupcustomattributespublicv1 \
    --groupId <groupId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AcceptGroupInvitationPublicV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op acceptgroupinvitationpublicv1 \
    --groupId <groupId value> \
    --namespace <namespace value>
```

### Operation RejectGroupInvitationPublicV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op rejectgroupinvitationpublicv1 \
    --groupId <groupId value> \
    --namespace <namespace value>
```

### Operation JoinGroupV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op joingroupv1 \
    --groupId <groupId value> \
    --namespace <namespace value>
```

### Operation CancelGroupJoinRequestV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op cancelgroupjoinrequestv1 \
    --groupId <groupId value> \
    --namespace <namespace value>
```

### Operation GetGroupJoinRequestPublicV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op getgroupjoinrequestpublicv1 \
    --groupId <groupId value> \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation GetGroupMembersListPublicV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op getgroupmemberslistpublicv1 \
    --groupId <groupId value> \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --order <order value - optional>
```

### Operation UpdateGroupCustomRulePublicV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op updategroupcustomrulepublicv1 \
    --groupId <groupId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation UpdateGroupPredefinedRulePublicV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op updategrouppredefinedrulepublicv1 \
    --allowedAction <allowedAction value> \
    --groupId <groupId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteGroupPredefinedRulePublicV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op deletegrouppredefinedrulepublicv1 \
    --allowedAction <allowedAction value> \
    --groupId <groupId value> \
    --namespace <namespace value>
```

### Operation LeaveGroupPublicV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op leavegrouppublicv1 \
    --namespace <namespace value>
```

### Operation GetMemberRolesListPublicV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op getmemberroleslistpublicv1 \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation UpdateMemberRolePublicV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op updatememberrolepublicv1 \
    --memberRoleId <memberRoleId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteMemberRolePublicV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op deletememberrolepublicv1 \
    --memberRoleId <memberRoleId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetGroupInvitationRequestPublicV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op getgroupinvitationrequestpublicv1 \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation GetUserGroupInformationPublicV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op getusergroupinformationpublicv1 \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation InviteGroupPublicV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op invitegrouppublicv1 \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AcceptGroupJoinRequestPublicV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op acceptgroupjoinrequestpublicv1 \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation RejectGroupJoinRequestPublicV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op rejectgroupjoinrequestpublicv1 \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation KickGroupMemberPublicV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op kickgroupmemberpublicv1 \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation GetListGroupByIDsAdminV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op getlistgroupbyidsadminv2 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetUserJoinedGroupInformationPublicV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op getuserjoinedgroupinformationpublicv2 \
    --namespace <namespace value> \
    --userId <userId value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation AdminGetUserGroupStatusInformationV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op admingetusergroupstatusinformationv2 \
    --groupId <groupId value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation CreateNewGroupPublicV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op createnewgrouppublicv2 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetListGroupByIDsV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op getlistgroupbyidsv2 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation UpdatePutSingleGroupPublicV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op updateputsinglegrouppublicv2 \
    --groupId <groupId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteGroupPublicV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op deletegrouppublicv2 \
    --groupId <groupId value> \
    --namespace <namespace value>
```

### Operation UpdatePatchSingleGroupPublicV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op updatepatchsinglegrouppublicv2 \
    --groupId <groupId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation UpdateGroupCustomAttributesPublicV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op updategroupcustomattributespublicv2 \
    --groupId <groupId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AcceptGroupInvitationPublicV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op acceptgroupinvitationpublicv2 \
    --groupId <groupId value> \
    --namespace <namespace value>
```

### Operation RejectGroupInvitationPublicV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op rejectgroupinvitationpublicv2 \
    --groupId <groupId value> \
    --namespace <namespace value>
```

### Operation GetGroupInviteRequestPublicV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op getgroupinviterequestpublicv2 \
    --groupId <groupId value> \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation JoinGroupV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op joingroupv2 \
    --groupId <groupId value> \
    --namespace <namespace value>
```

### Operation GetGroupJoinRequestPublicV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op getgroupjoinrequestpublicv2 \
    --groupId <groupId value> \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation LeaveGroupPublicV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op leavegrouppublicv2 \
    --groupId <groupId value> \
    --namespace <namespace value>
```

### Operation UpdateGroupCustomRulePublicV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op updategroupcustomrulepublicv2 \
    --groupId <groupId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation UpdateGroupPredefinedRulePublicV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op updategrouppredefinedrulepublicv2 \
    --allowedAction <allowedAction value> \
    --groupId <groupId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteGroupPredefinedRulePublicV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op deletegrouppredefinedrulepublicv2 \
    --allowedAction <allowedAction value> \
    --groupId <groupId value> \
    --namespace <namespace value>
```

### Operation GetMemberRolesListPublicV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op getmemberroleslistpublicv2 \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation UpdateMemberRolePublicV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op updatememberrolepublicv2 \
    --groupId <groupId value> \
    --memberRoleId <memberRoleId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteMemberRolePublicV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op deletememberrolepublicv2 \
    --groupId <groupId value> \
    --memberRoleId <memberRoleId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetUserGroupInformationPublicV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op getusergroupinformationpublicv2 \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation GetMyGroupJoinRequestV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op getmygroupjoinrequestv2 \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation InviteGroupPublicV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op invitegrouppublicv2 \
    --groupId <groupId value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation CancelInvitationGroupMemberV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op cancelinvitationgroupmemberv2 \
    --groupId <groupId value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AcceptGroupJoinRequestPublicV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op acceptgroupjoinrequestpublicv2 \
    --groupId <groupId value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation RejectGroupJoinRequestPublicV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op rejectgroupjoinrequestpublicv2 \
    --groupId <groupId value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation KickGroupMemberPublicV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op kickgroupmemberpublicv2 \
    --groupId <groupId value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation GetUserGroupStatusInformationV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn group \
    --op getusergroupstatusinformationv2 \
    --groupId <groupId value> \
    --namespace <namespace value> \
    --userId <userId value>
```

