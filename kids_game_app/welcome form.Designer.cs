namespace kids_game_app
{
    partial class welcome_frm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(welcome_frm));
            new_start_button = new Button();
            label1_game_name = new Label();
            load_button = new Button();
            wlcom_spekr_btn = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // new_start_button
            // 
            new_start_button.Anchor = AnchorStyles.None;
            new_start_button.BackColor = SystemColors.Info;
            new_start_button.Font = new Font("MV Boli", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            new_start_button.ForeColor = SystemColors.HotTrack;
            new_start_button.Location = new Point(158, 248);
            new_start_button.Name = "new_start_button";
            new_start_button.Size = new Size(286, 89);
            new_start_button.TabIndex = 0;
            new_start_button.Text = "New Start";
            new_start_button.UseVisualStyleBackColor = false;
            new_start_button.Click += new_start_button_Click;
            // 
            // label1_game_name
            // 
            label1_game_name.Anchor = AnchorStyles.None;
            label1_game_name.AutoSize = true;
            label1_game_name.BackColor = SystemColors.Info;
            label1_game_name.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1_game_name.ForeColor = SystemColors.HotTrack;
            label1_game_name.Location = new Point(283, 76);
            label1_game_name.Name = "label1_game_name";
            label1_game_name.Size = new Size(489, 74);
            label1_game_name.TabIndex = 2;
            label1_game_name.Text = "wonder learn";
            // 
            // load_button
            // 
            load_button.Anchor = AnchorStyles.None;
            load_button.BackColor = SystemColors.Info;
            load_button.Font = new Font("MV Boli", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            load_button.ForeColor = SystemColors.HotTrack;
            load_button.Location = new Point(593, 248);
            load_button.Name = "load_button";
            load_button.Size = new Size(286, 89);
            load_button.TabIndex = 5;
            load_button.Text = "Load";
            load_button.UseVisualStyleBackColor = false;
            load_button.Click += load_button_Click;
            // 
            // wlcom_spekr_btn
            // 
            wlcom_spekr_btn.Anchor = AnchorStyles.None;
            wlcom_spekr_btn.BackgroundImage = Properties.Resources.photo_2023_12_23_09_30_15;
            wlcom_spekr_btn.Location = new Point(466, 423);
            wlcom_spekr_btn.Name = "wlcom_spekr_btn";
            wlcom_spekr_btn.Size = new Size(96, 102);
            wlcom_spekr_btn.TabIndex = 6;
            wlcom_spekr_btn.UseVisualStyleBackColor = true;
            wlcom_spekr_btn.Click += wlcom_spekr_btn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(859, 592);
            button1.Name = "button1";
            button1.Size = new Size(136, 33);
            button1.TabIndex = 7;
            button1.Text = "dbconnection";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // welcome_frm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1062, 673);
            Controls.Add(button1);
            Controls.Add(wlcom_spekr_btn);
            Controls.Add(load_button);
            Controls.Add(label1_game_name);
            Controls.Add(new_start_button);
            MaximizeBox = false;
            Name = "welcome_frm";
            Text = "welcome form";
            FormClosing += welcome_frm_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button new_start_button;
        private Button button2;
        private Label label1_game_name;
        private Button load_button;
        private Button wlcom_spekr_btn;
        private Button button1;
    }
}
