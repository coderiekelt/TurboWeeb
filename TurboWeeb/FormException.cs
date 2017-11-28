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
    public partial class FormException : Form
    {
        private Exception Exception;

        public FormException(Exception exception)
        {
            this.Exception = exception;

            InitializeComponent();
        }

        private void FormException_Load(object sender, EventArgs e)
        {
            string errorTemplate = "An fatal error has ocurred: {0}.\r\n\r\nStack trace:\n{1}\r\n\r\n TurboWeeb will exit after closing this window.";

            this.TextInfo.Text = String.Format(errorTemplate, this.Exception.Message, this.Exception.StackTrace);
        }
    }
}
