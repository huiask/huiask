using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuiWen.DAL
{
    public class UserManage : UserDalBase
    {
        #region 获取用户基础信息
        /// <summary>
        /// 获取用户基础信息
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public int GetBaseUserInfo(int userId)
        {
            return userId;
//            const string sqlQuery = @"select userid
//                                        ,nickname
//                                        ,password
//                                        ,answer
//                                        ,verifycount
//                                        ,verifytime
//                                        ,verifycode
//                                        ,multionline,TradeVerify,TradeVerify_Time
//                                        ,flag
//                                    from [ah_user]
//                                    where userid = @userid";
//            return DbContext.Execute(conn => conn.Query<int>(sqlQuery, new { userid = userId }).FirstOrDefault());
        }
        #endregion
    }
}
