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

            LoadProducts();
            
        }

        private void LoadProducts()
        {

            dgwProducts.DataSource = _productDal1.GetAll();

        }
       


        private void btnAdd_Click(object sender, EventArgs e)
        {


            _productDal1.Add(new Product
            {
                Name = tbxName.Text,
                UnitPrice = Convert.ToDecimal(tbxunitPrice.Text),
                StockAmount = Convert.ToInt32(tbxstockAmount.Text)


            });

            LoadProducts();
            
            MessageBox.Show("Added!");



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            _productDal1.Update(new Product
            {

                Name = tbxName.Text,
                UnitPrice = Convert.ToDecimal(tbxunitPrice.Text),
                StockAmount = Convert.ToInt32(tbxstockAmount.Text)


            });

            LoadProducts();

            MessageBox.Show("Added!");
        }


        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            txtUpdateName.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();

            txtUniUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();

            txtStockUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();



        }

        private void button1_Click(object sender, EventArgs e)
        {


            Product product = new Product{

                Id =Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),

                Name = txtUpdateName.Text,

                UnitPrice = Convert.ToInt32(txtUniUpdate.Text),

                StockAmount = Convert.ToInt32(txtStockUpdate.Text)



            };

            _productDal1.Update(product);
            LoadProducts();
            MessageBox.Show("Update");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

           int id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value);

            _productDal1.Remove(id);
            LoadProducts();
            MessageBox.Show("Deleted!");



        }
    }
}
