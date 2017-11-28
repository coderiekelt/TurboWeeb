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
            try
            {
                this.Refresh();
            }
            catch (Exception exception)
            {
                Context.HandleException(exception);
            }
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            try {
                if (FormWindowState.Minimized == this.WindowState)
                {
                    this.Hide();
                    NotifyIcon.Visible = true;

                    return;
                }
            }
            catch (Exception exception)
            {
                Context.HandleException(exception);
            }
        }

        public void Refresh()
        {
            try
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
            catch (Exception exception)
            {
                Context.HandleException(exception);
            }
}

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                FormAdd addForm = new FormAdd();
                addForm.Show();
            }
            catch (Exception exception)
            {
                Context.HandleException(exception);
            }
        }

        private void ButtonModify_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ListResults.SelectedItem != null)
                {
                    FormModify modifyForm = new FormModify((Anime)this.ListResults.SelectedItem);
                    modifyForm.Show();
                }
            }
            catch (Exception exception)
            {
                Context.HandleException(exception);
            }
        }

        private void ListResults_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                //if (this.ListResults.SelectedItem != null)
                //{
                    Process.Start(((Anime)this.ListResults.SelectedItem).Uri);
                    this.Hide();
                    this.NotifyIcon.Visible = true;
                    this.WindowState = FormWindowState.Minimized;
                //}
            }
            catch (Exception exception)
            {
                Context.HandleException(exception);
            }
        }

        private void NotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                this.TextSearch.Text = "Search...";
                this.Show();
                this.WindowState = FormWindowState.Normal;
                this.BringToFront();
            }
            catch (Exception exception)
            {
                Context.HandleException(exception);
            }
        }

        private void TextSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Refresh();
            }
            catch (Exception exception)
            {
                Context.HandleException(exception);
            }
        }
    }
}
