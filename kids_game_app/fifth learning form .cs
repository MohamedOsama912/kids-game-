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
    public partial class fifth_learning_form : Form
    {
        string[] content_path = { @"alphabets\q.jpeg", @"alphabets\r.jpeg", @"alphabets\s.jpeg", @"alphabets\t.jpeg", @"numbers\sventeen.jpeg", @"numbers\eighteen.jpeg", @"numbers\ninteen.jpeg", @"numbers\twinty.jpeg", @"colors\9.jpeg", @"colors\10.jpeg" };
        string[] sound_path = { @"alphabet_sound\q.wav", @"alphabet_sound\r.wav", @"alphabet_sound\s.wav", @"alphabet_sound\t.wav", @"number_sound\17.wav", @"number_sound\18.wav", @"number_sound\19.wav", @"number_sound\20.wav", @"color_sound\blue.wav", @"color_sound\white.wav" };
        int position = 0;
        bool chickExit = true;
        public fifth_learning_form()
        {
            InitializeComponent();
        }

        private void fifth_learning_form_Load(object sender, EventArgs e)
        {
            LoadObject();
        }

        private void LoadObject()
        {
            pic_view.BackgroundImage = Image.FromFile(content_path[position]);
            pic_view.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            position++;
            if (position <= 9)
            {
                LoadObject();
            }
            else
            {
                new motivational_form().Show();
                this.Hide();
            }
        }

        private void obj_audio_button_Click(object sender, EventArgs e)
        {
            SoundPlayer Player = new SoundPlayer(sound_path[position]);
            Player.Play();
        }

        private void back_home_button_Click(object sender, EventArgs e)
        {
            chickExit = false;
            Application.OpenForms[3].Show();
            this.Close();
        }

        private void fifth_learning_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (chickExit) Application.Exit();
        }
    }
}
