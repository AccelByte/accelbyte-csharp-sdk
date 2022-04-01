# Eventlog Service Index

&nbsp;  

## Operations

### Event Descriptions Wrapper:  [EventDescriptions](../AccelByte.Sdk/Api/Eventlog/Wrapper/EventDescriptions.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /event/descriptions/agentType | GET | AgentTypeDescriptionHandler | [AgentTypeDescriptionHandler](../AccelByte.Sdk/Api/Eventlog/Operation//AgentTypeDescriptionHandler.cs) |
| /event/descriptions/agentType/listByAgentTypes | GET | SpecificAgentTypeDescriptionHandler | [SpecificAgentTypeDescriptionHandler](../AccelByte.Sdk/Api/Eventlog/Operation//SpecificAgentTypeDescriptionHandler.cs) |
| /event/descriptions/eventId | GET | EventIDDescriptionHandler | [EventIDDescriptionHandler](../AccelByte.Sdk/Api/Eventlog/Operation//EventIDDescriptionHandler.cs) |
| /event/descriptions/eventId/listByEventIds | GET | SpecificEventIDDescriptionHandler | [SpecificEventIDDescriptionHandler](../AccelByte.Sdk/Api/Eventlog/Operation//SpecificEventIDDescriptionHandler.cs) |
| /event/descriptions/eventLevel | GET | EventLevelDescriptionHandler | [EventLevelDescriptionHandler](../AccelByte.Sdk/Api/Eventlog/Operation//EventLevelDescriptionHandler.cs) |
| /event/descriptions/eventLevel/listByEventLevels | GET | SpecificEventLevelDescriptionHandler | [SpecificEventLevelDescriptionHandler](../AccelByte.Sdk/Api/Eventlog/Operation//SpecificEventLevelDescriptionHandler.cs) |
| /event/descriptions/eventType | GET | EventTypeDescriptionHandler | [EventTypeDescriptionHandler](../AccelByte.Sdk/Api/Eventlog/Operation//EventTypeDescriptionHandler.cs) |
| /event/descriptions/eventType/listByEventTypes | GET | SpecificEventTypeDescriptionHandler | [SpecificEventTypeDescriptionHandler](../AccelByte.Sdk/Api/Eventlog/Operation//SpecificEventTypeDescriptionHandler.cs) |
| /event/descriptions/ux | GET | UXNameDescriptionHandler | [UXNameDescriptionHandler](../AccelByte.Sdk/Api/Eventlog/Operation//UXNameDescriptionHandler.cs) |
| /event/descriptions/ux/listByUx | GET | SpecificUXDescriptionHandler | [SpecificUXDescriptionHandler](../AccelByte.Sdk/Api/Eventlog/Operation//SpecificUXDescriptionHandler.cs) |

### Event Wrapper:  [Event](../AccelByte.Sdk/Api/Eventlog/Wrapper/Event.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /event/namespaces/{namespace} | GET | GetEventByNamespaceHandler | [GetEventByNamespaceHandler](../AccelByte.Sdk/Api/Eventlog/Operation//GetEventByNamespaceHandler.cs) |
| /event/namespaces/{namespace} | POST | PostEventHandler | [PostEventHandler](../AccelByte.Sdk/Api/Eventlog/Operation//PostEventHandler.cs) |
| /event/namespaces/{namespace}/eventId/{eventId} | GET | GetEventByEventIDHandler | [GetEventByEventIDHandler](../AccelByte.Sdk/Api/Eventlog/Operation//GetEventByEventIDHandler.cs) |
| /event/namespaces/{namespace}/eventType/{eventType} | GET | GetEventByEventTypeHandler | [GetEventByEventTypeHandler](../AccelByte.Sdk/Api/Eventlog/Operation//GetEventByEventTypeHandler.cs) |
| /event/namespaces/{namespace}/eventType/{eventType}/eventId/{eventId} | GET | GetEventByEventTypeAndEventIDHandler | [GetEventByEventTypeAndEventIDHandler](../AccelByte.Sdk/Api/Eventlog/Operation//GetEventByEventTypeAndEventIDHandler.cs) |
| /event/namespaces/{namespace}/users/{userId} | GET | GetEventByUserIDHandler | [GetEventByUserIDHandler](../AccelByte.Sdk/Api/Eventlog/Operation//GetEventByUserIDHandler.cs) |
| /event/namespaces/{namespace}/users/{userId}/eventId/{eventId} | GET | GetEventByUserIDAndEventIDHandler | [GetEventByUserIDAndEventIDHandler](../AccelByte.Sdk/Api/Eventlog/Operation//GetEventByUserIDAndEventIDHandler.cs) |
| /event/namespaces/{namespace}/users/{userId}/eventType/{eventType} | GET | GetEventByUserIDAndEventTypeHandler | [GetEventByUserIDAndEventTypeHandler](../AccelByte.Sdk/Api/Eventlog/Operation//GetEventByUserIDAndEventTypeHandler.cs) |
| /event/namespaces/{namespace}/users/{userId}/eventType/{eventType}/eventId/{eventId} | GET | GetEventByUserEventIDAndEventTypeHandler | [GetEventByUserEventIDAndEventTypeHandler](../AccelByte.Sdk/Api/Eventlog/Operation//GetEventByUserEventIDAndEventTypeHandler.cs) |

### User Information Wrapper:  [UserInformation](../AccelByte.Sdk/Api/Eventlog/Wrapper/UserInformation.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /event/namespaces/{namespace}/users/{userId}/activities | GET | GetUserActivitiesHandler | [GetUserActivitiesHandler](../AccelByte.Sdk/Api/Eventlog/Operation//GetUserActivitiesHandler.cs) |
| /event/namespaces/{namespace}/users/{userId}/activities | DELETE | DeleteUserActivitiesHandler | [DeleteUserActivitiesHandler](../AccelByte.Sdk/Api/Eventlog/Operation//DeleteUserActivitiesHandler.cs) |
| /event/namespaces/{namespace}/users/{userId}/lastActivityTime | GET | LastUserActivityTimeHandler | [LastUserActivityTimeHandler](../AccelByte.Sdk/Api/Eventlog/Operation//LastUserActivityTimeHandler.cs) |

### Event Registry Wrapper:  [EventRegistry](../AccelByte.Sdk/Api/Eventlog/Wrapper/EventRegistry.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /event/registry/eventIds | GET | GetRegisteredEventsHandler | [GetRegisteredEventsHandler](../AccelByte.Sdk/Api/Eventlog/Operation//GetRegisteredEventsHandler.cs) |
| /event/registry/eventIds | POST | RegisterEventHandler | [RegisterEventHandler](../AccelByte.Sdk/Api/Eventlog/Operation//RegisterEventHandler.cs) |
| /event/registry/eventIds/{eventId} | GET | GetRegisteredEventIDHandler | [GetRegisteredEventIDHandler](../AccelByte.Sdk/Api/Eventlog/Operation//GetRegisteredEventIDHandler.cs) |
| /event/registry/eventIds/{eventId} | POST | UpdateEventRegistryHandler | [UpdateEventRegistryHandler](../AccelByte.Sdk/Api/Eventlog/Operation//UpdateEventRegistryHandler.cs) |
| /event/registry/eventIds/{eventId} | DELETE | UnregisterEventIDHandler | [UnregisterEventIDHandler](../AccelByte.Sdk/Api/Eventlog/Operation//UnregisterEventIDHandler.cs) |
| /event/registry/eventTypes/{eventType} | GET | GetRegisteredEventsByEventTypeHandler | [GetRegisteredEventsByEventTypeHandler](../AccelByte.Sdk/Api/Eventlog/Operation//GetRegisteredEventsByEventTypeHandler.cs) |

### Event V2 Wrapper:  [EventV2](../AccelByte.Sdk/Api/Eventlog/Wrapper/EventV2.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /event/v2/admin/namespaces/{namespace}/query | POST | QueryEventStreamHandler | [QueryEventStreamHandler](../AccelByte.Sdk/Api/Eventlog/Operation//QueryEventStreamHandler.cs) |
| /event/v2/admin/namespaces/{namespace}/users/{userId}/event | GET | GetEventSpecificUserV2Handler | [GetEventSpecificUserV2Handler](../AccelByte.Sdk/Api/Eventlog/Operation//GetEventSpecificUserV2Handler.cs) |
| /event/v2/public/namespaces/{namespace}/users/{userId}/edithistory | GET | GetPublicEditHistory | [GetPublicEditHistory](../AccelByte.Sdk/Api/Eventlog/Operation//GetPublicEditHistory.cs) |
| /event/v2/public/namespaces/{namespace}/users/{userId}/event | GET | GetUserEventsV2Public | [GetUserEventsV2Public](../AccelByte.Sdk/Api/Eventlog/Operation//GetUserEventsV2Public.cs) |


&nbsp;  

## Models

| Model | Class |
|---|---|
| models.AgentType | [ModelsAgentType](../AccelByte.Sdk/Api/Eventlog/Model/ModelsAgentType.cs) |
| models.Event | [ModelsEvent](../AccelByte.Sdk/Api/Eventlog/Model/ModelsEvent.cs) |
| models.EventID | [ModelsEventID](../AccelByte.Sdk/Api/Eventlog/Model/ModelsEventID.cs) |
| models.EventLevel | [ModelsEventLevel](../AccelByte.Sdk/Api/Eventlog/Model/ModelsEventLevel.cs) |
| models.EventRegistry | [ModelsEventRegistry](../AccelByte.Sdk/Api/Eventlog/Model/ModelsEventRegistry.cs) |
| models.EventResponse | [ModelsEventResponse](../AccelByte.Sdk/Api/Eventlog/Model/ModelsEventResponse.cs) |
| models.EventResponseV2 | [ModelsEventResponseV2](../AccelByte.Sdk/Api/Eventlog/Model/ModelsEventResponseV2.cs) |
| models.EventType | [ModelsEventType](../AccelByte.Sdk/Api/Eventlog/Model/ModelsEventType.cs) |
| models.EventV2 | [ModelsEventV2](../AccelByte.Sdk/Api/Eventlog/Model/ModelsEventV2.cs) |
| models.GenericQueryPayload | [ModelsGenericQueryPayload](../AccelByte.Sdk/Api/Eventlog/Model/ModelsGenericQueryPayload.cs) |
| models.MultipleAgentType | [ModelsMultipleAgentType](../AccelByte.Sdk/Api/Eventlog/Model/ModelsMultipleAgentType.cs) |
| models.MultipleEventID | [ModelsMultipleEventID](../AccelByte.Sdk/Api/Eventlog/Model/ModelsMultipleEventID.cs) |
| models.MultipleEventLevel | [ModelsMultipleEventLevel](../AccelByte.Sdk/Api/Eventlog/Model/ModelsMultipleEventLevel.cs) |
| models.MultipleEventType | [ModelsMultipleEventType](../AccelByte.Sdk/Api/Eventlog/Model/ModelsMultipleEventType.cs) |
| models.MultipleUX | [ModelsMultipleUX](../AccelByte.Sdk/Api/Eventlog/Model/ModelsMultipleUX.cs) |
| models.Pagination | [ModelsPagination](../AccelByte.Sdk/Api/Eventlog/Model/ModelsPagination.cs) |
| models.Paging | [ModelsPaging](../AccelByte.Sdk/Api/Eventlog/Model/ModelsPaging.cs) |
| models.UX | [ModelsUX](../AccelByte.Sdk/Api/Eventlog/Model/ModelsUX.cs) |
| models.UserLastActivity | [ModelsUserLastActivity](../AccelByte.Sdk/Api/Eventlog/Model/ModelsUserLastActivity.cs) |
