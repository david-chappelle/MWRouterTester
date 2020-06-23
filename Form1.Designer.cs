namespace urlgen
{
	partial class Form1
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtSupplierID = new System.Windows.Forms.TextBox();
			this.txtSupplierSubID = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtUniqueUserID = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDOB = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.cboGender = new System.Windows.Forms.ComboBox();
			this.txtIPAddress = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtSecretKey = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.grpData = new System.Windows.Forms.GroupBox();
			this.btnCopySupplierSubID = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txtEntryLink = new System.Windows.Forms.TextBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnCopy = new System.Windows.Forms.Button();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.btnTest = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.txtHMAC = new System.Windows.Forms.Label();
			this.txtHmacData = new System.Windows.Forms.TextBox();
			this.rbSecretIsAscii = new System.Windows.Forms.RadioButton();
			this.rbSecretIsHex = new System.Windows.Forms.RadioButton();
			this.grpSecretKeyType = new System.Windows.Forms.GroupBox();
			this.grpData.SuspendLayout();
			this.grpSecretKeyType.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Supplier ID";
			// 
			// txtSupplierID
			// 
			this.txtSupplierID.Location = new System.Drawing.Point(108, 29);
			this.txtSupplierID.Name = "txtSupplierID";
			this.txtSupplierID.Size = new System.Drawing.Size(148, 20);
			this.txtSupplierID.TabIndex = 1;
			// 
			// txtSupplierSubID
			// 
			this.txtSupplierSubID.Location = new System.Drawing.Point(108, 55);
			this.txtSupplierSubID.Name = "txtSupplierSubID";
			this.txtSupplierSubID.Size = new System.Drawing.Size(148, 20);
			this.txtSupplierSubID.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Supplier Sub ID";
			// 
			// txtUniqueUserID
			// 
			this.txtUniqueUserID.Location = new System.Drawing.Point(108, 81);
			this.txtUniqueUserID.Name = "txtUniqueUserID";
			this.txtUniqueUserID.Size = new System.Drawing.Size(148, 20);
			this.txtUniqueUserID.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 84);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Unique User ID";
			// 
			// txtDOB
			// 
			this.txtDOB.Location = new System.Drawing.Point(108, 107);
			this.txtDOB.Name = "txtDOB";
			this.txtDOB.Size = new System.Drawing.Size(148, 20);
			this.txtDOB.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 110);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Date of Birth";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(108, 133);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(473, 20);
			this.txtEmail.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 136);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Email";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 162);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(42, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Gender";
			// 
			// cboGender
			// 
			this.cboGender.FormattingEnabled = true;
			this.cboGender.Location = new System.Drawing.Point(108, 159);
			this.cboGender.Name = "cboGender";
			this.cboGender.Size = new System.Drawing.Size(121, 21);
			this.cboGender.TabIndex = 11;
			// 
			// txtIPAddress
			// 
			this.txtIPAddress.Location = new System.Drawing.Point(108, 186);
			this.txtIPAddress.Name = "txtIPAddress";
			this.txtIPAddress.Size = new System.Drawing.Size(148, 20);
			this.txtIPAddress.TabIndex = 13;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 189);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(58, 13);
			this.label7.TabIndex = 12;
			this.label7.Text = "IP Address";
			// 
			// txtSecretKey
			// 
			this.txtSecretKey.Location = new System.Drawing.Point(108, 212);
			this.txtSecretKey.Name = "txtSecretKey";
			this.txtSecretKey.Size = new System.Drawing.Size(473, 20);
			this.txtSecretKey.TabIndex = 15;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 215);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(59, 13);
			this.label8.TabIndex = 14;
			this.label8.Text = "Secret Key";
			// 
			// grpData
			// 
			this.grpData.Controls.Add(this.grpSecretKeyType);
			this.grpData.Controls.Add(this.btnCopySupplierSubID);
			this.grpData.Controls.Add(this.txtSupplierID);
			this.grpData.Controls.Add(this.label8);
			this.grpData.Controls.Add(this.txtSecretKey);
			this.grpData.Controls.Add(this.label7);
			this.grpData.Controls.Add(this.label1);
			this.grpData.Controls.Add(this.label6);
			this.grpData.Controls.Add(this.label2);
			this.grpData.Controls.Add(this.label5);
			this.grpData.Controls.Add(this.txtIPAddress);
			this.grpData.Controls.Add(this.label4);
			this.grpData.Controls.Add(this.txtSupplierSubID);
			this.grpData.Controls.Add(this.txtUniqueUserID);
			this.grpData.Controls.Add(this.cboGender);
			this.grpData.Controls.Add(this.label3);
			this.grpData.Controls.Add(this.txtDOB);
			this.grpData.Controls.Add(this.txtEmail);
			this.grpData.Location = new System.Drawing.Point(12, 12);
			this.grpData.Name = "grpData";
			this.grpData.Size = new System.Drawing.Size(686, 320);
			this.grpData.TabIndex = 16;
			this.grpData.TabStop = false;
			this.grpData.Text = "URL Parameters";
			// 
			// btnCopySupplierSubID
			// 
			this.btnCopySupplierSubID.Location = new System.Drawing.Point(303, 53);
			this.btnCopySupplierSubID.Name = "btnCopySupplierSubID";
			this.btnCopySupplierSubID.Size = new System.Drawing.Size(75, 23);
			this.btnCopySupplierSubID.TabIndex = 16;
			this.btnCopySupplierSubID.Text = "Copy ID";
			this.btnCopySupplierSubID.UseVisualStyleBackColor = true;
			this.btnCopySupplierSubID.Click += new System.EventHandler(this.btnCopySupplierSubID_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(9, 424);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(38, 13);
			this.label9.TabIndex = 17;
			this.label9.Text = "HMAC";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(9, 478);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(54, 13);
			this.label10.TabIndex = 19;
			this.label10.Text = "Entry Link";
			// 
			// txtEntryLink
			// 
			this.txtEntryLink.Location = new System.Drawing.Point(12, 494);
			this.txtEntryLink.Name = "txtEntryLink";
			this.txtEntryLink.ReadOnly = true;
			this.txtEntryLink.Size = new System.Drawing.Size(1022, 20);
			this.txtEntryLink.TabIndex = 20;
			// 
			// btnExit
			// 
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnExit.Location = new System.Drawing.Point(546, 536);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 21;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnCopy
			// 
			this.btnCopy.Location = new System.Drawing.Point(436, 536);
			this.btnCopy.Name = "btnCopy";
			this.btnCopy.Size = new System.Drawing.Size(75, 23);
			this.btnCopy.TabIndex = 22;
			this.btnCopy.Text = "Copy";
			this.btnCopy.UseVisualStyleBackColor = true;
			this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
			// 
			// btnCalculate
			// 
			this.btnCalculate.Location = new System.Drawing.Point(12, 338);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(75, 23);
			this.btnCalculate.TabIndex = 23;
			this.btnCalculate.Text = "Calculate";
			this.btnCalculate.UseVisualStyleBackColor = true;
			this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
			// 
			// btnTest
			// 
			this.btnTest.Location = new System.Drawing.Point(623, 338);
			this.btnTest.Name = "btnTest";
			this.btnTest.Size = new System.Drawing.Size(75, 23);
			this.btnTest.TabIndex = 24;
			this.btnTest.Text = "Test Data";
			this.btnTest.UseVisualStyleBackColor = true;
			this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(9, 391);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(64, 13);
			this.label12.TabIndex = 25;
			this.label12.Text = "HMAC Data";
			// 
			// txtHMAC
			// 
			this.txtHMAC.AutoSize = true;
			this.txtHMAC.Location = new System.Drawing.Point(117, 424);
			this.txtHMAC.Name = "txtHMAC";
			this.txtHMAC.Size = new System.Drawing.Size(62, 13);
			this.txtHMAC.TabIndex = 18;
			this.txtHMAC.Text = "(calculated)";
			// 
			// txtHmacData
			// 
			this.txtHmacData.Location = new System.Drawing.Point(120, 391);
			this.txtHmacData.Name = "txtHmacData";
			this.txtHmacData.ReadOnly = true;
			this.txtHmacData.Size = new System.Drawing.Size(914, 20);
			this.txtHmacData.TabIndex = 26;
			// 
			// rbSecretIsAscii
			// 
			this.rbSecretIsAscii.AutoSize = true;
			this.rbSecretIsAscii.Checked = true;
			this.rbSecretIsAscii.Location = new System.Drawing.Point(6, 19);
			this.rbSecretIsAscii.Name = "rbSecretIsAscii";
			this.rbSecretIsAscii.Size = new System.Drawing.Size(117, 17);
			this.rbSecretIsAscii.TabIndex = 17;
			this.rbSecretIsAscii.TabStop = true;
			this.rbSecretIsAscii.Text = "Secret Key is ASCII";
			this.rbSecretIsAscii.UseVisualStyleBackColor = true;
			// 
			// rbSecretIsHex
			// 
			this.rbSecretIsHex.AutoSize = true;
			this.rbSecretIsHex.Location = new System.Drawing.Point(6, 42);
			this.rbSecretIsHex.Name = "rbSecretIsHex";
			this.rbSecretIsHex.Size = new System.Drawing.Size(109, 17);
			this.rbSecretIsHex.TabIndex = 18;
			this.rbSecretIsHex.Text = "Secret Key is Hex";
			this.rbSecretIsHex.UseVisualStyleBackColor = true;
			// 
			// grpSecretKeyType
			// 
			this.grpSecretKeyType.Controls.Add(this.rbSecretIsAscii);
			this.grpSecretKeyType.Controls.Add(this.rbSecretIsHex);
			this.grpSecretKeyType.Location = new System.Drawing.Point(37, 238);
			this.grpSecretKeyType.Name = "grpSecretKeyType";
			this.grpSecretKeyType.Size = new System.Drawing.Size(130, 73);
			this.grpSecretKeyType.TabIndex = 19;
			this.grpSecretKeyType.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1046, 570);
			this.Controls.Add(this.txtHmacData);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.btnTest);
			this.Controls.Add(this.btnCalculate);
			this.Controls.Add(this.btnCopy);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.txtEntryLink);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txtHMAC);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.grpData);
			this.Name = "Form1";
			this.Text = "Router Tester";
			this.grpData.ResumeLayout(false);
			this.grpData.PerformLayout();
			this.grpSecretKeyType.ResumeLayout(false);
			this.grpSecretKeyType.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtSupplierID;
		private System.Windows.Forms.TextBox txtSupplierSubID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtUniqueUserID;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtDOB;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cboGender;
		private System.Windows.Forms.TextBox txtIPAddress;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtSecretKey;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.GroupBox grpData;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtEntryLink;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnCopy;
		private System.Windows.Forms.Button btnCalculate;
		private System.Windows.Forms.Button btnTest;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label txtHMAC;
		private System.Windows.Forms.TextBox txtHmacData;
		private System.Windows.Forms.Button btnCopySupplierSubID;
		private System.Windows.Forms.GroupBox grpSecretKeyType;
		private System.Windows.Forms.RadioButton rbSecretIsAscii;
		private System.Windows.Forms.RadioButton rbSecretIsHex;
	}
}

