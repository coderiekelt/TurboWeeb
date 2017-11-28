namespace TurboWeeb
{
    partial class FormException
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormException));
            this.ImageKawaii = new System.Windows.Forms.PictureBox();
            this.TextInfo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageKawaii)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageKawaii
            // 
            this.ImageKawaii.Image = ((System.Drawing.Image)(resources.GetObject("ImageKawaii.Image")));
            this.ImageKawaii.Location = new System.Drawing.Point(0, 0);
            this.ImageKawaii.Name = "ImageKawaii";
            this.ImageKawaii.Size = new System.Drawing.Size(1015, 585);
            this.ImageKawaii.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageKawaii.TabIndex = 0;
            this.ImageKawaii.TabStop = false;
            // 
            // TextInfo
            // 
            this.TextInfo.Location = new System.Drawing.Point(699, 12);
            this.TextInfo.Multiline = true;
            this.TextInfo.Name = "TextInfo";
            this.TextInfo.ReadOnly = true;
            this.TextInfo.Size = new System.Drawing.Size(305, 561);
            this.TextInfo.TabIndex = 1;
            // 
            // FormException
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 585);
            this.Controls.Add(this.TextInfo);
            this.Controls.Add(this.ImageKawaii);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormException";
            this.Text = "Uhoh... something went terribly wrong...";
            this.Load += new System.EventHandler(this.FormException_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImageKawaii)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImageKawaii;
        private System.Windows.Forms.TextBox TextInfo;
    }
}