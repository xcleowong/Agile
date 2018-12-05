using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileNewsEntity
{
    /// <summary>
    /// 新闻类别表
    /// </summary>
    public class NewsType
    {
        /// <summary>
        /// 新闻类型ID
        /// </summary>
        public int NewsTypeID { get; set; }
        /// <summary>
        /// 新闻类型名称
        /// </summary>
        public string NewsTypeName { get; set; }
        /// <summary>
        /// 新闻类型描述
        /// </summary>
        public string NewsTypeDesr { get; set; }
        /// <summary>
        /// 新闻类型修改时间
        /// </summary>
        public DateTime? NewsTypeUpdateDate { get; set; }
        /// <summary>
        /// 新闻类型外键PID
        /// </summary>
        public int NewsTypePID { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? NewsTypeCreate { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? NewsTypeUpdate { get; set; }



    }
}
