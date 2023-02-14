# Reporting Service Index

&nbsp;  

## Operations

### Admin Extension Categories and Auto Moderation Actions Wrapper:  [AdminExtensionCategoriesAndAutoModerationActions](../../AccelByte.Sdk/Api/Reporting/Wrapper/AdminExtensionCategoriesAndAutoModerationActions.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/reporting/v1/admin/extensionActions` | GET | AdminFindActionList | [AdminFindActionList](../../AccelByte.Sdk/Api/Reporting/Operation/AdminExtensionCategoriesAndAutoModerationActions/AdminFindActionList.cs) | [AdminFindActionList](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Reporting/AdminExtensionCategoriesAndAutoModerationActions/AdminFindActionList.cs) |
| `/reporting/v1/admin/extensionActions` | POST | AdminCreateModAction | [AdminCreateModAction](../../AccelByte.Sdk/Api/Reporting/Operation/AdminExtensionCategoriesAndAutoModerationActions/AdminCreateModAction.cs) | [AdminCreateModAction](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Reporting/AdminExtensionCategoriesAndAutoModerationActions/AdminCreateModAction.cs) |
| `/reporting/v1/admin/extensionCategories` | GET | AdminFindExtensionCategoryList | [AdminFindExtensionCategoryList](../../AccelByte.Sdk/Api/Reporting/Operation/AdminExtensionCategoriesAndAutoModerationActions/AdminFindExtensionCategoryList.cs) | [AdminFindExtensionCategoryList](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Reporting/AdminExtensionCategoriesAndAutoModerationActions/AdminFindExtensionCategoryList.cs) |
| `/reporting/v1/admin/extensionCategories` | POST | AdminCreateExtensionCategory | [AdminCreateExtensionCategory](../../AccelByte.Sdk/Api/Reporting/Operation/AdminExtensionCategoriesAndAutoModerationActions/AdminCreateExtensionCategory.cs) | [AdminCreateExtensionCategory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Reporting/AdminExtensionCategoriesAndAutoModerationActions/AdminCreateExtensionCategory.cs) |

### Admin Configurations Wrapper:  [AdminConfigurations](../../AccelByte.Sdk/Api/Reporting/Wrapper/AdminConfigurations.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/reporting/v1/admin/namespaces/{namespace}/configurations` | GET | Get | [Get](../../AccelByte.Sdk/Api/Reporting/Operation/AdminConfigurations/Get.cs) | [Get](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Reporting/AdminConfigurations/Get.cs) |
| `/reporting/v1/admin/namespaces/{namespace}/configurations` | POST | Upsert | [Upsert](../../AccelByte.Sdk/Api/Reporting/Operation/AdminConfigurations/Upsert.cs) | [Upsert](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Reporting/AdminConfigurations/Upsert.cs) |

