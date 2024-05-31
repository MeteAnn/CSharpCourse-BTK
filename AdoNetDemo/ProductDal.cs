using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    public class ProductDal
    {
        SqlConnection _connection = new SqlConnection(@"Server=(localdb)\mssqllocaldb;initial catalog=ETrade;integrated security=true");
        public List<Product> GetAll2()
        {


            ConnectionControl();

            

            SqlCommand command = new SqlCommand("select * from Products", _connection);

            SqlDataReader reader = command.ExecuteReader();

            List<Product> products = new List<Product>();

            while (reader.Read())
            {

                Product product = new Product()
                {

                    Id = Convert.ToInt32(reader["Id"]),
                    Name = Convert.ToString(reader["Name"]),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"])


                };

                products.Add(product);
                


            }

            reader.Close();
            _connection.Close();
            return products;
        }



        public DataTable GetAll()
        {

            ConnectionControl();

            SqlCommand command = new SqlCommand("select * from Products", _connection);

            SqlDataReader reader = command.ExecuteReader();

            DataTable datatable = new DataTable();

            datatable.Load(reader);

            reader.Close();

            _connection.Close();

            return datatable;

        }
       


       

        public void Add(Product product)
        {

            ConnectionControl();

            SqlCommand command = new SqlCommand("Insert into Products values(@name, @unitPrice, @StockAmount)",_connection);

            command.Parameters.AddWithValue("@name",product.Name);

            command.Parameters.AddWithValue("@unitprice", product.UnitPrice);

            command.Parameters.AddWithValue("@stockamount", product.StockAmount);

            

            command.ExecuteNonQuery();
            _connection.Close();

        }

        public void Update(Product product)
        {

            ConnectionControl();

            SqlCommand command = new SqlCommand("update Products Set Name=@Name, UnitPrice=@UnitPrice, StockAmount=@StockAmount where Id=@id)", _connection);

            command.Parameters.AddWithValue("@name", product.Name);

            command.Parameters.AddWithValue("@unitprice", product.UnitPrice);

            command.Parameters.AddWithValue("@stockamount", product.StockAmount);

            command.Parameters.AddWithValue("@id",product.Id);



            command.ExecuteNonQuery();
            _connection.Close();

        }
        public void Remove(int id)
        {

            ConnectionControl();

            SqlCommand command = new SqlCommand("Delete from Products where Id=@id)", _connection);

            command.Parameters.AddWithValue("@id", id);

    
            command.ExecuteNonQuery();
            _connection.Close();

        }




        public void ConnectionControl()
        {

            if (_connection.State==ConnectionState.Closed)
            {
                _connection.Open();
            }



        }

    }
}
