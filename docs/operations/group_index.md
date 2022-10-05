# Group Service Index

&nbsp;  

## Operations

### Configuration Wrapper:  [Configuration](../../AccelByte.Sdk/Api/Group/Wrapper/Configuration.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/group/v1/admin/namespaces/{namespace}/configuration` | GET | ListGroupConfigurationAdminV1 | [ListGroupConfigurationAdminV1](../../AccelByte.Sdk/Api/Group/Operation/Configuration/ListGroupConfigurationAdminV1.cs) | [ListGroupConfigurationAdminV1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Group/Configuration/ListGroupConfigurationAdminV1.cs) |
| `/group/v1/admin/namespaces/{namespace}/configuration` | POST | CreateGroupConfigurationAdminV1 | [CreateGroupConfigurationAdminV1](../../AccelByte.Sdk/Api/Group/Operation/Configuration/CreateGroupConfigurationAdminV1.cs) | [CreateGroupConfigurationAdminV1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Group/Configuration/CreateGroupConfigurationAdminV1.cs) |
| `/group/v1/admin/namespaces/{namespace}/configuration/initiate` | POST | InitiateGroupConfigurationAdminV1 | [InitiateGroupConfigurationAdminV1](../../AccelByte.Sdk/Api/Group/Operation/Configuration/InitiateGroupConfigurationAdminV1.cs) | [InitiateGroupConfigurationAdminV1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Group/Configuration/InitiateGroupConfigurationAdminV1.cs) |
| `/group/v1/admin/namespaces/{namespace}/configuration/{configurationCode}` | GET | GetGroupConfigurationAdminV1 | [GetGroupConfigurationAdminV1](../../AccelByte.Sdk/Api/Group/Operation/Configuration/GetGroupConfigurationAdminV1.cs) | [GetGroupConfigurationAdminV1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Group/Configuration/GetGroupConfigurationAdminV1.cs) |
| `/group/v1/admin/namespaces/{namespace}/configuration/{configurationCode}` | DELETE | DeleteGroupConfigurationV1 | [DeleteGroupConfigurationV1](../../AccelByte.Sdk/Api/Group/Operation/Configuration/DeleteGroupConfigurationV1.cs) | [DeleteGroupConfigurationV1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Group/Configuration/DeleteGroupConfigurationV1.cs) |
| `/group/v1/admin/namespaces/{namespace}/configuration/{configurationCode}` | PATCH | UpdateGroupConfigurationAdminV1 | [UpdateGroupConfigurationAdminV1](../../AccelByte.Sdk/Api/Group/Operation/Configuration/UpdateGroupConfigurationAdminV1.cs) | [UpdateGroupConfigurationAdminV1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Group/Configuration/UpdateGroupConfigurationAdminV1.cs) |
| `/group/v1/admin/namespaces/{namespace}/configuration/{configurationCode}/rules/{allowedAction}` | PUT | UpdateGroupConfigurationGlobalRuleAdminV1 | [UpdateGroupConfigurationGlobalRuleAdminV1](../../AccelByte.Sdk/Api/Group/Operation/Configuration/UpdateGroupConfigurationGlobalRuleAdminV1.cs) | [UpdateGroupConfigurationGlobalRuleAdminV1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Group/Configuration/UpdateGroupConfigurationGlobalRuleAdminV1.cs) |
| `/group/v1/admin/namespaces/{namespace}/configuration/{configurationCode}/rules/{allowedAction}` | DELETE | DeleteGroupConfigurationGlobalRuleAdminV1 | [DeleteGroupConfigurationGlobalRuleAdminV1](../../AccelByte.Sdk/Api/Group/Operation/Configuration/DeleteGroupConfigurationGlobalRuleAdminV1.cs) | [DeleteGroupConfigurationGlobalRuleAdminV1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Group/Configuration/DeleteGroupConfigurationGlobalRuleAdminV1.cs) |

