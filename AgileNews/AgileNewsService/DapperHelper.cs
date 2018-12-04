using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Net.Configuration;

using Dapper;
using System;
using System.Linq;

namespace AgileNewsCommon
{
    using AgileNewsEntity;
    public class DapperHelper
    {
        public static string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        /// <summary>
        /// 获取连接数据库的字符串
        /// </summary>
        /// <returns></returns>
        public static System.Data.SqlClient.SqlConnection GetConnString()
        {
            return new System.Data.SqlClient.SqlConnection(connString);
        }

        /// <summary>
        /// 公共分页方法
        /// </summary>
        /// <typeparam name="T">表名</typeparam>
        /// <param name="criteria">分页对象</param>
        /// <returns></returns>
        public static PageDataView<T> GetPageData<T>(PageCriteria criteria)
        {
            using (SqlConnection conn = GetConnString())
            {
                conn.Open();

                DynamicParameters parms = new DynamicParameters();
                parms.Add("@TableName", criteria.TableName, DbType.String, ParameterDirection.Input, null);
                parms.Add("@PrimaryKey", criteria.PrimaryKey, DbType.String, ParameterDirection.Input, null);
                parms.Add("@Fields", criteria.Fields, DbType.String, ParameterDirection.Input, null);
                parms.Add("@Condition", criteria.Condition, DbType.String, ParameterDirection.Input, null);
                parms.Add("@CurrentPage", criteria.CurrentPage, DbType.Int32, ParameterDirection.Input, null);
                parms.Add("@PageSize", criteria.PageSize, DbType.Int32, ParameterDirection.Input, null);
                parms.Add("@Sort", criteria.Sort, DbType.String, ParameterDirection.Input, null);
                parms.Add("@RecordCount", criteria.RecordCount, DbType.Int32, ParameterDirection.Output, null);

                string proName = "ProcGetPageData";
                var pageData = new PageDataView<T>();
                pageData.Items = conn.Query<T>(proName, parms,CommandType.StoredProcedure).ToList();
                conn.Close();

                pageData.TotalNum = parms.Get<int>("RecordCount");
                pageData.TotalPageCount = Convert.ToInt32(Math.Ceiling(pageData.TotalNum * 1.0 / criteria.PageSize));
                pageData.CurrentPage = criteria.CurrentPage > pageData.TotalPageCount ? pageData.TotalPageCount : criteria.CurrentPage;
                return pageData;
            }
        }
    }
}
