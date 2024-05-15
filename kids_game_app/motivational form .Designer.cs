namespace kids_game_app
{
    partial class motivational_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(motivational_form));
            enter_the_fame_back = new Button();
            SuspendLayout();
            // 
            // enter_the_fame_back
            // 
            enter_the_fame_back.BackgroundImage = Properties.Resources.بيت1;
            enter_the_fame_back.Location = new Point(912, 36);
            enter_the_fame_back.Name = "enter_the_fame_back";
            enter_the_fame_back.Size = new Size(88, 96);
            enter_the_fame_back.TabIndex = 0;
            enter_the_fame_back.UseVisualStyleBackColor = true;
            enter_the_fame_back.Click += enter_the_fame_back_Click;
            // 
            // motivational_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1062, 673);
            Controls.Add(enter_the_fame_back);
            MaximizeBox = false;
            Name = "motivational_form";
            Text = "motivational_form";
            FormClosing += motivational_form_FormClosing;
            Load += motivational_form_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button enter_the_fame_back;
    }
}