### Group Wrapper:  [Group](../../AccelByte.Sdk/Api/Group/Wrapper/Group.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/group/v1/admin/namespaces/{namespace}/groups` | GET | GetGroupListAdminV1 | [GetGroupListAdminV1](../../AccelByte.Sdk/Api/Group/Operation/Group/GetGroupListAdminV1.cs) | [GetGroupListAdminV1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Group/Group/GetGroupListAdminV1.cs) |
| `/group/v1/admin/namespaces/{namespace}/groups/{groupId}` | GET | GetSingleGroupAdminV1 | [GetSingleGroupAdminV1](../../AccelByte.Sdk/Api/Group/Operation/Group/GetSingleGroupAdminV1.cs) | [GetSingleGroupAdminV1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Group/Group/GetSingleGroupAdminV1.cs) |
| `/group/v1/admin/namespaces/{namespace}/groups/{groupId}` | DELETE | DeleteGroupAdminV1 | [DeleteGroupAdminV1](../../AccelByte.Sdk/Api/Group/Operation/Group/DeleteGroupAdminV1.cs) | [DeleteGroupAdminV1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Group/Group/DeleteGroupAdminV1.cs) |
| `/group/v1/public/namespaces/{namespace}/groups` | GET | GetGroupListPublicV1 | [GetGroupListPublicV1](../../AccelByte.Sdk/Api/Group/Operation/Group/GetGroupListPublicV1.cs) | [GetGroupListPublicV1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Group/Group/GetGroupListPublicV1.cs) |
| `/group/v1/public/namespaces/{namespace}/groups` | POST | CreateNewGroupPublicV1 | [CreateNewGroupPublicV1](../../AccelByte.Sdk/Api/Group/Operation/Group/CreateNewGroupPublicV1.cs) | [CreateNewGroupPublicV1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Group/Group/CreateNewGroupPublicV1.cs) |
| `/group/v1/public/namespaces/{namespace}/groups/{groupId}` | GET | GetSingleGroupPublicV1 | [GetSingleGroupPublicV1](../../AccelByte.Sdk/Api/Group/Operation/Group/GetSingleGroupPublicV1.cs) | [GetSingleGroupPublicV1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Group/Group/GetSingleGroupPublicV1.cs) |
| `/group/v1/public/namespaces/{namespace}/groups/{groupId}` | PUT | UpdateSingleGroupV1 | [UpdateSingleGroupV1](../../AccelByte.Sdk/Api/Group/Operation/Group/UpdateSingleGroupV1.cs) | [UpdateSingleGroupV1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Group/Group/UpdateSingleGroupV1.cs) |
| `/group/v1/public/namespaces/{namespace}/groups/{groupId}` | DELETE | DeleteGroupPublicV1 | [DeleteGroupPublicV1](../../AccelByte.Sdk/Api/Group/Operation/Group/DeleteGroupPublicV1.cs) | [DeleteGroupPublicV1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Group/Group/DeleteGroupPublicV1.cs) |
| `/group/v1/public/namespaces/{namespace}/groups/{groupId}` | PATCH | UpdatePatchSingleGroupPublicV1 | [UpdatePatchSingleGroupPublicV1](../../AccelByte.Sdk/Api/Group/Operation/Group/UpdatePatchSingleGroupPublicV1.cs) | [UpdatePatchSingleGroupPublicV1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Group/Group/UpdatePatchSingleGroupPublicV1.cs) |
| `/group/v1/public/namespaces/{namespace}/groups/{groupId}/attributes/custom` | PUT | UpdateGroupCustomAttributesPublicV1 | [UpdateGroupCustomAttributesPublicV1](../../AccelByte.Sdk/Api/Group/Operation/Group/UpdateGroupCustomAttributesPublicV1.cs) | [UpdateGroupCustomAttributesPublicV1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Group/Group/UpdateGroupCustomAttributesPublicV1.cs) |
| `/group/v1/public/namespaces/{namespace}/groups/{groupId}/rules/custom` | PUT | UpdateGroupCustomRulePublicV1 | [UpdateGroupCustomRulePublicV1](../../AccelByte.Sdk/Api/Group/Operation/Group/UpdateGroupCustomRulePublicV1.cs) | [UpdateGroupCustomRulePublicV1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Group/Group/UpdateGroupCustomRulePublicV1.cs) |
| `/group/v1/public/namespaces/{namespace}/groups/{groupId}/rules/defined/{allowedAction}` | PUT | UpdateGroupPredefinedRulePublicV1 | [UpdateGroupPredefinedRulePublicV1](../../AccelByte.Sdk/Api/Group/Operation/Group/UpdateGroupPredefinedRulePublicV1.cs) | [UpdateGroupPredefinedRulePublicV1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Group/Group/UpdateGroupPredefinedRulePublicV1.cs) |
| `/group/v1/public/namespaces/{namespace}/groups/{groupId}/rules/defined/{allowedAction}` | DELETE | DeleteGroupPredefinedRulePublicV1 | [DeleteGroupPredefinedRulePublicV1](../../AccelByte.Sdk/Api/Group/Operation/Group/DeleteGroupPredefinedRulePublicV1.cs) | [DeleteGroupPredefinedRulePublicV1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Group/Group/DeleteGroupPredefinedRulePublicV1.cs) |

