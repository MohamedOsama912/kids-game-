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
    public partial class fourth_learning_form : Form
    {
        string[] content_path = { @"alphabets\m.jpeg", @"alphabets\n.jpeg", @"alphabets\o.jpeg", @"alphabets\p.jpeg", @"numbers\thirteen.jpeg", @"numbers\fourteen.jpeg", @"numbers\fifteen.jpeg", @"numbers\sixteen.jpeg", @"colors\7.jpeg", @"colors\8.jpeg" };
        string[] sound_path = { @"alphabet_sound\m.wav", @"alphabet_sound\n.wav", @"alphabet_sound\o.wav", @"alphabet_sound\p.wav", @"number_sound\13.wav", @"number_sound\14.wav", @"number_sound\15.wav", @"number_sound\16.wav", @"color_sound\green.wav", @"color_sound\orange.wav" };
        int position = 0;
        bool chickExit = true;
        public fourth_learning_form()
        {
            InitializeComponent();
        }

        private void fourth_learning_form_Load(object sender, EventArgs e)
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
            SoundPlayer player = new SoundPlayer(sound_path[position]);
            player.Play();
        }

        private void fourth_learning_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (chickExit) Application.Exit();
        }

        private void back_home_button_Click(object sender, EventArgs e)
        {
            chickExit = false;
            Application.OpenForms[3].Show();
            this.Close();
        }
    }
}
