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
    public partial class enter_the_game_frm : Form
    {
        SoundPlayer learn_command = new SoundPlayer(@"commands_sound\learning section.wav");
        SoundPlayer quiz_command = new SoundPlayer(@"commands_sound\quiz section.wav");
        SoundPlayer back_effect = new SoundPlayer(@"back_effect.wav");
        bool chickExit = true;
        public enter_the_game_frm()
        {
            InitializeComponent();
        }

        private void enter_learn_button_Click(object sender, EventArgs e)
        {

            new learn_levels_form().Show();
            this.Hide();
        }

        private void audio_learn_button_Click(object sender, EventArgs e)
        {
            learn_command.Play();
        }

        private void audio_quizzes_button_Click(object sender, EventArgs e)
        {
            quiz_command.Play();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            learn_command.Stop();
            quiz_command.Stop();
            back_effect.Play();
            chickExit = false;
            Application.OpenForms[0].Show();
            this.Close();

        }

        private void enter_quizzes_button_Click(object sender, EventArgs e)
        {
            new quizzes_levels_form().Show();
            this.Hide();
        }

        private void enter_the_game_frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (chickExit) Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user u1 = new user();
            MessageBox.Show("your score is " + u1.ScoreValue);
        }
    }
}
