using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bestaurants
{
    class Category
    {
        public String _categoryname { get; set; }
        public int _categorycode { get; set; }
      

        public override string ToString()
        {
            return _categoryname;
        }
    }
}
