// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Api.Lobby.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Lobby.Wrapper
{
    public class Party
    {
        private readonly AccelByteSDK _sdk;

        public Party(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminGetPartyDataV1.AdminGetPartyDataV1Builder AdminGetPartyDataV1Op
        {
            get { return Operation.AdminGetPartyDataV1.Builder.SetWrapperObject(this); }
        }
        public AdminGetUserPartyV1.AdminGetUserPartyV1Builder AdminGetUserPartyV1Op
        {
            get { return Operation.AdminGetUserPartyV1.Builder.SetWrapperObject(this); }
        }
        public PublicGetPartyDataV1.PublicGetPartyDataV1Builder PublicGetPartyDataV1Op
        {
            get { return Operation.PublicGetPartyDataV1.Builder.SetWrapperObject(this); }
        }
        public PublicUpdatePartyAttributesV1.PublicUpdatePartyAttributesV1Builder PublicUpdatePartyAttributesV1Op
        {
            get { return Operation.PublicUpdatePartyAttributesV1.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.ModelsPartyData? AdminGetPartyDataV1(AdminGetPartyDataV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPartyData? AdminGetUserPartyV1(AdminGetUserPartyV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPartyData? PublicGetPartyDataV1(PublicGetPartyDataV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPartyData? PublicUpdatePartyAttributesV1(PublicUpdatePartyAttributesV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class Party_OperationExtensions
    {
        public static Model.ModelsPartyData? Execute(
            this AdminGetPartyDataV1.AdminGetPartyDataV1Builder builder,
            string namespace_,
            string partyId
        )
        {
            AdminGetPartyDataV1 op = builder.Build(
                namespace_,
                partyId
            );

            return ((Party)builder.WrapperObject!).AdminGetPartyDataV1(op);
        }

        public static Model.ModelsPartyData? Execute(
            this AdminGetUserPartyV1.AdminGetUserPartyV1Builder builder,
            string namespace_,
            string userId
        )
        {
            AdminGetUserPartyV1 op = builder.Build(
                namespace_,
                userId
            );

            return ((Party)builder.WrapperObject!).AdminGetUserPartyV1(op);
        }

        public static Model.ModelsPartyData? Execute(
            this PublicGetPartyDataV1.PublicGetPartyDataV1Builder builder,
            string namespace_,
            string partyId
        )
        {
            PublicGetPartyDataV1 op = builder.Build(
                namespace_,
                partyId
            );

            return ((Party)builder.WrapperObject!).PublicGetPartyDataV1(op);
        }

        public static Model.ModelsPartyData? Execute(
            this PublicUpdatePartyAttributesV1.PublicUpdatePartyAttributesV1Builder builder,
            ModelsPartyPUTCustomAttributesRequest body,
            string namespace_,
            string partyId
        )
        {
            PublicUpdatePartyAttributesV1 op = builder.Build(
                body,
                namespace_,
                partyId
            );

            return ((Party)builder.WrapperObject!).PublicUpdatePartyAttributesV1(op);
        }

    }
}