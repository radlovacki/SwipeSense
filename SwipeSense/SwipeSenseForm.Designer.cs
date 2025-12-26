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
            toolStripButton1 = new ToolStripButton();
            txtTracks = new TextBox();
            grbTracks = new GroupBox();
            txtTrack3 = new TextBox();
            txtTrack2 = new TextBox();
            txtTrack1 = new TextBox();
            grbTrack1 = new GroupBox();
            label9 = new Label();
            txtDd = new TextBox();
            txtSc3 = new TextBox();
            txtSc2 = new TextBox();
            txtSc1 = new TextBox();
            label8 = new Label();
            txtSc = new TextBox();
            txtExpired = new TextBox();
            label7 = new Label();
            txtDate = new TextBox();
            txtLrc = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtIso = new TextBox();
            label4 = new Label();
            txtCVV = new TextBox();
            label3 = new Label();
            txtType = new TextBox();
            label2 = new Label();
            txtRegion = new TextBox();
            txtCard = new TextBox();
            label1 = new Label();
            txtPrimaryAccountNumberValidated = new TextBox();
            txtPrimaryAccountNumber = new TextBox();
            lblPan = new Label();
            txtFormatCodeDescription = new TextBox();
            txtFormatCode = new TextBox();
            lblFC = new Label();
            dlgSave = new SaveFileDialog();
            tsMenu.SuspendLayout();
            grbTracks.SuspendLayout();
            grbTrack1.SuspendLayout();
            SuspendLayout();
            // 
            // tsMenu
            // 
            tsMenu.ImageScalingSize = new Size(20, 20);
            tsMenu.Items.AddRange(new ToolStripItem[] { toolStripButton1 });
            tsMenu.Location = new Point(0, 0);
            tsMenu.Name = "tsMenu";
            tsMenu.Size = new Size(1445, 27);
            tsMenu.TabIndex = 0;
            tsMenu.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources.saveHS;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(29, 24);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // txtTracks
            // 
            txtTracks.Font = new Font("Consolas", 10F);
            txtTracks.Location = new Point(14, 37);
            txtTracks.Margin = new Padding(3, 4, 3, 4);
            txtTracks.Name = "txtTracks";
            txtTracks.ReadOnly = true;
            txtTracks.Size = new Size(1417, 27);
            txtTracks.TabIndex = 1;
            // 
            // grbTracks
            // 
            grbTracks.Controls.Add(txtTrack3);
            grbTracks.Controls.Add(txtTrack2);
            grbTracks.Controls.Add(txtTrack1);
            grbTracks.Location = new Point(14, 76);
            grbTracks.Margin = new Padding(3, 4, 3, 4);
            grbTracks.Name = "grbTracks";
            grbTracks.Padding = new Padding(3, 4, 3, 4);
            grbTracks.Size = new Size(1417, 151);
            grbTracks.TabIndex = 2;
            grbTracks.TabStop = false;
            grbTracks.Text = "Tracks";
            // 
            // txtTrack3
            // 
            txtTrack3.BackColor = Color.Black;
            txtTrack3.Font = new Font("Consolas", 10F);
            txtTrack3.ForeColor = Color.White;
            txtTrack3.Location = new Point(7, 107);
            txtTrack3.Margin = new Padding(3, 4, 3, 4);
            txtTrack3.Name = "txtTrack3";
            txtTrack3.ReadOnly = true;
            txtTrack3.Size = new Size(1403, 27);
            txtTrack3.TabIndex = 4;
            // 
            // txtTrack2
            // 
            txtTrack2.BackColor = Color.Black;
            txtTrack2.Font = new Font("Consolas", 10F);
            txtTrack2.ForeColor = Color.White;
            txtTrack2.Location = new Point(7, 68);
            txtTrack2.Margin = new Padding(3, 4, 3, 4);
            txtTrack2.Name = "txtTrack2";
            txtTrack2.ReadOnly = true;
            txtTrack2.Size = new Size(1403, 27);
            txtTrack2.TabIndex = 4;
            // 
            // txtTrack1
            // 
            txtTrack1.BackColor = Color.Black;
            txtTrack1.Font = new Font("Consolas", 10F);
            txtTrack1.ForeColor = Color.White;
            txtTrack1.Location = new Point(7, 29);
            txtTrack1.Margin = new Padding(3, 4, 3, 4);
            txtTrack1.Name = "txtTrack1";
            txtTrack1.ReadOnly = true;
            txtTrack1.Size = new Size(1403, 27);
            txtTrack1.TabIndex = 3;
            // 
            // grbTrack1
            // 
            grbTrack1.Controls.Add(label9);
            grbTrack1.Controls.Add(txtDd);
            grbTrack1.Controls.Add(txtSc3);
            grbTrack1.Controls.Add(txtSc2);
            grbTrack1.Controls.Add(txtSc1);
            grbTrack1.Controls.Add(label8);
            grbTrack1.Controls.Add(txtSc);
            grbTrack1.Controls.Add(txtExpired);
            grbTrack1.Controls.Add(label7);
            grbTrack1.Controls.Add(txtDate);
            grbTrack1.Controls.Add(txtLrc);
            grbTrack1.Controls.Add(label6);
            grbTrack1.Controls.Add(label5);
            grbTrack1.Controls.Add(txtIso);
            grbTrack1.Controls.Add(label4);
            grbTrack1.Controls.Add(txtCVV);
            grbTrack1.Controls.Add(label3);
            grbTrack1.Controls.Add(txtType);
            grbTrack1.Controls.Add(label2);
            grbTrack1.Controls.Add(txtRegion);
            grbTrack1.Controls.Add(txtCard);
            grbTrack1.Controls.Add(label1);
            grbTrack1.Controls.Add(txtPrimaryAccountNumberValidated);
            grbTrack1.Controls.Add(txtPrimaryAccountNumber);
            grbTrack1.Controls.Add(lblPan);
            grbTrack1.Controls.Add(txtFormatCodeDescription);
            grbTrack1.Controls.Add(txtFormatCode);
            grbTrack1.Controls.Add(lblFC);
            grbTrack1.Location = new Point(14, 235);
            grbTrack1.Margin = new Padding(3, 4, 3, 4);
            grbTrack1.Name = "grbTrack1";
            grbTrack1.Padding = new Padding(3, 4, 3, 4);
            grbTrack1.Size = new Size(457, 657);
            grbTrack1.TabIndex = 3;
            grbTrack1.TabStop = false;
            grbTrack1.Text = "Track 1";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(39, 495);
            label9.Name = "label9";
            label9.Size = new Size(31, 20);
            label9.TabIndex = 11;
            label9.Text = "DD";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtDd
            // 
            txtDd.Font = new Font("Consolas", 10F);
            txtDd.Location = new Point(75, 492);
            txtDd.Margin = new Padding(3, 4, 3, 4);
            txtDd.Name = "txtDd";
            txtDd.ReadOnly = true;
            txtDd.Size = new Size(375, 27);
            txtDd.TabIndex = 14;
            // 
            // txtSc3
            // 
            txtSc3.Font = new Font("Consolas", 10F);
            txtSc3.Location = new Point(74, 457);
            txtSc3.Margin = new Padding(3, 4, 3, 4);
            txtSc3.Name = "txtSc3";
            txtSc3.ReadOnly = true;
            txtSc3.Size = new Size(375, 27);
            txtSc3.TabIndex = 14;
            // 
            // txtSc2
            // 
            txtSc2.Font = new Font("Consolas", 10F);
            txtSc2.Location = new Point(74, 422);
            txtSc2.Margin = new Padding(3, 4, 3, 4);
            txtSc2.Name = "txtSc2";
            txtSc2.ReadOnly = true;
            txtSc2.Size = new Size(375, 27);
            txtSc2.TabIndex = 14;
            // 
            // txtSc1
            // 
            txtSc1.Font = new Font("Consolas", 10F);
            txtSc1.Location = new Point(74, 387);
            txtSc1.Margin = new Padding(3, 4, 3, 4);
            txtSc1.Name = "txtSc1";
            txtSc1.ReadOnly = true;
            txtSc1.Size = new Size(375, 27);
            txtSc1.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(44, 351);
            label8.Name = "label8";
            label8.Size = new Size(26, 20);
            label8.TabIndex = 10;
            label8.Text = "SC";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSc
            // 
            txtSc.Font = new Font("Consolas", 10F);
            txtSc.Location = new Point(74, 352);
            txtSc.Margin = new Padding(3, 4, 3, 4);
            txtSc.Name = "txtSc";
            txtSc.ReadOnly = true;
            txtSc.Size = new Size(375, 27);
            txtSc.TabIndex = 13;
            // 
            // txtExpired
            // 
            txtExpired.Font = new Font("Consolas", 10F);
            txtExpired.Location = new Point(322, 313);
            txtExpired.Margin = new Padding(3, 4, 3, 4);
            txtExpired.Name = "txtExpired";
            txtExpired.ReadOnly = true;
            txtExpired.Size = new Size(127, 27);
            txtExpired.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 316);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 6;
            label7.Text = "Date";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtDate
            // 
            txtDate.Font = new Font("Consolas", 10F);
            txtDate.Location = new Point(74, 313);
            txtDate.Margin = new Padding(3, 4, 3, 4);
            txtDate.Name = "txtDate";
            txtDate.ReadOnly = true;
            txtDate.Size = new Size(241, 27);
            txtDate.TabIndex = 7;
            // 
            // txtLrc
            // 
            txtLrc.Font = new Font("Consolas", 10F);
            txtLrc.Location = new Point(74, 278);
            txtLrc.Margin = new Padding(3, 4, 3, 4);
            txtLrc.Name = "txtLrc";
            txtLrc.ReadOnly = true;
            txtLrc.Size = new Size(375, 27);
            txtLrc.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 281);
            label6.Name = "label6";
            label6.Size = new Size(34, 20);
            label6.TabIndex = 10;
            label6.Text = "LRC";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 246);
            label5.Name = "label5";
            label5.Size = new Size(32, 20);
            label5.TabIndex = 9;
            label5.Text = "ISO";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtIso
            // 
            txtIso.Font = new Font("Consolas", 10F);
            txtIso.Location = new Point(74, 243);
            txtIso.Margin = new Padding(3, 4, 3, 4);
            txtIso.Name = "txtIso";
            txtIso.ReadOnly = true;
            txtIso.Size = new Size(375, 27);
            txtIso.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 211);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 8;
            label4.Text = "CVV";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtCVV
            // 
            txtCVV.Font = new Font("Consolas", 10F);
            txtCVV.Location = new Point(74, 208);
            txtCVV.Margin = new Padding(3, 4, 3, 4);
            txtCVV.Name = "txtCVV";
            txtCVV.ReadOnly = true;
            txtCVV.Size = new Size(375, 27);
            txtCVV.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 176);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 7;
            label3.Text = "Type";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtType
            // 
            txtType.Font = new Font("Consolas", 10F);
            txtType.Location = new Point(74, 173);
            txtType.Margin = new Padding(3, 4, 3, 4);
            txtType.Name = "txtType";
            txtType.ReadOnly = true;
            txtType.Size = new Size(375, 27);
            txtType.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 141);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 6;
            label2.Text = "Region";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtRegion
            // 
            txtRegion.Font = new Font("Consolas", 10F);
            txtRegion.Location = new Point(74, 138);
            txtRegion.Margin = new Padding(3, 4, 3, 4);
            txtRegion.Name = "txtRegion";
            txtRegion.ReadOnly = true;
            txtRegion.Size = new Size(375, 27);
            txtRegion.TabIndex = 8;
            // 
            // txtCard
            // 
            txtCard.Font = new Font("Consolas", 10F);
            txtCard.Location = new Point(74, 103);
            txtCard.Margin = new Padding(3, 4, 3, 4);
            txtCard.Name = "txtCard";
            txtCard.ReadOnly = true;
            txtCard.Size = new Size(375, 27);
            txtCard.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 106);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 5;
            label1.Text = "Card";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtPrimaryAccountNumberValidated
            // 
            txtPrimaryAccountNumberValidated.Font = new Font("Consolas", 10F);
            txtPrimaryAccountNumberValidated.Location = new Point(322, 68);
            txtPrimaryAccountNumberValidated.Margin = new Padding(3, 4, 3, 4);
            txtPrimaryAccountNumberValidated.Name = "txtPrimaryAccountNumberValidated";
            txtPrimaryAccountNumberValidated.ReadOnly = true;
            txtPrimaryAccountNumberValidated.Size = new Size(127, 27);
            txtPrimaryAccountNumberValidated.TabIndex = 7;
            // 
            // txtPrimaryAccountNumber
            // 
            txtPrimaryAccountNumber.Font = new Font("Consolas", 10F);
            txtPrimaryAccountNumber.Location = new Point(74, 68);
            txtPrimaryAccountNumber.Margin = new Padding(3, 4, 3, 4);
            txtPrimaryAccountNumber.Name = "txtPrimaryAccountNumber";
            txtPrimaryAccountNumber.ReadOnly = true;
            txtPrimaryAccountNumber.Size = new Size(241, 27);
            txtPrimaryAccountNumber.TabIndex = 6;
            // 
            // lblPan
            // 
            lblPan.AutoSize = true;
            lblPan.Location = new Point(33, 72);
            lblPan.Name = "lblPan";
            lblPan.Size = new Size(37, 20);
            lblPan.TabIndex = 4;
            lblPan.Text = "PAN";
            lblPan.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtFormatCodeDescription
            // 
            txtFormatCodeDescription.Font = new Font("Consolas", 10F);
            txtFormatCodeDescription.Location = new Point(110, 29);
            txtFormatCodeDescription.Margin = new Padding(3, 4, 3, 4);
            txtFormatCodeDescription.Name = "txtFormatCodeDescription";
            txtFormatCodeDescription.ReadOnly = true;
            txtFormatCodeDescription.Size = new Size(340, 27);
            txtFormatCodeDescription.TabIndex = 5;
            // 
            // txtFormatCode
            // 
            txtFormatCode.Font = new Font("Consolas", 10F);
            txtFormatCode.Location = new Point(74, 29);
            txtFormatCode.Margin = new Padding(3, 4, 3, 4);
            txtFormatCode.Name = "txtFormatCode";
            txtFormatCode.ReadOnly = true;
            txtFormatCode.Size = new Size(28, 27);
            txtFormatCode.TabIndex = 4;
            // 
            // lblFC
            // 
            lblFC.AutoSize = true;
            lblFC.Location = new Point(43, 33);
            lblFC.Name = "lblFC";
            lblFC.Size = new Size(25, 20);
            lblFC.TabIndex = 0;
            lblFC.Text = "FC";
            lblFC.TextAlign = ContentAlignment.MiddleRight;
            // 
            // SwipeSenseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1445, 908);
            Controls.Add(grbTrack1);
            Controls.Add(grbTracks);
            Controls.Add(txtTracks);
            Controls.Add(tsMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
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
        private ToolStripButton toolStripButton1;
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
        private Label label4;
        private TextBox txtCVV;
        private Label label3;
        private TextBox txtType;
        private Label label2;
        private TextBox txtRegion;
        private TextBox txtCard;
        private Label label1;
        private TextBox txtExpired;
        private Label label7;
        private TextBox txtDate;
        private TextBox txtLrc;
        private Label label6;
        private Label label5;
        private TextBox txtIso;
        private TextBox txtSc;
        private Label label9;
        private TextBox txtDd;
        private TextBox txtSc3;
        private TextBox txtSc2;
        private TextBox txtSc1;
        private Label label8;
        private SaveFileDialog dlgSave;
    }
}
