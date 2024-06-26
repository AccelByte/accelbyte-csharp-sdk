// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Dsartifact.Model;
using AccelByte.Sdk.Api.Dsartifact.Operation;
using AccelByte.Sdk.Api.Dsartifact.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class DsartifactArtifactUploadProcessQueue_OpExts
    {
        public static Dsartifact.Model.ModelsListNodesIPAddress? Execute(
            this ListNodesIPAddress.ListNodesIPAddressBuilder builder
        )
        {
            ListNodesIPAddress op = builder.Build(
            );

            return ((Dsartifact.Wrapper.ArtifactUploadProcessQueue)builder.WrapperObject!).ListNodesIPAddress(op);
        }
        public static async Task<Dsartifact.Model.ModelsListNodesIPAddress?> ExecuteAsync(
            this ListNodesIPAddress.ListNodesIPAddressBuilder builder
        )
        {
            ListNodesIPAddress op = builder.Build(
            );

            return await ((Dsartifact.Wrapper.ArtifactUploadProcessQueue)builder.WrapperObject!).ListNodesIPAddressAsync(op);
        }
        public static void Execute(
            this DeleteNodeByID.DeleteNodeByIDBuilder builder,
            string nodeIP,
            string podName
        )
        {
            DeleteNodeByID op = builder.Build(
                nodeIP,
                podName
            );

            ((Dsartifact.Wrapper.ArtifactUploadProcessQueue)builder.WrapperObject!).DeleteNodeByID(op);
        }
        public static async Task ExecuteAsync(
            this DeleteNodeByID.DeleteNodeByIDBuilder builder,
            string nodeIP,
            string podName
        )
        {
            DeleteNodeByID op = builder.Build(
                nodeIP,
                podName
            );

            await ((Dsartifact.Wrapper.ArtifactUploadProcessQueue)builder.WrapperObject!).DeleteNodeByIDAsync(op);
        }
        public static Dsartifact.Model.ModelsListQueueResponse? Execute(
            this ListQueue.ListQueueBuilder builder,
            string nodeIP
        )
        {
            ListQueue op = builder.Build(
                nodeIP
            );

            return ((Dsartifact.Wrapper.ArtifactUploadProcessQueue)builder.WrapperObject!).ListQueue(op);
        }
        public static async Task<Dsartifact.Model.ModelsListQueueResponse?> ExecuteAsync(
            this ListQueue.ListQueueBuilder builder,
            string nodeIP
        )
        {
            ListQueue op = builder.Build(
                nodeIP
            );

            return await ((Dsartifact.Wrapper.ArtifactUploadProcessQueue)builder.WrapperObject!).ListQueueAsync(op);
        }
        public static Dsartifact.Model.ModelsQueue? Execute(
            this GetActiveQueue.GetActiveQueueBuilder builder,
            string nodeIP
        )
        {
            GetActiveQueue op = builder.Build(
                nodeIP
            );

            return ((Dsartifact.Wrapper.ArtifactUploadProcessQueue)builder.WrapperObject!).GetActiveQueue(op);
        }
        public static async Task<Dsartifact.Model.ModelsQueue?> ExecuteAsync(
            this GetActiveQueue.GetActiveQueueBuilder builder,
            string nodeIP
        )
        {
            GetActiveQueue op = builder.Build(
                nodeIP
            );

            return await ((Dsartifact.Wrapper.ArtifactUploadProcessQueue)builder.WrapperObject!).GetActiveQueueAsync(op);
        }
        public static void Execute(
            this SetActiveQueue.SetActiveQueueBuilder builder,
            string nodeIP,
            string podName
        )
        {
            SetActiveQueue op = builder.Build(
                nodeIP,
                podName
            );

            ((Dsartifact.Wrapper.ArtifactUploadProcessQueue)builder.WrapperObject!).SetActiveQueue(op);
        }
        public static async Task ExecuteAsync(
            this SetActiveQueue.SetActiveQueueBuilder builder,
            string nodeIP,
            string podName
        )
        {
            SetActiveQueue op = builder.Build(
                nodeIP,
                podName
            );

            await ((Dsartifact.Wrapper.ArtifactUploadProcessQueue)builder.WrapperObject!).SetActiveQueueAsync(op);
        }
        public static void Execute(
            this DeleteActiveQueue.DeleteActiveQueueBuilder builder,
            string nodeIP
        )
        {
            DeleteActiveQueue op = builder.Build(
                nodeIP
            );

            ((Dsartifact.Wrapper.ArtifactUploadProcessQueue)builder.WrapperObject!).DeleteActiveQueue(op);
        }
        public static async Task ExecuteAsync(
            this DeleteActiveQueue.DeleteActiveQueueBuilder builder,
            string nodeIP
        )
        {
            DeleteActiveQueue op = builder.Build(
                nodeIP
            );

            await ((Dsartifact.Wrapper.ArtifactUploadProcessQueue)builder.WrapperObject!).DeleteActiveQueueAsync(op);
        }
        public static void Execute(
            this ReportFailedUpload.ReportFailedUploadBuilder builder,
            string nodeIP,
            string podName
        )
        {
            ReportFailedUpload op = builder.Build(
                nodeIP,
                podName
            );

            ((Dsartifact.Wrapper.ArtifactUploadProcessQueue)builder.WrapperObject!).ReportFailedUpload(op);
        }
        public static async Task ExecuteAsync(
            this ReportFailedUpload.ReportFailedUploadBuilder builder,
            string nodeIP,
            string podName
        )
        {
            ReportFailedUpload op = builder.Build(
                nodeIP,
                podName
            );

            await ((Dsartifact.Wrapper.ArtifactUploadProcessQueue)builder.WrapperObject!).ReportFailedUploadAsync(op);
        }
        public static void Execute(
            this DeleteQueue.DeleteQueueBuilder builder,
            string namespace_,
            string nodeIP,
            string podName
        )
        {
            DeleteQueue op = builder.Build(
                namespace_,
                nodeIP,
                podName
            );

            ((Dsartifact.Wrapper.ArtifactUploadProcessQueue)builder.WrapperObject!).DeleteQueue(op);
        }
        public static async Task ExecuteAsync(
            this DeleteQueue.DeleteQueueBuilder builder,
            string namespace_,
            string nodeIP,
            string podName
        )
        {
            DeleteQueue op = builder.Build(
                namespace_,
                nodeIP,
                podName
            );

            await ((Dsartifact.Wrapper.ArtifactUploadProcessQueue)builder.WrapperObject!).DeleteQueueAsync(op);
        }
        public static Dsartifact.Model.ModelsListAllQueueResponse? Execute(
            this ListAllActiveQueue.ListAllActiveQueueBuilder builder,
            string namespace_
        )
        {
            ListAllActiveQueue op = builder.Build(
                namespace_
            );

            return ((Dsartifact.Wrapper.ArtifactUploadProcessQueue)builder.WrapperObject!).ListAllActiveQueue(op);
        }
        public static async Task<Dsartifact.Model.ModelsListAllQueueResponse?> ExecuteAsync(
            this ListAllActiveQueue.ListAllActiveQueueBuilder builder,
            string namespace_
        )
        {
            ListAllActiveQueue op = builder.Build(
                namespace_
            );

            return await ((Dsartifact.Wrapper.ArtifactUploadProcessQueue)builder.WrapperObject!).ListAllActiveQueueAsync(op);
        }
        public static Dsartifact.Model.ModelsListAllQueueResponse? Execute(
            this ListAllQueue.ListAllQueueBuilder builder,
            string namespace_
        )
        {
            ListAllQueue op = builder.Build(
                namespace_
            );

            return ((Dsartifact.Wrapper.ArtifactUploadProcessQueue)builder.WrapperObject!).ListAllQueue(op);
        }
        public static async Task<Dsartifact.Model.ModelsListAllQueueResponse?> ExecuteAsync(
            this ListAllQueue.ListAllQueueBuilder builder,
            string namespace_
        )
        {
            ListAllQueue op = builder.Build(
                namespace_
            );

            return await ((Dsartifact.Wrapper.ArtifactUploadProcessQueue)builder.WrapperObject!).ListAllQueueAsync(op);
        }
    }
}