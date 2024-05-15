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
    public partial class fourth_quizzes_form : Form
    {
        string[] audio_path = { @"alphabet_sound\m.wav", @"alphabet_sound\n.wav", @"alphabet_sound\o.wav", @"alphabet_sound\p.wav", @"number_sound\13.wav", @"number_sound\14.wav", @"number_sound\15.wav", @"number_sound\16.wav", @"color_sound\green.wav", @"color_sound\orange.wav" };
        string[] true_ans = { @"alphabets\m.jpeg", @"alphabets\n.jpeg", @"alphabets\o.jpeg", @"alphabets\p.jpeg", @"numbers\thirteen.jpeg", @"numbers\fourteen.jpeg", @"numbers\fifteen.jpeg", @"numbers\sixteen.jpeg", @"colors\7.jpeg", @"colors\8.jpeg" };
        string[] false_ans = { @"alphabets\e.jpeg", @"alphabets\h.jpeg", @"alphabets\v.jpeg", @"alphabets\f.jpeg", @"numbers\three.jpeg", @"numbers\four.jpeg", @"numbers\five.jpeg", @"numbers\two.jpeg", @"colors\4.jpeg", @"colors\6.jpeg" };
        int position = 0;
        bool chickExit = true;
        public fourth_quizzes_form()
        {
            InitializeComponent();
        }

        private void fourth_quizzes_form_Load(object sender, EventArgs e)
        {
            loadobject();
        }

        private void loadobject()
        {
            pic4_true.BackgroundImage = Image.FromFile(true_ans[position]);
            pic4_true.BackgroundImageLayout = ImageLayout.Stretch;
            pic4_false.BackgroundImage = Image.FromFile(false_ans[position]);
            pic4_false.BackgroundImageLayout = ImageLayout.Stretch;
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

        private void false_fouthans_btn_Click(object sender, EventArgs e)
        {
            SoundPlayer right = new SoundPlayer(@"right_effect.wav");
            right.Play();
            MessageBox.Show("right");
        }

        private void false_ans4_btn_Click(object sender, EventArgs e)
        {
            SoundPlayer wrong = new SoundPlayer(@"wrong_effect.wav");
            wrong.Play();
            MessageBox.Show("wrong");
        }

        private void fourth_quizzes_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (chickExit) Application.Exit();
        }
    }
}
