namespace kids_game_app
{
    partial class first_quizzes_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(first_quizzes_form));
            next_button = new Button();
            back_home_button = new Button();
            true_ans_btn = new Button();
            false_ans_btn = new Button();
            question_audio_button = new Button();
            pic_true = new PictureBox();
            pic_false = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pic_true).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_false).BeginInit();
            SuspendLayout();
            // 
            // next_button
            // 
            next_button.Image = (Image)resources.GetObject("next_button.Image");
            next_button.Location = new Point(916, 58);
            next_button.Name = "next_button";
            next_button.Size = new Size(94, 47);
            next_button.TabIndex = 3;
            next_button.UseVisualStyleBackColor = true;
            next_button.Click += next_button_Click;
            // 
            // back_home_button
            // 
            back_home_button.Image = Properties.Resources.بيت1;
            back_home_button.Location = new Point(50, 50);
            back_home_button.Name = "back_home_button";
            back_home_button.Size = new Size(74, 63);
            back_home_button.TabIndex = 4;
            back_home_button.UseVisualStyleBackColor = true;
            back_home_button.Click += back_home_button_Click;
            // 
            // true_ans_btn
            // 
            true_ans_btn.Location = new Point(274, 428);
            true_ans_btn.Name = "true_ans_btn";
            true_ans_btn.Size = new Size(150, 120);
            true_ans_btn.TabIndex = 5;
            true_ans_btn.UseVisualStyleBackColor = true;
            true_ans_btn.Click += true_ans_btn_Click;
            // 
            // false_ans_btn
            // 
            false_ans_btn.Location = new Point(648, 428);
            false_ans_btn.Name = "false_ans_btn";
            false_ans_btn.Size = new Size(150, 120);
            false_ans_btn.TabIndex = 6;
            false_ans_btn.UseVisualStyleBackColor = true;
            false_ans_btn.Click += false_ans_btn_Click;
            // 
            // question_audio_button
            // 
            question_audio_button.Image = Properties.Resources.مايك_1;
            question_audio_button.Location = new Point(435, 120);
            question_audio_button.Name = "question_audio_button";
            question_audio_button.Size = new Size(183, 151);
            question_audio_button.TabIndex = 7;
            question_audio_button.UseVisualStyleBackColor = true;
            question_audio_button.Click += question_audio_button_Click;
            // 
            // pic_true
            // 
            pic_true.Location = new Point(274, 248);
            pic_true.Name = "pic_true";
            pic_true.Size = new Size(141, 174);
            pic_true.TabIndex = 8;
            pic_true.TabStop = false;
            // 
            // pic_false
            // 
            pic_false.Location = new Point(657, 248);
            pic_false.Name = "pic_false";
            pic_false.Size = new Size(141, 174);
            pic_false.TabIndex = 9;
            pic_false.TabStop = false;
            // 
            // first_quizzes_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1062, 673);
            Controls.Add(pic_false);
            Controls.Add(pic_true);
            Controls.Add(question_audio_button);
            Controls.Add(false_ans_btn);
            Controls.Add(true_ans_btn);
            Controls.Add(back_home_button);
            Controls.Add(next_button);
            MaximizeBox = false;
            Name = "first_quizzes_form";
            Text = "first_quizzes_form";
            FormClosing += first_quizzes_form_FormClosing;
            Load += first_quizzes_form_Load;
            ((System.ComponentModel.ISupportInitialize)pic_true).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_false).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button next_button;
        private Button back_home_button;
        private Button true_ans_btn;
        private Button false_ans_btn;
        private Button question_audio_button;
        private PictureBox pic_true;
        private PictureBox pic_false;
    }
}