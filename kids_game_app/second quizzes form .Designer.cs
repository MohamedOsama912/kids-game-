namespace kids_game_app
{
    partial class second_quizzes_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(second_quizzes_form));
            next_button = new Button();
            false_ans2_btn = new Button();
            true_ans2_btn = new Button();
            question_audio_button = new Button();
            backhome_btn = new Button();
            pic2_true = new PictureBox();
            pic2_false = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pic2_true).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic2_false).BeginInit();
            SuspendLayout();
            // 
            // next_button
            // 
            next_button.Image = Properties.Resources.next_1;
            next_button.Location = new Point(908, 56);
            next_button.Name = "next_button";
            next_button.Size = new Size(94, 51);
            next_button.TabIndex = 4;
            next_button.UseVisualStyleBackColor = true;
            next_button.Click += next_button_Click;
            // 
            // false_ans2_btn
            // 
            false_ans2_btn.Location = new Point(250, 435);
            false_ans2_btn.Name = "false_ans2_btn";
            false_ans2_btn.Size = new Size(150, 120);
            false_ans2_btn.TabIndex = 6;
            false_ans2_btn.UseVisualStyleBackColor = true;
            false_ans2_btn.Click += false_ans2_btn_Click;
            // 
            // true_ans2_btn
            // 
            true_ans2_btn.Location = new Point(644, 435);
            true_ans2_btn.Name = "true_ans2_btn";
            true_ans2_btn.Size = new Size(150, 120);
            true_ans2_btn.TabIndex = 7;
            true_ans2_btn.UseVisualStyleBackColor = true;
            true_ans2_btn.Click += true_ans2_btn_Click;
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
            // backhome_btn
            // 
            backhome_btn.Image = Properties.Resources.بيت1;
            backhome_btn.Location = new Point(50, 50);
            backhome_btn.Name = "backhome_btn";
            backhome_btn.Size = new Size(74, 63);
            backhome_btn.TabIndex = 9;
            backhome_btn.UseVisualStyleBackColor = true;
            backhome_btn.Click += backhome_btn_Click;
            // 
            // pic2_true
            // 
            pic2_true.Location = new Point(653, 224);
            pic2_true.Name = "pic2_true";
            pic2_true.Size = new Size(141, 174);
            pic2_true.TabIndex = 10;
            pic2_true.TabStop = false;
            pic2_true.Click += pic2_true_Click;
            // 
            // pic2_false
            // 
            pic2_false.Location = new Point(259, 224);
            pic2_false.Name = "pic2_false";
            pic2_false.Size = new Size(141, 174);
            pic2_false.TabIndex = 11;
            pic2_false.TabStop = false;
            // 
            // second_quizzes_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1062, 673);
            Controls.Add(pic2_false);
            Controls.Add(pic2_true);
            Controls.Add(backhome_btn);
            Controls.Add(question_audio_button);
            Controls.Add(true_ans2_btn);
            Controls.Add(false_ans2_btn);
            Controls.Add(next_button);
            MaximizeBox = false;
            Name = "second_quizzes_form";
            Text = "second_quizzes_form";
            FormClosing += second_quizzes_form_FormClosing;
            Load += second_quizzes_form_Load;
            ((System.ComponentModel.ISupportInitialize)pic2_true).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic2_false).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button next_button;
        private Button false_ans2_btn;
        private Button true_ans2_btn;
        private Button question_audio_button;
        private Button backhome_btn;
        private PictureBox pic2_true;
        private PictureBox pic2_false;
    }
}