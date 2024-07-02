// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Challenge.Model
{
    public class ModelUpdateChallengeRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("activeGoalsPerRotation")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? ActiveGoalsPerRotation { get; set; }

        [JsonPropertyName("assignmentRule")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public ModelUpdateChallengeRequestAssignmentRule? AssignmentRule { get; set; }

        [JsonPropertyName("description")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Description { get; set; }

        [JsonPropertyName("endAfter")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? EndAfter { get; set; }

        [JsonPropertyName("endDate")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? EndDate { get; set; }

        [JsonPropertyName("goalsVisibility")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public ModelUpdateChallengeRequestGoalsVisibility? GoalsVisibility { get; set; }

        [JsonPropertyName("name")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Name { get; set; }

        [JsonPropertyName("repeatAfter")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? RepeatAfter { get; set; }

        [JsonPropertyName("resetConfig")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ModelResetConfig? ResetConfig { get; set; }

        [JsonPropertyName("rotation")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public ModelUpdateChallengeRequestRotation? Rotation { get; set; }

        [JsonPropertyName("startDate")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? StartDate { get; set; }

    }



    public class ModelUpdateChallengeRequestAssignmentRule : StringEnum<ModelUpdateChallengeRequestAssignmentRule>
    {
        public static readonly ModelUpdateChallengeRequestAssignmentRule FIXED
            = new ModelUpdateChallengeRequestAssignmentRule("FIXED");

        public static readonly ModelUpdateChallengeRequestAssignmentRule RANDOMIZED
            = new ModelUpdateChallengeRequestAssignmentRule("RANDOMIZED");

        public static readonly ModelUpdateChallengeRequestAssignmentRule UNSCHEDULED
            = new ModelUpdateChallengeRequestAssignmentRule("UNSCHEDULED");


        public static implicit operator ModelUpdateChallengeRequestAssignmentRule(string value)
        {
            return NewValue(value);
        }

        public ModelUpdateChallengeRequestAssignmentRule(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class ModelUpdateChallengeRequestGoalsVisibility : StringEnum<ModelUpdateChallengeRequestGoalsVisibility>
    {
        public static readonly ModelUpdateChallengeRequestGoalsVisibility PERIODONLY
            = new ModelUpdateChallengeRequestGoalsVisibility("PERIODONLY");

        public static readonly ModelUpdateChallengeRequestGoalsVisibility SHOWALL
            = new ModelUpdateChallengeRequestGoalsVisibility("SHOWALL");


        public static implicit operator ModelUpdateChallengeRequestGoalsVisibility(string value)
        {
            return NewValue(value);
        }

        public ModelUpdateChallengeRequestGoalsVisibility(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class ModelUpdateChallengeRequestRotation : StringEnum<ModelUpdateChallengeRequestRotation>
    {
        public static readonly ModelUpdateChallengeRequestRotation DAILY
            = new ModelUpdateChallengeRequestRotation("DAILY");

        public static readonly ModelUpdateChallengeRequestRotation MONTHLY
            = new ModelUpdateChallengeRequestRotation("MONTHLY");

        public static readonly ModelUpdateChallengeRequestRotation NONE
            = new ModelUpdateChallengeRequestRotation("NONE");

        public static readonly ModelUpdateChallengeRequestRotation WEEKLY
            = new ModelUpdateChallengeRequestRotation("WEEKLY");


        public static implicit operator ModelUpdateChallengeRequestRotation(string value)
        {
            return NewValue(value);
        }

        public ModelUpdateChallengeRequestRotation(string enumValue)
            : base(enumValue)
        {

        }
    }
}