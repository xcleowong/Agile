using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileNewsEntity
{
  public  class ProductOneToMore
    {
        public virtual int ProductID { get; set; }
        public virtual string ProductName { get; set; }
        public virtual string ProductDesc { get; set; }
        public virtual int UserID { get; set; }
        public virtual DateTime CreateTime { get; set; }
    }
}
