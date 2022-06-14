// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccelByte.Sdk.Core.Pipeline
{
    public class OperationProcessPipeline
    {
        private IOperationProcessPipeline? First { get; set; } = null;

        private IOperationProcessPipeline? Last { get; set; } = null;

        public void AppendToChain(IOperationProcessPipeline handler)
        {
            if (First == null)
            {
                First = handler;
                Last = handler;
            }
            else if (Last == null)
            {
                IOperationProcessPipeline temp = First;
                while (temp.Next != null)
                    temp = temp.Next;
                Last = temp;

                Last.Next = handler;
                Last = handler;
            }
            else
            {
                Last.Next = handler;
                Last = handler;
            }
        }

        public void PrependToChain(IOperationProcessPipeline handler)
        {
            if (First == null)
            {
                First = handler;
                Last = handler;
            }
            else
            {
                handler.Next = First;
                First = handler;
            }
        }

        public Operation RunProcessPipeline(Operation op, AccelByteSDK sdk)
        {
            if (First == null)
                throw new Exception("No operation process handler in chain.");

            IOperationProcessPipeline handler = First;
            Operation resultOp = handler.Handle(op, sdk);
            while (handler.Next != null)
            {
                handler = handler.Next;
                resultOp = handler.Handle(resultOp, sdk);
            }

            return resultOp;
        }
    }
}