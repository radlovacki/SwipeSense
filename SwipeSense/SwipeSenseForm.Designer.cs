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
            txtPrimaryAccountNumber = new TextBox();
            lblPan = new Label();
            txtFormatCodeDescription = new TextBox();
            txtFormatCode = new TextBox();
            lblFC = new Label();
            txtPrimaryAccountNumberValidated = new TextBox();
            tsMenu.SuspendLayout();
            grbTracks.SuspendLayout();
            grbTrack1.SuspendLayout();
            SuspendLayout();
            // 
            // tsMenu
            // 
            tsMenu.Items.AddRange(new ToolStripItem[] { toolStripButton1 });
            tsMenu.Location = new Point(0, 0);
            tsMenu.Name = "tsMenu";
            tsMenu.Size = new Size(1264, 25);
            tsMenu.TabIndex = 0;
            tsMenu.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
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
            grbTrack1.Controls.Add(txtPrimaryAccountNumberValidated);
            grbTrack1.Controls.Add(txtPrimaryAccountNumber);
            grbTrack1.Controls.Add(lblPan);
            grbTrack1.Controls.Add(txtFormatCodeDescription);
            grbTrack1.Controls.Add(txtFormatCode);
            grbTrack1.Controls.Add(lblFC);
            grbTrack1.Location = new Point(12, 176);
            grbTrack1.Name = "grbTrack1";
            grbTrack1.Size = new Size(400, 493);
            grbTrack1.TabIndex = 3;
            grbTrack1.TabStop = false;
            grbTrack1.Text = "Track 1";
            // 
            // txtPrimaryAccountNumber
            // 
            txtPrimaryAccountNumber.Font = new Font("Consolas", 10F);
            txtPrimaryAccountNumber.Location = new Point(65, 51);
            txtPrimaryAccountNumber.Name = "txtPrimaryAccountNumber";
            txtPrimaryAccountNumber.ReadOnly = true;
            txtPrimaryAccountNumber.Size = new Size(211, 23);
            txtPrimaryAccountNumber.TabIndex = 6;
            // 
            // lblPan
            // 
            lblPan.AutoSize = true;
            lblPan.Location = new Point(29, 54);
            lblPan.Name = "lblPan";
            lblPan.Size = new Size(30, 15);
            lblPan.TabIndex = 4;
            lblPan.Text = "PAN";
            lblPan.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtFormatCodeDescription
            // 
            txtFormatCodeDescription.Font = new Font("Consolas", 10F);
            txtFormatCodeDescription.Location = new Point(96, 22);
            txtFormatCodeDescription.Name = "txtFormatCodeDescription";
            txtFormatCodeDescription.ReadOnly = true;
            txtFormatCodeDescription.Size = new Size(298, 23);
            txtFormatCodeDescription.TabIndex = 5;
            // 
            // txtFormatCode
            // 
            txtFormatCode.Font = new Font("Consolas", 10F);
            txtFormatCode.Location = new Point(65, 22);
            txtFormatCode.Name = "txtFormatCode";
            txtFormatCode.ReadOnly = true;
            txtFormatCode.Size = new Size(25, 23);
            txtFormatCode.TabIndex = 4;
            // 
            // lblFC
            // 
            lblFC.AutoSize = true;
            lblFC.Location = new Point(38, 25);
            lblFC.Name = "lblFC";
            lblFC.Size = new Size(21, 15);
            lblFC.TabIndex = 0;
            lblFC.Text = "FC";
            lblFC.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtPrimaryAccountNumberValidated
            // 
            txtPrimaryAccountNumberValidated.Font = new Font("Consolas", 10F);
            txtPrimaryAccountNumberValidated.Location = new Point(282, 51);
            txtPrimaryAccountNumberValidated.Name = "txtPrimaryAccountNumberValidated";
            txtPrimaryAccountNumberValidated.ReadOnly = true;
            txtPrimaryAccountNumberValidated.Size = new Size(112, 23);
            txtPrimaryAccountNumberValidated.TabIndex = 7;
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
    }
}
