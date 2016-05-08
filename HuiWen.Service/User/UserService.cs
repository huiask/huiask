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
}
