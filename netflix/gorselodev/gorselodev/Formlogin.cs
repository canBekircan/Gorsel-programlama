using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorselodev
{
    public partial class Formlogin : Form
    {
        public Formlogin()
        {
            InitializeComponent();
        }

        private void Formlogin_Load(object sender, EventArgs e)
        {
            txtkullanici.Focus();
            txtsifre.Focus();
            

            this.AcceptButton = Btngiris;
            
        }

        private void Btngiris_Click(object sender, EventArgs e)
        {

            string user = txtkullanici.Text.Trim();
            string pass = txtsifre.Text.Trim();

            using (SqlConnection conn = DbManager.GetConnection())
            {
                string query = "SELECT Id, KullaniciAdi FROM Kullanicilar WHERE KullaniciAdi=@u AND Sifre=@p";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@u", user);
                cmd.Parameters.AddWithValue("@p", pass);

                try
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {

                        UserSession.SeciliKullaniciId = Convert.ToInt32(dr["Id"]);
                        UserSession.KullaniciAdi = dr["KullaniciAdi"].ToString();
                        this.Hide();

                        FrmIntro intro = new FrmIntro();
                        intro.ShowDialog(); 
                        Form1 anaForm = new Form1();
                        anaForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Hatalı giriş!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frmkayit frmkayit = new Frmkayit();
            frmkayit.Show();
            this.Hide();
        }

        private void Lbl_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
