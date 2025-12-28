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
            txtTitle = new TextBox();
            label3 = new Label();
            txtMiddleName = new TextBox();
            lblMiddleName = new Label();
            txtSc3 = new TextBox();
            txtFirstName = new TextBox();
            txtSc2 = new TextBox();
            lblFirstName = new Label();
            txtEtx = new TextBox();
            lblEtx = new Label();
            txtSurname = new TextBox();
            lblSurname = new Label();
            label2 = new Label();
            label1 = new Label();
            lblTyoe = new Label();
            lblRegion = new Label();
            lblNetwork = new Label();
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
            label6 = new Label();
            txtLrc = new TextBox();
            txtCvv = new TextBox();
            txtIso = new TextBox();
            dlgSave = new SaveFileDialog();
            tsMenu.SuspendLayout();
            grbTracks.SuspendLayout();
            grbTrack1.SuspendLayout();
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
            txtTracks.Font = new Font("Consolas", 10F);
            txtTracks.Location = new Point(12, 28);
            txtTracks.Name = "txtTracks";
            txtTracks.ReadOnly = true;
            txtTracks.Size = new Size(1240, 23);
            txtTracks.TabIndex = 1;
            // 
            // grbTracks
            // 
            grbTracks.Controls.Add(txtTrack3);
            grbTracks.Controls.Add(txtTrack2);
            grbTracks.Controls.Add(txtTrack1);
            grbTracks.Location = new Point(12, 57);
            grbTracks.Name = "grbTracks";
            grbTracks.Size = new Size(1240, 113);
            grbTracks.TabIndex = 2;
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
            txtTrack3.TabIndex = 4;
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
            txtTrack2.TabIndex = 4;
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
            txtTrack1.TabIndex = 3;
            // 
            // grbTrack1
            // 
            grbTrack1.Controls.Add(txtTitle);
            grbTrack1.Controls.Add(label3);
            grbTrack1.Controls.Add(txtMiddleName);
            grbTrack1.Controls.Add(lblMiddleName);
            grbTrack1.Controls.Add(txtSc3);
            grbTrack1.Controls.Add(txtFirstName);
            grbTrack1.Controls.Add(txtSc2);
            grbTrack1.Controls.Add(lblFirstName);
            grbTrack1.Controls.Add(txtEtx);
            grbTrack1.Controls.Add(lblEtx);
            grbTrack1.Controls.Add(txtSurname);
            grbTrack1.Controls.Add(lblSurname);
            grbTrack1.Controls.Add(label2);
            grbTrack1.Controls.Add(label1);
            grbTrack1.Controls.Add(lblTyoe);
            grbTrack1.Controls.Add(lblRegion);
            grbTrack1.Controls.Add(lblNetwork);
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
            grbTrack1.Controls.Add(label6);
            grbTrack1.Controls.Add(txtLrc);
            grbTrack1.Controls.Add(txtCvv);
            grbTrack1.Controls.Add(txtIso);
            grbTrack1.Location = new Point(12, 176);
            grbTrack1.Name = "grbTrack1";
            grbTrack1.Size = new Size(1234, 141);
            grbTrack1.TabIndex = 3;
            grbTrack1.TabStop = false;
            grbTrack1.Text = "Track 1";
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Consolas", 10F);
            txtTitle.Location = new Point(972, 52);
            txtTitle.Name = "txtTitle";
            txtTitle.ReadOnly = true;
            txtTitle.Size = new Size(50, 23);
            txtTitle.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(937, 56);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 10;
            label3.Text = "Title";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Font = new Font("Consolas", 10F);
            txtMiddleName.Location = new Point(911, 52);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.ReadOnly = true;
            txtMiddleName.Size = new Size(20, 23);
            txtMiddleName.TabIndex = 9;
            // 
            // lblMiddleName
            // 
            lblMiddleName.AutoSize = true;
            lblMiddleName.Location = new Point(826, 56);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new Size(79, 15);
            lblMiddleName.TabIndex = 9;
            lblMiddleName.Text = "Middle Name";
            lblMiddleName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSc3
            // 
            txtSc3.BackColor = Color.Silver;
            txtSc3.Font = new Font("Consolas", 10F);
            txtSc3.Location = new Point(828, 81);
            txtSc3.Name = "txtSc3";
            txtSc3.ReadOnly = true;
            txtSc3.Size = new Size(400, 23);
            txtSc3.TabIndex = 14;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Consolas", 10F);
            txtFirstName.Location = new Point(720, 52);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.ReadOnly = true;
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 8;
            // 
            // txtSc2
            // 
            txtSc2.BackColor = Color.Silver;
            txtSc2.Font = new Font("Consolas", 10F);
            txtSc2.Location = new Point(418, 81);
            txtSc2.Name = "txtSc2";
            txtSc2.ReadOnly = true;
            txtSc2.Size = new Size(400, 23);
            txtSc2.TabIndex = 14;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(651, 56);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(64, 15);
            lblFirstName.TabIndex = 8;
            lblFirstName.Text = "First Name";
            lblFirstName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtEtx
            // 
            txtEtx.Font = new Font("Consolas", 10F);
            txtEtx.Location = new Point(346, 110);
            txtEtx.Name = "txtEtx";
            txtEtx.ReadOnly = true;
            txtEtx.Size = new Size(15, 23);
            txtEtx.TabIndex = 6;
            // 
            // lblEtx
            // 
            lblEtx.AutoSize = true;
            lblEtx.Location = new Point(314, 113);
            lblEtx.Name = "lblEtx";
            lblEtx.Size = new Size(26, 15);
            lblEtx.TabIndex = 12;
            lblEtx.Text = "ETX";
            lblEtx.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSurname
            // 
            txtSurname.Font = new Font("Consolas", 10F);
            txtSurname.Location = new Point(544, 52);
            txtSurname.Name = "txtSurname";
            txtSurname.ReadOnly = true;
            txtSurname.Size = new Size(100, 23);
            txtSurname.TabIndex = 7;
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Location = new Point(485, 55);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(54, 15);
            lblSurname.TabIndex = 7;
            lblSurname.Text = "Surname";
            lblSurname.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(382, 56);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 5;
            label2.Text = "CVV Length";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 56);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 5;
            label1.Text = "Standard";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTyoe
            // 
            lblTyoe.AutoSize = true;
            lblTyoe.Location = new Point(1009, 26);
            lblTyoe.Name = "lblTyoe";
            lblTyoe.Size = new Size(31, 15);
            lblTyoe.TabIndex = 6;
            lblTyoe.Text = "Type";
            lblTyoe.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblRegion
            // 
            lblRegion.AutoSize = true;
            lblRegion.Location = new Point(806, 26);
            lblRegion.Name = "lblRegion";
            lblRegion.Size = new Size(92, 15);
            lblRegion.TabIndex = 6;
            lblRegion.Text = "Region/Country";
            lblRegion.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNetwork
            // 
            lblNetwork.AutoSize = true;
            lblNetwork.Location = new Point(650, 26);
            lblNetwork.Name = "lblNetwork";
            lblNetwork.Size = new Size(38, 15);
            lblNetwork.TabIndex = 5;
            lblNetwork.Text = "Brand";
            lblNetwork.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtStx
            // 
            txtStx.Font = new Font("Consolas", 10F);
            txtStx.Location = new Point(38, 23);
            txtStx.Name = "txtStx";
            txtStx.ReadOnly = true;
            txtStx.Size = new Size(15, 23);
            txtStx.TabIndex = 5;
            // 
            // lblSTX
            // 
            lblSTX.AutoSize = true;
            lblSTX.Location = new Point(6, 26);
            lblSTX.Name = "lblSTX";
            lblSTX.Size = new Size(26, 15);
            lblSTX.TabIndex = 4;
            lblSTX.Text = "STX";
            lblSTX.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 113);
            label9.Name = "label9";
            label9.Size = new Size(23, 15);
            label9.TabIndex = 11;
            label9.Text = "DD";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtDd
            // 
            txtDd.Font = new Font("Consolas", 10F);
            txtDd.Location = new Point(35, 110);
            txtDd.Name = "txtDd";
            txtDd.ReadOnly = true;
            txtDd.Size = new Size(273, 23);
            txtDd.TabIndex = 14;
            // 
            // lblFC
            // 
            lblFC.AutoSize = true;
            lblFC.Location = new Point(59, 26);
            lblFC.Name = "lblFC";
            lblFC.Size = new Size(21, 15);
            lblFC.TabIndex = 0;
            lblFC.Text = "FC";
            lblFC.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtFormatCode
            // 
            txtFormatCode.Font = new Font("Consolas", 10F);
            txtFormatCode.Location = new Point(86, 23);
            txtFormatCode.Name = "txtFormatCode";
            txtFormatCode.ReadOnly = true;
            txtFormatCode.Size = new Size(15, 23);
            txtFormatCode.TabIndex = 4;
            // 
            // txtFormatCodeDescription
            // 
            txtFormatCodeDescription.BackColor = Color.Silver;
            txtFormatCodeDescription.Font = new Font("Consolas", 10F);
            txtFormatCodeDescription.Location = new Point(107, 23);
            txtFormatCodeDescription.Name = "txtFormatCodeDescription";
            txtFormatCodeDescription.ReadOnly = true;
            txtFormatCodeDescription.Size = new Size(269, 23);
            txtFormatCodeDescription.TabIndex = 5;
            // 
            // lblPan
            // 
            lblPan.AutoSize = true;
            lblPan.Location = new Point(382, 26);
            lblPan.Name = "lblPan";
            lblPan.Size = new Size(30, 15);
            lblPan.TabIndex = 4;
            lblPan.Text = "PAN";
            lblPan.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtPrimaryAccountNumber
            // 
            txtPrimaryAccountNumber.Font = new Font("Consolas", 10F);
            txtPrimaryAccountNumber.Location = new Point(418, 23);
            txtPrimaryAccountNumber.Name = "txtPrimaryAccountNumber";
            txtPrimaryAccountNumber.ReadOnly = true;
            txtPrimaryAccountNumber.Size = new Size(170, 23);
            txtPrimaryAccountNumber.TabIndex = 6;
            // 
            // txtPrimaryAccountNumberValidated
            // 
            txtPrimaryAccountNumberValidated.BackColor = Color.Silver;
            txtPrimaryAccountNumberValidated.Font = new Font("Consolas", 10F);
            txtPrimaryAccountNumberValidated.Location = new Point(594, 23);
            txtPrimaryAccountNumberValidated.Name = "txtPrimaryAccountNumberValidated";
            txtPrimaryAccountNumberValidated.ReadOnly = true;
            txtPrimaryAccountNumberValidated.Size = new Size(50, 23);
            txtPrimaryAccountNumberValidated.TabIndex = 7;
            // 
            // txtSc1
            // 
            txtSc1.BackColor = Color.Silver;
            txtSc1.Font = new Font("Consolas", 10F);
            txtSc1.Location = new Point(6, 81);
            txtSc1.Name = "txtSc1";
            txtSc1.ReadOnly = true;
            txtSc1.Size = new Size(400, 23);
            txtSc1.TabIndex = 14;
            // 
            // txtBrand
            // 
            txtBrand.BackColor = Color.Silver;
            txtBrand.Font = new Font("Consolas", 10F);
            txtBrand.Location = new Point(694, 23);
            txtBrand.Name = "txtBrand";
            txtBrand.ReadOnly = true;
            txtBrand.Size = new Size(106, 23);
            txtBrand.TabIndex = 7;
            // 
            // txtSc
            // 
            txtSc.Font = new Font("Consolas", 10F);
            txtSc.Location = new Point(1198, 52);
            txtSc.Name = "txtSc";
            txtSc.ReadOnly = true;
            txtSc.Size = new Size(30, 23);
            txtSc.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1171, 56);
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
            txtRegion.Location = new Point(904, 23);
            txtRegion.Name = "txtRegion";
            txtRegion.ReadOnly = true;
            txtRegion.Size = new Size(99, 23);
            txtRegion.TabIndex = 8;
            // 
            // txtExpired
            // 
            txtExpired.BackColor = Color.Silver;
            txtExpired.Font = new Font("Consolas", 10F);
            txtExpired.Location = new Point(1110, 52);
            txtExpired.Name = "txtExpired";
            txtExpired.ReadOnly = true;
            txtExpired.Size = new Size(55, 23);
            txtExpired.TabIndex = 8;
            // 
            // txtDate
            // 
            txtDate.Font = new Font("Consolas", 10F);
            txtDate.Location = new Point(1064, 52);
            txtDate.Name = "txtDate";
            txtDate.ReadOnly = true;
            txtDate.Size = new Size(40, 23);
            txtDate.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1028, 56);
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
            txtType.Location = new Point(1046, 23);
            txtType.Name = "txtType";
            txtType.ReadOnly = true;
            txtType.Size = new Size(182, 23);
            txtType.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(367, 113);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 10;
            label6.Text = "CalculatedLRC";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtLrc
            // 
            txtLrc.BackColor = Color.Silver;
            txtLrc.Font = new Font("Consolas", 10F);
            txtLrc.Location = new Point(454, 110);
            txtLrc.Name = "txtLrc";
            txtLrc.ReadOnly = true;
            txtLrc.Size = new Size(25, 23);
            txtLrc.TabIndex = 12;
            // 
            // txtCvv
            // 
            txtCvv.BackColor = Color.Silver;
            txtCvv.Font = new Font("Consolas", 10F);
            txtCvv.Location = new Point(464, 52);
            txtCvv.Name = "txtCvv";
            txtCvv.ReadOnly = true;
            txtCvv.Size = new Size(15, 23);
            txtCvv.TabIndex = 10;
            // 
            // txtIso
            // 
            txtIso.BackColor = Color.Silver;
            txtIso.Font = new Font("Consolas", 10F);
            txtIso.Location = new Point(66, 52);
            txtIso.Name = "txtIso";
            txtIso.ReadOnly = true;
            txtIso.Size = new Size(310, 23);
            txtIso.TabIndex = 11;
            // 
            // SwipeSenseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
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
        private Label label6;
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
        private Label lblNetwork;
        private Label lblRegion;
        private Label lblTyoe;
        private Label label2;
        private Label label1;
        private ToolStripButton tsbOpen;
        private TextBox txtSurname;
        private Label lblSurname;
        private TextBox txtEtx;
        private Label lblEtx;
        private TextBox txtFirstName;
        private Label lblFirstName;
        private TextBox txtMiddleName;
        private Label lblMiddleName;
        private TextBox txtTitle;
        private Label label3;
    }
}
