// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class CatalogChanges
    {
        private readonly AccelByteSDK _sdk;

        public CatalogChanges(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public QueryChanges.QueryChangesBuilder QueryChangesOp
        {
            get { return Operation.QueryChanges.Builder.SetWrapperObject(this); }
        }
        public PublishAll.PublishAllBuilder PublishAllOp
        {
            get { return Operation.PublishAll.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public List<Model.CatalogChangePagingSlicedResult>? QueryChanges(QueryChanges input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.StoreInfo? PublishAll(PublishAll input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class CatalogChanges_OperationExtensions
    {
        public static List<Model.CatalogChangePagingSlicedResult>? Execute(
            this QueryChanges.QueryChangesBuilder builder,
            string namespace_,
            string storeId
        )
        {
            QueryChanges op = builder.Build(
                namespace_,
                storeId
            );

            return ((CatalogChanges)builder.WrapperObject!).QueryChanges(op);
        }

        public static Model.StoreInfo? Execute(
            this PublishAll.PublishAllBuilder builder,
            string namespace_,
            string storeId
        )
        {
            PublishAll op = builder.Build(
                namespace_,
                storeId
            );

            return ((CatalogChanges)builder.WrapperObject!).PublishAll(op);
        }

    }
}