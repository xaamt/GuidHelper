using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace GuidHelper
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            Reload();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            var guidString = txtGuid.Text;
            if (string.IsNullOrWhiteSpace(guidString))
            {
                MessageBox.Show("Guid input field is empty", "Convert Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtGuid.Focus();
                return;
            }

            if (!Guid.TryParse(guidString, out var guid))
            {
                MessageBox.Show("Guid is not in valid format", "Convert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGuid.Focus();
                return;
            }

            txtRaw.Text = OracleTypeHelper.DotNetToOracle(guid).ToString("N");

            txtSureGuid.Text = OracleTypeHelper.OracleToDotNet(guid).ToString("B");
        }

        private void tslblPoweredBy_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", @"http://www.xamt.pro");
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Reload()
        {
            txtGuid.ResetText();
            txtRaw.ResetText();
            txtSureGuid.ResetText();
            txtGuid.Focus();
            lblType.Text = " ... ";
        }

        

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txtGuid.Text = Guid.NewGuid().ToString("B");
            btnConvert_Click(sender, e);
        }

        private void txtGuid_TextChanged(object sender, EventArgs e)
        {
            if (Guid.TryParse(txtGuid.Text, out var guid))
            {
                txtGuid.ForeColor = Color.DarkOliveGreen;
                lblType.Text = OracleTypeHelper.IsOracleGuid(txtGuid.Text) ? "Possible Oracle Raw-16" : "Possible Standard Guid";
            }
            else
            {
                txtGuid.ForeColor = Color.DarkRed;
                lblType.Text = " ... ";
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtRaw.Text);
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            txtGuid.Text = Clipboard.GetText();
        }

        private void btnCopySureGuid_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtSureGuid.Text);
        }
    }
}
