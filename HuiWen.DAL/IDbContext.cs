using System;
using System.Data.SqlClient;

namespace HuiWen.Dal
{
    /// <summary>
    /// 数据库操作接口
    /// </summary>
    public interface IDbContext
    {
        /// <summary>
        /// 获取数据库链接字符串
        /// </summary>
        /// <param name="name">配置名称</param>
        /// <returns></returns>
        string GetConnectionString(string name);
        /// <summary>
        /// 对数据库执行操作
        /// </summary>
        /// <param name="action">委托，为用户传入已打开的SqlConnection对象，方法使用完毕后自动关闭数据库连接</param>
        /// <param name="useWriteConn">读/写分离库选择，默认使用写数据库</param>
        void Execute(Action<SqlConnection> action, bool useWriteConn = true);
        /// <summary>
        /// 对数据库执行操作并返回结果数据
        /// </summary>
        /// <typeparam name="T">要返回的数据类型</typeparam>
        /// <param name="func">委托，为用户传入已打开的SqlConnection对象，方法使用完毕后自动关闭数据库连接，并返回数据结果</param>
        /// <param name="useWriteConn">读/写分离库选择，默认使用写数据库</param>
        /// <returns>返回的数据</returns>
        T Execute<T>(Func<SqlConnection, T> func, bool useWriteConn = true);
    }
}
