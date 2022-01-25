using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PaymentMerchantConfigInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("adyenConfig")]
        public AdyenConfig? AdyenConfig { get; set; }
        
        [JsonPropertyName("adyenSandboxConfig")]
        public AdyenConfig? AdyenSandboxConfig { get; set; }
        
        [JsonPropertyName("aliPayConfig")]
        public AliPayConfig? AliPayConfig { get; set; }
        
        [JsonPropertyName("aliPaySandboxConfig")]
        public AliPayConfig? AliPaySandboxConfig { get; set; }
        
        [JsonPropertyName("checkoutConfig")]
        public CheckoutConfig? CheckoutConfig { get; set; }
        
        [JsonPropertyName("checkoutSandboxConfig")]
        public CheckoutConfig? CheckoutSandboxConfig { get; set; }
        
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }
        
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        
        [JsonPropertyName("payPalConfig")]
        public PayPalConfig? PayPalConfig { get; set; }
        
        [JsonPropertyName("payPalSandboxConfig")]
        public PayPalConfig? PayPalSandboxConfig { get; set; }
        
        [JsonPropertyName("stripeConfig")]
        public StripeConfig? StripeConfig { get; set; }
        
        [JsonPropertyName("stripeSandboxConfig")]
        public StripeConfig? StripeSandboxConfig { get; set; }
        
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }
        
        [JsonPropertyName("wxPayConfig")]
        public WxPayConfigInfo? WxPayConfig { get; set; }
        
        [JsonPropertyName("xsollaConfig")]
        public XsollaConfig? XsollaConfig { get; set; }
        
        [JsonPropertyName("xsollaPaywallConfig")]
        public XsollaPaywallConfig? XsollaPaywallConfig { get; set; }
        
    }
}