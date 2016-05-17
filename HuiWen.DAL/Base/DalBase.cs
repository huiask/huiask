using System.Data;

namespace HuiWen.Dal
{
    /// <summary>
    /// 数据访问基类
    /// </summary>
    public class DalBase
    {
        public IDbContext DbContext { get; set; }
        protected DalBase(string readConnectionName, string writeConnectionName)
        {
            DbContext = new DbContext(readConnectionName, writeConnectionName);
        }

        /// <summary>
        /// 生成公共分页存储过程参数
        /// </summary>
        /// <param name="querySql">表名、视图名、查询语句</param>
        /// <param name="fieldOrder">排序字段列表</param>
        /// <param name="pageIndex">要显示的页</param>
        /// <param name="pageSize">每页的大小(行数)</param>
        /// <param name="fieldShow">要显示的字段列表(为空列出所有字段）</param>
        /// <param name="rows">为空时计算结果行数，否则不计算</param>
        /// <returns></returns>
        protected DynamicParameters PageParameters(string querySql, string fieldOrder, int pageIndex, int pageSize, string fieldShow = null, int? rows = null)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@QuerySql", querySql);
            parameters.Add("@PageIndex", pageIndex);
            parameters.Add("@PageSize", pageSize);
            parameters.Add("@FieldShow", fieldShow);
            parameters.Add("@FieldOrder", fieldOrder);
            parameters.Add("@Rows", rows, dbType: DbType.Int32, direction: ParameterDirection.Output);
            return parameters;
        }
    }
}
