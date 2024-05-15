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

    public partial class second_learning_form : Form
    {
        string[] content2_path = { @"alphabets\e.jpeg", @"alphabets\f.jpeg", @"alphabets\g.jpeg", @"alphabets\h.jpeg", @"numbers\five.jpeg", @"numbers\six.jpeg", @"numbers\seven.jpeg", @"numbers\eight.jpeg", @"colors\3.jpeg", @"colors\4.jpeg" };
        string[] audio2_path = { @"alphabet_sound\e.wav", @"alphabet_sound\f.wav", @"alphabet_sound\g.wav", @"alphabet_sound\h.wav", @"number_sound\5.wav", @"number_sound\6.wav", @"number_sound\7.wav", @"number_sound\8.wav", @"color_sound\brown.wav", @"color_sound\pink.wav" };
        int position = 0;
        bool chickExit = true;

        public second_learning_form()
        {
            InitializeComponent();
        }

        private void second_learning_form_Load(object sender, EventArgs e)
        {
            loadobject();
        }

        private void loadobject()
        {
            pic_view.BackgroundImage = Image.FromFile(content2_path[position]);
            pic_view.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void back_home_button_Click(object sender, EventArgs e)
        {
            chickExit = false;
            Application.OpenForms[3].Show();
            this.Close();
        }

        private void obj_audio_button_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new System.Media.SoundPlayer(audio2_path[position]);
            player.Play();
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            position++;
            if (position <= 9)
            {
                loadobject();
            }
            else
            {
                new motivational_form().Show();
                this.Hide();
            }
        }

        private void second_learning_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (chickExit) Application.Exit();
        }
    }
}
