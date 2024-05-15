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
    public partial class fifth_quizzes_form : Form
    {
        string[] audio_path = { @"alphabet_sound\q.wav", @"alphabet_sound\r.wav", @"alphabet_sound\s.wav", @"alphabet_sound\t.wav", @"number_sound\17.wav", @"number_sound\18.wav", @"number_sound\19.wav", @"number_sound\20.wav", @"color_sound\blue.wav", @"color_sound\white.wav" };
        string[] true_ans = { @"alphabets\q.jpeg", @"alphabets\r.jpeg", @"alphabets\s.jpeg", @"alphabets\t.jpeg", @"numbers\sventeen.jpeg", @"numbers\eighteen.jpeg", @"numbers\ninteen.jpeg", @"numbers\twinty.jpeg", @"colors\9.jpeg", @"colors\10.jpeg" };
        string[] false_ans = { @"alphabets\a.jpeg", @"alphabets\u.jpeg", @"alphabets\w.jpeg", @"alphabets\z.jpeg", @"numbers\three.jpeg", @"numbers\four.jpeg", @"numbers\nine.jpeg", @"numbers\two.jpeg", @"colors\5.jpeg", @"colors\2.jpeg" };
        int position = 0;
        bool chickExit = true;
        public fifth_quizzes_form()
        {
            InitializeComponent();
        }

        private void fifth_quizzes_form_Load(object sender, EventArgs e)
        {
            loadobject();
        }

        private void loadobject()
        {
            pic5_true.BackgroundImage = Image.FromFile(true_ans[position]);
            pic5_true.BackgroundImageLayout = ImageLayout.Stretch;
            pic5_false.BackgroundImage = Image.FromFile(false_ans[position]);
            pic5_false.BackgroundImageLayout = ImageLayout.Stretch;
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

        private void true_ans5_btn_Click(object sender, EventArgs e)
        {
            SoundPlayer right = new SoundPlayer(@"right_effect.wav");
            right.Play();
            MessageBox.Show("right");
        }

        private void false_ans5_btn_Click(object sender, EventArgs e)
        {
            SoundPlayer wrong = new SoundPlayer(@"wrong_effect.wav");
            wrong.Play();
            MessageBox.Show("wrong");
        }

        private void fifth_quizzes_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (chickExit) Application.Exit();
        }
    }
}
