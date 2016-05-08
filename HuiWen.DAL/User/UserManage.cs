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
        public string GetNickNameByUserId(int userId)
        {
            string sqlQuery = "select NickName from ah_user where UserId=@userId";
            return DbContext.Execute(conn => conn.Query<string>(sqlQuery, new { userid = userId }).FirstOrDefault());
        }
        #endregion
    }
}
