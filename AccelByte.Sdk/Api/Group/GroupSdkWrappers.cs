// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Group.Wrapper;
using AccelByte.Sdk.Api.Group.Operation;

namespace AccelByte.Sdk.Core
{
    public class GroupSdkWrappers
    {
        private AccelByteSDK _SdkObject;

        public Configuration Configuration
        {
            get
            {
                if (_Configuration == null)
                    _Configuration = new Configuration(_SdkObject);
                return _Configuration;
            }
        }
        private Configuration? _Configuration = null;

        public Group Group
        {
            get
            {
                if (_Group == null)
                    _Group = new Group(_SdkObject);
                return _Group;
            }
        }
        private Group? _Group = null;

        public GroupMember GroupMember
        {
            get
            {
                if (_GroupMember == null)
                    _GroupMember = new GroupMember(_SdkObject);
                return _GroupMember;
            }
        }
        private GroupMember? _GroupMember = null;

        public GroupRoles GroupRoles
        {
            get
            {
                if (_GroupRoles == null)
                    _GroupRoles = new GroupRoles(_SdkObject);
                return _GroupRoles;
            }
        }
        private GroupRoles? _GroupRoles = null;

        public MemberRequest MemberRequest
        {
            get
            {
                if (_MemberRequest == null)
                    _MemberRequest = new MemberRequest(_SdkObject);
                return _MemberRequest;
            }
        }
        private MemberRequest? _MemberRequest = null;

        internal GroupSdkWrappers(AccelByteSDK sdk)
        {
            _SdkObject = sdk;
        }
    }

    public partial class AccelByteSDK
    {
        public GroupSdkWrappers Group
        {
            get
            {
                if (_Group == null)
                    _Group = new GroupSdkWrappers(this);
                return _Group;
            }
        }
        private GroupSdkWrappers? _Group = null;
    }
}