### Admin Reasons Wrapper:  [AdminReasons](../../AccelByte.Sdk/Api/Reporting/Wrapper/AdminReasons.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/reporting/v1/admin/namespaces/{namespace}/reasonGroups` | GET | AdminListReasonGroups | [AdminListReasonGroups](../../AccelByte.Sdk/Api/Reporting/Operation/AdminReasons/AdminListReasonGroups.cs) | [AdminListReasonGroups](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Reporting/AdminReasons/AdminListReasonGroups.cs) |
| `/reporting/v1/admin/namespaces/{namespace}/reasonGroups` | POST | CreateReasonGroup | [CreateReasonGroup](../../AccelByte.Sdk/Api/Reporting/Operation/AdminReasons/CreateReasonGroup.cs) | [CreateReasonGroup](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Reporting/AdminReasons/CreateReasonGroup.cs) |
| `/reporting/v1/admin/namespaces/{namespace}/reasonGroups/{groupId}` | GET | GetReasonGroup | [GetReasonGroup](../../AccelByte.Sdk/Api/Reporting/Operation/AdminReasons/GetReasonGroup.cs) | [GetReasonGroup](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Reporting/AdminReasons/GetReasonGroup.cs) |
| `/reporting/v1/admin/namespaces/{namespace}/reasonGroups/{groupId}` | DELETE | DeleteReasonGroup | [DeleteReasonGroup](../../AccelByte.Sdk/Api/Reporting/Operation/AdminReasons/DeleteReasonGroup.cs) | [DeleteReasonGroup](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Reporting/AdminReasons/DeleteReasonGroup.cs) |
| `/reporting/v1/admin/namespaces/{namespace}/reasonGroups/{groupId}` | PATCH | UpdateReasonGroup | [UpdateReasonGroup](../../AccelByte.Sdk/Api/Reporting/Operation/AdminReasons/UpdateReasonGroup.cs) | [UpdateReasonGroup](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Reporting/AdminReasons/UpdateReasonGroup.cs) |
| `/reporting/v1/admin/namespaces/{namespace}/reasons` | GET | AdminGetReasons | [AdminGetReasons](../../AccelByte.Sdk/Api/Reporting/Operation/AdminReasons/AdminGetReasons.cs) | [AdminGetReasons](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Reporting/AdminReasons/AdminGetReasons.cs) |
| `/reporting/v1/admin/namespaces/{namespace}/reasons` | POST | CreateReason | [CreateReason](../../AccelByte.Sdk/Api/Reporting/Operation/AdminReasons/CreateReason.cs) | [CreateReason](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Reporting/AdminReasons/CreateReason.cs) |
| `/reporting/v1/admin/namespaces/{namespace}/reasons/all` | GET | AdminGetAllReasons | [AdminGetAllReasons](../../AccelByte.Sdk/Api/Reporting/Operation/AdminReasons/AdminGetAllReasons.cs) | [AdminGetAllReasons](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Reporting/AdminReasons/AdminGetAllReasons.cs) |
| `/reporting/v1/admin/namespaces/{namespace}/reasons/unused` | GET | AdminGetUnusedReasons | [AdminGetUnusedReasons](../../AccelByte.Sdk/Api/Reporting/Operation/AdminReasons/AdminGetUnusedReasons.cs) | [AdminGetUnusedReasons](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Reporting/AdminReasons/AdminGetUnusedReasons.cs) |
| `/reporting/v1/admin/namespaces/{namespace}/reasons/{reasonId}` | GET | AdminGetReason | [AdminGetReason](../../AccelByte.Sdk/Api/Reporting/Operation/AdminReasons/AdminGetReason.cs) | [AdminGetReason](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Reporting/AdminReasons/AdminGetReason.cs) |
| `/reporting/v1/admin/namespaces/{namespace}/reasons/{reasonId}` | DELETE | DeleteReason | [DeleteReason](../../AccelByte.Sdk/Api/Reporting/Operation/AdminReasons/DeleteReason.cs) | [DeleteReason](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Reporting/AdminReasons/DeleteReason.cs) |
| `/reporting/v1/admin/namespaces/{namespace}/reasons/{reasonId}` | PATCH | UpdateReason | [UpdateReason](../../AccelByte.Sdk/Api/Reporting/Operation/AdminReasons/UpdateReason.cs) | [UpdateReason](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Reporting/AdminReasons/UpdateReason.cs) |

### Admin Reports Wrapper:  [AdminReports](../../AccelByte.Sdk/Api/Reporting/Wrapper/AdminReports.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/reporting/v1/admin/namespaces/{namespace}/reports` | GET | ListReports | [ListReports](../../AccelByte.Sdk/Api/Reporting/Operation/AdminReports/ListReports.cs) | [ListReports](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Reporting/AdminReports/ListReports.cs) |
| `/reporting/v1/admin/namespaces/{namespace}/reports` | POST | AdminSubmitReport | [AdminSubmitReport](../../AccelByte.Sdk/Api/Reporting/Operation/AdminReports/AdminSubmitReport.cs) | [AdminSubmitReport](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Reporting/AdminReports/AdminSubmitReport.cs) |

