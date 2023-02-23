
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

        string connectionString = "server=localhost;database=db_soru;uid=root;password=1234;";


        public Ogrenci logInOgrenci(string no)
        {
            Ogrenci ogrenci;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand("SELECT * FROM tbl_ogrenciler where no=" + no + " ", connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ogrenci = new Ogrenci(reader.GetInt32("id"), reader.GetString("name"), reader.GetString("no"), reader.GetString("sinif"), reader.GetString("sube"));
                        }
                        else
                        {
                            ogrenci = null;
                        }
                    }
                }
                connection.Close();
            }
            return ogrenci;
        }

        public Ogretmen logInOgretmen(string no, string sifre)
        {
            Ogretmen ogretmen;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand("SELECT * FROM tbl_ogretmenler where no=" + no + " && pass=" + sifre + " ", connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ogretmen = new Ogretmen(reader.GetInt32("id"), reader.GetString("name"), reader.GetString("no"), reader.GetString("pass"));
                        }
                        else
                        {
                            ogretmen = null;
                        }
                    }
                }
                connection.Close();
            }
            return ogretmen;
        }



        public void addOgrenci(Ogrenci ogrenci)
        {
            string query = "INSERT INTO tbl_ogrenciler (name, no, sinif, sube) VALUES (@name, @no, @sinif, @sube)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", ogrenci.getName());
                    command.Parameters.AddWithValue("@no", ogrenci.getNo());
                    command.Parameters.AddWithValue("@sinif", ogrenci.getSinif());
                    command.Parameters.AddWithValue("@sube", ogrenci.getSube());

                    int affectedRows = command.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        MessageBox.Show("öğrenci eklendi");
                    }
                    else
                    {
                        MessageBox.Show("öğrenci eklenemedi");
                    }
                }
            }
        }

        public void addOgretmen(Ogretmen ogretmen)
        {
            string query = "INSERT INTO tbl_ogretmenler (name, no, pass) VALUES (@name, @no, @pass)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", ogretmen.getName());
                    command.Parameters.AddWithValue("@no", ogretmen.getNo());
                    command.Parameters.AddWithValue("@pass", ogretmen.getSifre());

                    int affectedRows = command.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        MessageBox.Show("öğretmen eklendi");
                    }
                    else
                    {
                        MessageBox.Show("öğretmen eklenemedi");
                    }
                }
            }
        }

        public List<Ogretmen> getOgretmenler()
        {
            List<Ogretmen> ogretmenler = new List<Ogretmen>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand("SELECT * FROM tbl_ogretmenler", connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ogretmenler.Add(new Ogretmen(reader.GetInt32("id"), reader.GetString("name"), reader.GetString("no"), reader.GetString("pass")));
                        }
                    }
                }
                connection.Close();
            }

            return ogretmenler;
        }

        public List<Ogrenci> getOgrenciler()
        {
            List<Ogrenci> ogrenciler = new List<Ogrenci>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand("SELECT * FROM tbl_ogrenciler", connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ogrenciler.Add(new Ogrenci(reader.GetInt32("id"), reader.GetString("name"), reader.GetString("no"), reader.GetString("sinif"), reader.GetString("sube")));
                        }
                    }
                }
                connection.Close();
            }

            return ogrenciler;
        }

    }
}
