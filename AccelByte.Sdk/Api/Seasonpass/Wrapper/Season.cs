// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Seasonpass.Model;
using AccelByte.Sdk.Api.Seasonpass.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Seasonpass.Wrapper
{
    public class Season
    {
        private readonly AccelByteSDK _sdk;

        public Season(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public QuerySeasons.QuerySeasonsBuilder QuerySeasonsOp
        {
            get { return Operation.QuerySeasons.Builder.SetWrapperObject(this); }
        }
        public CreateSeason.CreateSeasonBuilder CreateSeasonOp
        {
            get { return Operation.CreateSeason.Builder.SetWrapperObject(this); }
        }
        public GetCurrentSeason.GetCurrentSeasonBuilder GetCurrentSeasonOp
        {
            get { return Operation.GetCurrentSeason.Builder.SetWrapperObject(this); }
        }
        public GetSeason.GetSeasonBuilder GetSeasonOp
        {
            get { return Operation.GetSeason.Builder.SetWrapperObject(this); }
        }
        public DeleteSeason.DeleteSeasonBuilder DeleteSeasonOp
        {
            get { return Operation.DeleteSeason.Builder.SetWrapperObject(this); }
        }
        public UpdateSeason.UpdateSeasonBuilder UpdateSeasonOp
        {
            get { return Operation.UpdateSeason.Builder.SetWrapperObject(this); }
        }
        public CloneSeason.CloneSeasonBuilder CloneSeasonOp
        {
            get { return Operation.CloneSeason.Builder.SetWrapperObject(this); }
        }
        public PublishSeason.PublishSeasonBuilder PublishSeasonOp
        {
            get { return Operation.PublishSeason.Builder.SetWrapperObject(this); }
        }
        public RetireSeason.RetireSeasonBuilder RetireSeasonOp
        {
            get { return Operation.RetireSeason.Builder.SetWrapperObject(this); }
        }
        public UnpublishSeason.UnpublishSeasonBuilder UnpublishSeasonOp
        {
            get { return Operation.UnpublishSeason.Builder.SetWrapperObject(this); }
        }
        public GetUserParticipatedSeasons.GetUserParticipatedSeasonsBuilder GetUserParticipatedSeasonsOp
        {
            get { return Operation.GetUserParticipatedSeasons.Builder.SetWrapperObject(this); }
        }
        public ExistsAnyPassByPassCodes.ExistsAnyPassByPassCodesBuilder ExistsAnyPassByPassCodesOp
        {
            get { return Operation.ExistsAnyPassByPassCodes.Builder.SetWrapperObject(this); }
        }
        public GetCurrentUserSeasonProgression.GetCurrentUserSeasonProgressionBuilder GetCurrentUserSeasonProgressionOp
        {
            get { return Operation.GetCurrentUserSeasonProgression.Builder.SetWrapperObject(this); }
        }
        public CheckSeasonPurchasable.CheckSeasonPurchasableBuilder CheckSeasonPurchasableOp
        {
            get { return Operation.CheckSeasonPurchasable.Builder.SetWrapperObject(this); }
        }
        public ResetUserSeason.ResetUserSeasonBuilder ResetUserSeasonOp
        {
            get { return Operation.ResetUserSeason.Builder.SetWrapperObject(this); }
        }
        public GetUserSeason.GetUserSeasonBuilder GetUserSeasonOp
        {
            get { return Operation.GetUserSeason.Builder.SetWrapperObject(this); }
        }
        public PublicGetCurrentSeason.PublicGetCurrentSeasonBuilder PublicGetCurrentSeasonOp
        {
            get { return Operation.PublicGetCurrentSeason.Builder.SetWrapperObject(this); }
        }
        public PublicGetCurrentUserSeason.PublicGetCurrentUserSeasonBuilder PublicGetCurrentUserSeasonOp
        {
            get { return Operation.PublicGetCurrentUserSeason.Builder.SetWrapperObject(this); }
        }
        public PublicGetUserSeason.PublicGetUserSeasonBuilder PublicGetUserSeasonOp
        {
            get { return Operation.PublicGetUserSeason.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.ListSeasonInfoPagingSlicedResult? QuerySeasons(QuerySeasons input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.SeasonInfo? CreateSeason(CreateSeason input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.SeasonSummary? GetCurrentSeason(GetCurrentSeason input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.SeasonInfo? GetSeason(GetSeason input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteSeason(DeleteSeason input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.SeasonInfo? UpdateSeason(UpdateSeason input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.SeasonInfo? CloneSeason(CloneSeason input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.SeasonInfo? PublishSeason(PublishSeason input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.SeasonInfo? RetireSeason(RetireSeason input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.SeasonInfo? UnpublishSeason(UnpublishSeason input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ListUserSeasonInfoPagingSlicedResult? GetUserParticipatedSeasons(GetUserParticipatedSeasons input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.Ownership? ExistsAnyPassByPassCodes(ExistsAnyPassByPassCodes input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.UserSeasonSummary? GetCurrentUserSeasonProgression(GetCurrentUserSeasonProgression input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void CheckSeasonPurchasable(CheckSeasonPurchasable input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void ResetUserSeason(ResetUserSeason input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ClaimableUserSeasonInfo? GetUserSeason(GetUserSeason input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.LocalizedSeasonInfo? PublicGetCurrentSeason(PublicGetCurrentSeason input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ClaimableUserSeasonInfo? PublicGetCurrentUserSeason(PublicGetCurrentUserSeason input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ClaimableUserSeasonInfo? PublicGetUserSeason(PublicGetUserSeason input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class Season_OperationExtensions
    {
        public static Model.ListSeasonInfoPagingSlicedResult? Execute(
            this QuerySeasons.QuerySeasonsBuilder builder,
            string namespace_
        )
        {
            QuerySeasons op = builder.Build(
                namespace_
            );

            return ((Season)builder.WrapperObject!).QuerySeasons(op);
        }

        public static Model.SeasonInfo? Execute(
            this CreateSeason.CreateSeasonBuilder builder,
            string namespace_
        )
        {
            CreateSeason op = builder.Build(
                namespace_
            );

            return ((Season)builder.WrapperObject!).CreateSeason(op);
        }

        public static Model.SeasonSummary? Execute(
            this GetCurrentSeason.GetCurrentSeasonBuilder builder,
            string namespace_
        )
        {
            GetCurrentSeason op = builder.Build(
                namespace_
            );

            return ((Season)builder.WrapperObject!).GetCurrentSeason(op);
        }

        public static Model.SeasonInfo? Execute(
            this GetSeason.GetSeasonBuilder builder,
            string namespace_,
            string seasonId
        )
        {
            GetSeason op = builder.Build(
                namespace_,
                seasonId
            );

            return ((Season)builder.WrapperObject!).GetSeason(op);
        }

        public static void Execute(
            this DeleteSeason.DeleteSeasonBuilder builder,
            string namespace_,
            string seasonId
        )
        {
            DeleteSeason op = builder.Build(
                namespace_,
                seasonId
            );

            ((Season)builder.WrapperObject!).DeleteSeason(op);
        }

        public static Model.SeasonInfo? Execute(
            this UpdateSeason.UpdateSeasonBuilder builder,
            string namespace_,
            string seasonId
        )
        {
            UpdateSeason op = builder.Build(
                namespace_,
                seasonId
            );

            return ((Season)builder.WrapperObject!).UpdateSeason(op);
        }

        public static Model.SeasonInfo? Execute(
            this CloneSeason.CloneSeasonBuilder builder,
            string namespace_,
            string seasonId
        )
        {
            CloneSeason op = builder.Build(
                namespace_,
                seasonId
            );

            return ((Season)builder.WrapperObject!).CloneSeason(op);
        }

        public static Model.SeasonInfo? Execute(
            this PublishSeason.PublishSeasonBuilder builder,
            string namespace_,
            string seasonId
        )
        {
            PublishSeason op = builder.Build(
                namespace_,
                seasonId
            );

            return ((Season)builder.WrapperObject!).PublishSeason(op);
        }

        public static Model.SeasonInfo? Execute(
            this RetireSeason.RetireSeasonBuilder builder,
            string namespace_,
            string seasonId
        )
        {
            RetireSeason op = builder.Build(
                namespace_,
                seasonId
            );

            return ((Season)builder.WrapperObject!).RetireSeason(op);
        }

        public static Model.SeasonInfo? Execute(
            this UnpublishSeason.UnpublishSeasonBuilder builder,
            string namespace_,
            string seasonId
        )
        {
            UnpublishSeason op = builder.Build(
                namespace_,
                seasonId
            );

            return ((Season)builder.WrapperObject!).UnpublishSeason(op);
        }

        public static Model.ListUserSeasonInfoPagingSlicedResult? Execute(
            this GetUserParticipatedSeasons.GetUserParticipatedSeasonsBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetUserParticipatedSeasons op = builder.Build(
                namespace_,
                userId
            );

            return ((Season)builder.WrapperObject!).GetUserParticipatedSeasons(op);
        }

        public static Model.Ownership? Execute(
            this ExistsAnyPassByPassCodes.ExistsAnyPassByPassCodesBuilder builder,
            string namespace_,
            string userId
        )
        {
            ExistsAnyPassByPassCodes op = builder.Build(
                namespace_,
                userId
            );

            return ((Season)builder.WrapperObject!).ExistsAnyPassByPassCodes(op);
        }

        public static Model.UserSeasonSummary? Execute(
            this GetCurrentUserSeasonProgression.GetCurrentUserSeasonProgressionBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetCurrentUserSeasonProgression op = builder.Build(
                namespace_,
                userId
            );

            return ((Season)builder.WrapperObject!).GetCurrentUserSeasonProgression(op);
        }

        public static void Execute(
            this CheckSeasonPurchasable.CheckSeasonPurchasableBuilder builder,
            string namespace_,
            string userId
        )
        {
            CheckSeasonPurchasable op = builder.Build(
                namespace_,
                userId
            );

            ((Season)builder.WrapperObject!).CheckSeasonPurchasable(op);
        }

        public static void Execute(
            this ResetUserSeason.ResetUserSeasonBuilder builder,
            string namespace_,
            string userId
        )
        {
            ResetUserSeason op = builder.Build(
                namespace_,
                userId
            );

            ((Season)builder.WrapperObject!).ResetUserSeason(op);
        }

        public static Model.ClaimableUserSeasonInfo? Execute(
            this GetUserSeason.GetUserSeasonBuilder builder,
            string namespace_,
            string seasonId,
            string userId
        )
        {
            GetUserSeason op = builder.Build(
                namespace_,
                seasonId,
                userId
            );

            return ((Season)builder.WrapperObject!).GetUserSeason(op);
        }

        public static Model.LocalizedSeasonInfo? Execute(
            this PublicGetCurrentSeason.PublicGetCurrentSeasonBuilder builder,
            string namespace_
        )
        {
            PublicGetCurrentSeason op = builder.Build(
                namespace_
            );

            return ((Season)builder.WrapperObject!).PublicGetCurrentSeason(op);
        }

        public static Model.ClaimableUserSeasonInfo? Execute(
            this PublicGetCurrentUserSeason.PublicGetCurrentUserSeasonBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicGetCurrentUserSeason op = builder.Build(
                namespace_,
                userId
            );

            return ((Season)builder.WrapperObject!).PublicGetCurrentUserSeason(op);
        }

        public static Model.ClaimableUserSeasonInfo? Execute(
            this PublicGetUserSeason.PublicGetUserSeasonBuilder builder,
            string namespace_,
            string seasonId,
            string userId
        )
        {
            PublicGetUserSeason op = builder.Build(
                namespace_,
                seasonId,
                userId
            );

            return ((Season)builder.WrapperObject!).PublicGetUserSeason(op);
        }

    }
}