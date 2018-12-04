using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileNewsService
{
    using AgileNewsEntity;
    using IAgileNewsService;
    using Newtonsoft.Json;
    using AgileNewsCommon;
    using System.Net.Http;
    using AgileNewsCache;
    using Dapper;
    using System.Data.SqlClient;
    public class UserDAL
    {
        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <returns></returns>
        public List<Users> ListUsers()
        {
            using (SqlConnection sqlConnection = DapperHelper.GetConnString())
            {
                sqlConnection.Open();
                string connectionString = string.Format("select * from Users");
                IEnumerable<Users> result = sqlConnection.Query<Users>(connectionString, null);
                return result.ToList<Users>();

            }
        }

        /// <summary>
        /// 根据ID获取用户信息
        /// </summary>
        /// <param name="UserID"></param>
        /// <returns></returns>
        public Users GetAloneUsers(int UserID)
        {
            using (SqlConnection sqlConnection = DapperHelper.GetConnString())
            {
                sqlConnection.Open();
                string connectionString = string.Format("select * from Users where UserID=@UserID");
                var result = sqlConnection.Query<Users>(connectionString, new { UserID = UserID }).SingleOrDefault();
                return result;
            }
        }

        /// <summary>
        /// 添加用户信息
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public int AddUsers(Users users)
        {
            using (SqlConnection sqlConnection = DapperHelper.GetConnString())
            {
                sqlConnection.Open();
                string connectionString = string.Format("insert into Users(UserName,Email,[Address]) values(@UserName,@Email,@Address)");
                int i = sqlConnection.Execute(connectionString, users);
                return i;
            }

        }

        /// <summary>
        /// 批量添加用户信息
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public int AddGroupUsers(List<Users> users)
        {
            using (SqlConnection sqlConnection = DapperHelper.GetConnString())
            {
                sqlConnection.Open();
                string connectionString = string.Format("insert into Users(UserName,Email,[Address]) values(@UserName,@Email,@Address)");
                int i = sqlConnection.Execute(connectionString, users);
                return i;
            }

        }

        /// <summary>
        /// 多表联查
        /// </summary>
        /// <returns></returns>
        public List<UserOneToMore> usersListForOneToMore()
        {
            List<UserOneToMore> userList = new List<UserOneToMore>();
            using (SqlConnection sqlConnection = DapperHelper.GetConnString())
            {
                sqlConnection.Open();
                string connectionString = string.Format(@"select * from Users inner join Product on Users.UserID=Product.UserID");
                var LookUp = new Dictionary<int, Users>();
                userList = sqlConnection.Query<UserOneToMore, ProductOneToMore, UserOneToMore>(connectionString,(Users,Product)=> {
                    Users.Productlist.Add(Product);
                    return Users;
                },null,null,true,"UserID",null,null).ToList();
                return userList;
            }

        }





    }
}
