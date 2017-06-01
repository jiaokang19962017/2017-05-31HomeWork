using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Book<T>
    {
        public T Price { get; set; }
        public T Title { get; set; }
        public Book()
        {
                
        }
    }
}
