using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kids_game_app
{
    public partial class quizzes_levels_form : Form
    {
        bool chickExit = true;
        public quizzes_levels_form()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            chickExit = false;
            Application.OpenForms[2].Show();
            this.Close();
        }



        private void level1_button_Click(object sender, EventArgs e)
        {
            new first_quizzes_form().Show();
            this.Hide();
        }

        private void level2_button_Click(object sender, EventArgs e)
        {
            new second_quizzes_form().Show();
            this.Hide();
        }
        private void level3_button_Click(object sender, EventArgs e)
        {
            new third_quizzes_form().Show();
            this.Hide();
        }

        private void level4_button_Click(object sender, EventArgs e)
        {
            new fourth_quizzes_form().Show();
            this.Hide();
        }

        private void level5_button_Click(object sender, EventArgs e)
        {
            new fifth_quizzes_form().Show();
            this.Hide();
        }

        private void level6_button_Click(object sender, EventArgs e)
        {
            new sixth_quizzes_form().Show();
            this.Hide();
        }

        private void level1_audio_button_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"levels\l1.wav");
            player.Play();
        }

        private void level2_audio_button_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"levels\l2.wav");
            player.Play();
        }

        private void level3_audio_button_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"levels\l3.wav");
            player.Play();
        }

        private void level4_audio_button_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"levels\l4.wav");
            player.Play();
        }

        private void level5_audio_button_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"levels\l5.wav");
            player.Play();
        }

        private void level6_audio_button_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"levels\l6.wav");
            player.Play();
        }

        private void quizzes_levels_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (chickExit) Application.Exit();
        }
    }
}
