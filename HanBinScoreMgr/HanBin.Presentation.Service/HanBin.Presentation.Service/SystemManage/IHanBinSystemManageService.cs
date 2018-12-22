﻿using iCMS.Common.Component.Data.Base;
using iCMS.Common.Component.Data.Request.HanBin.SystemManage;
using iCMS.Common.Component.Data.Response.HanBin.SystemManager;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace HanBin.Presentation.Service.SystemManage
{

    [ServiceContract]
  public  interface IHanBinSystemManageService
    {
        [WebInvoke(UriTemplate = "Login",
              BodyStyle = WebMessageBodyStyle.Bare,
              Method = "POST",
              RequestFormat = WebMessageFormat.Json,
              ResponseFormat = WebMessageFormat.Json)]
        BaseResponse<LoginResult> Login(LoginParameter parameter);

        [WebInvoke(UriTemplate = "AddUser",
             BodyStyle = WebMessageBodyStyle.Bare,
             Method = "POST",
             RequestFormat = WebMessageFormat.Json,
             ResponseFormat = WebMessageFormat.Json)]
        BaseResponse<bool> AddUser(AddUserParameter parameter);

        [WebInvoke(UriTemplate = "EditUser",
             BodyStyle = WebMessageBodyStyle.Bare,
             Method = "POST",
             RequestFormat = WebMessageFormat.Json,
             ResponseFormat = WebMessageFormat.Json)]
        BaseResponse<bool> EditUser(EditUserParameter parameter);

        [WebInvoke(UriTemplate = "GetUserInfo",
            BodyStyle = WebMessageBodyStyle.Bare,
            Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        BaseResponse<GetUserInfoResult> GetUserInfo(GetUserInfoParameter parameter);

    }
}