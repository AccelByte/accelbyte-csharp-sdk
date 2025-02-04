// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Session.Model
{
    public class ApimodelsPublicConfiguration : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("PSNBaseURL")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PSNBaseURL { get; set; }

        [JsonPropertyName("appName")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? AppName { get; set; }

        [JsonPropertyName("asyncProcessDSRequest")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ModelsAsyncProcessDSRequest? AsyncProcessDSRequest { get; set; }

        [JsonPropertyName("attributes")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, object>? Attributes { get; set; }

        [JsonPropertyName("autoJoin")]
        public bool? AutoJoin { get; set; }

        [JsonPropertyName("clientVersion")]
        public string? ClientVersion { get; set; }

        [JsonPropertyName("customURLGRPC")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? CustomURLGRPC { get; set; }

        [JsonPropertyName("deployment")]
        public string? Deployment { get; set; }

        [JsonPropertyName("disableCodeGeneration")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? DisableCodeGeneration { get; set; }

        [JsonPropertyName("disableResendInvite")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? DisableResendInvite { get; set; }

        [JsonPropertyName("dsManualSetReady")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? DsManualSetReady { get; set; }

        [JsonPropertyName("dsSource")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? DsSource { get; set; }

        [JsonPropertyName("enableSecret")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? EnableSecret { get; set; }

        [JsonPropertyName("fallbackClaimKeys")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? FallbackClaimKeys { get; set; }

        [JsonPropertyName("grpcSessionConfig")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ModelsExtendConfiguration? GrpcSessionConfig { get; set; }

        [JsonPropertyName("immutableStorage")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? ImmutableStorage { get; set; }

        [JsonPropertyName("inactiveTimeout")]
        public int? InactiveTimeout { get; set; }

        [JsonPropertyName("inviteTimeout")]
        public int? InviteTimeout { get; set; }

        [JsonPropertyName("joinability")]
        public string? Joinability { get; set; }

        [JsonPropertyName("leaderElectionGracePeriod")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? LeaderElectionGracePeriod { get; set; }

        [JsonPropertyName("manualRejoin")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? ManualRejoin { get; set; }

        [JsonPropertyName("maxActiveSession")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? MaxActiveSession { get; set; }

        [JsonPropertyName("maxPlayers")]
        public int? MaxPlayers { get; set; }

        [JsonPropertyName("minPlayers")]
        public int? MinPlayers { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("nativeSessionSetting")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ModelsNativeSessionSetting? NativeSessionSetting { get; set; }

        [JsonPropertyName("persistent")]
        public bool? Persistent { get; set; }

        [JsonPropertyName("preferredClaimKeys")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? PreferredClaimKeys { get; set; }

        [JsonPropertyName("requestedRegions")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? RequestedRegions { get; set; }

        [JsonPropertyName("textChat")]
        public bool? TextChat { get; set; }

        [JsonPropertyName("textChatMode")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public ApimodelsPublicConfigurationTextChatMode? TextChatMode { get; set; }

        [JsonPropertyName("tieTeamsSessionLifetime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? TieTeamsSessionLifetime { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }

    }

    public class ApimodelsPublicConfiguration<T1> : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("PSNBaseURL")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PSNBaseURL { get; set; }

        [JsonPropertyName("appName")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? AppName { get; set; }

        [JsonPropertyName("asyncProcessDSRequest")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ModelsAsyncProcessDSRequest? AsyncProcessDSRequest { get; set; }

        [JsonPropertyName("attributes")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public T1? Attributes { get; set; }

        [JsonPropertyName("autoJoin")]
        public bool? AutoJoin { get; set; }

        [JsonPropertyName("clientVersion")]
        public string? ClientVersion { get; set; }

        [JsonPropertyName("customURLGRPC")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? CustomURLGRPC { get; set; }

        [JsonPropertyName("deployment")]
        public string? Deployment { get; set; }

        [JsonPropertyName("disableCodeGeneration")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? DisableCodeGeneration { get; set; }

        [JsonPropertyName("disableResendInvite")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? DisableResendInvite { get; set; }

        [JsonPropertyName("dsManualSetReady")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? DsManualSetReady { get; set; }

        [JsonPropertyName("dsSource")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? DsSource { get; set; }

        [JsonPropertyName("enableSecret")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? EnableSecret { get; set; }

        [JsonPropertyName("fallbackClaimKeys")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? FallbackClaimKeys { get; set; }

        [JsonPropertyName("grpcSessionConfig")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ModelsExtendConfiguration? GrpcSessionConfig { get; set; }

        [JsonPropertyName("immutableStorage")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? ImmutableStorage { get; set; }

        [JsonPropertyName("inactiveTimeout")]
        public int? InactiveTimeout { get; set; }

        [JsonPropertyName("inviteTimeout")]
        public int? InviteTimeout { get; set; }

        [JsonPropertyName("joinability")]
        public string? Joinability { get; set; }

        [JsonPropertyName("leaderElectionGracePeriod")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? LeaderElectionGracePeriod { get; set; }

        [JsonPropertyName("manualRejoin")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? ManualRejoin { get; set; }

        [JsonPropertyName("maxActiveSession")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? MaxActiveSession { get; set; }

        [JsonPropertyName("maxPlayers")]
        public int? MaxPlayers { get; set; }

        [JsonPropertyName("minPlayers")]
        public int? MinPlayers { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("nativeSessionSetting")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ModelsNativeSessionSetting? NativeSessionSetting { get; set; }

        [JsonPropertyName("persistent")]
        public bool? Persistent { get; set; }

        [JsonPropertyName("preferredClaimKeys")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? PreferredClaimKeys { get; set; }

        [JsonPropertyName("requestedRegions")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? RequestedRegions { get; set; }

        [JsonPropertyName("textChat")]
        public bool? TextChat { get; set; }

        [JsonPropertyName("textChatMode")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public ApimodelsPublicConfigurationTextChatMode? TextChatMode { get; set; }

        [JsonPropertyName("tieTeamsSessionLifetime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? TieTeamsSessionLifetime { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }

    }


    public class ApimodelsPublicConfigurationTextChatMode : StringEnum<ApimodelsPublicConfigurationTextChatMode>
    {
        public static readonly ApimodelsPublicConfigurationTextChatMode GAME
            = new ApimodelsPublicConfigurationTextChatMode("GAME");

        public static readonly ApimodelsPublicConfigurationTextChatMode NONE
            = new ApimodelsPublicConfigurationTextChatMode("NONE");

        public static readonly ApimodelsPublicConfigurationTextChatMode TEAM
            = new ApimodelsPublicConfigurationTextChatMode("TEAM");


        public static implicit operator ApimodelsPublicConfigurationTextChatMode(string value)
        {
            return NewValue(value);
        }

        public ApimodelsPublicConfigurationTextChatMode(string enumValue)
            : base(enumValue)
        {

        }
    }
}