namespace kids_game_app
{
    partial class sixth_quizzes_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sixth_quizzes_form));
            back_home_button = new Button();
            next_button = new Button();
            question_audio_button = new Button();
            true_ans6_btn = new Button();
            false_ans6_btn = new Button();
            pic6_false = new PictureBox();
            pic6_true = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pic6_false).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic6_true).BeginInit();
            SuspendLayout();
            // 
            // back_home_button
            // 
            back_home_button.Image = Properties.Resources.بيت1;
            back_home_button.Location = new Point(50, 50);
            back_home_button.Name = "back_home_button";
            back_home_button.Size = new Size(74, 63);
            back_home_button.TabIndex = 5;
            back_home_button.UseVisualStyleBackColor = true;
            back_home_button.Click += back_home_button_Click;
            // 
            // next_button
            // 
            next_button.Image = (Image)resources.GetObject("next_button.Image");
            next_button.Location = new Point(924, 58);
            next_button.Name = "next_button";
            next_button.Size = new Size(94, 47);
            next_button.TabIndex = 6;
            next_button.UseVisualStyleBackColor = true;
            next_button.Click += next_button_Click;
            // 
            // question_audio_button
            // 
            question_audio_button.Image = Properties.Resources.مايك_1;
            question_audio_button.Location = new Point(435, 120);
            question_audio_button.Name = "question_audio_button";
            question_audio_button.Size = new Size(183, 151);
            question_audio_button.TabIndex = 8;
            question_audio_button.UseVisualStyleBackColor = true;
            question_audio_button.Click += question_audio_button_Click;
            // 
            // true_ans6_btn
            // 
            true_ans6_btn.Location = new Point(263, 440);
            true_ans6_btn.Name = "true_ans6_btn";
            true_ans6_btn.Size = new Size(150, 120);
            true_ans6_btn.TabIndex = 9;
            true_ans6_btn.UseVisualStyleBackColor = true;
            true_ans6_btn.Click += true_ans6_btn_Click;
            // 
            // false_ans6_btn
            // 
            false_ans6_btn.Location = new Point(655, 440);
            false_ans6_btn.Name = "false_ans6_btn";
            false_ans6_btn.Size = new Size(150, 120);
            false_ans6_btn.TabIndex = 10;
            false_ans6_btn.UseVisualStyleBackColor = true;
            false_ans6_btn.Click += false_ans6_btn_Click;
            // 
            // pic6_false
            // 
            pic6_false.Location = new Point(655, 260);
            pic6_false.Name = "pic6_false";
            pic6_false.Size = new Size(141, 174);
            pic6_false.TabIndex = 11;
            pic6_false.TabStop = false;
            pic6_false.Click += pic2_true_Click;
            // 
            // pic6_true
            // 
            pic6_true.Location = new Point(263, 260);
            pic6_true.Name = "pic6_true";
            pic6_true.Size = new Size(141, 174);
            pic6_true.TabIndex = 12;
            pic6_true.TabStop = false;
            pic6_true.Click += pictureBox1_Click;
            // 
            // sixth_quizzes_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.سحابة_باك_جراوند;
            ClientSize = new Size(1062, 673);
            Controls.Add(pic6_true);
            Controls.Add(pic6_false);
            Controls.Add(false_ans6_btn);
            Controls.Add(true_ans6_btn);
            Controls.Add(question_audio_button);
            Controls.Add(next_button);
            Controls.Add(back_home_button);
            MaximizeBox = false;
            Name = "sixth_quizzes_form";
            Text = "sixth_quizzes_form";
            FormClosing += sixth_quizzes_form_FormClosing;
            Load += sixth_quizzes_form_Load;
            ((System.ComponentModel.ISupportInitialize)pic6_false).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic6_true).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button back_home_button;
        private Button next_button;
        private Button question_audio_button;
        private Button true_ans6_btn;
        private Button false_ans6_btn;
        private PictureBox pic6_false;
        private PictureBox pic6_true;
    }
}