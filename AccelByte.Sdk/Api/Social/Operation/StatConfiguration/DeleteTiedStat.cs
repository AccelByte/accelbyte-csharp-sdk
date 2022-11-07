// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// deleteTiedStat
    ///
    /// Deletes stat template.
    /// Other detail info:
    /// 
    ///   *  Required permission : resource="ADMIN:NAMESPACE:{namespace}:STAT", action=8 (DELETE)
    /// </summary>
    public class DeleteTiedStat : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteTiedStatBuilder Builder = new DeleteTiedStatBuilder();

        public class DeleteTiedStatBuilder
            : OperationBuilder<DeleteTiedStatBuilder>
        {





            internal DeleteTiedStatBuilder() { }






            public DeleteTiedStat Build(
                string namespace_,
                string statCode
            )
            {
                DeleteTiedStat op = new DeleteTiedStat(this,
                    namespace_,                    
                    statCode                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private DeleteTiedStat(DeleteTiedStatBuilder builder,
            string namespace_,
            string statCode
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["statCode"] = statCode;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteTiedStat(
            string namespace_,            
            string statCode            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["statCode"] = statCode;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v1/admin/namespaces/{namespace}/stats/{statCode}/tied";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] {  };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}