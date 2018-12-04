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
        public string NewsContent { get; set; }
    }
}
