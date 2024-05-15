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
    public partial class first_quizzes_form : Form
    {
        string[] audio_path = { @"alphabet_sound\a.wav", @"alphabet_sound\b.wav", @"alphabet_sound\c.wav", @"alphabet_sound\d.wav", @"number_sound\1.wav", @"number_sound\2.wav", @"number_sound\3.wav", @"number_sound\4.wav", @"color_sound\black.wav", @"color_sound\red.wav" };
        string[] true_ans = { @"alphabets\a.jpeg", @"alphabets\b.jpeg", @"alphabets\c.jpeg", @"alphabets\d.jpeg", @"numbers\one.jpeg", @"numbers\two.jpeg", @"numbers\three.jpeg", @"numbers\four.jpeg", @"colors\1.jpeg", @"colors\2.jpeg" };
        string[] false_ans = { @"alphabets\c.jpeg", @"alphabets\g.jpeg", @"alphabets\d.jpeg", @"alphabets\j.jpeg", @"numbers\nine.jpeg", @"numbers\seven.jpeg", @"numbers\one.jpeg", @"numbers\two.jpeg", @"colors\4.jpeg", @"colors\8.jpeg" };
        int position = 0;
        bool chickExit = true;
        public first_quizzes_form()
        {
            InitializeComponent();
        }



        private void first_quizzes_form_Load(object sender, EventArgs e)
        {
            loadobject();
        }

        private void loadobject()
        {
            pic_true.BackgroundImage = Image.FromFile(true_ans[position]);
            pic_true.BackgroundImageLayout = ImageLayout.Stretch;
            pic_false.BackgroundImage = Image.FromFile(false_ans[position]);
            pic_false.BackgroundImageLayout = ImageLayout.Stretch;

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

        private void first_quizzes_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (chickExit) Application.Exit();
        }

        private void true_ans_btn_Click(object sender, EventArgs e)
        {
            SoundPlayer right = new SoundPlayer(@"right_effect.wav");
            right.Play();
            MessageBox.Show("right");
        }

        private void false_ans_btn_Click(object sender, EventArgs e)
        {
            SoundPlayer wrong = new SoundPlayer(@"wrong_effect.wav");
            wrong.Play();
            MessageBox.Show("wrong");
        }
    }
}
