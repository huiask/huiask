using System;
using System.Data.SqlClient;

namespace HuiWen.Dal
{
    /// <summary>
    /// 数据库操作
    /// </summary>
    public class DbContext : IDbContext
    {
        /// <summary>
        /// 读取数据的连接字符串名
        /// </summary>
        private string ReadConnectionName { get; set; }
        /// <summary>
        /// 写入数据的连接字符串名
        /// </summary>
        private string WriteConnectionName { get; set; }
        /// <summary>
        /// 构建函数
        /// </summary>
        /// <param name="readConnectionName">读取数据的连接字符串名</param>
        /// <param name="writeConnectionName">写入数据的连接字符串名</param>
        public DbContext(string readConnectionName, string writeConnectionName)
        {
            ReadConnectionName = readConnectionName;
            WriteConnectionName = writeConnectionName;
        }

        /// <summary> 
        /// 读取配置文件数据库连接字符串
        /// </summary>
        /// <param name="connectionName"></param>
        /// <returns></returns>
        public string GetConnectionString(string connectionName)
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
        }

        /// <summary>
        /// 对数据库执行操作
        /// </summary>
        /// <param name="action">委托，为用户传入已打开的SqlConnection对象，方法使用完毕后自动关闭数据库连接</param>
        /// <param name="useWriteConn">读/写分离库选择，默认使用写数据库</param>
        public void Execute(Action<SqlConnection> action, bool useWriteConn = true)
        {
            using (SqlConnection conn = new SqlConnection(GetConnectionString(useWriteConn ? WriteConnectionName : ReadConnectionName)))
            {
                conn.Open();
                action(conn);
                conn.Close();
            }
        }

        /// <summary>
        /// 对数据库执行操作并返回结果数据
        /// </summary>
        /// <typeparam name="T">要返回的数据类型</typeparam>
        /// <param name="func">委托，为用户传入已打开的SqlConnection对象，方法使用完毕后自动关闭数据库连接，并返回数据结果</param>
        /// <param name="useWriteConn">读/写分离库选择，默认使用写数据库</param>
        /// <returns>返回的数据</returns>
        public T Execute<T>(Func<SqlConnection, T> func, bool useWriteConn = true)
        {
            using (SqlConnection conn = new SqlConnection(GetConnectionString(useWriteConn ? WriteConnectionName : ReadConnectionName)))
            {
                conn.Open();
                T value = func(conn);
                conn.Close();
                return value;
            }
        }
    }
}
