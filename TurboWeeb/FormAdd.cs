using System;
using System.Windows.Forms;

namespace TurboWeeb
{
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Context.Library.Anime.Add(new Anime { Name = this.TextName.Text, Uri = this.TextUri.Text });

            Context.Save();

            Context.MainForm.Refresh();

            this.Close();
        }
    }
}
