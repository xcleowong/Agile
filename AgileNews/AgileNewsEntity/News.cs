using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileNewsEntity
{
    /// <summary>
    /// 新聞實體信息
    /// </summary>
    public class News
    {
        /// <summary>
        /// 新聞ID
        /// </summary>
        public int NewsID { get; set; }

        /// <summary>
        /// 新聞標題
        /// </summary>
        public string NewsTitle { get; set; }

        /// <summary>
        /// 新聞內容
        /// </summary>
        //public string NewsContent { get; set; }

        /// <summary>
        /// 新闻发布人
        /// </summary>
        public string NewsPublisher { get; set; }

        /// <summary>
        /// 新闻发布时间
        /// </summary>
        public DateTime? NewsPublishDate { get; set; }

        /// <summary>
        /// 新闻细节
        /// </summary>
        public string NewsDetails { get; set; }

        /// <summary>
        /// 新闻排序
        /// </summary>
        public int NewsSort { get; set; }

        /// <summary>
        /// 新闻阅读人数
        /// </summary>
        public int NewsReader { get; set; }

        /// <summary>
        /// 新闻修改时间
        /// </summary>
        public DateTime? NewsUpdateDate { get; set; }

        /// <summary>
        /// 新闻类型外键
        /// </summary>
        public string NewsTypeID { get; set; }

    }
}
