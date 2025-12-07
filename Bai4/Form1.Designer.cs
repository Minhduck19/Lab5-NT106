namespace Bai4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.pbPoster = new System.Windows.Forms.PictureBox();
            this.cboPhim = new System.Windows.Forms.ComboBox();
            this.lblChonPhim = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnBook = new System.Windows.Forms.Button();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grpSeats = new System.Windows.Forms.GroupBox();
            this.flpGhe = new System.Windows.Forms.FlowLayoutPanel();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).BeginInit();
            this.panelRight.SuspendLayout();
            this.grpCustomer.SuspendLayout();
            this.grpSeats.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1499, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "RẠP CHIẾU PHIM - BOOKING ONLINE";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.AliceBlue;
            this.panelLeft.Controls.Add(this.pbPoster);
            this.panelLeft.Controls.Add(this.cboPhim);
            this.panelLeft.Controls.Add(this.lblChonPhim);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 50);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(481, 653);
            this.panelLeft.TabIndex = 1;
            // 
            // pbPoster
            // 
            this.pbPoster.BackColor = System.Drawing.Color.Gainsboro;
            this.pbPoster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPoster.Location = new System.Drawing.Point(16, 80);
            this.pbPoster.Name = "pbPoster";
            this.pbPoster.Size = new System.Drawing.Size(423, 541);
            this.pbPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPoster.TabIndex = 2;
            this.pbPoster.TabStop = false;
            // 
            // cboPhim
            // 
            this.cboPhim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhim.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboPhim.FormattingEnabled = true;
            this.cboPhim.Location = new System.Drawing.Point(16, 40);
            this.cboPhim.Name = "cboPhim";
            this.cboPhim.Size = new System.Drawing.Size(423, 31);
            this.cboPhim.TabIndex = 1;
            this.cboPhim.SelectedIndexChanged += new System.EventHandler(this.CboPhim_SelectedIndexChanged);
            // 
            // lblChonPhim
            // 
            this.lblChonPhim.AutoSize = true;
            this.lblChonPhim.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblChonPhim.Location = new System.Drawing.Point(12, 15);
            this.lblChonPhim.Name = "lblChonPhim";
            this.lblChonPhim.Size = new System.Drawing.Size(173, 25);
            this.lblChonPhim.TabIndex = 0;
            this.lblChonPhim.Text = "Chọn Phim (Web):";
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.AliceBlue;
            this.panelRight.Controls.Add(this.lblStatus);
            this.panelRight.Controls.Add(this.btnBook);
            this.panelRight.Controls.Add(this.grpCustomer);
            this.panelRight.Controls.Add(this.grpSeats);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(481, 50);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(1018, 653);
            this.panelRight.TabIndex = 2;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblStatus.ForeColor = System.Drawing.Color.DimGray;
            this.lblStatus.Location = new System.Drawing.Point(474, 579);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(124, 20);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Vui lòng chọn vé...";
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBook.FlatAppearance.BorderSize = 0;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBook.ForeColor = System.Drawing.Color.White;
            this.btnBook.Location = new System.Drawing.Point(23, 561);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(372, 50);
            this.btnBook.TabIndex = 2;
            this.btnBook.Text = "ĐẶT VÉ & GỬI MAIL";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.BtnBook_Click);
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.lblEmail);
            this.grpCustomer.Controls.Add(this.txtEmail);
            this.grpCustomer.Controls.Add(this.lblName);
            this.grpCustomer.Controls.Add(this.txtName);
            this.grpCustomer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpCustomer.Location = new System.Drawing.Point(23, 382);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(897, 146);
            this.grpCustomer.TabIndex = 1;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Thông tin khách hàng";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmail.Location = new System.Drawing.Point(20, 70);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 23);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.Location = new System.Drawing.Point(114, 67);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(400, 30);
            this.txtEmail.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblName.Location = new System.Drawing.Point(20, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(88, 23);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Họ và tên:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtName.Location = new System.Drawing.Point(114, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(400, 30);
            this.txtName.TabIndex = 1;
            // 
            // grpSeats
            // 
            this.grpSeats.Controls.Add(this.flpGhe);
            this.grpSeats.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpSeats.Location = new System.Drawing.Point(20, 15);
            this.grpSeats.Name = "grpSeats";
            this.grpSeats.Size = new System.Drawing.Size(897, 344);
            this.grpSeats.TabIndex = 0;
            this.grpSeats.TabStop = false;
            this.grpSeats.Text = "Màn Hình (Chọn ghế bên dưới)";
            // 
            // flpGhe
            // 
            this.flpGhe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flpGhe.AutoScroll = true;
            this.flpGhe.Cursor = System.Windows.Forms.Cursors.Default;
            this.flpGhe.Location = new System.Drawing.Point(209, 21);
            this.flpGhe.Name = "flpGhe";
            this.flpGhe.Padding = new System.Windows.Forms.Padding(10);
            this.flpGhe.Size = new System.Drawing.Size(669, 317);
            this.flpGhe.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1499, 703);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Phòng vé (Lab 5) - Ông Trùm Winforms";
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.grpSeats.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.PictureBox pbPoster;
        private System.Windows.Forms.ComboBox cboPhim;
        private System.Windows.Forms.Label lblChonPhim;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox grpSeats;
        private System.Windows.Forms.FlowLayoutPanel flpGhe;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Label lblStatus;
    }
}