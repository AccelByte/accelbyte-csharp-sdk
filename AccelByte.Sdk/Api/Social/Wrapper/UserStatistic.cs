using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Api.Social.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Social.Wrapper
{
    public class UserStatistic {
        private readonly AccelByteSDK _sdk;

        public UserStatistic(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public List<Model.UserStatItemInfo>? BulkFetchStatItems(BulkFetchStatItems input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.BulkStatItemOperationResult>? BulkIncUserStatItem(BulkIncUserStatItem input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.BulkStatItemOperationResult>? BulkIncUserStatItemValue(BulkIncUserStatItemValue input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.BulkStatItemOperationResult>? BulkResetUserStatItem(BulkResetUserStatItem input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.UserStatItemPagingSlicedResult? GetUserStatItems(GetUserStatItems input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.BulkStatItemOperationResult>? BulkCreateUserStatItems(BulkCreateUserStatItems input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.BulkStatItemOperationResult>? BulkIncUserStatItem1(BulkIncUserStatItem1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.BulkStatItemOperationResult>? BulkIncUserStatItemValue1(BulkIncUserStatItemValue1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.BulkStatItemOperationResult>? BulkResetUserStatItem1(BulkResetUserStatItem1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void CreateUserStatItem(CreateUserStatItem input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteUserStatItems(DeleteUserStatItems input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.StatItemIncResult? IncUserStatItemValue(IncUserStatItemValue input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.StatItemIncResult? ResetUserStatItemValue(ResetUserStatItemValue input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.UserStatItemInfo>? BulkFetchStatItems1(BulkFetchStatItems1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.BulkStatItemOperationResult>? PublicBulkIncUserStatItem(PublicBulkIncUserStatItem input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.BulkStatItemOperationResult>? PublicBulkIncUserStatItemValue(PublicBulkIncUserStatItemValue input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.BulkStatItemOperationResult>? BulkResetUserStatItem2(BulkResetUserStatItem2 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.UserStatItemPagingSlicedResult? PublicQueryUserStatItems(PublicQueryUserStatItems input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.BulkStatItemOperationResult>? PublicBulkCreateUserStatItems(PublicBulkCreateUserStatItems input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.BulkStatItemOperationResult>? PublicBulkIncUserStatItem1(PublicBulkIncUserStatItem1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.BulkStatItemOperationResult>? BulkIncUserStatItemValue2(BulkIncUserStatItemValue2 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.BulkStatItemOperationResult>? BulkResetUserStatItem3(BulkResetUserStatItem3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PublicCreateUserStatItem(PublicCreateUserStatItem input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteUserStatItems1(DeleteUserStatItems1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.StatItemIncResult? PublicIncUserStatItem(PublicIncUserStatItem input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.StatItemIncResult? PublicIncUserStatItemValue(PublicIncUserStatItemValue input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.StatItemIncResult? ResetUserStatItemValue1(ResetUserStatItemValue1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.BulkStatItemOperationResult>? BulkUpdateUserStatItemV2(BulkUpdateUserStatItemV2 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.BulkStatItemOperationResult>? BulkUpdateUserStatItem(BulkUpdateUserStatItem input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.BulkStatItemOperationResult>? BulkResetUserStatItemValues(BulkResetUserStatItemValues input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteUserStatItems2(DeleteUserStatItems2 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.StatItemIncResult? UpdateUserStatItemValue(UpdateUserStatItemValue input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.BulkStatItemOperationResult>? BulkUpdateUserStatItem1(BulkUpdateUserStatItem1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.BulkStatItemOperationResult>? BulkUpdateUserStatItem2(BulkUpdateUserStatItem2 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.StatItemIncResult? UpdateUserStatItemValue1(UpdateUserStatItemValue1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}