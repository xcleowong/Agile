using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileNewsEntity
{
    /// <summary>
    /// 定义一个用来装载适合所有类的分页结果类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PageDataView<T>
    {
        public int TotalNum { get; set; }

        public List<T> Items { get; set; }

        public int CurrentPage { get; set; }

        public int TotalPageCount { get; set; }
    }
}
