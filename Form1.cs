using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace urlgen
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			var dsGender = new Gender[]
			{
				new Gender() { ID = "m", Name = "Male" },
				new Gender() { ID = "f", Name = "Female" }
			};

			cboGender.DisplayMember = "Name";
			cboGender.ValueMember = "ID";
			cboGender.DataSource = dsGender;
		}

		private void btnTest_Click(object sender, EventArgs e)
		{
			txtSupplierID.Text = "123";
			txtSupplierSubID.Text = "8675309200";
			txtUniqueUserID.Text = "8675309200";
			txtDOB.Text = "1955-11-05";
			txtEmail.Text = "DrEmmett.L.Brown.PhD%2B200%40gmail.com";
			// txtEmail.Text = "DrEmmett.L.Brown.PhD+200@gmail.com";
			txtIPAddress.Text = "76.236.220.211";
			txtSecretKey.Text = "69785143472835dba8facfa442e042b8";
			cboGender.SelectedIndex = cboGender.FindString("Male");
			rbSecretIsAscii.Checked = true;
			rbSecretIsHex.Checked = false;
		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			var x = Crypto.StringEncode(txtSecretKey.Text);
			var x2 = Crypto.HashEncode(x);

			var hmacData = new Dictionary<string, string>();
			hmacData["unique_user_id"] = txtUniqueUserID.Text;
			hmacData["date_of_birth"] = txtDOB.Text;
			hmacData["email"] = txtEmail.Text;
			hmacData["gender"] = cboGender.SelectedValue.ToString();
			hmacData["ip_address"] = txtIPAddress.Text;
			var hmacPayload = string.Join("&", hmacData.Select(p => p.Key + "=" + p.Value));

			txtHmacData.Text = hmacPayload;
			txtHMAC.Text = Crypto.HashHMACHex(txtSecretKey.Text, hmacPayload, rbSecretIsHex.Checked);

			var qsData = new Dictionary<string, string>();
			qsData["si"] = txtSupplierID.Text;
			qsData["ssi"] = txtSupplierSubID.Text;
			qsData["unique_user_id"] = txtUniqueUserID.Text;
			qsData["date_of_birth"] = txtDOB.Text;
			qsData["email"] = txtEmail.Text;
			qsData["gender"] = cboGender.SelectedValue.ToString();
			qsData["ip_address"] = txtIPAddress.Text;
			qsData["hmac"] = txtHMAC.Text;
			var qs = string.Join("&", qsData.Select(p => p.Key + "=" + p.Value));

			var uri = new UriBuilder();
			uri.Scheme = "https";
			uri.Host = "www.your-surveys.com";
			uri.Query = qs;

			txtEntryLink.Text = uri.ToString();

		}

		private void btnCopy_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.Clipboard.SetText(txtEntryLink.Text);
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnCopySupplierSubID_Click(object sender, EventArgs e)
		{
			txtUniqueUserID.Text = txtSupplierSubID.Text;
		}
	}
}
