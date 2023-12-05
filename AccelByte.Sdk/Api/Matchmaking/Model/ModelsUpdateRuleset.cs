// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Matchmaking.Model
{
    public class ModelsUpdateRuleset : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("alliance")]
        public ModelsUpdateAllianceRule? Alliance { get; set; }

        [JsonPropertyName("alliance_flexing_rule")]
        public List<ModelsAllianceFlexingRule>? AllianceFlexingRule { get; set; }

        [JsonPropertyName("batch_size")]
        public int? BatchSize { get; set; }

        [JsonPropertyName("bucket_mmr_rule")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ModelsBucketMMRRule? BucketMmrRule { get; set; }

        [JsonPropertyName("flexingRules")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<ModelsFlexingRule>? FlexingRules { get; set; }

        [JsonPropertyName("match_options")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ModelsMatchOptionRule? MatchOptions { get; set; }

        [JsonPropertyName("matchingRules")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<ModelsMatchingRule>? MatchingRules { get; set; }

        [JsonPropertyName("sort_ticket")]
        public ModelsSortTicket? SortTicket { get; set; }

        [JsonPropertyName("sort_tickets")]
        public List<ModelsSortTicketRule>? SortTickets { get; set; }

        [JsonPropertyName("sub_game_modes")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ModelsUpdateRulesetSubGameModes? SubGameModes { get; set; }

        [JsonPropertyName("ticket_flexing_selection")]
        [JsonStringEnum]
        public ModelsUpdateRulesetTicketFlexingSelection? TicketFlexingSelection { get; set; }

        [JsonPropertyName("ticket_flexing_selections")]
        public List<ModelsSelectionRule>? TicketFlexingSelections { get; set; }

        [JsonPropertyName("use_newest_ticket_for_flexing")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? UseNewestTicketForFlexing { get; set; }

    }



    public class ModelsUpdateRulesetTicketFlexingSelection : StringEnum<ModelsUpdateRulesetTicketFlexingSelection>
    {
        public static readonly ModelsUpdateRulesetTicketFlexingSelection Newest
            = new ModelsUpdateRulesetTicketFlexingSelection("newest");

        public static readonly ModelsUpdateRulesetTicketFlexingSelection Oldest
            = new ModelsUpdateRulesetTicketFlexingSelection("oldest");

        public static readonly ModelsUpdateRulesetTicketFlexingSelection Pivot
            = new ModelsUpdateRulesetTicketFlexingSelection("pivot");

        public static readonly ModelsUpdateRulesetTicketFlexingSelection Random
            = new ModelsUpdateRulesetTicketFlexingSelection("random");


        public static implicit operator ModelsUpdateRulesetTicketFlexingSelection(string value)
        {
            return NewValue(value);
        }

        public ModelsUpdateRulesetTicketFlexingSelection(string enumValue)
            : base(enumValue)
        {

        }
    }
}