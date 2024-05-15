using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using kids_game_app.data;

namespace kids_game_app
{

    public partial class motivational_form : Form
    {
        SoundPlayer rewarding_effect = new SoundPlayer(@"level_up.wav");
        bool chickExit = true;
        public motivational_form()
        {
            InitializeComponent();
        }

        private void motivational_form_Load(object sender, EventArgs e)
        {
            rewarding_effect.Play();
        }

        private void enter_the_fame_back_Click(object sender, EventArgs e)
        {
            chickExit = false;
            Application.OpenForms[2].Show();
            this.Close();
        }

        private void motivational_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (chickExit) Application.Exit();
        }
    }
}
