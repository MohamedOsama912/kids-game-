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
    public partial class sixth_quizzes_form : Form
    {
        string[] audio_path = { @"alphabet_sound\u.wav", @"alphabet_sound\v.wav", @"alphabet_sound\w.wav", @"alphabet_sound\x.wav", @"alphabet_sound\y.wav", @"alphabet_sound\z.wav", @"color_sound\purple.wav", @"color_sound\turquoise.wav" };
        string[] true_ans = { @"alphabets\u.jpeg", @"alphabets\v.jpeg", @"alphabets\w.jpeg", @"alphabets\x.jpeg", @"alphabets\y.jpeg", @"alphabets\z.jpeg", @"colors\11.jpeg", @"colors\12.jpeg" };
        string[] false_ans = { @"alphabets\a.jpeg", @"alphabets\b.jpeg", @"alphabets\v.jpeg", @"alphabets\r.jpeg", @"alphabets\c.jpeg", @"alphabets\o.jpeg", @"colors\9.jpeg", @"colors\7.jpeg" };
        int position = 0;
        bool chickExit = true;
        public sixth_quizzes_form()
        {
            InitializeComponent();
        }

        private void sixth_quizzes_form_Load(object sender, EventArgs e)
        {
            loadobject();
        }

        private void loadobject()
        {
            pic6_true.BackgroundImage = Image.FromFile(true_ans[position]);
            pic6_true.BackgroundImageLayout = ImageLayout.Stretch;
            pic6_false.BackgroundImage = Image.FromFile(false_ans[position]);
            pic6_false.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void next_button_Click(object sender, EventArgs e)
        {
            position++;
            if (position <= audio_path.Length - 1)
            {
                loadobject();
            }
            else
            {
                new motivational_form().Show();
                this.Hide();
            }
        }
        private void question_audio_button_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(audio_path[position]);
            player.Play();
        }
        private void back_home_button_Click(object sender, EventArgs e)
        {
            chickExit = false;
            Application.OpenForms[3].Show();
            this.Close();
        }

        private void pic2_true_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void sixth_quizzes_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (chickExit) Application.Exit();
        }

        private void true_ans6_btn_Click(object sender, EventArgs e)
        {
            SoundPlayer right = new SoundPlayer(@"right_effect.wav");
            right.Play();
            MessageBox.Show("right");
        }

        private void false_ans6_btn_Click(object sender, EventArgs e)
        {
            SoundPlayer wrong = new SoundPlayer(@"wrong_effect.wav");
            wrong.Play();
            MessageBox.Show("wrong");
        }
    }
}
