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
    /// JoinGroupV1
    ///
    /// Required valid user authentication
    /// 
    /// This endpoint is used to join as group member
    /// 
    /// Join to the group. This endpoint will check the the the type of the group based on the groupID.
    /// 
    /// Additional Information:
    /// 
    /// * User cannot join to the group with PRIVATE type
    /// * Joining PUBLIC group type will create join request and need approval from the privileged group member to accept the request to become the member
    /// * Joining OPEN group type will make this user become member of that group immediately
    /// 
    /// This endpoint will return status field to give information whether the user is JOINED or REQUESTED to join to the specific group
    /// 
    /// Action Code: 73403
    /// </summary>
    public class JoinGroupV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static JoinGroupV1Builder Builder { get => new JoinGroupV1Builder(); }

        public class JoinGroupV1Builder
            : OperationBuilder<JoinGroupV1Builder>
        {





            internal JoinGroupV1Builder() { }






            public JoinGroupV1 Build(
                string groupId,
                string namespace_
            )
            {
                JoinGroupV1 op = new JoinGroupV1(this,
                    groupId,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private JoinGroupV1(JoinGroupV1Builder builder,
            string groupId,
            string namespace_
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public JoinGroupV1(
            string groupId,
            string namespace_
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v1/public/namespaces/{namespace}/groups/{groupId}/join";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsJoinGroupResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsJoinGroupResponseV1>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsJoinGroupResponseV1>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsJoinGroupResponseV1>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}