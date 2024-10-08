// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class PlatformTradeAction_OpExts
    {
        public static Platform.Model.TradeChainActionHistoryInfo? Execute(
            this Commit.CommitBuilder builder,
            TradeChainedActionCommitRequest body,
            string namespace_
        )
        {
            Commit op = builder.Build(
                body,
                namespace_
            );

            return ((Platform.Wrapper.TradeAction)builder.WrapperObject!).Commit(op);
        }
        public static async Task<Platform.Model.TradeChainActionHistoryInfo?> ExecuteAsync(
            this Commit.CommitBuilder builder,
            TradeChainedActionCommitRequest body,
            string namespace_
        )
        {
            Commit op = builder.Build(
                body,
                namespace_
            );

            return await ((Platform.Wrapper.TradeAction)builder.WrapperObject!).CommitAsync(op);
        }

        public static Platform.Model.TradeChainActionHistoryInfo<T1>? Execute<T1>(
            this Commit.CommitBuilder builder,
            TradeChainedActionCommitRequest body,
            string namespace_
        )
        {
            Commit op = builder.Build(
                body,
                namespace_
            );

            return ((Platform.Wrapper.TradeAction)builder.WrapperObject!).Commit<T1>(op);
        }
        public static async Task<Platform.Model.TradeChainActionHistoryInfo<T1>?> ExecuteAsync<T1>(
            this Commit.CommitBuilder builder,
            TradeChainedActionCommitRequest body,
            string namespace_
        )
        {
            Commit op = builder.Build(
                body,
                namespace_
            );

            return await ((Platform.Wrapper.TradeAction)builder.WrapperObject!).CommitAsync<T1>(op);
        }
        public static Platform.Model.TradeActionPagingSlicedResult? Execute(
            this GetTradeHistoryByCriteria.GetTradeHistoryByCriteriaBuilder builder,
            string namespace_
        )
        {
            GetTradeHistoryByCriteria op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.TradeAction)builder.WrapperObject!).GetTradeHistoryByCriteria(op);
        }
        public static async Task<Platform.Model.TradeActionPagingSlicedResult?> ExecuteAsync(
            this GetTradeHistoryByCriteria.GetTradeHistoryByCriteriaBuilder builder,
            string namespace_
        )
        {
            GetTradeHistoryByCriteria op = builder.Build(
                namespace_
            );

            return await ((Platform.Wrapper.TradeAction)builder.WrapperObject!).GetTradeHistoryByCriteriaAsync(op);
        }
        public static Platform.Model.TradeChainActionHistoryInfo? Execute(
            this GetTradeHistoryByTransactionId.GetTradeHistoryByTransactionIdBuilder builder,
            string namespace_,
            string transactionId
        )
        {
            GetTradeHistoryByTransactionId op = builder.Build(
                namespace_,
                transactionId
            );

            return ((Platform.Wrapper.TradeAction)builder.WrapperObject!).GetTradeHistoryByTransactionId(op);
        }
        public static async Task<Platform.Model.TradeChainActionHistoryInfo?> ExecuteAsync(
            this GetTradeHistoryByTransactionId.GetTradeHistoryByTransactionIdBuilder builder,
            string namespace_,
            string transactionId
        )
        {
            GetTradeHistoryByTransactionId op = builder.Build(
                namespace_,
                transactionId
            );

            return await ((Platform.Wrapper.TradeAction)builder.WrapperObject!).GetTradeHistoryByTransactionIdAsync(op);
        }

        public static Platform.Model.TradeChainActionHistoryInfo<T1>? Execute<T1>(
            this GetTradeHistoryByTransactionId.GetTradeHistoryByTransactionIdBuilder builder,
            string namespace_,
            string transactionId
        )
        {
            GetTradeHistoryByTransactionId op = builder.Build(
                namespace_,
                transactionId
            );

            return ((Platform.Wrapper.TradeAction)builder.WrapperObject!).GetTradeHistoryByTransactionId<T1>(op);
        }
        public static async Task<Platform.Model.TradeChainActionHistoryInfo<T1>?> ExecuteAsync<T1>(
            this GetTradeHistoryByTransactionId.GetTradeHistoryByTransactionIdBuilder builder,
            string namespace_,
            string transactionId
        )
        {
            GetTradeHistoryByTransactionId op = builder.Build(
                namespace_,
                transactionId
            );

            return await ((Platform.Wrapper.TradeAction)builder.WrapperObject!).GetTradeHistoryByTransactionIdAsync<T1>(op);
        }
    }
}