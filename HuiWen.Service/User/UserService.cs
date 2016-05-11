using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HuiWen.DAL;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace HuiWen.Service
{

    #region 查询用户的邀请码信息 q/Event/GetNickNameByUserIdRequset

    [RestService("q/User/GetNickNameByUserIdRequset")]
    public class GetNickNameByUserIdService
    {

        public int userId { get; set; }

    }
    public class GetUserInviteKeyService : RestServiceBase<GetNickNameByUserIdService>
    {

        public override object OnGet(GetNickNameByUserIdService request)
        {
            return new UserManage().GetNickNameByUserId(request.userId);

        }

    }

    #endregion

    #region 新建用户 q/Event/AddUserRequset

    [RestService("q/User/AddUserRequset")]
    public class AddUserRequest : UserEntity
    {


    }
    public class AddUserService : RestServiceBase<AddUserRequest>
    {

        public override object OnGet(AddUserRequest request)
        {
            return new UserManage().AddUser(request);

        }

    }

    #endregion

    #region 新建用户 q/Event/GetUserInfoRequest

    [RestService("q/User/GetUserInfoRequest")]
    public class GetUserInfoRequest
    {

        public int userId { get; set; }
    }
    public class GetUserInfoService : RestServiceBase<GetUserInfoRequest>
    {

        public override object OnGet(GetUserInfoRequest request)
        {
            return new UserManage().GetUserInfo(request.userId);

        }

    }

    #endregion
}
