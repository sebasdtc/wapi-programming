namespace DataWappi.Views
{
    partial class MainView
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
            if(disposing && (components != null))
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
            panelHearder = new Panel();
            picbClose = new PictureBox();
            picbIcon = new PictureBox();
            lblTitle = new Label();
            button1 = new Button();
            panelPortada = new Panel();
            picbPortada = new PictureBox();
            btnLoadFile = new Button();
            btnConvert = new Button();
            pnlBtnLoadFile = new Panel();
            txtFileName = new TextBox();
            txtSize = new TextBox();
            panel1 = new Panel();
            btnSettings = new Button();
            panelHearder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picbClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picbIcon).BeginInit();
            panelPortada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picbPortada).BeginInit();
            pnlBtnLoadFile.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelHearder
            // 
            panelHearder.BackColor = Color.White;
            panelHearder.Controls.Add(picbClose);
            panelHearder.Controls.Add(picbIcon);
            panelHearder.Controls.Add(lblTitle);
            panelHearder.Dock = DockStyle.Top;
            panelHearder.Location = new Point(0, 0);
            panelHearder.Margin = new Padding(2, 2, 2, 2);
            panelHearder.Name = "panelHearder";
            panelHearder.Size = new Size(281, 48);
            panelHearder.TabIndex = 0;
            panelHearder.MouseDown += PanelHearder_MouseDown;
            // 
            // picbClose
            // 
            picbClose.Dock = DockStyle.Right;
            picbClose.Image = Properties.Resources.cross;
            picbClose.Location = new Point(221, 0);
            picbClose.Margin = new Padding(2, 2, 2, 2);
            picbClose.Name = "picbClose";
            picbClose.Size = new Size(60, 48);
            picbClose.SizeMode = PictureBoxSizeMode.CenterImage;
            picbClose.TabIndex = 3;
            picbClose.TabStop = false;
            picbClose.Click += PicbClose_Click;
            picbClose.MouseLeave += PicClose_MouseLeave;
            picbClose.MouseMove += PicbClose_MouseMove;
            // 
            // picbIcon
            // 
            picbIcon.Dock = DockStyle.Left;
            picbIcon.Image = Properties.Resources.whatsapp;
            picbIcon.Location = new Point(0, 0);
            picbIcon.Margin = new Padding(2, 2, 2, 2);
            picbIcon.Name = "picbIcon";
            picbIcon.Size = new Size(60, 48);
            picbIcon.SizeMode = PictureBoxSizeMode.CenterImage;
            picbIcon.TabIndex = 2;
            picbIcon.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(64, 9);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(96, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Convertir wappi";
            lblTitle.MouseDown += PanelHearder_MouseDown;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(242, 242, 242);
            button1.Image = Properties.Resources.information;
            button1.Location = new Point(207, 256);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(60, 44);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panelPortada
            // 
            panelPortada.Controls.Add(picbPortada);
            panelPortada.Dock = DockStyle.Top;
            panelPortada.Location = new Point(0, 48);
            panelPortada.Margin = new Padding(2, 2, 2, 2);
            panelPortada.Name = "panelPortada";
            panelPortada.Size = new Size(281, 90);
            panelPortada.TabIndex = 1;
            // 
            // picbPortada
            // 
            picbPortada.BackColor = Color.FromArgb(90, 92, 96);
            picbPortada.Image = Properties.Resources.portada;
            picbPortada.Location = new Point(8, 6);
            picbPortada.Margin = new Padding(2, 2, 2, 2);
            picbPortada.Name = "picbPortada";
            picbPortada.Size = new Size(263, 86);
            picbPortada.SizeMode = PictureBoxSizeMode.Zoom;
            picbPortada.TabIndex = 0;
            picbPortada.TabStop = false;
            // 
            // btnLoadFile
            // 
            btnLoadFile.BackColor = Color.FromArgb(254, 198, 0);
            btnLoadFile.FlatAppearance.MouseDownBackColor = Color.FromArgb(234, 178, 160);
            btnLoadFile.FlatAppearance.MouseOverBackColor = Color.FromArgb(234, 178, 160);
            btnLoadFile.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            btnLoadFile.ForeColor = Color.Black;
            btnLoadFile.Location = new Point(11, 6);
            btnLoadFile.Margin = new Padding(2, 2, 2, 2);
            btnLoadFile.Name = "btnLoadFile";
            btnLoadFile.Size = new Size(240, 28);
            btnLoadFile.TabIndex = 2;
            btnLoadFile.Text = "Seleccionar archivo";
            btnLoadFile.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLoadFile.UseVisualStyleBackColor = false;
            btnLoadFile.Click += BtnLoadFile_Click;
            // 
            // btnConvert
            // 
            btnConvert.BackColor = Color.FromArgb(254, 198, 0);
            btnConvert.FlatAppearance.MouseDownBackColor = Color.FromArgb(234, 178, 160);
            btnConvert.FlatAppearance.MouseOverBackColor = Color.FromArgb(234, 178, 160);
            btnConvert.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            btnConvert.ForeColor = Color.Black;
            btnConvert.Location = new Point(11, 10);
            btnConvert.Margin = new Padding(2, 2, 2, 2);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(240, 28);
            btnConvert.TabIndex = 3;
            btnConvert.Text = "Convertir";
            btnConvert.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConvert.UseVisualStyleBackColor = false;
            // 
            // pnlBtnLoadFile
            // 
            pnlBtnLoadFile.BackColor = Color.White;
            pnlBtnLoadFile.Controls.Add(txtFileName);
            pnlBtnLoadFile.Controls.Add(txtSize);
            pnlBtnLoadFile.Controls.Add(btnLoadFile);
            pnlBtnLoadFile.Location = new Point(8, 126);
            pnlBtnLoadFile.Margin = new Padding(2, 2, 2, 2);
            pnlBtnLoadFile.Name = "pnlBtnLoadFile";
            pnlBtnLoadFile.Size = new Size(263, 61);
            pnlBtnLoadFile.TabIndex = 4;
            pnlBtnLoadFile.Click += BtnLoadFile_Click;
            // 
            // txtFileName
            // 
            txtFileName.BackColor = Color.White;
            txtFileName.BorderStyle = BorderStyle.None;
            txtFileName.Location = new Point(11, 39);
            txtFileName.Margin = new Padding(2, 2, 2, 2);
            txtFileName.Name = "txtFileName";
            txtFileName.ReadOnly = true;
            txtFileName.Size = new Size(183, 16);
            txtFileName.TabIndex = 8;
            // 
            // txtSize
            // 
            txtSize.BackColor = Color.White;
            txtSize.BorderStyle = BorderStyle.None;
            txtSize.Location = new Point(199, 39);
            txtSize.Margin = new Padding(2, 2, 2, 2);
            txtSize.Name = "txtSize";
            txtSize.ReadOnly = true;
            txtSize.Size = new Size(52, 16);
            txtSize.TabIndex = 8;
            txtSize.TextAlign = HorizontalAlignment.Right;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnConvert);
            panel1.Location = new Point(8, 190);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(263, 49);
            panel1.TabIndex = 6;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.FromArgb(242, 242, 242);
            btnSettings.Enabled = false;
            btnSettings.Image = Properties.Resources.gear;
            btnSettings.Location = new Point(8, 256);
            btnSettings.Margin = new Padding(2, 2, 2, 2);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(60, 44);
            btnSettings.TabIndex = 7;
            btnSettings.UseVisualStyleBackColor = false;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 241, 243);
            ClientSize = new Size(281, 311);
            Controls.Add(btnSettings);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(pnlBtnLoadFile);
            Controls.Add(panelPortada);
            Controls.Add(panelHearder);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "MainView";
            Text = "Generar archivo wappi";
            panelHearder.ResumeLayout(false);
            panelHearder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picbClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)picbIcon).EndInit();
            panelPortada.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picbPortada).EndInit();
            pnlBtnLoadFile.ResumeLayout(false);
            pnlBtnLoadFile.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelHearder;
        private Panel panelPortada;
        private PictureBox picbPortada;
        private Label lblTitle;
        private PictureBox picbIcon;
        private Button btnLoadFile;
        private PictureBox picbClose;
        private Button btnConvert;
        private Panel pnlBtnLoadFile;
        private Button button1;
        private Panel panel1;
        private TextBox txtSize;
        private TextBox txtFileName;
        private Button btnSettings;
    }
}