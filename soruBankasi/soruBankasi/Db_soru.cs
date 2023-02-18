
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soruBankasi
{
    internal class Db_soru
    {
        public void basla()
        {
            string connectionString = "server=localhost;database=db_soru;uid=root;password=1234;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand("SELECT * FROM tbl_ogretmenler", connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32("id");
                            string name = reader.GetString("name");

                            Console.WriteLine($"ID: {id}, Name: {name}");
                        }
                    }
                }
            }

        }
    }
}
