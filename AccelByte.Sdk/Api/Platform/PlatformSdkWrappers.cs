// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Core
{
    public class PlatformSdkWrappers
    {
        private AccelByteSDK _SdkObject;

        public FulfillmentScript FulfillmentScript
        {
            get
            {
                if (_FulfillmentScript == null)
                    _FulfillmentScript = new FulfillmentScript(_SdkObject);
                return _FulfillmentScript;
            }
        }
        private FulfillmentScript? _FulfillmentScript = null;

        public Campaign Campaign
        {
            get
            {
                if (_Campaign == null)
                    _Campaign = new Campaign(_SdkObject);
                return _Campaign;
            }
        }
        private Campaign? _Campaign = null;

        public Category Category
        {
            get
            {
                if (_Category == null)
                    _Category = new Category(_SdkObject);
                return _Category;
            }
        }
        private Category? _Category = null;

        public Currency Currency
        {
            get
            {
                if (_Currency == null)
                    _Currency = new Currency(_SdkObject);
                return _Currency;
            }
        }
        private Currency? _Currency = null;

        public DLC DLC
        {
            get
            {
                if (_DLC == null)
                    _DLC = new DLC(_SdkObject);
                return _DLC;
            }
        }
        private DLC? _DLC = null;

        public Entitlement Entitlement
        {
            get
            {
                if (_Entitlement == null)
                    _Entitlement = new Entitlement(_SdkObject);
                return _Entitlement;
            }
        }
        private Entitlement? _Entitlement = null;

        public Fulfillment Fulfillment
        {
            get
            {
                if (_Fulfillment == null)
                    _Fulfillment = new Fulfillment(_SdkObject);
                return _Fulfillment;
            }
        }
        private Fulfillment? _Fulfillment = null;

        public IAP IAP
        {
            get
            {
                if (_IAP == null)
                    _IAP = new IAP(_SdkObject);
                return _IAP;
            }
        }
        private IAP? _IAP = null;

        public Item Item
        {
            get
            {
                if (_Item == null)
                    _Item = new Item(_SdkObject);
                return _Item;
            }
        }
        private Item? _Item = null;

        public KeyGroup KeyGroup
        {
            get
            {
                if (_KeyGroup == null)
                    _KeyGroup = new KeyGroup(_SdkObject);
                return _KeyGroup;
            }
        }
        private KeyGroup? _KeyGroup = null;

        public Order Order
        {
            get
            {
                if (_Order == null)
                    _Order = new Order(_SdkObject);
                return _Order;
            }
        }
        private Order? _Order = null;

        public PaymentCallbackConfig PaymentCallbackConfig
        {
            get
            {
                if (_PaymentCallbackConfig == null)
                    _PaymentCallbackConfig = new PaymentCallbackConfig(_SdkObject);
                return _PaymentCallbackConfig;
            }
        }
        private PaymentCallbackConfig? _PaymentCallbackConfig = null;

        public Payment Payment
        {
            get
            {
                if (_Payment == null)
                    _Payment = new Payment(_SdkObject);
                return _Payment;
            }
        }
        private Payment? _Payment = null;

        public PaymentDedicated PaymentDedicated
        {
            get
            {
                if (_PaymentDedicated == null)
                    _PaymentDedicated = new PaymentDedicated(_SdkObject);
                return _PaymentDedicated;
            }
        }
        private PaymentDedicated? _PaymentDedicated = null;

        public Reward Reward
        {
            get
            {
                if (_Reward == null)
                    _Reward = new Reward(_SdkObject);
                return _Reward;
            }
        }
        private Reward? _Reward = null;

        public Store Store
        {
            get
            {
                if (_Store == null)
                    _Store = new Store(_SdkObject);
                return _Store;
            }
        }
        private Store? _Store = null;

        public CatalogChanges CatalogChanges
        {
            get
            {
                if (_CatalogChanges == null)
                    _CatalogChanges = new CatalogChanges(_SdkObject);
                return _CatalogChanges;
            }
        }
        private CatalogChanges? _CatalogChanges = null;

        public Subscription Subscription
        {
            get
            {
                if (_Subscription == null)
                    _Subscription = new Subscription(_SdkObject);
                return _Subscription;
            }
        }
        private Subscription? _Subscription = null;

        public Ticket Ticket
        {
            get
            {
                if (_Ticket == null)
                    _Ticket = new Ticket(_SdkObject);
                return _Ticket;
            }
        }
        private Ticket? _Ticket = null;

        public Anonymization Anonymization
        {
            get
            {
                if (_Anonymization == null)
                    _Anonymization = new Anonymization(_SdkObject);
                return _Anonymization;
            }
        }
        private Anonymization? _Anonymization = null;

        public Wallet Wallet
        {
            get
            {
                if (_Wallet == null)
                    _Wallet = new Wallet(_SdkObject);
                return _Wallet;
            }
        }
        private Wallet? _Wallet = null;

        public OrderDedicated OrderDedicated
        {
            get
            {
                if (_OrderDedicated == null)
                    _OrderDedicated = new OrderDedicated(_SdkObject);
                return _OrderDedicated;
            }
        }
        private OrderDedicated? _OrderDedicated = null;

        public PaymentConfig PaymentConfig
        {
            get
            {
                if (_PaymentConfig == null)
                    _PaymentConfig = new PaymentConfig(_SdkObject);
                return _PaymentConfig;
            }
        }
        private PaymentConfig? _PaymentConfig = null;

        public PaymentStation PaymentStation
        {
            get
            {
                if (_PaymentStation == null)
                    _PaymentStation = new PaymentStation(_SdkObject);
                return _PaymentStation;
            }
        }
        private PaymentStation? _PaymentStation = null;

        public PaymentAccount PaymentAccount
        {
            get
            {
                if (_PaymentAccount == null)
                    _PaymentAccount = new PaymentAccount(_SdkObject);
                return _PaymentAccount;
            }
        }
        private PaymentAccount? _PaymentAccount = null;

        internal PlatformSdkWrappers(AccelByteSDK sdk)
        {
            _SdkObject = sdk;
        }
    }

    public partial class AccelByteSDK
    {
        public PlatformSdkWrappers Platform
        {
            get
            {
                if (_Platform == null)
                    _Platform = new PlatformSdkWrappers(this);
                return _Platform;
            }
        }
        private PlatformSdkWrappers? _Platform = null;
    }
}