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
    public partial class Frmkayit : Form
    {
        public Frmkayit()
        {
            InitializeComponent();
        }

        private void Btngiris_Click(object sender, EventArgs e)
        {
            string user = txtkullanici.Text.Trim();
            string pass = txtsifre.Text.Trim();
            string mail = txtmail.Text.Trim();
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(mail))
            {
                MessageBox.Show("Lütfen boş alan bırakmayın!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = DbManager.GetConnection())
            {
                try
                {
                    conn.Open();
                    string checkQuery = "SELECT COUNT(*) FROM Kullanicilar WHERE KullaniciAdi = @u";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@u", user);

                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Bu kullanıcı adı zaten alınmış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string insertQuery = "INSERT INTO Kullanicilar (KullaniciAdi, Sifre, Eposta) VALUES (@u, @p, @e)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@u", user);
                    insertCmd.Parameters.AddWithValue("@p", pass);
                    insertCmd.Parameters.AddWithValue("@e", mail);

                    insertCmd.ExecuteNonQuery();

                    MessageBox.Show("Kaydınız başarıyla oluşturuldu! Giriş yapabilirsiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kayıt sırasında bir hata oluştu: " + ex.Message);
                }

            }

            Formlogin formlogin = new Formlogin();
            formlogin.Show();
            this.Close();
        }

        private void Lbl_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frmkayit_Load(object sender, EventArgs e)
        {

        }
    }
}
