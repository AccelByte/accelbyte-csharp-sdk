// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

namespace AccelByte.Sdk.Core
{
    public abstract class OperationBuilder<T> where T : OperationBuilder<T>
    {
        internal object? WrapperObject { get; set; } = null;

        protected string PreferredSecurityMethod { get; set; } = String.Empty;

        public T SetPreferredSecurityMethod(string securityMethod)
        {
            PreferredSecurityMethod = securityMethod;
            return (T)this;
        }

        public T SetWrapperObject(object wrapperObject)
        {
            WrapperObject = wrapperObject;
            return (T)this;
        }

        public TWrapper GetWrapperObject<TWrapper>()
        {
            if (WrapperObject == null)
                throw new Exception($"No wrapper object assigned.");
            return (TWrapper)WrapperObject;
        }
    }
}