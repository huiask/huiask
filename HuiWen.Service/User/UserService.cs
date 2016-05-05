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

    #region 查询用户的邀请码信息 q/Event/GetUserInviteKeyRequest

    [RestService("q/User/GetUserIdRequset")]
    public class UserService
    {

        public int userId { get; set; }

    }
    public class GetUserInviteKeyService : RestServiceBase<UserService>
    {

        public override object OnGet(UserService request)
        {
            return new UserManage().GetBaseUserInfo(request.userId);

        }

    }

    #endregion
}
