using System.Linq;
using System.Data;

namespace HuiWen.Dal
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

        #region 新建用户
        /// <summary>
        /// 新建用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int AddUser(UserEntity user)
        {
            return DbContext.Execute(conn => conn.Execute("[ProcChangeUserTag]", new { NickName = user.NickName, Password = user.Password, Mobile = user.Mobile, Email = user.Email, qq = user.QQ }, commandType: CommandType.StoredProcedure));
        }
        #endregion

        #region 获取用户所有信息
        /// <summary>
        /// 获取用户所有信息
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public UserEntity GetUserInfo(int userId)
        {
            string sqlQuery = "select * from AskUser as a left join AskUserD as b on a.UserId = b.UserId where a.userId = @userId";
            return DbContext.Execute(conn => conn.Query<UserEntity>(sqlQuery, new { userId = userId }).FirstOrDefault());
        }
        #endregion
    }
}
