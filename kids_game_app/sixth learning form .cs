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
    public partial class sixth_learning_form : Form
    {
        string[] content_path = { @"alphabets\u.jpeg", @"alphabets\v.jpeg", @"alphabets\w.jpeg", @"alphabets\x.jpeg", @"alphabets\y.jpeg", @"alphabets\z.jpeg", @"colors\11.jpeg", @"colors\12.jpeg" };
        string[] audio_path = { @"alphabet_sound\u.wav", @"alphabet_sound\v.wav", @"alphabet_sound\w.wav", @"alphabet_sound\x.wav", @"alphabet_sound\y.wav", @"alphabet_sound\z.wav", @"color_sound\purple.wav", @"color_sound\turquoise.wav" };
        int position = 0;
        bool chickExit = true;
        public sixth_learning_form()
        {
            InitializeComponent();
        }

        private void sixth_learning_form_Load(object sender, EventArgs e)
        {
            loadobject();
        }

        private void loadobject()
        {
            pic_view.BackgroundImage = Image.FromFile(content_path[position]);
            pic_view.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            position++;
            if (position <= content_path.Length - 1)
            {
                loadobject();

            }
            else
            {
                new motivational_form().Show();
                this.Hide();
            }
        }

        private void obj_audio_button_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(audio_path[position]);
            player.Play();
        }

        private void sixth_learning_form_FormClosing(object sender, FormClosingEventArgs e)
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
