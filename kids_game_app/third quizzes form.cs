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
    public partial class third_quizzes_form : Form
    {
        string[] audio_path = { @"alphabet_sound\i.wav", @"alphabet_sound\j.wav", @"alphabet_sound\k.wav", @"alphabet_sound\l.wav", @"number_sound\9.wav", @"number_sound\10.wav", @"number_sound\11.wav", @"number_sound\12.wav", @"color_sound\grey.wav", @"color_sound\yellow.wav" };
        string[] true_ans = { @"alphabets\i.jpeg", @"alphabets\j.jpeg", @"alphabets\k.jpeg", @"alphabets\l.jpeg", @"numbers\nine.jpeg", @"numbers\ten.jpeg", @"numbers\eleven.jpeg", @"numbers\twilve.jpeg", @"colors\5.jpeg", @"colors\6.jpeg" };
        string[] false_ans = { @"alphabets\e.jpeg", @"alphabets\p.jpeg", @"alphabets\v.jpeg", @"alphabets\s.jpeg", @"numbers\one.jpeg", @"numbers\seven.jpeg", @"numbers\four.jpeg", @"numbers\two.jpeg", @"colors\1.jpeg", @"colors\10.jpeg" };
        int position = 0;
        bool chickExit = true;
        public third_quizzes_form()
        {
            InitializeComponent();
        }

        private void third_quizzes_form_Load(object sender, EventArgs e)
        {
            loadobject();
        }

        private void loadobject()
        {
            pic3_true.BackgroundImage = Image.FromFile(true_ans[position]);
            pic3_true.BackgroundImageLayout = ImageLayout.Stretch;
            pic3_false.BackgroundImage = Image.FromFile(false_ans[position]);
            pic3_false.BackgroundImageLayout = ImageLayout.Stretch;
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

        private void ans2_button_Click(object sender, EventArgs e)
        {
            SoundPlayer wrong = new SoundPlayer(@"wrong_effect.wav");
            wrong.Play();
            MessageBox.Show("wrong");
        }

        private void ans1_button_Click(object sender, EventArgs e)
        {
            SoundPlayer right = new SoundPlayer(@"right_effect.wav");
            right.Play();
            MessageBox.Show("right");
        }

        private void third_quizzes_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (chickExit) Application.Exit();
        }
    }
}
