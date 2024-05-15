namespace kids_game_app
{
    partial class fifth_quizzes_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fifth_quizzes_form));
            back_home_button = new Button();
            next_button = new Button();
            question_audio_button = new Button();
            false_ans5_btn = new Button();
            true_ans5_btn = new Button();
            pic5_false = new PictureBox();
            pic5_true = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pic5_false).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic5_true).BeginInit();
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
            next_button.Location = new Point(918, 58);
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
            // false_ans5_btn
            // 
            false_ans5_btn.Location = new Point(251, 414);
            false_ans5_btn.Name = "false_ans5_btn";
            false_ans5_btn.Size = new Size(150, 120);
            false_ans5_btn.TabIndex = 9;
            false_ans5_btn.UseVisualStyleBackColor = true;
            false_ans5_btn.Click += false_ans5_btn_Click;
            // 
            // true_ans5_btn
            // 
            true_ans5_btn.Location = new Point(647, 414);
            true_ans5_btn.Name = "true_ans5_btn";
            true_ans5_btn.Size = new Size(150, 120);
            true_ans5_btn.TabIndex = 10;
            true_ans5_btn.UseVisualStyleBackColor = true;
            true_ans5_btn.Click += true_ans5_btn_Click;
            // 
            // pic5_false
            // 
            pic5_false.Location = new Point(251, 234);
            pic5_false.Name = "pic5_false";
            pic5_false.Size = new Size(141, 174);
            pic5_false.TabIndex = 15;
            pic5_false.TabStop = false;
            // 
            // pic5_true
            // 
            pic5_true.Location = new Point(656, 234);
            pic5_true.Name = "pic5_true";
            pic5_true.Size = new Size(141, 174);
            pic5_true.TabIndex = 16;
            pic5_true.TabStop = false;
            // 
            // fifth_quizzes_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1062, 673);
            Controls.Add(pic5_true);
            Controls.Add(pic5_false);
            Controls.Add(true_ans5_btn);
            Controls.Add(false_ans5_btn);
            Controls.Add(question_audio_button);
            Controls.Add(next_button);
            Controls.Add(back_home_button);
            MaximizeBox = false;
            Name = "fifth_quizzes_form";
            Text = "fifth_quizzes_form";
            FormClosing += fifth_quizzes_form_FormClosing;
            Load += fifth_quizzes_form_Load;
            ((System.ComponentModel.ISupportInitialize)pic5_false).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic5_true).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button back_home_button;
        private Button next_button;
        private Button question_audio_button;
        private Button false_ans5_btn;
        private Button true_ans5_btn;
        private PictureBox pic5_false;
        private PictureBox pic5_true;
    }
}