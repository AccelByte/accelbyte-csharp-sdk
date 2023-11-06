// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Session.Model;
using AccelByte.Sdk.Api.Session.Operation;
using AccelByte.Sdk.Api.Session.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class SessionCertificate_OpExts
    {
        public static Session.Model.ModelsPlatformCredentials? Execute(
            this HandleUploadXboxPFXCertificate.HandleUploadXboxPFXCertificateBuilder builder,
            Stream file,
            string password,
            string certname,
            string namespace_
        )
        {
            HandleUploadXboxPFXCertificate op = builder.Build(
                file,
                password,
                certname,
                namespace_
            );

            return ((Session.Wrapper.Certificate)builder.WrapperObject!).HandleUploadXboxPFXCertificate(op);
        }
    }
}