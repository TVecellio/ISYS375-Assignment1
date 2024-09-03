using System.CodeDom;
using System.Diagnostics;

namespace ActualChap2Example
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblstash.Text = "Hello World";
        }
        private void btnShow_Click(Object sender, EventArgs e)
        {
            lblstash.Visible = !lblstash.Visible;
        }

        private void btnClose_Click(Object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
