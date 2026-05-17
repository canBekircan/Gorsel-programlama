using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace gorselodev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void Form1_Load(object sender, EventArgs e)
        {
            interpicture.Tag = 4;
            ataturkpicture.Tag = 2;
            illegalpicture.Tag = 3;
            Loupicture.Tag = 5;
            btnizle.Tag = 1;
           

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            if (pb == null || pb.Tag == null) return;

            int filmId = Convert.ToInt32(pb.Tag);
            int aktifKullaniciId = UserSession.SeciliKullaniciId;

            using (SqlConnection conn = DbManager.GetConnection())
            {
                try
                {
                    conn.Open();

                   
                    string historyQuery = "INSERT INTO IzlemeGecmisi (KullaniciId, FilmId, IzlemeTarihi) VALUES (@uid, @fid, GETDATE())";
                    SqlCommand cmdHistory = new SqlCommand(historyQuery, conn);
                    cmdHistory.Parameters.AddWithValue("@uid", aktifKullaniciId);
                    cmdHistory.Parameters.AddWithValue("@fid", filmId);
                    cmdHistory.ExecuteNonQuery();

                    
                    string linkQuery = "SELECT FragmanLink FROM Filmler WHERE Id = @fid";
                    SqlCommand cmdLink = new SqlCommand(linkQuery, conn);
                    cmdLink.Parameters.AddWithValue("@fid", filmId);
                    object linkObj = cmdLink.ExecuteScalar();

                    if (linkObj != null && linkObj != DBNull.Value)
                    {
                        string url = linkObj.ToString();

                        
                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                        {
                            FileName = url,
                            UseShellExecute = true 
                        });
                    }
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
           
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_sonizlenen_Click_1(object sender, EventArgs e)
        {
            FrmIzlenenler izlenenForm = new FrmIzlenenler();
            izlenenForm.Show();
            this.Hide();
        }

        private void btnizle_Click(object sender, EventArgs e)
        {


            Button btnizle = sender as Button;
            if (btnizle == null || btnizle.Tag == null) return;

            int filmId = Convert.ToInt32(btnizle.Tag);
            int aktifKullaniciId = UserSession.SeciliKullaniciId;

            using (SqlConnection conn = DbManager.GetConnection())
            {
                try
                {
                    conn.Open();


                    string historyQuery = "INSERT INTO IzlemeGecmisi (KullaniciId, FilmId, IzlemeTarihi) VALUES (@uid, @fid, GETDATE())";
                    SqlCommand cmdHistory = new SqlCommand(historyQuery, conn);
                    cmdHistory.Parameters.AddWithValue("@uid", aktifKullaniciId);
                    cmdHistory.Parameters.AddWithValue("@fid", filmId);
                    cmdHistory.ExecuteNonQuery();


                    string linkQuery = "SELECT FragmanLink FROM Filmler WHERE Id = @fid";
                    SqlCommand cmdLink = new SqlCommand(linkQuery, conn);
                    cmdLink.Parameters.AddWithValue("@fid", filmId);
                    object linkObj = cmdLink.ExecuteScalar();

                    if (linkObj != null && linkObj != DBNull.Value)
                    {
                        string url = linkObj.ToString();


                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                        {
                            FileName = url,
                            UseShellExecute = true
                        });
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
