using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace TurboWeeb
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            Context.MainForm = this;

            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                this.Hide();
                NotifyIcon.Visible = true;

                return;
            }
        }

        public void Refresh()
        {
            Context.Load(false);

            this.ListResults.ClearSelected();
            this.ListResults.Items.Clear();

            bool search = !(this.TextSearch.Text == "Search..." || this.TextSearch.Text == "" || this.TextSearch.Text == " ");
            string searchString = this.TextSearch.Text;

            foreach (Anime anime in Context.Library.Anime)
            {
                if (search && !anime.Name.Trim().ToLower().Contains(searchString.ToLower()))
                {
                    continue;
                }

                this.ListResults.Items.Add(anime);
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            FormAdd addForm = new FormAdd();
            addForm.Show();
        }

        private void ButtonModify_Click(object sender, EventArgs e)
        {
            if (this.ListResults.SelectedItem != null)
            {
                FormModify modifyForm = new FormModify((Anime)this.ListResults.SelectedItem);
                modifyForm.Show();
            }
        }

        private void ListResults_DoubleClick(object sender, EventArgs e)
        {
            if (this.ListResults.SelectedItem != null)
            {
                Process.Start(((Anime)this.ListResults.SelectedItem).Uri);
                this.Hide();
                this.NotifyIcon.Visible = true;
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void NotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            this.TextSearch.Text = "Search...";
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.BringToFront();
        }

        private void TextSearch_TextChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
