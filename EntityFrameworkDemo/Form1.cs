using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            LoadProducts();



        }

        private void LoadProducts()
        {


            using (ETradeContext context = new ETradeContext())
            {

                dgwProducts.DataSource = context.Products.ToList();


            }
        }

        private void SearchProducts(string key)
        {


            //var result = _productDal.GetAll().Where(p=>p.Name.ToLower().Contains(key.ToLower())).ToList();


            var result = _productDal.GetByName(key);
            
            dgwProducts.DataSource = result;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product

            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value.ToString()),
                Name = txtUpdateName.Text,
                UnitPrice = Convert.ToDecimal(txtUniUpdate.Text),
                StockAmount = Convert.ToInt32(txtStockUpdate.Text)

                


            });

            LoadProducts();
            MessageBox.Show("Updated!");


        }

        ProductDal _productDal = new ProductDal();

       

        private void btnAdd_Click(object sender, EventArgs e)
        {

            _productDal.Add(new Product
            {

                Name = tbxName.Text,
                UnitPrice = Convert.ToDecimal(tbxunitPrice.Text),
                StockAmount = Convert.ToInt32(tbxstockAmount.Text)
                  

             });

            LoadProducts();

            MessageBox.Show("Ürün Eklendi");

        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            

            txtUpdateName.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            txtUniUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            txtStockUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {


            _productDal.Delete(new Product
            {





                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value.ToString())



            });


            LoadProducts();
            MessageBox.Show("Deleted");


        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {



            SearchProducts(tbxSearch.Text);


        }

        private void tbxGetById_Click(object sender, EventArgs e)
        {
            _productDal.GetById(10);
        }
    }
}
