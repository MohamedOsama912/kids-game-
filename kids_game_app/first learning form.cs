using kids_game_app.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kids_game_app
{
    public partial class first_learning_form : Form
    {
        string[] content_path = { @"alphabets\a.jpeg", @"alphabets\b.jpeg", @"alphabets\c.jpeg", @"alphabets\d.jpeg", @"numbers\one.jpeg", @"numbers\two.jpeg", @"numbers\three.jpeg", @"numbers\four.jpeg", @"colors\1.jpeg", @"colors\2.jpeg" };
        string[] sound_path = { @"alphabet_sound\a.wav", @"alphabet_sound\b.wav", @"alphabet_sound\c.wav", @"alphabet_sound\d.wav", @"number_sound\1.wav", @"number_sound\2.wav", @"number_sound\3.wav", @"number_sound\4.wav", @"color_sound\black.wav", @"color_sound\red.wav" };
        int position = 0;
        bool chickExit = true;

        public first_learning_form()
        {
            InitializeComponent();
        }

        private void first_learning_form_Load(object sender, EventArgs e)
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



        private void pic_view_Click(object sender, EventArgs e)
        {

        }

        private void back_home_button_Click(object sender, EventArgs e)
        {
            chickExit = false;
            Application.OpenForms[3].Show();
            this.Close();
        }

        private void first_learning_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(chickExit)Application.Exit();
        }
    }
}
