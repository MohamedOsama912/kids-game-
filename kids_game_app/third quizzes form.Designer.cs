namespace kids_game_app
{
    partial class third_quizzes_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(third_quizzes_form));
            back_home_button = new Button();
            next_button = new Button();
            question_audio_button = new Button();
            true_ans3_btn = new Button();
            false_ans3_btn = new Button();
            pic3_true = new PictureBox();
            pic3_false = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pic3_true).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic3_false).BeginInit();
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
            next_button.Location = new Point(917, 58);
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
            // true_ans3_btn
            // 
            true_ans3_btn.Location = new Point(256, 418);
            true_ans3_btn.Name = "true_ans3_btn";
            true_ans3_btn.Size = new Size(150, 120);
            true_ans3_btn.TabIndex = 9;
            true_ans3_btn.UseVisualStyleBackColor = true;
            true_ans3_btn.Click += ans1_button_Click;
            // 
            // false_ans3_btn
            // 
            false_ans3_btn.Location = new Point(619, 418);
            false_ans3_btn.Name = "false_ans3_btn";
            false_ans3_btn.Size = new Size(150, 120);
            false_ans3_btn.TabIndex = 10;
            false_ans3_btn.UseVisualStyleBackColor = true;
            false_ans3_btn.Click += ans2_button_Click;
            // 
            // pic3_true
            // 
            pic3_true.Location = new Point(256, 238);
            pic3_true.Name = "pic3_true";
            pic3_true.Size = new Size(141, 174);
            pic3_true.TabIndex = 11;
            pic3_true.TabStop = false;
            // 
            // pic3_false
            // 
            pic3_false.Location = new Point(628, 238);
            pic3_false.Name = "pic3_false";
            pic3_false.Size = new Size(141, 174);
            pic3_false.TabIndex = 12;
            pic3_false.TabStop = false;
            // 
            // third_quizzes_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.سحابة_باك_جراوند;
            ClientSize = new Size(1062, 673);
            Controls.Add(pic3_false);
            Controls.Add(pic3_true);
            Controls.Add(false_ans3_btn);
            Controls.Add(true_ans3_btn);
            Controls.Add(question_audio_button);
            Controls.Add(next_button);
            Controls.Add(back_home_button);
            MaximizeBox = false;
            Name = "third_quizzes_form";
            Text = "third_quizzes_form";
            FormClosing += third_quizzes_form_FormClosing;
            Load += third_quizzes_form_Load;
            ((System.ComponentModel.ISupportInitialize)pic3_true).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic3_false).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button back_home_button;
        private Button next_button;
        private Button question_audio_button;
        private Button true_ans3_btn;
        private Button false_ans3_btn;
        private PictureBox pic3_true;
        private PictureBox pic3_false;
    }
}