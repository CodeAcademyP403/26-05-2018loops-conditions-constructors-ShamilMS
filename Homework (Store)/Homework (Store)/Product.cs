using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__Store_
{
    class Product
    {
        public string name { get; }
        public string weight { get; }
        public string cost { get; }
        public string expireDate { get; }
        public string category { get; }
        public string alert { get; }
        public int ProductID { get; }
        //Categories
        public static int ProdudctCount { get; private set; }
        public static int MeatCategoryID { get; private set; }
        public static int SweetCategoryID { get; private set; }
        public static int VegerableCategoryID { get; private set; }
        //.........


        public Product(string _name, string _weight, string _cost, string _expireDate, string _category)
        {
            if (_name != "" && Double.TryParse(_weight, out double result) && Double.TryParse(_cost, out double result2 )&& _expireDate != "" && _category != null && Convert.ToDouble(_weight) > 0 && Convert.ToDouble(_cost) > 0)
            {
                               
                this.name = _name;
                this.weight = _weight;
                this.cost = _cost;
                this.expireDate = _expireDate;
                this.ProductID = ProdudctCount;
                switch (_category)
                {
                    case "Meat":
                        this.category = _category;
                        MeatCategoryID++;
                        ProdudctCount++;
                        break;

                    case "Sweet":
                        this.category = _category;
                        SweetCategoryID++;
                        ProdudctCount++;
                        break;
                    case "Vegetable":
                        this.category = _category;
                        VegerableCategoryID++;
                        ProdudctCount++;
                        break;
                    default:
                        this.alert = "There is no such a category";
                        break;
                }
            }

            else
            {
                alert = "Please fill out correctly, and use comma as a floating point (not dot!)";
            }
        }
    }
}
