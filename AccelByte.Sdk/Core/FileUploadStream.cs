using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AccelByte.Sdk.Core
{
    public class FileUploadStream : FileStream
    {
        public FileUploadStream(string path, FileMode mode)
            : base(path, mode)
        {
            FileName = Path.GetFileName(path);

        }

        public FileUploadStream(string path, FileStreamOptions options)
            : base(path, options)
        {
            FileName = Path.GetFileName(path);

        }

        public FileUploadStream(string path, FileMode mode, FileAccess access)
            : base(path, mode, access)
        {
            FileName = Path.GetFileName(path);
        }

        public FileUploadStream(string path, FileMode mode, FileAccess access, FileShare share)
            : base(path, mode, access, share)
        {
            FileName = Path.GetFileName(path);

        }

        public FileUploadStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize)
            : base(path, mode, access, share, bufferSize)
        {
            FileName = Path.GetFileName(path);

        }

        public FileUploadStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool useAsync)
            : base(path, mode, access, share, bufferSize, useAsync)
        {
            FileName = Path.GetFileName(path);

        }

        public FileUploadStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options)
            : base(path, mode, access, share, bufferSize, options)
        {
            FileName = Path.GetFileName(path);
        }

        public string FileName { get; set; } = String.Empty;

        public string MimeType { get; set; } = "application/octet-stream";
    }
}