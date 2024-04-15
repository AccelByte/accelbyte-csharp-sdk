// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using AccelByte.Sdk.Api.Inventory.Wrapper;
using AccelByte.Sdk.Api.Inventory.Operation;

namespace AccelByte.Sdk.Core
{
    public class InventorySdkWrappers
    {
        private AccelByteSDK _SdkObject;

        public AdminChainingOperations AdminChainingOperations
        {
            get
            {
                if (_AdminChainingOperations == null)
                    _AdminChainingOperations = new AdminChainingOperations(_SdkObject);
                return _AdminChainingOperations;
            }
        }
        private AdminChainingOperations? _AdminChainingOperations = null;

        public AdminIntegrationConfigurations AdminIntegrationConfigurations
        {
            get
            {
                if (_AdminIntegrationConfigurations == null)
                    _AdminIntegrationConfigurations = new AdminIntegrationConfigurations(_SdkObject);
                return _AdminIntegrationConfigurations;
            }
        }
        private AdminIntegrationConfigurations? _AdminIntegrationConfigurations = null;

        public AdminInventories AdminInventories
        {
            get
            {
                if (_AdminInventories == null)
                    _AdminInventories = new AdminInventories(_SdkObject);
                return _AdminInventories;
            }
        }
        private AdminInventories? _AdminInventories = null;

        public AdminItems AdminItems
        {
            get
            {
                if (_AdminItems == null)
                    _AdminItems = new AdminItems(_SdkObject);
                return _AdminItems;
            }
        }
        private AdminItems? _AdminItems = null;

        public AdminInventoryConfigurations AdminInventoryConfigurations
        {
            get
            {
                if (_AdminInventoryConfigurations == null)
                    _AdminInventoryConfigurations = new AdminInventoryConfigurations(_SdkObject);
                return _AdminInventoryConfigurations;
            }
        }
        private AdminInventoryConfigurations? _AdminInventoryConfigurations = null;

        public AdminItemTypes AdminItemTypes
        {
            get
            {
                if (_AdminItemTypes == null)
                    _AdminItemTypes = new AdminItemTypes(_SdkObject);
                return _AdminItemTypes;
            }
        }
        private AdminItemTypes? _AdminItemTypes = null;

        public AdminTags AdminTags
        {
            get
            {
                if (_AdminTags == null)
                    _AdminTags = new AdminTags(_SdkObject);
                return _AdminTags;
            }
        }
        private AdminTags? _AdminTags = null;

        public PublicInventoryConfigurations PublicInventoryConfigurations
        {
            get
            {
                if (_PublicInventoryConfigurations == null)
                    _PublicInventoryConfigurations = new PublicInventoryConfigurations(_SdkObject);
                return _PublicInventoryConfigurations;
            }
        }
        private PublicInventoryConfigurations? _PublicInventoryConfigurations = null;

        public PublicItemTypes PublicItemTypes
        {
            get
            {
                if (_PublicItemTypes == null)
                    _PublicItemTypes = new PublicItemTypes(_SdkObject);
                return _PublicItemTypes;
            }
        }
        private PublicItemTypes? _PublicItemTypes = null;

        public PublicTags PublicTags
        {
            get
            {
                if (_PublicTags == null)
                    _PublicTags = new PublicTags(_SdkObject);
                return _PublicTags;
            }
        }
        private PublicTags? _PublicTags = null;

        public PublicInventories PublicInventories
        {
            get
            {
                if (_PublicInventories == null)
                    _PublicInventories = new PublicInventories(_SdkObject);
                return _PublicInventories;
            }
        }
        private PublicInventories? _PublicInventories = null;

        public PublicItems PublicItems
        {
            get
            {
                if (_PublicItems == null)
                    _PublicItems = new PublicItems(_SdkObject);
                return _PublicItems;
            }
        }
        private PublicItems? _PublicItems = null;

        internal InventorySdkWrappers(AccelByteSDK sdk)
        {
            _SdkObject = sdk;
        }
    }

    public partial class AccelByteSDK
    {
        public InventorySdkWrappers Inventory
        {
            get
            {
                if (_Inventory == null)
                    _Inventory = new InventorySdkWrappers(this);
                return _Inventory;
            }
        }
        private InventorySdkWrappers? _Inventory = null;
    }
}