namespace TurboWeeb
{
    partial class FormModify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModify));
            this.ButtonSave = new System.Windows.Forms.Button();
            this.TextUri = new System.Windows.Forms.TextBox();
            this.LabelUri = new System.Windows.Forms.Label();
            this.TextName = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(465, 109);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 9;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // TextUri
            // 
            this.TextUri.Location = new System.Drawing.Point(12, 65);
            this.TextUri.Name = "TextUri";
            this.TextUri.Size = new System.Drawing.Size(528, 20);
            this.TextUri.TabIndex = 8;
            // 
            // LabelUri
            // 
            this.LabelUri.AutoSize = true;
            this.LabelUri.Location = new System.Drawing.Point(12, 49);
            this.LabelUri.Name = "LabelUri";
            this.LabelUri.Size = new System.Drawing.Size(23, 13);
            this.LabelUri.TabIndex = 7;
            this.LabelUri.Text = "Uri:";
            // 
            // TextName
            // 
            this.TextName.Location = new System.Drawing.Point(12, 26);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(528, 20);
            this.TextName.TabIndex = 6;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(12, 10);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(38, 13);
            this.LabelName.TabIndex = 5;
            this.LabelName.Text = "Name:";
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(384, 109);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.ButtonDelete.TabIndex = 10;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // FormModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 143);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.TextUri);
            this.Controls.Add(this.LabelUri);
            this.Controls.Add(this.TextName);
            this.Controls.Add(this.LabelName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormModify";
            this.Text = "Modify Anime";
            this.Load += new System.EventHandler(this.FormModify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.TextBox TextUri;
        private System.Windows.Forms.Label LabelUri;
        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Button ButtonDelete;
    }
}