### Admin Moderation Rule Wrapper:  [AdminModerationRule](../../AccelByte.Sdk/Api/Reporting/Wrapper/AdminModerationRule.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/reporting/v1/admin/namespaces/{namespace}/rule` | POST | CreateModerationRule | [CreateModerationRule](../../AccelByte.Sdk/Api/Reporting/Operation/AdminModerationRule/CreateModerationRule.cs) | [CreateModerationRule](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Reporting/AdminModerationRule/CreateModerationRule.cs) |
| `/reporting/v1/admin/namespaces/{namespace}/rule/{ruleId}` | PUT | UpdateModerationRule | [UpdateModerationRule](../../AccelByte.Sdk/Api/Reporting/Operation/AdminModerationRule/UpdateModerationRule.cs) | [UpdateModerationRule](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Reporting/AdminModerationRule/UpdateModerationRule.cs) |
| `/reporting/v1/admin/namespaces/{namespace}/rule/{ruleId}` | DELETE | DeleteModerationRule | [DeleteModerationRule](../../AccelByte.Sdk/Api/Reporting/Operation/AdminModerationRule/DeleteModerationRule.cs) | [DeleteModerationRule](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Reporting/AdminModerationRule/DeleteModerationRule.cs) |
| `/reporting/v1/admin/namespaces/{namespace}/rule/{ruleId}/status` | PUT | UpdateModerationRuleStatus | [UpdateModerationRuleStatus](../../AccelByte.Sdk/Api/Reporting/Operation/AdminModerationRule/UpdateModerationRuleStatus.cs) | [UpdateModerationRuleStatus](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Reporting/AdminModerationRule/UpdateModerationRuleStatus.cs) |
| `/reporting/v1/admin/namespaces/{namespace}/rules` | GET | GetModerationRules | [GetModerationRules](../../AccelByte.Sdk/Api/Reporting/Operation/AdminModerationRule/GetModerationRules.cs) | [GetModerationRules](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Reporting/AdminModerationRule/GetModerationRules.cs) |
| `/reporting/v1/admin/namespaces/{namespace}/rules/{ruleId}` | GET | GetModerationRuleDetails | [GetModerationRuleDetails](../../AccelByte.Sdk/Api/Reporting/Operation/AdminModerationRule/GetModerationRuleDetails.cs) | [GetModerationRuleDetails](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Reporting/AdminModerationRule/GetModerationRuleDetails.cs) |

### Admin Tickets Wrapper:  [AdminTickets](../../AccelByte.Sdk/Api/Reporting/Wrapper/AdminTickets.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/reporting/v1/admin/namespaces/{namespace}/tickets` | GET | ListTickets | [ListTickets](../../AccelByte.Sdk/Api/Reporting/Operation/AdminTickets/ListTickets.cs) | [ListTickets](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Reporting/AdminTickets/ListTickets.cs) |
| `/reporting/v1/admin/namespaces/{namespace}/tickets/statistic` | GET | TicketStatistic | [TicketStatistic](../../AccelByte.Sdk/Api/Reporting/Operation/AdminTickets/TicketStatistic.cs) | [TicketStatistic](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Reporting/AdminTickets/TicketStatistic.cs) |
| `/reporting/v1/admin/namespaces/{namespace}/tickets/{ticketId}` | GET | GetTicketDetail | [GetTicketDetail](../../AccelByte.Sdk/Api/Reporting/Operation/AdminTickets/GetTicketDetail.cs) | [GetTicketDetail](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Reporting/AdminTickets/GetTicketDetail.cs) |
| `/reporting/v1/admin/namespaces/{namespace}/tickets/{ticketId}` | DELETE | DeleteTicket | [DeleteTicket](../../AccelByte.Sdk/Api/Reporting/Operation/AdminTickets/DeleteTicket.cs) | [DeleteTicket](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Reporting/AdminTickets/DeleteTicket.cs) |
| `/reporting/v1/admin/namespaces/{namespace}/tickets/{ticketId}/reports` | GET | GetReportsByTicket | [GetReportsByTicket](../../AccelByte.Sdk/Api/Reporting/Operation/AdminTickets/GetReportsByTicket.cs) | [GetReportsByTicket](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Reporting/AdminTickets/GetReportsByTicket.cs) |
| `/reporting/v1/admin/namespaces/{namespace}/tickets/{ticketId}/resolutions` | POST | UpdateTicketResolutions | [UpdateTicketResolutions](../../AccelByte.Sdk/Api/Reporting/Operation/AdminTickets/UpdateTicketResolutions.cs) | [UpdateTicketResolutions](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Reporting/AdminTickets/UpdateTicketResolutions.cs) |

### Public Reasons Wrapper:  [PublicReasons](../../AccelByte.Sdk/Api/Reporting/Wrapper/PublicReasons.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/reporting/v1/public/namespaces/{namespace}/reasonGroups` | GET | PublicListReasonGroups | [PublicListReasonGroups](../../AccelByte.Sdk/Api/Reporting/Operation/PublicReasons/PublicListReasonGroups.cs) | [PublicListReasonGroups](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Reporting/PublicReasons/PublicListReasonGroups.cs) |
| `/reporting/v1/public/namespaces/{namespace}/reasons` | GET | PublicGetReasons | [PublicGetReasons](../../AccelByte.Sdk/Api/Reporting/Operation/PublicReasons/PublicGetReasons.cs) | [PublicGetReasons](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Reporting/PublicReasons/PublicGetReasons.cs) |

