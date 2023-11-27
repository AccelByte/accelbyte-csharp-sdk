// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class TradeAction
    {
        private readonly AccelByteSDK _sdk;

        public TradeAction(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public Commit.CommitBuilder CommitOp
        {
            get { return Operation.Commit.Builder.SetWrapperObject(this); }
        }
        public GetTradeHistoryByCriteria.GetTradeHistoryByCriteriaBuilder GetTradeHistoryByCriteriaOp
        {
            get { return Operation.GetTradeHistoryByCriteria.Builder.SetWrapperObject(this); }
        }
        public GetTradeHistoryByTransactionId.GetTradeHistoryByTransactionIdBuilder GetTradeHistoryByTransactionIdOp
        {
            get { return Operation.GetTradeHistoryByTransactionId.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.TradeChainActionHistoryInfo? Commit(Commit input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.TradeChainActionHistoryInfo<T1>? Commit<T1>(Commit input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void GetTradeHistoryByCriteria(GetTradeHistoryByCriteria input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void GetTradeHistoryByTransactionId(GetTradeHistoryByTransactionId input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}