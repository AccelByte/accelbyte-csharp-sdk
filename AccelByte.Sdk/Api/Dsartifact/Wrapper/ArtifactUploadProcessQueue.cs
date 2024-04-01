// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Dsartifact.Model;
using AccelByte.Sdk.Api.Dsartifact.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Dsartifact.Wrapper
{
    public class ArtifactUploadProcessQueue
    {
        private readonly AccelByteSDK _sdk;

        public ArtifactUploadProcessQueue(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public ListNodesIPAddress.ListNodesIPAddressBuilder ListNodesIPAddressOp
        {
            get { return Operation.ListNodesIPAddress.Builder.SetWrapperObject(this); }
        }
        public DeleteNodeByID.DeleteNodeByIDBuilder DeleteNodeByIDOp
        {
            get { return Operation.DeleteNodeByID.Builder.SetWrapperObject(this); }
        }
        public ListQueue.ListQueueBuilder ListQueueOp
        {
            get { return Operation.ListQueue.Builder.SetWrapperObject(this); }
        }
        public GetActiveQueue.GetActiveQueueBuilder GetActiveQueueOp
        {
            get { return Operation.GetActiveQueue.Builder.SetWrapperObject(this); }
        }
        public SetActiveQueue.SetActiveQueueBuilder SetActiveQueueOp
        {
            get { return Operation.SetActiveQueue.Builder.SetWrapperObject(this); }
        }
        public DeleteActiveQueue.DeleteActiveQueueBuilder DeleteActiveQueueOp
        {
            get { return Operation.DeleteActiveQueue.Builder.SetWrapperObject(this); }
        }
        public ReportFailedUpload.ReportFailedUploadBuilder ReportFailedUploadOp
        {
            get { return Operation.ReportFailedUpload.Builder.SetWrapperObject(this); }
        }
        public DeleteQueue.DeleteQueueBuilder DeleteQueueOp
        {
            get { return Operation.DeleteQueue.Builder.SetWrapperObject(this); }
        }
        public ListAllActiveQueue.ListAllActiveQueueBuilder ListAllActiveQueueOp
        {
            get { return Operation.ListAllActiveQueue.Builder.SetWrapperObject(this); }
        }
        public ListAllQueue.ListAllQueueBuilder ListAllQueueOp
        {
            get { return Operation.ListAllQueue.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.ModelsListNodesIPAddress? ListNodesIPAddress(ListNodesIPAddress input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsListNodesIPAddress?> ListNodesIPAddressAsync(ListNodesIPAddress input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteNodeByID(DeleteNodeByID input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteNodeByIDAsync(DeleteNodeByID input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsListQueueResponse? ListQueue(ListQueue input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsListQueueResponse?> ListQueueAsync(ListQueue input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsQueue? GetActiveQueue(GetActiveQueue input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsQueue?> GetActiveQueueAsync(GetActiveQueue input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void SetActiveQueue(SetActiveQueue input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task SetActiveQueueAsync(SetActiveQueue input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteActiveQueue(DeleteActiveQueue input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteActiveQueueAsync(DeleteActiveQueue input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void ReportFailedUpload(ReportFailedUpload input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task ReportFailedUploadAsync(ReportFailedUpload input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteQueue(DeleteQueue input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteQueueAsync(DeleteQueue input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsListAllQueueResponse? ListAllActiveQueue(ListAllActiveQueue input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsListAllQueueResponse?> ListAllActiveQueueAsync(ListAllActiveQueue input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsListAllQueueResponse? ListAllQueue(ListAllQueue input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsListAllQueueResponse?> ListAllQueueAsync(ListAllQueue input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}