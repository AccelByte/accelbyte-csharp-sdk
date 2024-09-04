// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Challenge.Model
{
    public class ModelChallengeResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("activeGoalsPerRotation")]
        public int? ActiveGoalsPerRotation { get; set; }

        [JsonPropertyName("assignmentRule")]
        [JsonStringEnum]
        public ModelChallengeResponseAssignmentRule? AssignmentRule { get; set; }

        [JsonPropertyName("code")]
        public string? Code { get; set; }

        [JsonPropertyName("createdAt")]
        public string? CreatedAt { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("endAfter")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? EndAfter { get; set; }

        [JsonPropertyName("endDate")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? EndDate { get; set; }

        [JsonPropertyName("goalsVisibility")]
        [JsonStringEnum]
        public ModelChallengeResponseGoalsVisibility? GoalsVisibility { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("randomizedPerRotation")]
        public bool? RandomizedPerRotation { get; set; }

        [JsonPropertyName("repeatAfter")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? RepeatAfter { get; set; }

        [JsonPropertyName("resetConfig")]
        public ModelResetConfig? ResetConfig { get; set; }

        [JsonPropertyName("rotation")]
        [JsonStringEnum]
        public ModelChallengeResponseRotation? Rotation { get; set; }

        [JsonPropertyName("startDate")]
        public string? StartDate { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public ModelChallengeResponseStatus? Status { get; set; }

        [JsonPropertyName("updatedAt")]
        public string? UpdatedAt { get; set; }

    }



    public class ModelChallengeResponseAssignmentRule : StringEnum<ModelChallengeResponseAssignmentRule>
    {
        public static readonly ModelChallengeResponseAssignmentRule CUSTOM
            = new ModelChallengeResponseAssignmentRule("CUSTOM");

        public static readonly ModelChallengeResponseAssignmentRule FIXED
            = new ModelChallengeResponseAssignmentRule("FIXED");

        public static readonly ModelChallengeResponseAssignmentRule RANDOMIZED
            = new ModelChallengeResponseAssignmentRule("RANDOMIZED");

        public static readonly ModelChallengeResponseAssignmentRule UNSCHEDULED
            = new ModelChallengeResponseAssignmentRule("UNSCHEDULED");


        public static implicit operator ModelChallengeResponseAssignmentRule(string value)
        {
            return NewValue(value);
        }

        public ModelChallengeResponseAssignmentRule(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class ModelChallengeResponseGoalsVisibility : StringEnum<ModelChallengeResponseGoalsVisibility>
    {
        public static readonly ModelChallengeResponseGoalsVisibility PERIODONLY
            = new ModelChallengeResponseGoalsVisibility("PERIODONLY");

        public static readonly ModelChallengeResponseGoalsVisibility SHOWALL
            = new ModelChallengeResponseGoalsVisibility("SHOWALL");


        public static implicit operator ModelChallengeResponseGoalsVisibility(string value)
        {
            return NewValue(value);
        }

        public ModelChallengeResponseGoalsVisibility(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class ModelChallengeResponseRotation : StringEnum<ModelChallengeResponseRotation>
    {
        public static readonly ModelChallengeResponseRotation DAILY
            = new ModelChallengeResponseRotation("DAILY");

        public static readonly ModelChallengeResponseRotation MONTHLY
            = new ModelChallengeResponseRotation("MONTHLY");

        public static readonly ModelChallengeResponseRotation NONE
            = new ModelChallengeResponseRotation("NONE");

        public static readonly ModelChallengeResponseRotation WEEKLY
            = new ModelChallengeResponseRotation("WEEKLY");


        public static implicit operator ModelChallengeResponseRotation(string value)
        {
            return NewValue(value);
        }

        public ModelChallengeResponseRotation(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class ModelChallengeResponseStatus : StringEnum<ModelChallengeResponseStatus>
    {
        public static readonly ModelChallengeResponseStatus INIT
            = new ModelChallengeResponseStatus("INIT");

        public static readonly ModelChallengeResponseStatus RETIRED
            = new ModelChallengeResponseStatus("RETIRED");

        public static readonly ModelChallengeResponseStatus TIED
            = new ModelChallengeResponseStatus("TIED");


        public static implicit operator ModelChallengeResponseStatus(string value)
        {
            return NewValue(value);
        }

        public ModelChallengeResponseStatus(string enumValue)
            : base(enumValue)
        {

        }
    }
}