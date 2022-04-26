// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Basic.Operation
{
    /// <summary>
    /// addCountryGroup
    ///
    /// Add a country groups
    /// Country code must follow ISO3166-1 alpha-2.
    /// Other detail info:
    /// 
    ///   * Required permission : resource = "ADMIN:NAMESPACE:{namespace}:MISC" , action=1 (CREATE)
    ///   *  Action code : 11201
    ///   *  Returns : newly created country group
    /// </summary>
    public class AddCountryGroup : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AddCountryGroupBuilder Builder = new AddCountryGroupBuilder();

        public class AddCountryGroupBuilder
            : OperationBuilder<AddCountryGroupBuilder>
        {
            
            public Model.AddCountryGroupRequest? Body { get; set; }
            
            internal AddCountryGroupBuilder() { }



            public AddCountryGroupBuilder SetBody(Model.AddCountryGroupRequest _body)
            {
                Body = _body;
                return this;
            }




            public AddCountryGroup Build(
                string namespace_
            )
            {
                AddCountryGroup op = new AddCountryGroup(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AddCountryGroup(AddCountryGroupBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AddCountryGroup(
            string namespace_,            
            Model.AddCountryGroupRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/basic/v1/admin/namespaces/{namespace}/misc/countrygroups";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.AddCountryGroupResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.AddCountryGroupResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.AddCountryGroupResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}