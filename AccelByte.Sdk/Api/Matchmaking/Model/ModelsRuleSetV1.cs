// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Matchmaking.Model
{
    public class ModelsRuleSetV1 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("alliance")]
        public ModelsAllianceRuleV1? Alliance { get; set; }

        [JsonPropertyName("alliance_flexing_rule")]
        public List<ModelsAllianceFlexingRule>? AllianceFlexingRule { get; set; }

        [JsonPropertyName("batch_size")]
        public int? BatchSize { get; set; }

        [JsonPropertyName("bucket_mmr_rule")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ModelsBucketMMRRule? BucketMmrRule { get; set; }

        [JsonPropertyName("flexingRules")]
        public List<ModelsFlexingRule>? FlexingRules { get; set; }

        [JsonPropertyName("match_options")]
        public ModelsMatchOptionRule? MatchOptions { get; set; }

        [JsonPropertyName("matchingRules")]
        public List<ModelsMatchingRule>? MatchingRules { get; set; }

        [JsonPropertyName("sort_ticket")]
        public ModelsSortTicket? SortTicket { get; set; }

        [JsonPropertyName("sort_tickets")]
        public List<ModelsSortTicketRule>? SortTickets { get; set; }

        [JsonPropertyName("sub_game_modes")]
        public Dictionary<string, ModelsSubGameMode>? SubGameModes { get; set; }

        [JsonPropertyName("ticket_flexing_selection")]
        [JsonStringEnum]
        public ModelsRuleSetV1TicketFlexingSelection? TicketFlexingSelection { get; set; }

        [JsonPropertyName("ticket_flexing_selections")]
        public List<ModelsSelectionRule>? TicketFlexingSelections { get; set; }

        [JsonPropertyName("use_newest_ticket_for_flexing")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? UseNewestTicketForFlexing { get; set; }

    }



    public class ModelsRuleSetV1TicketFlexingSelection : StringEnum<ModelsRuleSetV1TicketFlexingSelection>
    {
        public static readonly ModelsRuleSetV1TicketFlexingSelection Newest
            = new ModelsRuleSetV1TicketFlexingSelection("newest");

        public static readonly ModelsRuleSetV1TicketFlexingSelection Oldest
            = new ModelsRuleSetV1TicketFlexingSelection("oldest");

        public static readonly ModelsRuleSetV1TicketFlexingSelection Pivot
            = new ModelsRuleSetV1TicketFlexingSelection("pivot");

        public static readonly ModelsRuleSetV1TicketFlexingSelection Random
            = new ModelsRuleSetV1TicketFlexingSelection("random");


        public static implicit operator ModelsRuleSetV1TicketFlexingSelection(string value)
        {
            return NewValue(value);
        }

        public ModelsRuleSetV1TicketFlexingSelection(string enumValue)
            : base(enumValue)
        {

        }
    }
}