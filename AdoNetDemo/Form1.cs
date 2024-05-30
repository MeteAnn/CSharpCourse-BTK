using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProductDal _productDal1 = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {

            ProductDal productDal = new ProductDal();

            dgwProducts.DataSource = productDal.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            _productDal1.Add(new Product
            {
                Name = tbxName.Text,
                UnitPrice = Convert.ToDecimal(tbxunitPrice.Text),
                StockAmount = Convert.ToInt32(tbxstockAmount.Text)


            });

            MessageBox.Show("Added!");



        }
    }
}
