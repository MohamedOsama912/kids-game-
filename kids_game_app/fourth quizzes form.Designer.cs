namespace kids_game_app
{
    partial class fourth_quizzes_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fourth_quizzes_form));
            back_home_button = new Button();
            next_button = new Button();
            question_audio_button = new Button();
            true_fouthans_btn = new Button();
            false_ans4_btn = new Button();
            pic4_false = new PictureBox();
            pic4_true = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pic4_false).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic4_true).BeginInit();
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
            next_button.Location = new Point(916, 58);
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
            // true_fouthans_btn
            // 
            true_fouthans_btn.Location = new Point(248, 416);
            true_fouthans_btn.Name = "true_fouthans_btn";
            true_fouthans_btn.Size = new Size(150, 120);
            true_fouthans_btn.TabIndex = 9;
            true_fouthans_btn.UseVisualStyleBackColor = true;
            true_fouthans_btn.Click += false_fouthans_btn_Click;
            // 
            // false_ans4_btn
            // 
            false_ans4_btn.Location = new Point(660, 416);
            false_ans4_btn.Name = "false_ans4_btn";
            false_ans4_btn.Size = new Size(150, 120);
            false_ans4_btn.TabIndex = 10;
            false_ans4_btn.UseVisualStyleBackColor = true;
            false_ans4_btn.Click += false_ans4_btn_Click;
            // 
            // pic4_false
            // 
            pic4_false.Location = new Point(669, 236);
            pic4_false.Name = "pic4_false";
            pic4_false.Size = new Size(141, 174);
            pic4_false.TabIndex = 13;
            pic4_false.TabStop = false;
            // 
            // pic4_true
            // 
            pic4_true.Location = new Point(248, 236);
            pic4_true.Name = "pic4_true";
            pic4_true.Size = new Size(141, 174);
            pic4_true.TabIndex = 14;
            pic4_true.TabStop = false;
            // 
            // fourth_quizzes_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.سحابة_باك_جراوند;
            ClientSize = new Size(1062, 673);
            Controls.Add(pic4_true);
            Controls.Add(pic4_false);
            Controls.Add(false_ans4_btn);
            Controls.Add(true_fouthans_btn);
            Controls.Add(question_audio_button);
            Controls.Add(next_button);
            Controls.Add(back_home_button);
            MaximizeBox = false;
            Name = "fourth_quizzes_form";
            Text = "fourth_quizzes_form";
            FormClosing += fourth_quizzes_form_FormClosing;
            Load += fourth_quizzes_form_Load;
            ((System.ComponentModel.ISupportInitialize)pic4_false).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic4_true).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button back_home_button;
        private Button next_button;
        private Button question_audio_button;
        private Button true_fouthans_btn;
        private Button false_ans4_btn;
        private PictureBox pic4_false;
        private PictureBox pic4_true;
    }
}