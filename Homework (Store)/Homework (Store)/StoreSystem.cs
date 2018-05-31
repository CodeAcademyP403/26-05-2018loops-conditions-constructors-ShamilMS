using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__Store_
{
    class StoreSystem
    {
        public static Product[] List { get; private set; } = new Product[500]; // 500 length is just for example
        public static int ListIndex { get; private set; }
        public static void AddToSystem(Product newProduct)
        {
            List[ListIndex] = newProduct;
            ListIndex++;
        }
    }
}
