# Eventlog Service Index

&nbsp;  

## Operations

### Event Descriptions Wrapper:  [EventDescriptions](../../AccelByte.Sdk/Api/Eventlog/Wrapper/EventDescriptions.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/event/descriptions/agentType` | GET | AgentTypeDescriptionHandler | [AgentTypeDescriptionHandler](../../AccelByte.Sdk/Api/Eventlog/Operation/EventDescriptions/AgentTypeDescriptionHandler.cs) | [AgentTypeDescriptionHandler](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/EventDescriptions/AgentTypeDescriptionHandler.cs) |
| `/event/descriptions/agentType/listByAgentTypes` | GET | SpecificAgentTypeDescriptionHandler | [SpecificAgentTypeDescriptionHandler](../../AccelByte.Sdk/Api/Eventlog/Operation/EventDescriptions/SpecificAgentTypeDescriptionHandler.cs) | [SpecificAgentTypeDescriptionHandler](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/EventDescriptions/SpecificAgentTypeDescriptionHandler.cs) |
| `/event/descriptions/eventId` | GET | EventIDDescriptionHandler | [EventIDDescriptionHandler](../../AccelByte.Sdk/Api/Eventlog/Operation/EventDescriptions/EventIDDescriptionHandler.cs) | [EventIDDescriptionHandler](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/EventDescriptions/EventIDDescriptionHandler.cs) |
| `/event/descriptions/eventId/listByEventIds` | GET | SpecificEventIDDescriptionHandler | [SpecificEventIDDescriptionHandler](../../AccelByte.Sdk/Api/Eventlog/Operation/EventDescriptions/SpecificEventIDDescriptionHandler.cs) | [SpecificEventIDDescriptionHandler](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/EventDescriptions/SpecificEventIDDescriptionHandler.cs) |
| `/event/descriptions/eventLevel` | GET | EventLevelDescriptionHandler | [EventLevelDescriptionHandler](../../AccelByte.Sdk/Api/Eventlog/Operation/EventDescriptions/EventLevelDescriptionHandler.cs) | [EventLevelDescriptionHandler](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/EventDescriptions/EventLevelDescriptionHandler.cs) |
| `/event/descriptions/eventLevel/listByEventLevels` | GET | SpecificEventLevelDescriptionHandler | [SpecificEventLevelDescriptionHandler](../../AccelByte.Sdk/Api/Eventlog/Operation/EventDescriptions/SpecificEventLevelDescriptionHandler.cs) | [SpecificEventLevelDescriptionHandler](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/EventDescriptions/SpecificEventLevelDescriptionHandler.cs) |
| `/event/descriptions/eventType` | GET | EventTypeDescriptionHandler | [EventTypeDescriptionHandler](../../AccelByte.Sdk/Api/Eventlog/Operation/EventDescriptions/EventTypeDescriptionHandler.cs) | [EventTypeDescriptionHandler](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/EventDescriptions/EventTypeDescriptionHandler.cs) |
| `/event/descriptions/eventType/listByEventTypes` | GET | SpecificEventTypeDescriptionHandler | [SpecificEventTypeDescriptionHandler](../../AccelByte.Sdk/Api/Eventlog/Operation/EventDescriptions/SpecificEventTypeDescriptionHandler.cs) | [SpecificEventTypeDescriptionHandler](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/EventDescriptions/SpecificEventTypeDescriptionHandler.cs) |
| `/event/descriptions/ux` | GET | UXNameDescriptionHandler | [UXNameDescriptionHandler](../../AccelByte.Sdk/Api/Eventlog/Operation/EventDescriptions/UXNameDescriptionHandler.cs) | [UXNameDescriptionHandler](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/EventDescriptions/UXNameDescriptionHandler.cs) |
| `/event/descriptions/ux/listByUx` | GET | SpecificUXDescriptionHandler | [SpecificUXDescriptionHandler](../../AccelByte.Sdk/Api/Eventlog/Operation/EventDescriptions/SpecificUXDescriptionHandler.cs) | [SpecificUXDescriptionHandler](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/EventDescriptions/SpecificUXDescriptionHandler.cs) |

