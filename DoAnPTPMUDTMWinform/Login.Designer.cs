namespace DoAnPTPMUDTMWinform
{
    partial class Login
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
            label1 = new Label();
            ucLogin1 = new ControlsLibary.UcLogin();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Image = Properties.Resources.logo1;
            label1.Location = new Point(-2, -2);
            label1.Name = "label1";
            label1.Size = new Size(236, 254);
            label1.TabIndex = 1;
            // 
            // ucLogin1
            // 
            ucLogin1.BackColor = SystemColors.Control;
            ucLogin1.Location = new Point(236, -2);
            ucLogin1.Name = "ucLogin1";
            ucLogin1.Size = new Size(388, 253);
            ucLogin1.TabIndex = 2;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 252);
            Controls.Add(ucLogin1);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ControlsLibary.UcLogin ucLogin1;
    }
}