// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Gdpr.Model;
using AccelByte.Sdk.Api.Gdpr.Operation;
using AccelByte.Sdk.Api.Gdpr.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class GdprDataRetrievalS2S_OpExts
    {
        public static Gdpr.Model.DtoListFinishedDataRequests? Execute(
            this S2SGetListFinishedPersonalDataRequest.S2SGetListFinishedPersonalDataRequestBuilder builder,
            string namespace_,
            string end,
            string start
        )
        {
            S2SGetListFinishedPersonalDataRequest op = builder.Build(
                namespace_,
                end,
                start
            );

            return ((Gdpr.Wrapper.DataRetrievalS2S)builder.WrapperObject!).S2SGetListFinishedPersonalDataRequest(op);
        }
        public static async Task<Gdpr.Model.DtoListFinishedDataRequests?> ExecuteAsync(
            this S2SGetListFinishedPersonalDataRequest.S2SGetListFinishedPersonalDataRequestBuilder builder,
            string namespace_,
            string end,
            string start
        )
        {
            S2SGetListFinishedPersonalDataRequest op = builder.Build(
                namespace_,
                end,
                start
            );

            return await ((Gdpr.Wrapper.DataRetrievalS2S)builder.WrapperObject!).S2SGetListFinishedPersonalDataRequestAsync(op);
        }
        public static Gdpr.Model.ModelsS2SDataRetrievalResponse? Execute(
            this S2SRequestDataRetrieval.S2SRequestDataRetrievalBuilder builder,
            string namespace_,
            string userId
        )
        {
            S2SRequestDataRetrieval op = builder.Build(
                namespace_,
                userId
            );

            return ((Gdpr.Wrapper.DataRetrievalS2S)builder.WrapperObject!).S2SRequestDataRetrieval(op);
        }
        public static async Task<Gdpr.Model.ModelsS2SDataRetrievalResponse?> ExecuteAsync(
            this S2SRequestDataRetrieval.S2SRequestDataRetrievalBuilder builder,
            string namespace_,
            string userId
        )
        {
            S2SRequestDataRetrieval op = builder.Build(
                namespace_,
                userId
            );

            return await ((Gdpr.Wrapper.DataRetrievalS2S)builder.WrapperObject!).S2SRequestDataRetrievalAsync(op);
        }
        public static Gdpr.Model.ModelsS2SUserDataURL? Execute(
            this S2SGeneratePersonalDataURL.S2SGeneratePersonalDataURLBuilder builder,
            string namespace_,
            string requestDate,
            string userId
        )
        {
            S2SGeneratePersonalDataURL op = builder.Build(
                namespace_,
                requestDate,
                userId
            );

            return ((Gdpr.Wrapper.DataRetrievalS2S)builder.WrapperObject!).S2SGeneratePersonalDataURL(op);
        }
        public static async Task<Gdpr.Model.ModelsS2SUserDataURL?> ExecuteAsync(
            this S2SGeneratePersonalDataURL.S2SGeneratePersonalDataURLBuilder builder,
            string namespace_,
            string requestDate,
            string userId
        )
        {
            S2SGeneratePersonalDataURL op = builder.Build(
                namespace_,
                requestDate,
                userId
            );

            return await ((Gdpr.Wrapper.DataRetrievalS2S)builder.WrapperObject!).S2SGeneratePersonalDataURLAsync(op);
        }
    }
}