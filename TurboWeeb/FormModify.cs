using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurboWeeb
{
    public partial class FormModify : Form
    {
        private Anime Anime;

        public FormModify(Anime anime)
        {
            this.Anime = anime;

            InitializeComponent();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Anime.Name = this.TextName.Text;
            Anime.Uri = this.TextUri.Text;

            Context.Save();

            Context.MainForm.Refresh();

            this.Close();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            Context.Library.Anime.Remove(this.Anime);

            Context.Save();

            Context.MainForm.Refresh();

            this.Close();
        }

        private void FormModify_Load(object sender, EventArgs e)
        {
            this.TextName.Text = Anime.Name;
            this.TextUri.Text = Anime.Uri;
        }
    }
}
