namespace kids_game_app
{
    partial class first_learning_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(first_learning_form));
            back_home_button = new Button();
            next_button = new Button();
            obj_audio_button = new Button();
            pic_view = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pic_view).BeginInit();
            SuspendLayout();
            // 
            // back_home_button
            // 
            back_home_button.BackgroundImage = (Image)resources.GetObject("back_home_button.BackgroundImage");
            back_home_button.Image = Properties.Resources.بيت1;
            back_home_button.Location = new Point(50, 35);
            back_home_button.Name = "back_home_button";
            back_home_button.Size = new Size(70, 66);
            back_home_button.TabIndex = 0;
            back_home_button.UseVisualStyleBackColor = true;
            back_home_button.Click += back_home_button_Click;
            // 
            // next_button
            // 
            next_button.Image = Properties.Resources.next_1;
            next_button.Location = new Point(950, 35);
            next_button.Name = "next_button";
            next_button.Size = new Size(94, 51);
            next_button.TabIndex = 1;
            next_button.UseVisualStyleBackColor = true;
            next_button.Click += next_button_Click;
            // 
            // obj_audio_button
            // 
            obj_audio_button.Image = Properties.Resources.مايك_1;
            obj_audio_button.Location = new Point(50, 250);
            obj_audio_button.Name = "obj_audio_button";
            obj_audio_button.Size = new Size(173, 154);
            obj_audio_button.TabIndex = 2;
            obj_audio_button.UseVisualStyleBackColor = true;
            obj_audio_button.Click += obj_audio_button_Click;
            // 
            // pic_view
            // 
            pic_view.Location = new Point(500, 170);
            pic_view.Name = "pic_view";
            pic_view.Size = new Size(210, 244);
            pic_view.TabIndex = 3;
            pic_view.TabStop = false;
            pic_view.Click += pic_view_Click;
            // 
            // first_learning_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1062, 673);
            Controls.Add(pic_view);
            Controls.Add(obj_audio_button);
            Controls.Add(next_button);
            Controls.Add(back_home_button);
            MaximizeBox = false;
            Name = "first_learning_form";
            Text = "first_learning_form";
            FormClosing += first_learning_form_FormClosing;
            Load += first_learning_form_Load;
            ((System.ComponentModel.ISupportInitialize)pic_view).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button back_home_button;
        private Button next_button;
        private Button obj_audio_button;
        private PictureBox pic_view;
    }
}