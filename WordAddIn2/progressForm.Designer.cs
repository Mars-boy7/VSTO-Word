namespace WordAddIn2
{
    partial class progressForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(progressForm));
            this.progressbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressbutton
            // 
            this.progressbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressbutton.Image = ((System.Drawing.Image)(resources.GetObject("progressbutton.Image")));
            this.progressbutton.Location = new System.Drawing.Point(-7, -11);
            this.progressbutton.Margin = new System.Windows.Forms.Padding(0);
            this.progressbutton.Name = "progressbutton";
            this.progressbutton.Size = new System.Drawing.Size(346, 97);
            this.progressbutton.TabIndex = 1;
            this.progressbutton.UseVisualStyleBackColor = true;
            this.progressbutton.Click += new System.EventHandler(this.progressbutton_Click);
            // 
            // progressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 69);
            this.ControlBox = false;
            this.Controls.Add(this.progressbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "progressForm";
            this.Opacity = 0.7D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button progressbutton;
    }
}