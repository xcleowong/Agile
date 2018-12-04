using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAgileNewsService
{
    using AgileNewsEntity;
    /// <summary>
    /// 新聞接口
    /// </summary>
    public interface INewsService
    {
        /// <summary>
        /// 顯示新聞信息
        /// </summary>
        /// <returns></returns>
        List<News> GetNews();


    }
}
