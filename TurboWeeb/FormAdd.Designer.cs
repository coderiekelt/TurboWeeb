namespace TurboWeeb
{
    partial class FormAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdd));
            this.LabelName = new System.Windows.Forms.Label();
            this.TextName = new System.Windows.Forms.TextBox();
            this.LabelUri = new System.Windows.Forms.Label();
            this.TextUri = new System.Windows.Forms.TextBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(12, 9);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(38, 13);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "Name:";
            // 
            // TextName
            // 
            this.TextName.Location = new System.Drawing.Point(12, 25);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(528, 20);
            this.TextName.TabIndex = 1;
            // 
            // LabelUri
            // 
            this.LabelUri.AutoSize = true;
            this.LabelUri.Location = new System.Drawing.Point(12, 48);
            this.LabelUri.Name = "LabelUri";
            this.LabelUri.Size = new System.Drawing.Size(23, 13);
            this.LabelUri.TabIndex = 2;
            this.LabelUri.Text = "Uri:";
            // 
            // TextUri
            // 
            this.TextUri.Location = new System.Drawing.Point(12, 64);
            this.TextUri.Name = "TextUri";
            this.TextUri.Size = new System.Drawing.Size(528, 20);
            this.TextUri.TabIndex = 3;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(465, 108);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 4;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 143);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.TextUri);
            this.Controls.Add(this.LabelUri);
            this.Controls.Add(this.TextName);
            this.Controls.Add(this.LabelName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdd";
            this.Text = "Add Anime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.Label LabelUri;
        private System.Windows.Forms.TextBox TextUri;
        private System.Windows.Forms.Button ButtonSave;
    }
}