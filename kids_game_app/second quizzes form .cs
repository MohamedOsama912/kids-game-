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
    public partial class second_quizzes_form : Form
    {
        string[] audio_path = { @"alphabet_sound\e.wav", @"alphabet_sound\f.wav", @"alphabet_sound\g.wav", @"alphabet_sound\h.wav", @"number_sound\5.wav", @"number_sound\6.wav", @"number_sound\7.wav", @"number_sound\8.wav", @"color_sound\brown.wav", @"color_sound\pink.wav" };
        string[] true_ans = { @"alphabets\e.jpeg", @"alphabets\f.jpeg", @"alphabets\g.jpeg", @"alphabets\h.jpeg", @"numbers\five.jpeg", @"numbers\six.jpeg", @"numbers\seven.jpeg", @"numbers\eight.jpeg", @"colors\3.jpeg", @"colors\4.jpeg" };
        string[] false_ans = { @"alphabets\i.jpeg", @"alphabets\g.jpeg", @"alphabets\l.jpeg", @"alphabets\a.jpeg", @"numbers\nine.jpeg", @"numbers\seven.jpeg", @"numbers\one.jpeg", @"numbers\two.jpeg", @"colors\4.jpeg", @"colors\8.jpeg" };
        int position = 0;
        bool chickExit = true;
        public second_quizzes_form()
        {
            InitializeComponent();
        }

        private void second_quizzes_form_Load(object sender, EventArgs e)
        {
            loadobject();
        }

        private void loadobject()
        {
            pic2_true.BackgroundImage = Image.FromFile(true_ans[position]);
            pic2_true.BackgroundImageLayout = ImageLayout.Stretch;
            pic2_false.BackgroundImage = Image.FromFile(false_ans[position]);
            pic2_false.BackgroundImageLayout = ImageLayout.Stretch;
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

        private void backhome_btn_Click(object sender, EventArgs e)
        {
            chickExit = false;
            Application.OpenForms[3].Show();
            this.Close();
        }

        private void second_quizzes_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (chickExit) Application.Exit();
        }

        private void true_ans2_btn_Click(object sender, EventArgs e)
        {
            SoundPlayer right = new SoundPlayer(@"right_effect.wav");
            right.Play();
            MessageBox.Show("right");
        }

        private void false_ans2_btn_Click(object sender, EventArgs e)
        {
            SoundPlayer wrong = new SoundPlayer(@"wrong_effect.wav");
            wrong.Play();
            MessageBox.Show("wrong");

        }

        private void pic2_true_Click(object sender, EventArgs e)
        {

        }
    }
}
