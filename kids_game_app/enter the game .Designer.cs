namespace kids_game_app
{
    partial class enter_the_game_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(enter_the_game_frm));
            back_button = new Button();
            enter_quizzes_button = new Button();
            enter_learn_button = new Button();
            audio_quizzes_button = new Button();
            audio_learn_button = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // back_button
            // 
            back_button.Image = (Image)resources.GetObject("back_button.Image");
            back_button.Location = new Point(50, 50);
            back_button.Name = "back_button";
            back_button.Size = new Size(94, 42);
            back_button.TabIndex = 0;
            back_button.UseVisualStyleBackColor = true;
            back_button.Click += back_button_Click;
            // 
            // enter_quizzes_button
            // 
            enter_quizzes_button.Image = (Image)resources.GetObject("enter_quizzes_button.Image");
            enter_quizzes_button.Location = new Point(244, 150);
            enter_quizzes_button.Name = "enter_quizzes_button";
            enter_quizzes_button.Size = new Size(214, 174);
            enter_quizzes_button.TabIndex = 1;
            enter_quizzes_button.UseVisualStyleBackColor = true;
            enter_quizzes_button.Click += enter_quizzes_button_Click;
            // 
            // enter_learn_button
            // 
            enter_learn_button.Image = (Image)resources.GetObject("enter_learn_button.Image");
            enter_learn_button.Location = new Point(611, 150);
            enter_learn_button.Name = "enter_learn_button";
            enter_learn_button.Size = new Size(214, 174);
            enter_learn_button.TabIndex = 2;
            enter_learn_button.UseVisualStyleBackColor = true;
            enter_learn_button.Click += enter_learn_button_Click;
            // 
            // audio_quizzes_button
            // 
            audio_quizzes_button.Image = Properties.Resources.مايك_2;
            audio_quizzes_button.Location = new Point(301, 371);
            audio_quizzes_button.Name = "audio_quizzes_button";
            audio_quizzes_button.Size = new Size(90, 80);
            audio_quizzes_button.TabIndex = 3;
            audio_quizzes_button.UseVisualStyleBackColor = true;
            audio_quizzes_button.Click += audio_quizzes_button_Click;
            // 
            // audio_learn_button
            // 
            audio_learn_button.Image = (Image)resources.GetObject("audio_learn_button.Image");
            audio_learn_button.Location = new Point(667, 371);
            audio_learn_button.Name = "audio_learn_button";
            audio_learn_button.Size = new Size(90, 80);
            audio_learn_button.TabIndex = 4;
            audio_learn_button.UseVisualStyleBackColor = true;
            audio_learn_button.Click += audio_learn_button_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(18, 570);
            button1.Name = "button1";
            button1.Size = new Size(94, 34);
            button1.TabIndex = 5;
            button1.Text = "score";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // enter_the_game_frm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1062, 673);
            Controls.Add(button1);
            Controls.Add(audio_learn_button);
            Controls.Add(audio_quizzes_button);
            Controls.Add(enter_learn_button);
            Controls.Add(enter_quizzes_button);
            Controls.Add(back_button);
            MaximizeBox = false;
            Name = "enter_the_game_frm";
            Text = "enter_the_game";
            FormClosing += enter_the_game_frm_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button back_button;
        private Button enter_quizzes_button;
        private Button enter_learn_button;
        private Button audio_quizzes_button;
        private Button audio_learn_button;
        private Button button1;
    }
}