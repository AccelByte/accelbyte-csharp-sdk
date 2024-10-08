// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Core.Repository;
using AccelByte.Sdk.Core.Logging;

namespace AccelByte.Sdk.Core.Client
{
    public interface IHttpClient
    {
        HttpResponse SendRequest(Operation operation, String baseUrl);

        Task<HttpResponse> SendRequestAsync(Operation operation, String baseUrl);

        IHttpClient SetLogger(IHttpLogger logger);

        bool UploadBinaryData(string url, byte[] dataToUpload, string contentType);

        Task<bool> UploadBinaryDataAsync(string url, byte[] dataToUpload, string contentType);

        byte[] DownloadBinaryData(string url);

        Task<byte[]> DownloadBinaryDataAsync(string url);
    }
}