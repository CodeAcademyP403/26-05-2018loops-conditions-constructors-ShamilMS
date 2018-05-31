using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework__Store_
{
    public partial class Form1 : Form
    {


        #region Other
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            NameTextBox.Text = "";
            CategoryComboBox.Text = "";
            WeightTextBox.Text = "";
            CostTextBox.Text = "";
            ExpireTextBox.Text = "";

            NameTextBox.Focus();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        private void AddButton_Click(object sender, EventArgs e)
        {
            string ProductName = NameTextBox.Text;
            string ProductCategory = CategoryComboBox.Text;
            string ProductWeight = WeightTextBox.Text;
            string ProductCost = CostTextBox.Text;
            string ProductExpire = ExpireTextBox.Text;

            Product Good = new Product(ProductName, ProductWeight, ProductCost, ProductExpire, ProductCategory);
            StoreSystem.AddToSystem(Good);
            // All products are stored in array StoreSystem.List.
            
            StockProductTextBox.Text = Convert.ToString(Product.ProdudctCount);
            MeatCatTextBox.Text = Convert.ToString(Product.MeatCategoryID);
            SweetCatTextBox.Text = Convert.ToString(Product.SweetCategoryID);
            VegetableCatTextBox.Text = Convert.ToString(Product.VegerableCategoryID);
            AlertLabel.Text = Good.alert;

            NameTextBox.Text = "";
            CategoryComboBox.Text = "";
            WeightTextBox.Text="";
            CostTextBox.Text="";
            ExpireTextBox.Text="";

            NameTextBox.Focus();
        }

        
    }
}