### Group Member Wrapper:  [GroupMember](../../AccelByte.Sdk/Api/Group/Wrapper/GroupMember.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/group/v1/admin/namespaces/{namespace}/groups/{groupId}/members` | GET | GetGroupMembersListAdminV1 | [GetGroupMembersListAdminV1](../../AccelByte.Sdk/Api/Group/Operation/GroupMember/GetGroupMembersListAdminV1.cs) | [GetGroupMembersListAdminV1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Group/GroupMember/GetGroupMembersListAdminV1.cs) |
| `/group/v1/public/namespaces/{namespace}/groups/{groupId}/invite/accept` | POST | AcceptGroupInvitationPublicV1 | [AcceptGroupInvitationPublicV1](../../AccelByte.Sdk/Api/Group/Operation/GroupMember/AcceptGroupInvitationPublicV1.cs) | [AcceptGroupInvitationPublicV1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Group/GroupMember/AcceptGroupInvitationPublicV1.cs) |
| `/group/v1/public/namespaces/{namespace}/groups/{groupId}/invite/reject` | POST | RejectGroupInvitationPublicV1 | [RejectGroupInvitationPublicV1](../../AccelByte.Sdk/Api/Group/Operation/GroupMember/RejectGroupInvitationPublicV1.cs) | [RejectGroupInvitationPublicV1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Group/GroupMember/RejectGroupInvitationPublicV1.cs) |
| `/group/v1/public/namespaces/{namespace}/groups/{groupId}/join` | POST | JoinGroupV1 | [JoinGroupV1](../../AccelByte.Sdk/Api/Group/Operation/GroupMember/JoinGroupV1.cs) | [JoinGroupV1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Group/GroupMember/JoinGroupV1.cs) |
| `/group/v1/public/namespaces/{namespace}/groups/{groupId}/join/cancel` | POST | CancelGroupJoinRequestV1 | [CancelGroupJoinRequestV1](../../AccelByte.Sdk/Api/Group/Operation/GroupMember/CancelGroupJoinRequestV1.cs) | [CancelGroupJoinRequestV1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Group/GroupMember/CancelGroupJoinRequestV1.cs) |
| `/group/v1/public/namespaces/{namespace}/groups/{groupId}/members` | GET | GetGroupMembersListPublicV1 | [GetGroupMembersListPublicV1](../../AccelByte.Sdk/Api/Group/Operation/GroupMember/GetGroupMembersListPublicV1.cs) | [GetGroupMembersListPublicV1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Group/GroupMember/GetGroupMembersListPublicV1.cs) |
| `/group/v1/public/namespaces/{namespace}/leave` | POST | LeaveGroupPublicV1 | [LeaveGroupPublicV1](../../AccelByte.Sdk/Api/Group/Operation/GroupMember/LeaveGroupPublicV1.cs) | [LeaveGroupPublicV1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Group/GroupMember/LeaveGroupPublicV1.cs) |
| `/group/v1/public/namespaces/{namespace}/users/{userId}` | GET | GetUserGroupInformationPublicV1 | [GetUserGroupInformationPublicV1](../../AccelByte.Sdk/Api/Group/Operation/GroupMember/GetUserGroupInformationPublicV1.cs) | [GetUserGroupInformationPublicV1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Group/GroupMember/GetUserGroupInformationPublicV1.cs) |
| `/group/v1/public/namespaces/{namespace}/users/{userId}/invite` | POST | InviteGroupPublicV1 | [InviteGroupPublicV1](../../AccelByte.Sdk/Api/Group/Operation/GroupMember/InviteGroupPublicV1.cs) | [InviteGroupPublicV1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Group/GroupMember/InviteGroupPublicV1.cs) |
| `/group/v1/public/namespaces/{namespace}/users/{userId}/join/accept` | POST | AcceptGroupJoinRequestPublicV1 | [AcceptGroupJoinRequestPublicV1](../../AccelByte.Sdk/Api/Group/Operation/GroupMember/AcceptGroupJoinRequestPublicV1.cs) | [AcceptGroupJoinRequestPublicV1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Group/GroupMember/AcceptGroupJoinRequestPublicV1.cs) |
| `/group/v1/public/namespaces/{namespace}/users/{userId}/join/reject` | POST | RejectGroupJoinRequestPublicV1 | [RejectGroupJoinRequestPublicV1](../../AccelByte.Sdk/Api/Group/Operation/GroupMember/RejectGroupJoinRequestPublicV1.cs) | [RejectGroupJoinRequestPublicV1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Group/GroupMember/RejectGroupJoinRequestPublicV1.cs) |
| `/group/v1/public/namespaces/{namespace}/users/{userId}/kick` | POST | KickGroupMemberPublicV1 | [KickGroupMemberPublicV1](../../AccelByte.Sdk/Api/Group/Operation/GroupMember/KickGroupMemberPublicV1.cs) | [KickGroupMemberPublicV1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Group/GroupMember/KickGroupMemberPublicV1.cs) |