### Public Reports Wrapper:  [PublicReports](../../AccelByte.Sdk/Api/Reporting/Wrapper/PublicReports.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/reporting/v1/public/namespaces/{namespace}/reports` | POST | SubmitReport | [SubmitReport](../../AccelByte.Sdk/Api/Reporting/Operation/PublicReports/SubmitReport.cs) | [SubmitReport](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Reporting/PublicReports/SubmitReport.cs) |


&nbsp;  

## Operations with Generic Response

### Admin Extension Categories and Auto Moderation Actions Wrapper:  [AdminExtensionCategoriesAndAutoModerationActions](../../AccelByte.Sdk/Api/Reporting/Wrapper/AdminExtensionCategoriesAndAutoModerationActions.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Admin Configurations Wrapper:  [AdminConfigurations](../../AccelByte.Sdk/Api/Reporting/Wrapper/AdminConfigurations.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Admin Reasons Wrapper:  [AdminReasons](../../AccelByte.Sdk/Api/Reporting/Wrapper/AdminReasons.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Admin Reports Wrapper:  [AdminReports](../../AccelByte.Sdk/Api/Reporting/Wrapper/AdminReports.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Admin Moderation Rule Wrapper:  [AdminModerationRule](../../AccelByte.Sdk/Api/Reporting/Wrapper/AdminModerationRule.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Admin Tickets Wrapper:  [AdminTickets](../../AccelByte.Sdk/Api/Reporting/Wrapper/AdminTickets.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Public Reasons Wrapper:  [PublicReasons](../../AccelByte.Sdk/Api/Reporting/Wrapper/PublicReasons.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Public Reports Wrapper:  [PublicReports](../../AccelByte.Sdk/Api/Reporting/Wrapper/PublicReports.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|


&nbsp;  

## Models

