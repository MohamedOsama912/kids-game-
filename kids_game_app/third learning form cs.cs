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
    public partial class third_learning_form_cs : Form
    {
        string[] content3_path = { @"alphabets\i.jpeg", @"alphabets\j.jpeg", @"alphabets\k.jpeg", @"alphabets\l.jpeg", @"numbers\nine.jpeg", @"numbers\ten.jpeg", @"numbers\eleven.jpeg", @"numbers\twilve.jpeg", @"colors\5.jpeg", @"colors\6.jpeg" };
        string[] audio3_path = { @"alphabet_sound\i.wav", @"alphabet_sound\j.wav", @"alphabet_sound\k.wav", @"alphabet_sound\l.wav", @"number_sound\9.wav", @"number_sound\10.wav", @"number_sound\11.wav", @"number_sound\12.wav", @"color_sound\grey.wav", @"color_sound\yellow.wav" };
        int position = 0;
        bool chickExit = true;
        public third_learning_form_cs()
        {
            InitializeComponent();
        }

        private void obj_audio_button_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new System.Media.SoundPlayer(audio3_path[position]);
            player.Play();
        }

        private void third_learning_form_cs_Load(object sender, EventArgs e)
        {
            loadObject();
        }

        private void loadObject()
        {
            pic_view.BackgroundImage = Image.FromFile(content3_path[position]);
            pic_view.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            position++;
            if (position <= 9)
            {
                loadObject();
            }
            else
            {
                new motivational_form().Show();
                this.Hide();
            }
        }

        private void third_learning_form_cs_FormClosing(object sender, FormClosingEventArgs e)
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