### Event Wrapper:  [Event](../../AccelByte.Sdk/Api/Eventlog/Wrapper/Event.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/event/namespaces/{namespace}` | GET | GetEventByNamespaceHandler | [GetEventByNamespaceHandler](../../AccelByte.Sdk/Api/Eventlog/Operation/Event/GetEventByNamespaceHandler.cs) | [GetEventByNamespaceHandler](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/Event/GetEventByNamespaceHandler.cs) |
| `/event/namespaces/{namespace}` | POST | PostEventHandler | [PostEventHandler](../../AccelByte.Sdk/Api/Eventlog/Operation/Event/PostEventHandler.cs) | [PostEventHandler](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/Event/PostEventHandler.cs) |
| `/event/namespaces/{namespace}/eventId/{eventId}` | GET | GetEventByEventIDHandler | [GetEventByEventIDHandler](../../AccelByte.Sdk/Api/Eventlog/Operation/Event/GetEventByEventIDHandler.cs) | [GetEventByEventIDHandler](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/Event/GetEventByEventIDHandler.cs) |
| `/event/namespaces/{namespace}/eventType/{eventType}` | GET | GetEventByEventTypeHandler | [GetEventByEventTypeHandler](../../AccelByte.Sdk/Api/Eventlog/Operation/Event/GetEventByEventTypeHandler.cs) | [GetEventByEventTypeHandler](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/Event/GetEventByEventTypeHandler.cs) |
| `/event/namespaces/{namespace}/eventType/{eventType}/eventId/{eventId}` | GET | GetEventByEventTypeAndEventIDHandler | [GetEventByEventTypeAndEventIDHandler](../../AccelByte.Sdk/Api/Eventlog/Operation/Event/GetEventByEventTypeAndEventIDHandler.cs) | [GetEventByEventTypeAndEventIDHandler](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/Event/GetEventByEventTypeAndEventIDHandler.cs) |
| `/event/namespaces/{namespace}/users/{userId}` | GET | GetEventByUserIDHandler | [GetEventByUserIDHandler](../../AccelByte.Sdk/Api/Eventlog/Operation/Event/GetEventByUserIDHandler.cs) | [GetEventByUserIDHandler](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/Event/GetEventByUserIDHandler.cs) |
| `/event/namespaces/{namespace}/users/{userId}/eventId/{eventId}` | GET | GetEventByUserIDAndEventIDHandler | [GetEventByUserIDAndEventIDHandler](../../AccelByte.Sdk/Api/Eventlog/Operation/Event/GetEventByUserIDAndEventIDHandler.cs) | [GetEventByUserIDAndEventIDHandler](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/Event/GetEventByUserIDAndEventIDHandler.cs) |
| `/event/namespaces/{namespace}/users/{userId}/eventType/{eventType}` | GET | GetEventByUserIDAndEventTypeHandler | [GetEventByUserIDAndEventTypeHandler](../../AccelByte.Sdk/Api/Eventlog/Operation/Event/GetEventByUserIDAndEventTypeHandler.cs) | [GetEventByUserIDAndEventTypeHandler](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/Event/GetEventByUserIDAndEventTypeHandler.cs) |
| `/event/namespaces/{namespace}/users/{userId}/eventType/{eventType}/eventId/{eventId}` | GET | GetEventByUserEventIDAndEventTypeHandler | [GetEventByUserEventIDAndEventTypeHandler](../../AccelByte.Sdk/Api/Eventlog/Operation/Event/GetEventByUserEventIDAndEventTypeHandler.cs) | [GetEventByUserEventIDAndEventTypeHandler](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/Event/GetEventByUserEventIDAndEventTypeHandler.cs) |

