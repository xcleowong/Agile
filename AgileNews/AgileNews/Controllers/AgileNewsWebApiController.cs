using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AgileNews.Controllers
{
    using AgileNewsCache;
    using AgileNewsCommon;
    using AgileNewsEntity;
    using AgileNewsService;
    using IAgileNewsService;
    using Unity.Attributes;
    using Newtonsoft.Json;
    using System.Web.Security;
    [RoutePrefix("AgileNewsWebApi")]
    public class AgileNewsWebApiController : ApiController
    {
        [Dependency]
        public INewsService newsService { get; set; }//顯示新聞信息

        /// <summary>
        /// 顯示新聞信息數據
        /// </summary>
        /// <returns></returns>
        [Route("DisplayNews")]
        [HttpGet]
        public List<News> DisplayNews()
        {
            var list = newsService.GetNews();
            return list;
        }


    }
}