### Group Roles Wrapper:  [GroupRoles](../../AccelByte.Sdk/Api/Group/Wrapper/GroupRoles.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/group/v1/admin/namespaces/{namespace}/roles` | GET | GetMemberRolesListAdminV1 | [GetMemberRolesListAdminV1](../../AccelByte.Sdk/Api/Group/Operation/GroupRoles/GetMemberRolesListAdminV1.cs) | [GetMemberRolesListAdminV1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Group/GroupRoles/GetMemberRolesListAdminV1.cs) |
| `/group/v1/admin/namespaces/{namespace}/roles` | POST | CreateMemberRoleAdminV1 | [CreateMemberRoleAdminV1](../../AccelByte.Sdk/Api/Group/Operation/GroupRoles/CreateMemberRoleAdminV1.cs) | [CreateMemberRoleAdminV1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Group/GroupRoles/CreateMemberRoleAdminV1.cs) |
| `/group/v1/admin/namespaces/{namespace}/roles/{memberRoleId}` | GET | GetSingleMemberRoleAdminV1 | [GetSingleMemberRoleAdminV1](../../AccelByte.Sdk/Api/Group/Operation/GroupRoles/GetSingleMemberRoleAdminV1.cs) | [GetSingleMemberRoleAdminV1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Group/GroupRoles/GetSingleMemberRoleAdminV1.cs) |
| `/group/v1/admin/namespaces/{namespace}/roles/{memberRoleId}` | DELETE | DeleteMemberRoleAdminV1 | [DeleteMemberRoleAdminV1](../../AccelByte.Sdk/Api/Group/Operation/GroupRoles/DeleteMemberRoleAdminV1.cs) | [DeleteMemberRoleAdminV1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Group/GroupRoles/DeleteMemberRoleAdminV1.cs) |
| `/group/v1/admin/namespaces/{namespace}/roles/{memberRoleId}` | PATCH | UpdateMemberRoleAdminV1 | [UpdateMemberRoleAdminV1](../../AccelByte.Sdk/Api/Group/Operation/GroupRoles/UpdateMemberRoleAdminV1.cs) | [UpdateMemberRoleAdminV1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Group/GroupRoles/UpdateMemberRoleAdminV1.cs) |
| `/group/v1/admin/namespaces/{namespace}/roles/{memberRoleId}/permissions` | PUT | UpdateMemberRolePermissionAdminV1 | [UpdateMemberRolePermissionAdminV1](../../AccelByte.Sdk/Api/Group/Operation/GroupRoles/UpdateMemberRolePermissionAdminV1.cs) | [UpdateMemberRolePermissionAdminV1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Group/GroupRoles/UpdateMemberRolePermissionAdminV1.cs) |
| `/group/v1/public/namespaces/{namespace}/roles` | GET | GetMemberRolesListPublicV1 | [GetMemberRolesListPublicV1](../../AccelByte.Sdk/Api/Group/Operation/GroupRoles/GetMemberRolesListPublicV1.cs) | [GetMemberRolesListPublicV1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Group/GroupRoles/GetMemberRolesListPublicV1.cs) |
| `/group/v1/public/namespaces/{namespace}/roles/{memberRoleId}/members` | POST | UpdateMemberRolePublicV1 | [UpdateMemberRolePublicV1](../../AccelByte.Sdk/Api/Group/Operation/GroupRoles/UpdateMemberRolePublicV1.cs) | [UpdateMemberRolePublicV1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Group/GroupRoles/UpdateMemberRolePublicV1.cs) |
| `/group/v1/public/namespaces/{namespace}/roles/{memberRoleId}/members` | DELETE | DeleteMemberRolePublicV1 | [DeleteMemberRolePublicV1](../../AccelByte.Sdk/Api/Group/Operation/GroupRoles/DeleteMemberRolePublicV1.cs) | [DeleteMemberRolePublicV1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Group/GroupRoles/DeleteMemberRolePublicV1.cs) |

