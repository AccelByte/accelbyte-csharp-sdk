// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Basic.Operation
{
    /// <summary>
    /// unBanUsers
    ///
    /// Unban user.
    /// Other detail info:
    /// 
    ///   * Required permission : resource= "ADMIN:NAMESPACE:{namespace}:ACTION" , action=4 (UPDATE)
    /// </summary>
    public class UnBanUsers : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UnBanUsersBuilder Builder { get => new UnBanUsersBuilder(); }

        public class UnBanUsersBuilder
            : OperationBuilder<UnBanUsersBuilder>
        {


            public Model.ADTOForUnbanUserAPICall? Body { get; set; }




            internal UnBanUsersBuilder() { }



            public UnBanUsersBuilder SetBody(Model.ADTOForUnbanUserAPICall _body)
            {
                Body = _body;
                return this;
            }




            public UnBanUsers Build(
                string namespace_
            )
            {
                UnBanUsers op = new UnBanUsers(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private UnBanUsers(UnBanUsersBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UnBanUsers(
            string namespace_,
            Model.ADTOForUnbanUserAPICall body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/basic/v1/admin/namespaces/{namespace}/actions/unban";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return;
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}