### User Information Wrapper:  [UserInformation](../../AccelByte.Sdk/Api/Eventlog/Wrapper/UserInformation.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/event/namespaces/{namespace}/users/{userId}/activities` | GET | GetUserActivitiesHandler | [GetUserActivitiesHandler](../../AccelByte.Sdk/Api/Eventlog/Operation/UserInformation/GetUserActivitiesHandler.cs) | [GetUserActivitiesHandler](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/UserInformation/GetUserActivitiesHandler.cs) |
| `/event/namespaces/{namespace}/users/{userId}/activities` | DELETE | DeleteUserActivitiesHandler | [DeleteUserActivitiesHandler](../../AccelByte.Sdk/Api/Eventlog/Operation/UserInformation/DeleteUserActivitiesHandler.cs) | [DeleteUserActivitiesHandler](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/UserInformation/DeleteUserActivitiesHandler.cs) |
| `/event/namespaces/{namespace}/users/{userId}/lastActivityTime` | GET | LastUserActivityTimeHandler | [LastUserActivityTimeHandler](../../AccelByte.Sdk/Api/Eventlog/Operation/UserInformation/LastUserActivityTimeHandler.cs) | [LastUserActivityTimeHandler](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/UserInformation/LastUserActivityTimeHandler.cs) |

### Event Registry Wrapper:  [EventRegistry](../../AccelByte.Sdk/Api/Eventlog/Wrapper/EventRegistry.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/event/registry/eventIds` | GET | GetRegisteredEventsHandler | [GetRegisteredEventsHandler](../../AccelByte.Sdk/Api/Eventlog/Operation/EventRegistry/GetRegisteredEventsHandler.cs) | [GetRegisteredEventsHandler](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/EventRegistry/GetRegisteredEventsHandler.cs) |
| `/event/registry/eventIds` | POST | RegisterEventHandler | [RegisterEventHandler](../../AccelByte.Sdk/Api/Eventlog/Operation/EventRegistry/RegisterEventHandler.cs) | [RegisterEventHandler](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/EventRegistry/RegisterEventHandler.cs) |
| `/event/registry/eventIds/{eventId}` | GET | GetRegisteredEventIDHandler | [GetRegisteredEventIDHandler](../../AccelByte.Sdk/Api/Eventlog/Operation/EventRegistry/GetRegisteredEventIDHandler.cs) | [GetRegisteredEventIDHandler](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/EventRegistry/GetRegisteredEventIDHandler.cs) |
| `/event/registry/eventIds/{eventId}` | POST | UpdateEventRegistryHandler | [UpdateEventRegistryHandler](../../AccelByte.Sdk/Api/Eventlog/Operation/EventRegistry/UpdateEventRegistryHandler.cs) | [UpdateEventRegistryHandler](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/EventRegistry/UpdateEventRegistryHandler.cs) |
| `/event/registry/eventIds/{eventId}` | DELETE | UnregisterEventIDHandler | [UnregisterEventIDHandler](../../AccelByte.Sdk/Api/Eventlog/Operation/EventRegistry/UnregisterEventIDHandler.cs) | [UnregisterEventIDHandler](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/EventRegistry/UnregisterEventIDHandler.cs) |
| `/event/registry/eventTypes/{eventType}` | GET | GetRegisteredEventsByEventTypeHandler | [GetRegisteredEventsByEventTypeHandler](../../AccelByte.Sdk/Api/Eventlog/Operation/EventRegistry/GetRegisteredEventsByEventTypeHandler.cs) | [GetRegisteredEventsByEventTypeHandler](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/EventRegistry/GetRegisteredEventsByEventTypeHandler.cs) |

