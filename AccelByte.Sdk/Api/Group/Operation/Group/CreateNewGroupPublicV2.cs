// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Group.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Group.Operation
{
    /// <summary>
    /// createNewGroupPublicV2
    ///
    /// Required valid user authentication
    /// 
    /// This endpoint is used to create new group
    /// 
    /// There are some fields that needs to be fulfilled
    /// 
    /// * **groupDescription**: the description of the group (optional)
    /// * **groupIcon**: group icon URL link (optional)
    /// * **groupName**: name of the group
    /// * **groupRegion**: region of the group
    /// * **groupRules**: rules for specific group. It consists of groupCustomRule that can be used to save custom rule, and groupPredefinedRules that has similar usage with configuration, but this rule only works in specific group
    /// * **allowedAction**: available action in group service. It consist of joinGroup and inviteGroup
    /// * **ruleAttribute**: attribute of the player that needs to be checked
    /// * **ruleCriteria**: criteria of the value. The value will be in enum of EQUAL, MINIMUM, MAXIMUM
    /// * **ruleValue**: value that needs to be checked
    /// * **customAttributes**: additional custom group attributes (optional)
    /// 
    /// Action Code: 73304
    /// </summary>
    public class CreateNewGroupPublicV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateNewGroupPublicV2Builder Builder { get => new CreateNewGroupPublicV2Builder(); }

        public class CreateNewGroupPublicV2Builder
            : OperationBuilder<CreateNewGroupPublicV2Builder>
        {





            internal CreateNewGroupPublicV2Builder() { }






            public CreateNewGroupPublicV2 Build(
                ModelsPublicCreateNewGroupRequestV1 body,
                string namespace_
            )
            {
                CreateNewGroupPublicV2 op = new CreateNewGroupPublicV2(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private CreateNewGroupPublicV2(CreateNewGroupPublicV2Builder builder,
            ModelsPublicCreateNewGroupRequestV1 body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateNewGroupPublicV2(
            string namespace_,
            Model.ModelsPublicCreateNewGroupRequestV1 body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v2/public/namespaces/{namespace}/groups";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsGroupResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsGroupResponseV1>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsGroupResponseV1>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGroupResponseV1>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }

        public Model.ModelsGroupResponseV1<T1>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGroupResponseV1<T1>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGroupResponseV1<T1>>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);
            throw new HttpResponseException(code, payloadString);
        }
    }

}