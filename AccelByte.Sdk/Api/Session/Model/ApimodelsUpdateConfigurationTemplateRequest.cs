// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Session.Model
{
    public class ApimodelsUpdateConfigurationTemplateRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("NativeSessionSetting")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ModelsNativeSessionSetting? NativeSessionSetting { get; set; }

        [JsonPropertyName("PSNBaseUrl")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PSNBaseUrl { get; set; }

        [JsonPropertyName("amsClaimTimeoutMinutes")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? AmsClaimTimeoutMinutes { get; set; }

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
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? AutoJoin { get; set; }

        [JsonPropertyName("autoLeaveSession")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? AutoLeaveSession { get; set; }

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
        [JsonStringEnum]
        public ApimodelsUpdateConfigurationTemplateRequestJoinability? Joinability { get; set; }

        [JsonPropertyName("leaderElectionGracePeriod")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? LeaderElectionGracePeriod { get; set; }

        [JsonPropertyName("manualRejoin")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? ManualRejoin { get; set; }

        [JsonPropertyName("maxActiveSessions")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? MaxActiveSessions { get; set; }

        [JsonPropertyName("maxPlayers")]
        public int? MaxPlayers { get; set; }

        [JsonPropertyName("minPlayers")]
        public int? MinPlayers { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("persistent")]
        public bool? Persistent { get; set; }

        [JsonPropertyName("preferredClaimKeys")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? PreferredClaimKeys { get; set; }

        [JsonPropertyName("requestedRegions")]
        public List<string>? RequestedRegions { get; set; }

        [JsonPropertyName("textChat")]
        public bool? TextChat { get; set; }

        [JsonPropertyName("textChatMode")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public ApimodelsUpdateConfigurationTemplateRequestTextChatMode? TextChatMode { get; set; }

        [JsonPropertyName("tieTeamsSessionLifetime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? TieTeamsSessionLifetime { get; set; }

        [JsonPropertyName("ttlHours")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? TtlHours { get; set; }

        [JsonPropertyName("type")]
        [JsonStringEnum]
        public ApimodelsUpdateConfigurationTemplateRequestType? Type { get; set; }

    }

    public class ApimodelsUpdateConfigurationTemplateRequest<T1> : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("NativeSessionSetting")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ModelsNativeSessionSetting? NativeSessionSetting { get; set; }

        [JsonPropertyName("PSNBaseUrl")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PSNBaseUrl { get; set; }

        [JsonPropertyName("amsClaimTimeoutMinutes")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? AmsClaimTimeoutMinutes { get; set; }

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
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? AutoJoin { get; set; }

        [JsonPropertyName("autoLeaveSession")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? AutoLeaveSession { get; set; }

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
        [JsonStringEnum]
        public ApimodelsUpdateConfigurationTemplateRequestJoinability? Joinability { get; set; }

        [JsonPropertyName("leaderElectionGracePeriod")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? LeaderElectionGracePeriod { get; set; }

        [JsonPropertyName("manualRejoin")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? ManualRejoin { get; set; }

        [JsonPropertyName("maxActiveSessions")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? MaxActiveSessions { get; set; }

        [JsonPropertyName("maxPlayers")]
        public int? MaxPlayers { get; set; }

        [JsonPropertyName("minPlayers")]
        public int? MinPlayers { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("persistent")]
        public bool? Persistent { get; set; }

        [JsonPropertyName("preferredClaimKeys")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? PreferredClaimKeys { get; set; }

        [JsonPropertyName("requestedRegions")]
        public List<string>? RequestedRegions { get; set; }

        [JsonPropertyName("textChat")]
        public bool? TextChat { get; set; }

        [JsonPropertyName("textChatMode")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public ApimodelsUpdateConfigurationTemplateRequestTextChatMode? TextChatMode { get; set; }

        [JsonPropertyName("tieTeamsSessionLifetime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? TieTeamsSessionLifetime { get; set; }

        [JsonPropertyName("ttlHours")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? TtlHours { get; set; }

        [JsonPropertyName("type")]
        [JsonStringEnum]
        public ApimodelsUpdateConfigurationTemplateRequestType? Type { get; set; }

    }


    public class ApimodelsUpdateConfigurationTemplateRequestJoinability : StringEnum<ApimodelsUpdateConfigurationTemplateRequestJoinability>
    {
        public static readonly ApimodelsUpdateConfigurationTemplateRequestJoinability CLOSED
            = new ApimodelsUpdateConfigurationTemplateRequestJoinability("CLOSED");

        public static readonly ApimodelsUpdateConfigurationTemplateRequestJoinability FRIENDSOFFRIENDS
            = new ApimodelsUpdateConfigurationTemplateRequestJoinability("FRIENDS_OF_FRIENDS");

        public static readonly ApimodelsUpdateConfigurationTemplateRequestJoinability FRIENDSOFLEADER
            = new ApimodelsUpdateConfigurationTemplateRequestJoinability("FRIENDS_OF_LEADER");

        public static readonly ApimodelsUpdateConfigurationTemplateRequestJoinability FRIENDSOFMEMBERS
            = new ApimodelsUpdateConfigurationTemplateRequestJoinability("FRIENDS_OF_MEMBERS");

        public static readonly ApimodelsUpdateConfigurationTemplateRequestJoinability INVITEONLY
            = new ApimodelsUpdateConfigurationTemplateRequestJoinability("INVITE_ONLY");

        public static readonly ApimodelsUpdateConfigurationTemplateRequestJoinability OPEN
            = new ApimodelsUpdateConfigurationTemplateRequestJoinability("OPEN");


        public static implicit operator ApimodelsUpdateConfigurationTemplateRequestJoinability(string value)
        {
            return NewValue(value);
        }

        public ApimodelsUpdateConfigurationTemplateRequestJoinability(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class ApimodelsUpdateConfigurationTemplateRequestTextChatMode : StringEnum<ApimodelsUpdateConfigurationTemplateRequestTextChatMode>
    {
        public static readonly ApimodelsUpdateConfigurationTemplateRequestTextChatMode GAME
            = new ApimodelsUpdateConfigurationTemplateRequestTextChatMode("GAME");

        public static readonly ApimodelsUpdateConfigurationTemplateRequestTextChatMode NONE
            = new ApimodelsUpdateConfigurationTemplateRequestTextChatMode("NONE");

        public static readonly ApimodelsUpdateConfigurationTemplateRequestTextChatMode TEAM
            = new ApimodelsUpdateConfigurationTemplateRequestTextChatMode("TEAM");


        public static implicit operator ApimodelsUpdateConfigurationTemplateRequestTextChatMode(string value)
        {
            return NewValue(value);
        }

        public ApimodelsUpdateConfigurationTemplateRequestTextChatMode(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class ApimodelsUpdateConfigurationTemplateRequestType : StringEnum<ApimodelsUpdateConfigurationTemplateRequestType>
    {
        public static readonly ApimodelsUpdateConfigurationTemplateRequestType DS
            = new ApimodelsUpdateConfigurationTemplateRequestType("DS");

        public static readonly ApimodelsUpdateConfigurationTemplateRequestType NONE
            = new ApimodelsUpdateConfigurationTemplateRequestType("NONE");

        public static readonly ApimodelsUpdateConfigurationTemplateRequestType P2P
            = new ApimodelsUpdateConfigurationTemplateRequestType("P2P");


        public static implicit operator ApimodelsUpdateConfigurationTemplateRequestType(string value)
        {
            return NewValue(value);
        }

        public ApimodelsUpdateConfigurationTemplateRequestType(string enumValue)
            : base(enumValue)
        {

        }
    }
}