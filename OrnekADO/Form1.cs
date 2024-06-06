using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrnekADO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        DAL dal = new DAL();



        private void dgwListele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {






        }

        private void LoadPersonel()
        {

            dgwListele.DataSource = dal.GetAll();


        }
        private void Form1_Load(object sender, EventArgs e)
        {


            LoadPersonel();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            dal.Add(new Personel 
            { 
                Name = txtName.Text, 
                Lastname = txtLastName.Text,
                Age = Convert.ToInt32(txtYas.Text),
                Job = txtMeslek.Text
            
            });

            LoadPersonel();
            MessageBox.Show("Personel Eklenmiştir!");

        }

        private void dgwListele_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtName.Text = dgwListele.CurrentRow.Cells[1].Value.ToString();
            txtLastName.Text = dgwListele.CurrentRow.Cells[2].Value.ToString();
            txtYas.Text = dgwListele.CurrentRow.Cells[3].Value.ToString(); 
            txtMeslek.Text = dgwListele.CurrentRow.Cells[4].Value.ToString();



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            Personel personels = new Personel
            {
                Id = Convert.ToInt32(dgwListele.CurrentRow.Cells[0].Value),
                Name = txtName.Text,
                Lastname = txtLastName.Text,
                Age = Convert.ToInt32(txtYas.Text),
                Job = txtMeslek.Text

            };

            dal.Update(personels);
            LoadPersonel();
            MessageBox.Show("Güncellendi!");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {


            int id = Convert.ToInt32(dgwListele.CurrentRow.Cells[0].Value);

            dal.Delete(id);

            LoadPersonel();

            MessageBox.Show("Deleted!");




        }
    }
}
