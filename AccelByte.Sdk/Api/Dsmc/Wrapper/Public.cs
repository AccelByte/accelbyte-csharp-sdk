// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Api.Dsmc.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Dsmc.Wrapper
{
    public class Public
    {
        private readonly AccelByteSDK _sdk;

        public Public(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetDefaultProvider.GetDefaultProviderBuilder GetDefaultProviderOp
        {
            get { return Operation.GetDefaultProvider.Builder.SetWrapperObject(this); }
        }
        public ListProviders.ListProvidersBuilder ListProvidersOp
        {
            get { return Operation.ListProviders.Builder.SetWrapperObject(this); }
        }
        public ListProvidersByRegion.ListProvidersByRegionBuilder ListProvidersByRegionOp
        {
            get { return Operation.ListProvidersByRegion.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.ModelsDefaultProvider? GetDefaultProvider(GetDefaultProvider input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<string>? ListProviders(ListProviders input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDefaultProvider? ListProvidersByRegion(ListProvidersByRegion input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class Public_OperationExtensions
    {
        public static Model.ModelsDefaultProvider? Execute(
            this GetDefaultProvider.GetDefaultProviderBuilder builder
        )
        {
            GetDefaultProvider op = builder.Build(
            );

            return ((Public)builder.WrapperObject!).GetDefaultProvider(op);
        }

        public static List<string>? Execute(
            this ListProviders.ListProvidersBuilder builder
        )
        {
            ListProviders op = builder.Build(
            );

            return ((Public)builder.WrapperObject!).ListProviders(op);
        }

        public static Model.ModelsDefaultProvider? Execute(
            this ListProvidersByRegion.ListProvidersByRegionBuilder builder,
            string region
        )
        {
            ListProvidersByRegion op = builder.Build(
                region
            );

            return ((Public)builder.WrapperObject!).ListProvidersByRegion(op);
        }

    }
}