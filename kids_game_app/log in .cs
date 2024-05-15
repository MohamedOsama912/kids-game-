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

    public partial class log_in_frm : Form
    {
        SoundPlayer login_click_effect = new SoundPlayer(@"maro-jump-sound-effect_1.wav");
        SoundPlayer login_command_sound = new SoundPlayer(@"commands_sound\load.wav");
        SoundPlayer back_arrow = new SoundPlayer(@"back_effect.wav");
        bool chickExit = true;
        public log_in_frm()
        {
            InitializeComponent();

        }

        private void log_in__button_Click(object sender, EventArgs e)
        {
            login_command_sound.Stop();
            login_click_effect.Play();
            dbconnection db = new dbconnection();
            string user_name = login_txt.Text;
            string name_of_user = login_name_txt.Text;
            if (!string.IsNullOrWhiteSpace(user_name) && !string.IsNullOrWhiteSpace(name_of_user))
            {
                var check = db.users.Where(a => a.UserName == user_name && a.Name == name_of_user).FirstOrDefault();
                if (check != null)
                {
                    MessageBox.Show(" welcome you are in ");
                    new enter_the_game_frm().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("there is no user of this name or username");
                }
            }
            else
            {
                MessageBox.Show("empty cell");
            }

        }

        private void login_spkr_btn_Click(object sender, EventArgs e)
        {
            login_command_sound.Play();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {

            login_command_sound.Stop();
            back_arrow.Play();
            chickExit = false;
            Application.OpenForms[0].Show();
            this.Close();
        }

        private void log_in_frm_Load(object sender, EventArgs e)
        {

        }

        private void user_name_label_Click(object sender, EventArgs e)
        {

        }

        private void log_in_frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (chickExit) Application.Exit();
        }
    }
}
