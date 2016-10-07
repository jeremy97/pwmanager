namespace pwmanager {
    partial class LoginForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pwLoginLbl = new System.Windows.Forms.Label();
            this.unlockBtn = new System.Windows.Forms.Button();
            this.pwText = new System.Windows.Forms.TextBox();
            this.fileLbl = new System.Windows.Forms.Label();
            this.openBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.orLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pwCreateLbl = new System.Windows.Forms.Label();
            this.pwCreateText = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pwLoginLbl);
            this.panel1.Controls.Add(this.unlockBtn);
            this.panel1.Controls.Add(this.pwText);
            this.panel1.Controls.Add(this.fileLbl);
            this.panel1.Controls.Add(this.openBtn);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 115);
            this.panel1.TabIndex = 0;
            // 
            // pwLoginLbl
            // 
            this.pwLoginLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pwLoginLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwLoginLbl.Location = new System.Drawing.Point(3, 58);
            this.pwLoginLbl.Name = "pwLoginLbl";
            this.pwLoginLbl.Size = new System.Drawing.Size(61, 20);
            this.pwLoginLbl.TabIndex = 4;
            this.pwLoginLbl.Text = "Password";
            this.pwLoginLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // unlockBtn
            // 
            this.unlockBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unlockBtn.Enabled = false;
            this.unlockBtn.Location = new System.Drawing.Point(3, 84);
            this.unlockBtn.Name = "unlockBtn";
            this.unlockBtn.Size = new System.Drawing.Size(252, 23);
            this.unlockBtn.TabIndex = 3;
            this.unlockBtn.Text = "Unlock";
            this.unlockBtn.UseVisualStyleBackColor = true;
            this.unlockBtn.Click += new System.EventHandler(this.unlockBtn_Click);
            // 
            // pwText
            // 
            this.pwText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pwText.Enabled = false;
            this.pwText.Location = new System.Drawing.Point(70, 58);
            this.pwText.Name = "pwText";
            this.pwText.PasswordChar = '*';
            this.pwText.Size = new System.Drawing.Size(185, 20);
            this.pwText.TabIndex = 2;
            this.pwText.TextChanged += new System.EventHandler(this.pwText_TextChanged);
            // 
            // fileLbl
            // 
            this.fileLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileLbl.AutoEllipsis = true;
            this.fileLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileLbl.ForeColor = System.Drawing.Color.Black;
            this.fileLbl.Location = new System.Drawing.Point(3, 29);
            this.fileLbl.Name = "fileLbl";
            this.fileLbl.Size = new System.Drawing.Size(252, 15);
            this.fileLbl.TabIndex = 1;
            this.fileLbl.Text = "Selected file: None";
            // 
            // openBtn
            // 
            this.openBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openBtn.Location = new System.Drawing.Point(3, 3);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(252, 23);
            this.openBtn.TabIndex = 0;
            this.openBtn.Text = "Open Password File...";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // createBtn
            // 
            this.createBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createBtn.Enabled = false;
            this.createBtn.Location = new System.Drawing.Point(3, 29);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(252, 23);
            this.createBtn.TabIndex = 2;
            this.createBtn.Text = "Create a new file";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // orLbl
            // 
            this.orLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orLbl.ForeColor = System.Drawing.Color.Black;
            this.orLbl.Location = new System.Drawing.Point(12, 130);
            this.orLbl.Name = "orLbl";
            this.orLbl.Size = new System.Drawing.Size(260, 29);
            this.orLbl.TabIndex = 4;
            this.orLbl.Text = "OR";
            this.orLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pwCreateLbl);
            this.panel2.Controls.Add(this.pwCreateText);
            this.panel2.Controls.Add(this.createBtn);
            this.panel2.Location = new System.Drawing.Point(12, 162);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 57);
            this.panel2.TabIndex = 3;
            // 
            // pwCreateLbl
            // 
            this.pwCreateLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pwCreateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwCreateLbl.Location = new System.Drawing.Point(3, 3);
            this.pwCreateLbl.Name = "pwCreateLbl";
            this.pwCreateLbl.Size = new System.Drawing.Size(61, 20);
            this.pwCreateLbl.TabIndex = 6;
            this.pwCreateLbl.Text = "Password";
            this.pwCreateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pwCreateText
            // 
            this.pwCreateText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pwCreateText.Location = new System.Drawing.Point(70, 3);
            this.pwCreateText.Name = "pwCreateText";
            this.pwCreateText.PasswordChar = '*';
            this.pwCreateText.Size = new System.Drawing.Size(185, 20);
            this.pwCreateText.TabIndex = 5;
            this.pwCreateText.TextChanged += new System.EventHandler(this.pwCreateText_TextChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 231);
            this.Controls.Add(this.orLbl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unlock";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label fileLbl;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.Button unlockBtn;
        private System.Windows.Forms.TextBox pwText;
        private System.Windows.Forms.Label orLbl;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label pwLoginLbl;
        private System.Windows.Forms.Label pwCreateLbl;
        private System.Windows.Forms.TextBox pwCreateText;
    }
}