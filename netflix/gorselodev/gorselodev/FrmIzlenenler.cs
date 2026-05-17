using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorselodev
{
    public partial class FrmIzlenenler : Form
    {
        public FrmIzlenenler()
        {
            InitializeComponent();
        }

        private void FrmIzlenenler_Load(object sender, EventArgs e)
        {
            IzlenenleriGetir();
        }
        private void IzlenenleriGetir()
        {
            pnlIzlenenler.Controls.Clear();

            using (SqlConnection conn = DbManager.GetConnection())
            {
                string query = @"
            SELECT F.Id, F.FilmAdi, F.ResimYolu, MAX(G.IzlemeTarihi) as SonIzleme
            FROM Filmler F
            INNER JOIN IzlemeGecmisi G ON F.Id = G.FilmId
            WHERE G.KullaniciId = @uid
            GROUP BY F.Id, F.FilmAdi, F.ResimYolu
            ORDER BY SonIzleme DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@uid", UserSession.SeciliKullaniciId);

                try
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        PictureBox pb = new PictureBox();
                        pb.Width = 150;
                        pb.Height = 220;
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.Margin = new Padding(10);
                        pb.Cursor = Cursors.Hand;

                        string dbYolu = dr["ResimYolu"].ToString();
                        string tamYol = Path.Combine(Application.StartupPath, dbYolu);

                        if (File.Exists(tamYol))
                        {
                            pb.ImageLocation = tamYol;
                        }
                        else
                        {
                            pb.BackColor = Color.FromArgb(35, 35, 35); 
                        }

                        ToolTip hint = new ToolTip();
                        hint.SetToolTip(pb, dr["FilmAdi"].ToString());

                        pnlIzlenenler.Controls.Add(pb);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Listeleme sırasında bir hata oluştu: " + ex.Message);
                }
            }

        }

        private void Lblana_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