### Member Request Wrapper:  [MemberRequest](../../AccelByte.Sdk/Api/Group/Wrapper/MemberRequest.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/group/v1/public/namespaces/{namespace}/groups/{groupId}/join/request` | GET | GetGroupJoinRequestPublicV1 | [GetGroupJoinRequestPublicV1](../../AccelByte.Sdk/Api/Group/Operation/MemberRequest/GetGroupJoinRequestPublicV1.cs) | [GetGroupJoinRequestPublicV1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Group/MemberRequest/GetGroupJoinRequestPublicV1.cs) |
| `/group/v1/public/namespaces/{namespace}/users/me/invite/request` | GET | GetGroupInvitationRequestPublicV1 | [GetGroupInvitationRequestPublicV1](../../AccelByte.Sdk/Api/Group/Operation/MemberRequest/GetGroupInvitationRequestPublicV1.cs) | [GetGroupInvitationRequestPublicV1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Group/MemberRequest/GetGroupInvitationRequestPublicV1.cs) |


&nbsp;  

## Models

| Model | Class |
|---|---|
| `models.AssignRoleToMemberRequestV1` | [ModelsAssignRoleToMemberRequestV1](../../AccelByte.Sdk/Api/Group/Model/ModelsAssignRoleToMemberRequestV1.cs) |
| `models.CreateGroupConfigurationRequestV1` | [ModelsCreateGroupConfigurationRequestV1](../../AccelByte.Sdk/Api/Group/Model/ModelsCreateGroupConfigurationRequestV1.cs) |
| `models.CreateGroupConfigurationResponseV1` | [ModelsCreateGroupConfigurationResponseV1](../../AccelByte.Sdk/Api/Group/Model/ModelsCreateGroupConfigurationResponseV1.cs) |
| `models.CreateMemberRoleRequestV1` | [ModelsCreateMemberRoleRequestV1](../../AccelByte.Sdk/Api/Group/Model/ModelsCreateMemberRoleRequestV1.cs) |
| `models.CreateMemberRoleResponseV1` | [ModelsCreateMemberRoleResponseV1](../../AccelByte.Sdk/Api/Group/Model/ModelsCreateMemberRoleResponseV1.cs) |
| `models.GetGroupConfigurationResponseV1` | [ModelsGetGroupConfigurationResponseV1](../../AccelByte.Sdk/Api/Group/Model/ModelsGetGroupConfigurationResponseV1.cs) |
| `models.GetGroupMemberListResponseV1` | [ModelsGetGroupMemberListResponseV1](../../AccelByte.Sdk/Api/Group/Model/ModelsGetGroupMemberListResponseV1.cs) |
| `models.GetGroupsListResponseV1` | [ModelsGetGroupsListResponseV1](../../AccelByte.Sdk/Api/Group/Model/ModelsGetGroupsListResponseV1.cs) |
| `models.GetMemberRequestsListResponseV1` | [ModelsGetMemberRequestsListResponseV1](../../AccelByte.Sdk/Api/Group/Model/ModelsGetMemberRequestsListResponseV1.cs) |
| `models.GetMemberRoleResponseV1` | [ModelsGetMemberRoleResponseV1](../../AccelByte.Sdk/Api/Group/Model/ModelsGetMemberRoleResponseV1.cs) |
| `models.GetMemberRolesListResponseV1` | [ModelsGetMemberRolesListResponseV1](../../AccelByte.Sdk/Api/Group/Model/ModelsGetMemberRolesListResponseV1.cs) |
| `models.GetUserGroupInformationResponseV1` | [ModelsGetUserGroupInformationResponseV1](../../AccelByte.Sdk/Api/Group/Model/ModelsGetUserGroupInformationResponseV1.cs) |
| `models.GroupMember` | [ModelsGroupMember](../../AccelByte.Sdk/Api/Group/Model/ModelsGroupMember.cs) |
| `models.GroupResponseV1` | [ModelsGroupResponseV1](../../AccelByte.Sdk/Api/Group/Model/ModelsGroupResponseV1.cs) |
| `models.GroupRule` | [ModelsGroupRule](../../AccelByte.Sdk/Api/Group/Model/ModelsGroupRule.cs) |
| `models.GroupRule.groupCustomRule` | [ModelsGroupRuleGroupCustomRule](../../AccelByte.Sdk/Api/Group/Model/ModelsGroupRuleGroupCustomRule.cs) |
| `models.JoinGroupResponseV1` | [ModelsJoinGroupResponseV1](../../AccelByte.Sdk/Api/Group/Model/ModelsJoinGroupResponseV1.cs) |
| `models.KickGroupMemberResponseV1` | [ModelsKickGroupMemberResponseV1](../../AccelByte.Sdk/Api/Group/Model/ModelsKickGroupMemberResponseV1.cs) |
| `models.LeaveGroupResponseV1` | [ModelsLeaveGroupResponseV1](../../AccelByte.Sdk/Api/Group/Model/ModelsLeaveGroupResponseV1.cs) |
| `models.ListConfigurationResponseV1` | [ModelsListConfigurationResponseV1](../../AccelByte.Sdk/Api/Group/Model/ModelsListConfigurationResponseV1.cs) |
| `models.MemberRequestGroupResponseV1` | [ModelsMemberRequestGroupResponseV1](../../AccelByte.Sdk/Api/Group/Model/ModelsMemberRequestGroupResponseV1.cs) |
| `models.MemberRequestResponseV1` | [ModelsMemberRequestResponseV1](../../AccelByte.Sdk/Api/Group/Model/ModelsMemberRequestResponseV1.cs) |
| `models.Pagination` | [ModelsPagination](../../AccelByte.Sdk/Api/Group/Model/ModelsPagination.cs) |
| `models.PublicCreateNewGroupRequestV1` | [ModelsPublicCreateNewGroupRequestV1](../../AccelByte.Sdk/Api/Group/Model/ModelsPublicCreateNewGroupRequestV1.cs) |
| `models.RemoveRoleFromMemberRequestV1` | [ModelsRemoveRoleFromMemberRequestV1](../../AccelByte.Sdk/Api/Group/Model/ModelsRemoveRoleFromMemberRequestV1.cs) |
| `models.RolePermission` | [ModelsRolePermission](../../AccelByte.Sdk/Api/Group/Model/ModelsRolePermission.cs) |
| `models.Rule` | [ModelsRule](../../AccelByte.Sdk/Api/Group/Model/ModelsRule.cs) |
| `models.RuleInformation` | [ModelsRuleInformation](../../AccelByte.Sdk/Api/Group/Model/ModelsRuleInformation.cs) |
| `models.UpdateGroupConfigurationGlobalRulesRequestV1` | [ModelsUpdateGroupConfigurationGlobalRulesRequestV1](../../AccelByte.Sdk/Api/Group/Model/ModelsUpdateGroupConfigurationGlobalRulesRequestV1.cs) |
| `models.UpdateGroupConfigurationRequestV1` | [ModelsUpdateGroupConfigurationRequestV1](../../AccelByte.Sdk/Api/Group/Model/ModelsUpdateGroupConfigurationRequestV1.cs) |
| `models.UpdateGroupConfigurationResponseV1` | [ModelsUpdateGroupConfigurationResponseV1](../../AccelByte.Sdk/Api/Group/Model/ModelsUpdateGroupConfigurationResponseV1.cs) |
| `models.UpdateGroupCustomAttributesRequestV1` | [ModelsUpdateGroupCustomAttributesRequestV1](../../AccelByte.Sdk/Api/Group/Model/ModelsUpdateGroupCustomAttributesRequestV1.cs) |
| `models.UpdateGroupCustomRuleRequestV1` | [ModelsUpdateGroupCustomRuleRequestV1](../../AccelByte.Sdk/Api/Group/Model/ModelsUpdateGroupCustomRuleRequestV1.cs) |
| `models.UpdateGroupPredefinedRuleRequestV1` | [ModelsUpdateGroupPredefinedRuleRequestV1](../../AccelByte.Sdk/Api/Group/Model/ModelsUpdateGroupPredefinedRuleRequestV1.cs) |
| `models.UpdateGroupRequestV1` | [ModelsUpdateGroupRequestV1](../../AccelByte.Sdk/Api/Group/Model/ModelsUpdateGroupRequestV1.cs) |
| `models.UpdateGroupRequestV1.customAttributes` | [ModelsUpdateGroupRequestV1CustomAttributes](../../AccelByte.Sdk/Api/Group/Model/ModelsUpdateGroupRequestV1CustomAttributes.cs) |
| `models.UpdateMemberRolePermissionsRequestV1` | [ModelsUpdateMemberRolePermissionsRequestV1](../../AccelByte.Sdk/Api/Group/Model/ModelsUpdateMemberRolePermissionsRequestV1.cs) |
| `models.UpdateMemberRoleRequestV1` | [ModelsUpdateMemberRoleRequestV1](../../AccelByte.Sdk/Api/Group/Model/ModelsUpdateMemberRoleRequestV1.cs) |
| `models.UpdateMemberRoleResponseV1` | [ModelsUpdateMemberRoleResponseV1](../../AccelByte.Sdk/Api/Group/Model/ModelsUpdateMemberRoleResponseV1.cs) |
| `models.UserInvitationResponseV1` | [ModelsUserInvitationResponseV1](../../AccelByte.Sdk/Api/Group/Model/ModelsUserInvitationResponseV1.cs) |
| `response.ErrorResponse` | [ResponseErrorResponse](../../AccelByte.Sdk/Api/Group/Model/ResponseErrorResponse.cs) |
