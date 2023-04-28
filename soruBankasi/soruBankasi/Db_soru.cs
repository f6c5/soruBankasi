
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

        string connectionString = "server=localhost;database=db_soru;uid=root;password=1234;Allow User Variables=True";

        //***********************          login          **************************
        public Ogrenci logInOgrenci(string no)
        {
            Ogrenci ogrenci;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand("SELECT * FROM tbl_ogrenciler where no= @no ", connection))
                {

                    command.Parameters.AddWithValue("@no", no);
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

                using (MySqlCommand command = new MySqlCommand("SELECT * FROM tbl_ogretmenler where no=@no && pass=@sifre ", connection))
                {

                    command.Parameters.AddWithValue("@no", no);
                    command.Parameters.AddWithValue("@sifre", sifre);
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


        //***********************          register          **************************
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


        //***********************          get all          **************************
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


        //***********************          get one          **************************
        public Ogrenci getOgrenci(int ogrenciId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM tbl_ogrenciler WHERE id = @id";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", ogrenciId);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Ogrenci(reader.GetInt32("id"), reader.GetString("name"), reader.GetString("no"), reader.GetString("sinif"), reader.GetString("sube"));
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }
        public Ogretmen getOgretmen(int ogretmenId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM tbl_ogretmenler WHERE id = @id";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@id", ogretmenId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Ogretmen(reader.GetInt32("id"), reader.GetString("name"), reader.GetString("no"), reader.GetString("pass"));
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }


        //***********************          delete          **************************
        public void deleteOgrenci(int ogrenciId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM tbl_ogrenciler WHERE id = @id";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@id", ogrenciId);

                    int affectedRows = command.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        MessageBox.Show("öğrenci silindi");
                    }
                    else
                    {
                        MessageBox.Show("öğrenci silinemedi");
                    }
                }
            }
        }
        public void deleteOgretmen(int ogretmenId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM tbl_ogretmenler WHERE id = @id";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", ogretmenId);
                    int affectedRows = command.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        MessageBox.Show("öğretmen silindi");
                    }
                    else
                    {
                        MessageBox.Show("öğretmen silinemedi");
                    }
                }
            }
        }

        //***********************          update          **************************
        public void updateOgrenci(int ogrenciId, Ogrenci ogrenci)
        {

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE tbl_ogrenciler SET name = @name, no = @no, sinif = @sinif, sube = @sube WHERE id = @id";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", ogrenciId);
                    command.Parameters.AddWithValue("@name", ogrenci.getName());
                    command.Parameters.AddWithValue("@no", ogrenci.getNo());
                    command.Parameters.AddWithValue("@sinif", ogrenci.getSinif());
                    command.Parameters.AddWithValue("@sube", ogrenci.getSube());

                    int affectedRows = command.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        MessageBox.Show("öğrenci güncellendi");
                    }
                    else
                    {
                        MessageBox.Show("öğrenci güncellenemedi");
                    }
                }
            }
        }
        public void updateOgretmen(int ogretmenId, Ogretmen ogretmen)
        {

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE tbl_ogretmenler SET name = @name, no = @no, pass = @pass WHERE id = @id";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", ogretmenId);
                    command.Parameters.AddWithValue("@name", ogretmen.getName());
                    command.Parameters.AddWithValue("@no", ogretmen.getNo());
                    command.Parameters.AddWithValue("@pass", ogretmen.getSifre());

                    int affectedRows = command.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        MessageBox.Show("öğretmen güncellendi");
                    }
                    else
                    {
                        MessageBox.Show("öğretmen güncellenemedi");
                    }
                }
            }
        }

        //***********************          sınavlar         **************************
        public List<Sinav> getSinavlarim(int ogretmenId)
        {
            List<Sinav> sinavlar = new List<Sinav>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand("SELECT * FROM tbl_sinav HAVING ogretmen_id = @ogretmen_id ", connection))
                {
                    command.Parameters.AddWithValue("@ogretmen_id", ogretmenId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            sinavlar.Add(new Sinav(reader.GetInt32("id"), reader.GetInt32("ogretmen_id"), reader.GetString("sinav_adi"), reader.GetDateTime("sinav_tarihi")));
                        }
                    }
                }

                foreach (Sinav sinav in sinavlar)
                {
                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM db_soru.tbl_soru HAVING sinav_id= @sinav_id ", connection))
                    {
                        command.Parameters.AddWithValue("@sinav_id", sinav.getId());

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            List<Soru> sorular = new List<Soru>();
                            while (reader.Read())
                            {
                                sorular.Add(new Soru(reader.GetInt32("id"), reader.GetInt32("sinav_id"), reader.GetString("metin"), reader.GetString("a"), reader.GetString("b"), reader.GetString("c"), reader.GetString("d"), reader.GetString("e"), reader.GetString("cevap")));
                            }
                            sinav.setSinavSorulari(sorular);
                        }
                    }
                }

                connection.Close();
            }
            return sinavlar;

        }
        public void addSinav(string sinavAdi, int ogretmenId, DateTime sinavTarihi)
        {
            string query = "INSERT INTO tbl_sinav (ogretmen_id, sinav_adi, sinav_tarihi) VALUES (@ogretmen_id, @sinav_adi, @sinav_tarihi)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ogretmen_id", ogretmenId);
                    command.Parameters.AddWithValue("@sinav_adi", sinavAdi);
                    command.Parameters.AddWithValue("@sinav_tarihi", sinavTarihi);

                    int affectedRows = command.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        MessageBox.Show("sınav eklendi");
                    }
                    else
                    {
                        MessageBox.Show("sınav eklenemedi");
                    }
                }
            }
        }
        public void addSoru(Soru soru)
        {

            string query = "INSERT INTO tbl_soru (sinav_id, metin, a, b, c, d, e, cevap) VALUES (@sinav_id, @metin, @a, @b, @c, @d, @e, @cevap)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@sinav_id", soru.getSinavId());
                    command.Parameters.AddWithValue("@metin", soru.getMetin());
                    command.Parameters.AddWithValue("@a", soru.getA());
                    command.Parameters.AddWithValue("@b", soru.getB());
                    command.Parameters.AddWithValue("@c", soru.getC());
                    command.Parameters.AddWithValue("@d", soru.getD());
                    command.Parameters.AddWithValue("@e", soru.getE());
                    command.Parameters.AddWithValue("@cevap", soru.getCevap().ToCharArray()[0]);


                    int affectedRows = command.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        MessageBox.Show("soru eklendi");
                    }
                    else
                    {
                        MessageBox.Show("soru eklenemedi");
                    }
                }
            }
        }
        public void updateSoru(Soru soru)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE tbl_soru SET metin = @metin, a = @a, b = @b, c = @c, d = @d, e = @e, cevap = @cevap WHERE id = @id";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", soru.getId());
                    command.Parameters.AddWithValue("@metin", soru.getMetin());
                    command.Parameters.AddWithValue("@a", soru.getA());
                    command.Parameters.AddWithValue("@b", soru.getB());
                    command.Parameters.AddWithValue("@c", soru.getC());
                    command.Parameters.AddWithValue("@d", soru.getD());
                    command.Parameters.AddWithValue("@e", soru.getE());
                    command.Parameters.AddWithValue("@cevap", soru.getCevap().ToCharArray()[0]);

                    int affectedRows = command.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        MessageBox.Show("soru güncellendi");
                    }
                    else
                    {
                        MessageBox.Show("soru güncellenemedi");
                    }
                }
            }
        }
        public void deleteSoru(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM tbl_soru WHERE id = @id";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@id", id);

                    int affectedRows = command.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        MessageBox.Show("soru silindi");
                    }
                    else
                    {
                        MessageBox.Show("soru silinemedi");
                    }
                }
            }
        }
        public void deleteSinav(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM tbl_sinav WHERE id = @id";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@id", id);

                    int affectedRows = command.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        MessageBox.Show("sınav silindi");
                    }
                    else
                    {
                        MessageBox.Show("sınav silinemedi");
                    }
                }
            }
        }

        //***********************          notlar         **************************

    }
}