### Event V2 Wrapper:  [EventV2](../../AccelByte.Sdk/Api/Eventlog/Wrapper/EventV2.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/event/v2/admin/namespaces/{namespace}/query` | POST | QueryEventStreamHandler | [QueryEventStreamHandler](../../AccelByte.Sdk/Api/Eventlog/Operation/EventV2/QueryEventStreamHandler.cs) | [QueryEventStreamHandler](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/EventV2/QueryEventStreamHandler.cs) |
| `/event/v2/admin/namespaces/{namespace}/users/{userId}/event` | GET | GetEventSpecificUserV2Handler | [GetEventSpecificUserV2Handler](../../AccelByte.Sdk/Api/Eventlog/Operation/EventV2/GetEventSpecificUserV2Handler.cs) | [GetEventSpecificUserV2Handler](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/EventV2/GetEventSpecificUserV2Handler.cs) |
| `/event/v2/public/namespaces/{namespace}/users/{userId}/edithistory` | GET | GetPublicEditHistory | [GetPublicEditHistory](../../AccelByte.Sdk/Api/Eventlog/Operation/EventV2/GetPublicEditHistory.cs) | [GetPublicEditHistory](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/EventV2/GetPublicEditHistory.cs) |
| `/event/v2/public/namespaces/{namespace}/users/{userId}/event` | GET | GetUserEventsV2Public | [GetUserEventsV2Public](../../AccelByte.Sdk/Api/Eventlog/Operation/EventV2/GetUserEventsV2Public.cs) | [GetUserEventsV2Public](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/EventV2/GetUserEventsV2Public.cs) |


&nbsp;  

## Models

| Model | Class |
|---|---|
| `models.AgentType` | [ModelsAgentType](../../AccelByte.Sdk/Api/Eventlog/Model/ModelsAgentType.cs) |
| `models.Event` | [ModelsEvent](../../AccelByte.Sdk/Api/Eventlog/Model/ModelsEvent.cs) |
| `models.EventID` | [ModelsEventID](../../AccelByte.Sdk/Api/Eventlog/Model/ModelsEventID.cs) |
| `models.EventLevel` | [ModelsEventLevel](../../AccelByte.Sdk/Api/Eventlog/Model/ModelsEventLevel.cs) |
| `models.EventRegistry` | [ModelsEventRegistry](../../AccelByte.Sdk/Api/Eventlog/Model/ModelsEventRegistry.cs) |
| `models.EventResponse` | [ModelsEventResponse](../../AccelByte.Sdk/Api/Eventlog/Model/ModelsEventResponse.cs) |
| `models.EventResponseV2` | [ModelsEventResponseV2](../../AccelByte.Sdk/Api/Eventlog/Model/ModelsEventResponseV2.cs) |
| `models.EventType` | [ModelsEventType](../../AccelByte.Sdk/Api/Eventlog/Model/ModelsEventType.cs) |
| `models.EventV2` | [ModelsEventV2](../../AccelByte.Sdk/Api/Eventlog/Model/ModelsEventV2.cs) |
| `models.GenericQueryPayload` | [ModelsGenericQueryPayload](../../AccelByte.Sdk/Api/Eventlog/Model/ModelsGenericQueryPayload.cs) |
| `models.MultipleAgentType` | [ModelsMultipleAgentType](../../AccelByte.Sdk/Api/Eventlog/Model/ModelsMultipleAgentType.cs) |
| `models.MultipleEventID` | [ModelsMultipleEventID](../../AccelByte.Sdk/Api/Eventlog/Model/ModelsMultipleEventID.cs) |
| `models.MultipleEventLevel` | [ModelsMultipleEventLevel](../../AccelByte.Sdk/Api/Eventlog/Model/ModelsMultipleEventLevel.cs) |
| `models.MultipleEventType` | [ModelsMultipleEventType](../../AccelByte.Sdk/Api/Eventlog/Model/ModelsMultipleEventType.cs) |
| `models.MultipleUX` | [ModelsMultipleUX](../../AccelByte.Sdk/Api/Eventlog/Model/ModelsMultipleUX.cs) |
| `models.Pagination` | [ModelsPagination](../../AccelByte.Sdk/Api/Eventlog/Model/ModelsPagination.cs) |
| `models.Paging` | [ModelsPaging](../../AccelByte.Sdk/Api/Eventlog/Model/ModelsPaging.cs) |
| `models.UX` | [ModelsUX](../../AccelByte.Sdk/Api/Eventlog/Model/ModelsUX.cs) |
| `models.UserLastActivity` | [ModelsUserLastActivity](../../AccelByte.Sdk/Api/Eventlog/Model/ModelsUserLastActivity.cs) |
