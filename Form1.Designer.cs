namespace SSHRandD
{
    partial class Form1
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
            this.btnSSH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSSH
            // 
            this.btnSSH.Location = new System.Drawing.Point(368, 161);
            this.btnSSH.Name = "btnSSH";
            this.btnSSH.Size = new System.Drawing.Size(75, 23);
            this.btnSSH.TabIndex = 0;
            this.btnSSH.Text = "SSH";
            this.btnSSH.UseVisualStyleBackColor = true;
            this.btnSSH.Click += new System.EventHandler(this.btnSSH_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSSH);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSSH;
    }
}