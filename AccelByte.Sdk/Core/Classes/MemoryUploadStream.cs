// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AccelByte.Sdk.Core
{
    public class MemoryUploadStream : MemoryStream, IUploadStream
    {
        public string FileName { get; set; } = String.Empty;

        public string MimeType { get; set; } = "application/octet-stream";

        public MemoryUploadStream()
            : base() { }

        public MemoryUploadStream(byte[] buffer)
            : base(buffer) { }

        public MemoryUploadStream(int capacity)
            : base(capacity) { }

        public MemoryUploadStream(byte[] buffer, bool writable)
            : base(buffer, writable) { }

        public MemoryUploadStream(byte[] buffer, int index, int count)
            : base(buffer, index, count) { }

        public MemoryUploadStream(byte[] buffer, int index, int count, bool writable)
            : base(buffer, index, count, writable) { }

        public MemoryUploadStream(byte[] buffer, int index, int count, bool writable, bool publiclyVisible)
            : base(buffer, index, count, writable, publiclyVisible) { }

        public static MemoryUploadStream FromStream(Stream stream, string fileName)
        {
            byte[] tempBytes;
            using (MemoryStream tempStream = new MemoryStream())
            {
                stream.CopyTo(tempStream);
                tempBytes = tempStream.ToArray();
            }

            return new MemoryUploadStream(tempBytes)
            {
                FileName = fileName
            };
        }

        public static MemoryUploadStream FromStream(Stream stream, string fileName, string mimeType)
        {
            byte[] tempBytes;
            using (MemoryStream tempStream = new MemoryStream())
            {
                stream.CopyTo(tempStream);
                tempBytes = tempStream.ToArray();
            }

            return new MemoryUploadStream(tempBytes)
            {
                FileName = fileName,
                MimeType = mimeType
            };
        }
    }
}