| Model | Class |
|---|---|
| `restapi.AdminAllReasonsResponse` | [RestapiAdminAllReasonsResponse](../../AccelByte.Sdk/Api/Reporting/Model/RestapiAdminAllReasonsResponse.cs) |
| `restapi.BanAccountActionRequest` | [RestapiBanAccountActionRequest](../../AccelByte.Sdk/Api/Reporting/Model/RestapiBanAccountActionRequest.cs) |
| `restapi.BanAccountActionResponse` | [RestapiBanAccountActionResponse](../../AccelByte.Sdk/Api/Reporting/Model/RestapiBanAccountActionResponse.cs) |
| `restapi.ModerationRuleActionsRequest` | [RestapiModerationRuleActionsRequest](../../AccelByte.Sdk/Api/Reporting/Model/RestapiModerationRuleActionsRequest.cs) |
| `restapi.ModerationRuleActionsResponse` | [RestapiModerationRuleActionsResponse](../../AccelByte.Sdk/Api/Reporting/Model/RestapiModerationRuleActionsResponse.cs) |
| `restapi.ModerationRuleActiveRequest` | [RestapiModerationRuleActiveRequest](../../AccelByte.Sdk/Api/Reporting/Model/RestapiModerationRuleActiveRequest.cs) |
| `restapi.ModerationRuleRequest` | [RestapiModerationRuleRequest](../../AccelByte.Sdk/Api/Reporting/Model/RestapiModerationRuleRequest.cs) |
| `restapi.ModerationRuleResponse` | [RestapiModerationRuleResponse](../../AccelByte.Sdk/Api/Reporting/Model/RestapiModerationRuleResponse.cs) |
| `restapi.ModerationRulesList` | [RestapiModerationRulesList](../../AccelByte.Sdk/Api/Reporting/Model/RestapiModerationRulesList.cs) |
| `restapi.UnusedReasonListResponse` | [RestapiUnusedReasonListResponse](../../AccelByte.Sdk/Api/Reporting/Model/RestapiUnusedReasonListResponse.cs) |
| `restapi.actionApiRequest` | [RestapiActionApiRequest](../../AccelByte.Sdk/Api/Reporting/Model/RestapiActionApiRequest.cs) |
| `restapi.actionApiResponse` | [RestapiActionApiResponse](../../AccelByte.Sdk/Api/Reporting/Model/RestapiActionApiResponse.cs) |
| `restapi.actionListApiResponse` | [RestapiActionListApiResponse](../../AccelByte.Sdk/Api/Reporting/Model/RestapiActionListApiResponse.cs) |
| `restapi.adminReasonListResponse` | [RestapiAdminReasonListResponse](../../AccelByte.Sdk/Api/Reporting/Model/RestapiAdminReasonListResponse.cs) |
| `restapi.adminReasonResponse` | [RestapiAdminReasonResponse](../../AccelByte.Sdk/Api/Reporting/Model/RestapiAdminReasonResponse.cs) |
| `restapi.categoryLimit` | [RestapiCategoryLimit](../../AccelByte.Sdk/Api/Reporting/Model/RestapiCategoryLimit.cs) |
| `restapi.configResponse` | [RestapiConfigResponse](../../AccelByte.Sdk/Api/Reporting/Model/RestapiConfigResponse.cs) |
| `restapi.createReasonGroupRequest` | [RestapiCreateReasonGroupRequest](../../AccelByte.Sdk/Api/Reporting/Model/RestapiCreateReasonGroupRequest.cs) |
| `restapi.createReasonRequest` | [RestapiCreateReasonRequest](../../AccelByte.Sdk/Api/Reporting/Model/RestapiCreateReasonRequest.cs) |
| `restapi.errorResponse` | [RestapiErrorResponse](../../AccelByte.Sdk/Api/Reporting/Model/RestapiErrorResponse.cs) |
| `restapi.extensionCategoryApiRequest` | [RestapiExtensionCategoryApiRequest](../../AccelByte.Sdk/Api/Reporting/Model/RestapiExtensionCategoryApiRequest.cs) |
| `restapi.extensionCategoryApiResponse` | [RestapiExtensionCategoryApiResponse](../../AccelByte.Sdk/Api/Reporting/Model/RestapiExtensionCategoryApiResponse.cs) |
| `restapi.extensionCategoryListApiResponse` | [RestapiExtensionCategoryListApiResponse](../../AccelByte.Sdk/Api/Reporting/Model/RestapiExtensionCategoryListApiResponse.cs) |
| `restapi.pagination` | [RestapiPagination](../../AccelByte.Sdk/Api/Reporting/Model/RestapiPagination.cs) |
| `restapi.publicReasonGroupResponse` | [RestapiPublicReasonGroupResponse](../../AccelByte.Sdk/Api/Reporting/Model/RestapiPublicReasonGroupResponse.cs) |
| `restapi.publicReasonListResponse` | [RestapiPublicReasonListResponse](../../AccelByte.Sdk/Api/Reporting/Model/RestapiPublicReasonListResponse.cs) |
| `restapi.publicReasonResponse` | [RestapiPublicReasonResponse](../../AccelByte.Sdk/Api/Reporting/Model/RestapiPublicReasonResponse.cs) |
| `restapi.reasonGroupListResponse` | [RestapiReasonGroupListResponse](../../AccelByte.Sdk/Api/Reporting/Model/RestapiReasonGroupListResponse.cs) |
| `restapi.reasonGroupResponse` | [RestapiReasonGroupResponse](../../AccelByte.Sdk/Api/Reporting/Model/RestapiReasonGroupResponse.cs) |
| `restapi.reportListResponse` | [RestapiReportListResponse](../../AccelByte.Sdk/Api/Reporting/Model/RestapiReportListResponse.cs) |
| `restapi.reportResponse` | [RestapiReportResponse](../../AccelByte.Sdk/Api/Reporting/Model/RestapiReportResponse.cs) |
| `restapi.reportingLimit` | [RestapiReportingLimit](../../AccelByte.Sdk/Api/Reporting/Model/RestapiReportingLimit.cs) |
| `restapi.submitReportRequest` | [RestapiSubmitReportRequest](../../AccelByte.Sdk/Api/Reporting/Model/RestapiSubmitReportRequest.cs) |
| `restapi.submitReportResponse` | [RestapiSubmitReportResponse](../../AccelByte.Sdk/Api/Reporting/Model/RestapiSubmitReportResponse.cs) |
| `restapi.ticketListResponse` | [RestapiTicketListResponse](../../AccelByte.Sdk/Api/Reporting/Model/RestapiTicketListResponse.cs) |
| `restapi.ticketResponse` | [RestapiTicketResponse](../../AccelByte.Sdk/Api/Reporting/Model/RestapiTicketResponse.cs) |
| `restapi.ticketStatisticResponse` | [RestapiTicketStatisticResponse](../../AccelByte.Sdk/Api/Reporting/Model/RestapiTicketStatisticResponse.cs) |
| `restapi.updateReasonGroupRequest` | [RestapiUpdateReasonGroupRequest](../../AccelByte.Sdk/Api/Reporting/Model/RestapiUpdateReasonGroupRequest.cs) |
| `restapi.updateTicketResolutionsRequest` | [RestapiUpdateTicketResolutionsRequest](../../AccelByte.Sdk/Api/Reporting/Model/RestapiUpdateTicketResolutionsRequest.cs) |
