// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class View
    {
        private readonly AccelByteSDK _sdk;

        public View(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public ListViews.ListViewsBuilder ListViewsOp
        {
            get { return Operation.ListViews.Builder.SetWrapperObject(this); }
        }
        public CreateView.CreateViewBuilder CreateViewOp
        {
            get { return Operation.CreateView.Builder.SetWrapperObject(this); }
        }
        public GetView.GetViewBuilder GetViewOp
        {
            get { return Operation.GetView.Builder.SetWrapperObject(this); }
        }
        public UpdateView.UpdateViewBuilder UpdateViewOp
        {
            get { return Operation.UpdateView.Builder.SetWrapperObject(this); }
        }
        public DeleteView.DeleteViewBuilder DeleteViewOp
        {
            get { return Operation.DeleteView.Builder.SetWrapperObject(this); }
        }
        public PublicListViews.PublicListViewsBuilder PublicListViewsOp
        {
            get { return Operation.PublicListViews.Builder.SetWrapperObject(this); }
        }
        #endregion

        public List<Model.ListViewInfo>? ListViews(ListViews input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.FullViewInfo? CreateView(CreateView input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.FullViewInfo? GetView(GetView input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.FullViewInfo? UpdateView(UpdateView input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteView(DeleteView input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ViewInfo>? PublicListViews(PublicListViews input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public List<Model.ViewInfo<T1>>? PublicListViews<T1>(PublicListViews input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}