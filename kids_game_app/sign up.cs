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
    public partial class sign_up_frm : Form
    {
        SoundPlayer signup_command_effect = new SoundPlayer(@"commands_sound\new_start.wav");
        SoundPlayer back_effect = new SoundPlayer(@"back_effect.wav");
        SoundPlayer signup_click_effect = new SoundPlayer(@"maro-jump-sound-effect_1.wav");
        bool chickExit = true;

        public sign_up_frm()
        {
            InitializeComponent();
        }

        private void sign_up_Load(object sender, EventArgs e)
        {

        }

        private void signup_spkr_btn_Click(object sender, EventArgs e)
        {
            signup_command_effect.Play();
        }

        private void sign_up_btn_Click(object sender, EventArgs e)
        {
            signup_command_effect.Stop();
            signup_click_effect.Play();
            dbconnection db = new dbconnection();
            string user_name = signup_txt.Text;
            string name_of_user = name_txt.Text;
            if (!string.IsNullOrWhiteSpace(user_name) && !string.IsNullOrWhiteSpace(name_of_user))
            {
                user u1 = new user()
                {
                    UserName = signup_txt.Text,
                    Name = name_txt.Text

                };
                db.users.Add(u1);
                db.SaveChanges();
                new enter_the_game_frm().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("invalid values");
            }

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            signup_command_effect.Stop();
            back_effect.Play();
            chickExit = false;
            Application.OpenForms[0].Show();
            this.Close();
        }

        private void user_name_label_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sign_up_frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (chickExit) Application.Exit();
        }
    }
}
