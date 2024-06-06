using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace OrnekADO
{
    public class DAL
    {
        SqlConnection connection = new SqlConnection(@"Server=(localdb)\mssqllocaldb;initial catalog=ETrade;integrated security=true");

        public List<Personel> GetAll()
        {

            ConnectionControl();

            SqlCommand command = new SqlCommand("Select * from Personels",connection);

            SqlDataReader reader = command.ExecuteReader();


            List<Personel> personels = new List<Personel>();


            while (reader.Read())
            {
                Personel personel = new Personel()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = Convert.ToString(reader["Name"]),
                    Lastname = Convert.ToString(reader["Lastname"]),
                    Age = Convert.ToInt32(reader["Age"]),
                    Job = Convert.ToString(reader["Job"])

                };


                personels.Add(personel);

            }

            reader.Close();
            connection.Close();
            return personels;

        }



        public void Add(Personel personels)
        {

            ConnectionControl();
             
            SqlCommand command = new SqlCommand("Insert into Personels values(@Name, @Lastname, @Age, @Job)", connection);

            
            command.Parameters.AddWithValue("@Name", personels.Name);
            command.Parameters.AddWithValue("@Lastname", personels.Lastname);
            command.Parameters.AddWithValue("@Age", personels.Age);
            command.Parameters.AddWithValue("@Job", personels.Job);

            command.ExecuteNonQuery();



            connection.Close();


        }



        public void Update(Personel personels)
        {

            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Personels Set Name=@Name, Lastname=@Lastname, Age=@Age where Id=@Id", connection);

            command.Parameters.AddWithValue("@Id", personels.Id);
            command.Parameters.AddWithValue("@Name", personels.Name);
            command.Parameters.AddWithValue("@Lastname", personels.Lastname);
            command.Parameters.AddWithValue("@Age", personels.Age);
            command.Parameters.AddWithValue("@Job", personels.Job);

            command.ExecuteNonQuery();

            connection.Close(); 


        }


        public void Delete(int id)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("Delete from Personels where Id=@id",connection);

            command.Parameters.AddWithValue("@id",id);

            command.ExecuteNonQuery();

            connection.Close();


        }



        public void ConnectionControl()
        {
            if (connection.State == ConnectionState.Closed)
            {

                connection.Open();

            }

            


        }

    }
}
