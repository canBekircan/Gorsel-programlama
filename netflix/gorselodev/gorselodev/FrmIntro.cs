using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorselodev
{
    public partial class FrmIntro : Form
    {
        public FrmIntro()
        {
            InitializeComponent();
            
            axWindowsMediaPlayer1.URL = Application.StartupPath + @"\Resources\intro.mp4";
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.stretchToFit = true;
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
           
        }

        private void FrmIntro_Load(object sender, EventArgs e)
        {
            
            
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            
            if (e.newState == 8)
            {
                this.Close(); 
            }
        }
    }
}
