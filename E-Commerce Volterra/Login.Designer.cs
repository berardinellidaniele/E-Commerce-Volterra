namespace E_Commerce_Volterra
{
    partial class Login
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
            this.lblBentornato = new System.Windows.Forms.Label();
            this.lblUsernameL = new System.Windows.Forms.Label();
            this.txbusernameL = new System.Windows.Forms.TextBox();
            this.lblPasswordL = new System.Windows.Forms.Label();
            this.txbPasswordL = new System.Windows.Forms.TextBox();
            this.cmbPasswordL = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnClearL = new System.Windows.Forms.Button();
            this.lblNonhaiunaccount = new System.Windows.Forms.Label();
            this.lblCreaunaccount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBentornato
            // 
            this.lblBentornato.AutoSize = true;
            this.lblBentornato.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblBentornato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.lblBentornato.Location = new System.Drawing.Point(31, 64);
            this.lblBentornato.Name = "lblBentornato";
            this.lblBentornato.Size = new System.Drawing.Size(149, 27);
            this.lblBentornato.TabIndex = 12;
            this.lblBentornato.Text = "Bentornato";
            // 
            // lblUsernameL
            // 
            this.lblUsernameL.AutoSize = true;
            this.lblUsernameL.Location = new System.Drawing.Point(33, 119);
            this.lblUsernameL.Name = "lblUsernameL";
            this.lblUsernameL.Size = new System.Drawing.Size(69, 17);
            this.lblUsernameL.TabIndex = 13;
            this.lblUsernameL.Text = "Username";
            // 
            // txbusernameL
            // 
            this.txbusernameL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txbusernameL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbusernameL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbusernameL.Font = new System.Drawing.Font("MS UI Gothic", 15.75F);
            this.txbusernameL.Location = new System.Drawing.Point(38, 139);
            this.txbusernameL.Name = "txbusernameL";
            this.txbusernameL.Size = new System.Drawing.Size(216, 21);
            this.txbusernameL.TabIndex = 14;
            // 
            // lblPasswordL
            // 
            this.lblPasswordL.AutoSize = true;
            this.lblPasswordL.Location = new System.Drawing.Point(33, 179);
            this.lblPasswordL.Name = "lblPasswordL";
            this.lblPasswordL.Size = new System.Drawing.Size(66, 17);
            this.lblPasswordL.TabIndex = 15;
            this.lblPasswordL.Text = "Password";
            // 
            // txbPasswordL
            // 
            this.txbPasswordL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txbPasswordL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPasswordL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPasswordL.Font = new System.Drawing.Font("MS UI Gothic", 15.75F);
            this.txbPasswordL.Location = new System.Drawing.Point(36, 199);
            this.txbPasswordL.Name = "txbPasswordL";
            this.txbPasswordL.PasswordChar = '*';
            this.txbPasswordL.Size = new System.Drawing.Size(216, 21);
            this.txbPasswordL.TabIndex = 27;
            // 
            // cmbPasswordL
            // 
            this.cmbPasswordL.AutoSize = true;
            this.cmbPasswordL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbPasswordL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPasswordL.Location = new System.Drawing.Point(127, 230);
            this.cmbPasswordL.Name = "cmbPasswordL";
            this.cmbPasswordL.Size = new System.Drawing.Size(129, 21);
            this.cmbPasswordL.TabIndex = 28;
            this.cmbPasswordL.Text = "Mostra Password";
            this.cmbPasswordL.UseVisualStyleBackColor = true;
            this.cmbPasswordL.CheckedChanged += new System.EventHandler(this.cmbPasswordL_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(36, 279);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(216, 35);
            this.btnLogin.TabIndex = 20;
            this.btnLogin.Text = "LOG IN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnClearL
            // 
            this.btnClearL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnClearL.Location = new System.Drawing.Point(36, 334);
            this.btnClearL.Name = "btnClearL";
            this.btnClearL.Size = new System.Drawing.Size(216, 35);
            this.btnClearL.TabIndex = 21;
            this.btnClearL.Text = "CLEAR";
            this.btnClearL.UseVisualStyleBackColor = true;
            this.btnClearL.Click += new System.EventHandler(this.btnClearL_Click);
            // 
            // lblNonhaiunaccount
            // 
            this.lblNonhaiunaccount.AutoSize = true;
            this.lblNonhaiunaccount.Location = new System.Drawing.Point(76, 387);
            this.lblNonhaiunaccount.Name = "lblNonhaiunaccount";
            this.lblNonhaiunaccount.Size = new System.Drawing.Size(135, 17);
            this.lblNonhaiunaccount.TabIndex = 29;
            this.lblNonhaiunaccount.Text = "Non hai un account?";
            // 
            // lblCreaunaccount
            // 
            this.lblCreaunaccount.AutoSize = true;
            this.lblCreaunaccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCreaunaccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.lblCreaunaccount.Location = new System.Drawing.Point(90, 409);
            this.lblCreaunaccount.Name = "lblCreaunaccount";
            this.lblCreaunaccount.Size = new System.Drawing.Size(107, 17);
            this.lblCreaunaccount.TabIndex = 23;
            this.lblCreaunaccount.Text = "Crea un account";
            this.lblCreaunaccount.Click += new System.EventHandler(this.lblCreaunaccount_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(302, 486);
            this.Controls.Add(this.lblCreaunaccount);
            this.Controls.Add(this.lblNonhaiunaccount);
            this.Controls.Add(this.btnClearL);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cmbPasswordL);
            this.Controls.Add(this.txbPasswordL);
            this.Controls.Add(this.lblPasswordL);
            this.Controls.Add(this.txbusernameL);
            this.Controls.Add(this.lblUsernameL);
            this.Controls.Add(this.lblBentornato);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBentornato;
        private System.Windows.Forms.Label lblUsernameL;
        private System.Windows.Forms.TextBox txbusernameL;
        private System.Windows.Forms.Label lblPasswordL;
        private System.Windows.Forms.TextBox txbPasswordL;
        private System.Windows.Forms.CheckBox cmbPasswordL;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnClearL;
        private System.Windows.Forms.Label lblNonhaiunaccount;
        private System.Windows.Forms.Label lblCreaunaccount;
    }
}