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
    /// <summary>
    /// 新聞實現層
    /// </summary>
    public class NewsService : INewsService
    {
        /// <summary>
        /// 顯示新聞信息
        /// </summary>
        /// <returns></returns>
        public List<News> GetNews()
        {
            List<News> listNews = new List<News>();
            News news = null;

            news = new News();
            news.NewsID = 1;
            news.NewsTitle = "習主席出國訪問";
            news.NewsContent = "彰顯大國風範";
            listNews.Add(news);

            news = new News();
            news.NewsID = 1;
            news.NewsTitle = "中國盡顯大國風範";
            news.NewsContent = "我的祖國是中國";
            listNews.Add(news);

            news = new News();
            news.NewsID = 1;
            news.NewsTitle = "中國科技迅猛發展";
            news.NewsContent = "科學技術日新月異";
            listNews.Add(news);

            return listNews;
        }
    }
}
