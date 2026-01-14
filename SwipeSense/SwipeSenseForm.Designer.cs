namespace SwipeSense
{
    partial class SwipeSenseForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SwipeSenseForm));
            tsMenu = new ToolStrip();
            tsbSave = new ToolStripButton();
            tsbOpen = new ToolStripButton();
            txtTracks = new TextBox();
            grbTracks = new GroupBox();
            txtTrack3 = new TextBox();
            txtTrack2 = new TextBox();
            txtTrack1 = new TextBox();
            grbTrack1 = new GroupBox();
            txtName = new TextBox();
            label1 = new Label();
            txtTitle = new TextBox();
            txtMiddleName = new TextBox();
            txtSc3 = new TextBox();
            txtFirstName = new TextBox();
            txtSc2 = new TextBox();
            txtEtx = new TextBox();
            lblEtx = new Label();
            txtSurname = new TextBox();
            txtStx = new TextBox();
            lblSTX = new Label();
            label9 = new Label();
            txtDd = new TextBox();
            lblFC = new Label();
            txtFormatCode = new TextBox();
            txtFormatCodeDescription = new TextBox();
            lblPan = new Label();
            txtPrimaryAccountNumber = new TextBox();
            txtPrimaryAccountNumberValidated = new TextBox();
            txtSc1 = new TextBox();
            txtBrand = new TextBox();
            txtSc = new TextBox();
            label8 = new Label();
            txtRegion = new TextBox();
            txtExpired = new TextBox();
            txtDate = new TextBox();
            label7 = new Label();
            txtType = new TextBox();
            txtLrc = new TextBox();
            txtCvv = new TextBox();
            txtIso = new TextBox();
            dlgSave = new SaveFileDialog();
            groupBox1 = new GroupBox();
            txtT2pan = new TextBox();
            lblT2pan = new Label();
            txtT2stx = new TextBox();
            label2 = new Label();
            tsMenu.SuspendLayout();
            grbTracks.SuspendLayout();
            grbTrack1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tsMenu
            // 
            tsMenu.ImageScalingSize = new Size(20, 20);
            tsMenu.Items.AddRange(new ToolStripItem[] { tsbSave, tsbOpen });
            tsMenu.Location = new Point(0, 0);
            tsMenu.Name = "tsMenu";
            tsMenu.Size = new Size(1264, 27);
            tsMenu.TabIndex = 0;
            tsMenu.Text = "toolStrip1";
            // 
            // tsbSave
            // 
            tsbSave.Image = Properties.Resources.saveHS;
            tsbSave.ImageAlign = ContentAlignment.MiddleLeft;
            tsbSave.ImageTransparentColor = Color.Magenta;
            tsbSave.Name = "tsbSave";
            tsbSave.Size = new Size(55, 24);
            tsbSave.Text = "Save";
            tsbSave.TextAlign = ContentAlignment.MiddleRight;
            tsbSave.Click += tsbSave_Click;
            // 
            // tsbOpen
            // 
            tsbOpen.Image = Properties.Resources.openHS;
            tsbOpen.ImageAlign = ContentAlignment.MiddleLeft;
            tsbOpen.ImageTransparentColor = Color.Magenta;
            tsbOpen.Name = "tsbOpen";
            tsbOpen.Size = new Size(60, 24);
            tsbOpen.Text = "Open";
            tsbOpen.TextAlign = ContentAlignment.MiddleRight;
            tsbOpen.Click += tsbOpen_Click;
            // 
            // txtTracks
            // 
            txtTracks.BackColor = Color.White;
            txtTracks.Font = new Font("Consolas", 10F, FontStyle.Bold);
            txtTracks.ForeColor = Color.Black;
            txtTracks.Location = new Point(12, 28);
            txtTracks.Name = "txtTracks";
            txtTracks.ReadOnly = true;
            txtTracks.Size = new Size(1240, 23);
            txtTracks.TabIndex = 0;
            txtTracks.TextAlign = HorizontalAlignment.Center;
            // 
            // grbTracks
            // 
            grbTracks.Controls.Add(txtTrack3);
            grbTracks.Controls.Add(txtTrack2);
            grbTracks.Controls.Add(txtTrack1);
            grbTracks.Location = new Point(12, 57);
            grbTracks.Name = "grbTracks";
            grbTracks.Size = new Size(1240, 113);
            grbTracks.TabIndex = 1;
            grbTracks.TabStop = false;
            grbTracks.Text = "Tracks";
            // 
            // txtTrack3
            // 
            txtTrack3.BackColor = Color.Black;
            txtTrack3.Font = new Font("Consolas", 10F);
            txtTrack3.ForeColor = Color.White;
            txtTrack3.Location = new Point(6, 80);
            txtTrack3.Name = "txtTrack3";
            txtTrack3.ReadOnly = true;
            txtTrack3.Size = new Size(1228, 23);
            txtTrack3.TabIndex = 3;
            // 
            // txtTrack2
            // 
            txtTrack2.BackColor = Color.Black;
            txtTrack2.Font = new Font("Consolas", 10F);
            txtTrack2.ForeColor = Color.White;
            txtTrack2.Location = new Point(6, 51);
            txtTrack2.Name = "txtTrack2";
            txtTrack2.ReadOnly = true;
            txtTrack2.Size = new Size(1228, 23);
            txtTrack2.TabIndex = 2;
            // 
            // txtTrack1
            // 
            txtTrack1.BackColor = Color.Black;
            txtTrack1.Font = new Font("Consolas", 10F);
            txtTrack1.ForeColor = Color.White;
            txtTrack1.Location = new Point(6, 22);
            txtTrack1.Name = "txtTrack1";
            txtTrack1.ReadOnly = true;
            txtTrack1.Size = new Size(1228, 23);
            txtTrack1.TabIndex = 1;
            // 
            // grbTrack1
            // 
            grbTrack1.Controls.Add(txtName);
            grbTrack1.Controls.Add(label1);
            grbTrack1.Controls.Add(txtTitle);
            grbTrack1.Controls.Add(txtMiddleName);
            grbTrack1.Controls.Add(txtSc3);
            grbTrack1.Controls.Add(txtFirstName);
            grbTrack1.Controls.Add(txtSc2);
            grbTrack1.Controls.Add(txtEtx);
            grbTrack1.Controls.Add(lblEtx);
            grbTrack1.Controls.Add(txtSurname);
            grbTrack1.Controls.Add(txtStx);
            grbTrack1.Controls.Add(lblSTX);
            grbTrack1.Controls.Add(label9);
            grbTrack1.Controls.Add(txtDd);
            grbTrack1.Controls.Add(lblFC);
            grbTrack1.Controls.Add(txtFormatCode);
            grbTrack1.Controls.Add(txtFormatCodeDescription);
            grbTrack1.Controls.Add(lblPan);
            grbTrack1.Controls.Add(txtPrimaryAccountNumber);
            grbTrack1.Controls.Add(txtPrimaryAccountNumberValidated);
            grbTrack1.Controls.Add(txtSc1);
            grbTrack1.Controls.Add(txtBrand);
            grbTrack1.Controls.Add(txtSc);
            grbTrack1.Controls.Add(label8);
            grbTrack1.Controls.Add(txtRegion);
            grbTrack1.Controls.Add(txtExpired);
            grbTrack1.Controls.Add(txtDate);
            grbTrack1.Controls.Add(label7);
            grbTrack1.Controls.Add(txtType);
            grbTrack1.Controls.Add(txtLrc);
            grbTrack1.Controls.Add(txtCvv);
            grbTrack1.Controls.Add(txtIso);
            grbTrack1.Location = new Point(12, 176);
            grbTrack1.Name = "grbTrack1";
            grbTrack1.Size = new Size(1234, 171);
            grbTrack1.TabIndex = 4;
            grbTrack1.TabStop = false;
            grbTrack1.Text = "Track 1";
            // 
            // txtName
            // 
            txtName.Font = new Font("Consolas", 10F);
            txtName.Location = new Point(72, 80);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(207, 23);
            txtName.TabIndex = 14;
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 84);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 8;
            label1.Text = "Cardholder";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.Silver;
            txtTitle.Font = new Font("Consolas", 10F);
            txtTitle.Location = new Point(853, 80);
            txtTitle.Name = "txtTitle";
            txtTitle.ReadOnly = true;
            txtTitle.Size = new Size(150, 23);
            txtTitle.TabIndex = 18;
            txtTitle.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMiddleName
            // 
            txtMiddleName.BackColor = Color.Silver;
            txtMiddleName.Font = new Font("Consolas", 10F);
            txtMiddleName.Location = new Point(697, 80);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.ReadOnly = true;
            txtMiddleName.Size = new Size(150, 23);
            txtMiddleName.TabIndex = 17;
            txtMiddleName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSc3
            // 
            txtSc3.BackColor = Color.Silver;
            txtSc3.Font = new Font("Consolas", 10F);
            txtSc3.Location = new Point(817, 109);
            txtSc3.Name = "txtSc3";
            txtSc3.ReadOnly = true;
            txtSc3.Size = new Size(411, 23);
            txtSc3.TabIndex = 24;
            txtSc3.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.Silver;
            txtFirstName.Font = new Font("Consolas", 10F);
            txtFirstName.Location = new Point(491, 80);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.ReadOnly = true;
            txtFirstName.Size = new Size(200, 23);
            txtFirstName.TabIndex = 16;
            txtFirstName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSc2
            // 
            txtSc2.BackColor = Color.Silver;
            txtSc2.Font = new Font("Consolas", 10F);
            txtSc2.Location = new Point(441, 109);
            txtSc2.Name = "txtSc2";
            txtSc2.ReadOnly = true;
            txtSc2.Size = new Size(370, 23);
            txtSc2.TabIndex = 23;
            txtSc2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtEtx
            // 
            txtEtx.Font = new Font("Consolas", 10F);
            txtEtx.Location = new Point(360, 138);
            txtEtx.Name = "txtEtx";
            txtEtx.ReadOnly = true;
            txtEtx.Size = new Size(15, 23);
            txtEtx.TabIndex = 26;
            txtEtx.TextAlign = HorizontalAlignment.Center;
            // 
            // lblEtx
            // 
            lblEtx.AutoSize = true;
            lblEtx.Location = new Point(328, 141);
            lblEtx.Name = "lblEtx";
            lblEtx.Size = new Size(26, 15);
            lblEtx.TabIndex = 12;
            lblEtx.Text = "ETX";
            lblEtx.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSurname
            // 
            txtSurname.BackColor = Color.Silver;
            txtSurname.Font = new Font("Consolas", 10F);
            txtSurname.Location = new Point(285, 80);
            txtSurname.Name = "txtSurname";
            txtSurname.ReadOnly = true;
            txtSurname.Size = new Size(200, 23);
            txtSurname.TabIndex = 15;
            txtSurname.TextAlign = HorizontalAlignment.Center;
            // 
            // txtStx
            // 
            txtStx.Font = new Font("Consolas", 10F);
            txtStx.Location = new Point(32, 23);
            txtStx.Name = "txtStx";
            txtStx.ReadOnly = true;
            txtStx.Size = new Size(15, 23);
            txtStx.TabIndex = 4;
            txtStx.TextAlign = HorizontalAlignment.Center;
            // 
            // lblSTX
            // 
            lblSTX.AutoSize = true;
            lblSTX.Location = new Point(0, 26);
            lblSTX.Name = "lblSTX";
            lblSTX.Size = new Size(26, 15);
            lblSTX.TabIndex = 4;
            lblSTX.Text = "STX";
            lblSTX.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(0, 142);
            label9.Name = "label9";
            label9.Size = new Size(23, 15);
            label9.TabIndex = 11;
            label9.Text = "DD";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtDd
            // 
            txtDd.Font = new Font("Consolas", 10F);
            txtDd.Location = new Point(29, 138);
            txtDd.Name = "txtDd";
            txtDd.ReadOnly = true;
            txtDd.Size = new Size(273, 23);
            txtDd.TabIndex = 25;
            txtDd.TextAlign = HorizontalAlignment.Center;
            // 
            // lblFC
            // 
            lblFC.AutoSize = true;
            lblFC.Location = new Point(53, 26);
            lblFC.Name = "lblFC";
            lblFC.Size = new Size(21, 15);
            lblFC.TabIndex = 0;
            lblFC.Text = "FC";
            lblFC.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtFormatCode
            // 
            txtFormatCode.Font = new Font("Consolas", 10F);
            txtFormatCode.Location = new Point(80, 22);
            txtFormatCode.Name = "txtFormatCode";
            txtFormatCode.ReadOnly = true;
            txtFormatCode.Size = new Size(15, 23);
            txtFormatCode.TabIndex = 5;
            txtFormatCode.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFormatCodeDescription
            // 
            txtFormatCodeDescription.BackColor = Color.Silver;
            txtFormatCodeDescription.Font = new Font("Consolas", 10F);
            txtFormatCodeDescription.Location = new Point(98, 22);
            txtFormatCodeDescription.Name = "txtFormatCodeDescription";
            txtFormatCodeDescription.ReadOnly = true;
            txtFormatCodeDescription.Size = new Size(338, 23);
            txtFormatCodeDescription.TabIndex = 6;
            txtFormatCodeDescription.TextAlign = HorizontalAlignment.Center;
            // 
            // lblPan
            // 
            lblPan.AutoSize = true;
            lblPan.Location = new Point(0, 55);
            lblPan.Name = "lblPan";
            lblPan.Size = new Size(30, 15);
            lblPan.TabIndex = 4;
            lblPan.Text = "PAN";
            lblPan.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtPrimaryAccountNumber
            // 
            txtPrimaryAccountNumber.Font = new Font("Consolas", 10F);
            txtPrimaryAccountNumber.Location = new Point(36, 51);
            txtPrimaryAccountNumber.Name = "txtPrimaryAccountNumber";
            txtPrimaryAccountNumber.ReadOnly = true;
            txtPrimaryAccountNumber.Size = new Size(170, 23);
            txtPrimaryAccountNumber.TabIndex = 7;
            txtPrimaryAccountNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPrimaryAccountNumberValidated
            // 
            txtPrimaryAccountNumberValidated.BackColor = Color.Silver;
            txtPrimaryAccountNumberValidated.Font = new Font("Consolas", 10F);
            txtPrimaryAccountNumberValidated.Location = new Point(212, 51);
            txtPrimaryAccountNumberValidated.Name = "txtPrimaryAccountNumberValidated";
            txtPrimaryAccountNumberValidated.ReadOnly = true;
            txtPrimaryAccountNumberValidated.Size = new Size(62, 23);
            txtPrimaryAccountNumberValidated.TabIndex = 8;
            txtPrimaryAccountNumberValidated.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSc1
            // 
            txtSc1.BackColor = Color.Silver;
            txtSc1.Font = new Font("Consolas", 10F);
            txtSc1.Location = new Point(63, 109);
            txtSc1.Name = "txtSc1";
            txtSc1.ReadOnly = true;
            txtSc1.Size = new Size(372, 23);
            txtSc1.TabIndex = 22;
            txtSc1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBrand
            // 
            txtBrand.BackColor = Color.Silver;
            txtBrand.Font = new Font("Consolas", 10F);
            txtBrand.Location = new Point(280, 51);
            txtBrand.Name = "txtBrand";
            txtBrand.ReadOnly = true;
            txtBrand.Size = new Size(150, 23);
            txtBrand.TabIndex = 9;
            txtBrand.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSc
            // 
            txtSc.Font = new Font("Consolas", 10F);
            txtSc.Location = new Point(27, 109);
            txtSc.Name = "txtSc";
            txtSc.ReadOnly = true;
            txtSc.Size = new Size(30, 23);
            txtSc.TabIndex = 21;
            txtSc.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(0, 113);
            label8.Name = "label8";
            label8.Size = new Size(21, 15);
            label8.TabIndex = 10;
            label8.Text = "SC";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtRegion
            // 
            txtRegion.BackColor = Color.Silver;
            txtRegion.Font = new Font("Consolas", 10F);
            txtRegion.Location = new Point(436, 51);
            txtRegion.Name = "txtRegion";
            txtRegion.ReadOnly = true;
            txtRegion.Size = new Size(197, 23);
            txtRegion.TabIndex = 10;
            txtRegion.TextAlign = HorizontalAlignment.Center;
            // 
            // txtExpired
            // 
            txtExpired.BackColor = Color.Silver;
            txtExpired.Font = new Font("Consolas", 10F);
            txtExpired.Location = new Point(1161, 80);
            txtExpired.Name = "txtExpired";
            txtExpired.ReadOnly = true;
            txtExpired.Size = new Size(67, 23);
            txtExpired.TabIndex = 20;
            txtExpired.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDate
            // 
            txtDate.Font = new Font("Consolas", 10F);
            txtDate.Location = new Point(1107, 80);
            txtDate.Name = "txtDate";
            txtDate.ReadOnly = true;
            txtDate.Size = new Size(48, 23);
            txtDate.TabIndex = 19;
            txtDate.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1070, 83);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 6;
            label7.Text = "Date";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtType
            // 
            txtType.BackColor = Color.Silver;
            txtType.Font = new Font("Consolas", 10F);
            txtType.Location = new Point(639, 51);
            txtType.Name = "txtType";
            txtType.ReadOnly = true;
            txtType.Size = new Size(219, 23);
            txtType.TabIndex = 11;
            txtType.TextAlign = HorizontalAlignment.Center;
            // 
            // txtLrc
            // 
            txtLrc.BackColor = Color.Silver;
            txtLrc.Font = new Font("Consolas", 10F);
            txtLrc.Location = new Point(1086, 138);
            txtLrc.Name = "txtLrc";
            txtLrc.ReadOnly = true;
            txtLrc.Size = new Size(142, 23);
            txtLrc.TabIndex = 27;
            txtLrc.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCvv
            // 
            txtCvv.BackColor = Color.Silver;
            txtCvv.Font = new Font("Consolas", 10F);
            txtCvv.Location = new Point(1116, 52);
            txtCvv.Name = "txtCvv";
            txtCvv.ReadOnly = true;
            txtCvv.Size = new Size(112, 23);
            txtCvv.TabIndex = 13;
            txtCvv.TextAlign = HorizontalAlignment.Center;
            // 
            // txtIso
            // 
            txtIso.BackColor = Color.Silver;
            txtIso.Font = new Font("Consolas", 10F);
            txtIso.Location = new Point(864, 52);
            txtIso.Name = "txtIso";
            txtIso.ReadOnly = true;
            txtIso.Size = new Size(246, 23);
            txtIso.TabIndex = 12;
            txtIso.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtT2stx);
            groupBox1.Controls.Add(txtT2pan);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lblT2pan);
            groupBox1.Location = new Point(12, 353);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1228, 183);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "Track 2";
            // 
            // txtT2pan
            // 
            txtT2pan.Font = new Font("Consolas", 10F);
            txtT2pan.Location = new Point(36, 51);
            txtT2pan.Name = "txtT2pan";
            txtT2pan.ReadOnly = true;
            txtT2pan.Size = new Size(170, 23);
            txtT2pan.TabIndex = 29;
            txtT2pan.TextAlign = HorizontalAlignment.Center;
            // 
            // lblT2pan
            // 
            lblT2pan.AutoSize = true;
            lblT2pan.Location = new Point(0, 54);
            lblT2pan.Name = "lblT2pan";
            lblT2pan.Size = new Size(30, 15);
            lblT2pan.TabIndex = 29;
            lblT2pan.Text = "PAN";
            lblT2pan.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtT2stx
            // 
            txtT2stx.Font = new Font("Consolas", 10F);
            txtT2stx.Location = new Point(29, 22);
            txtT2stx.Name = "txtT2stx";
            txtT2stx.ReadOnly = true;
            txtT2stx.Size = new Size(15, 23);
            txtT2stx.TabIndex = 28;
            txtT2stx.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 25);
            label2.Name = "label2";
            label2.Size = new Size(26, 15);
            label2.TabIndex = 30;
            label2.Text = "STX";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // SwipeSenseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(groupBox1);
            Controls.Add(grbTrack1);
            Controls.Add(grbTracks);
            Controls.Add(txtTracks);
            Controls.Add(tsMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "SwipeSenseForm";
            Text = "SwipeSense";
            KeyPress += SwipeSenseForm_KeyPress;
            tsMenu.ResumeLayout(false);
            tsMenu.PerformLayout();
            grbTracks.ResumeLayout(false);
            grbTracks.PerformLayout();
            grbTrack1.ResumeLayout(false);
            grbTrack1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip tsMenu;
        private ToolStripButton tsbSave;
        private TextBox txtTracks;
        private GroupBox grbTracks;
        private TextBox txtTrack3;
        private TextBox txtTrack2;
        private TextBox txtTrack1;
        private GroupBox grbTrack1;
        private Label lblFC;
        private TextBox txtFormatCodeDescription;
        private TextBox txtFormatCode;
        private Label lblPan;
        private TextBox txtPrimaryAccountNumber;
        private TextBox txtPrimaryAccountNumberValidated;
        private TextBox txtCvv;
        private TextBox txtType;
        private TextBox txtRegion;
        private TextBox txtBrand;
        private TextBox txtExpired;
        private Label label7;
        private TextBox txtDate;
        private TextBox txtLrc;
        private TextBox txtIso;
        private TextBox txtSc;
        private Label label9;
        private TextBox txtDd;
        private TextBox txtSc3;
        private TextBox txtSc2;
        private TextBox txtSc1;
        private Label label8;
        private SaveFileDialog dlgSave;
        private TextBox txtStx;
        private Label lblSTX;
        private ToolStripButton tsbOpen;
        private TextBox txtSurname;
        private TextBox txtEtx;
        private Label lblEtx;
        private TextBox txtFirstName;
        private TextBox txtMiddleName;
        private TextBox txtTitle;
        private Label label1;
        private TextBox txtName;
        private GroupBox groupBox1;
        private TextBox txtT2pan;
        private Label lblT2pan;
        private TextBox txtT2stx;
        private Label label2;
    }
}
