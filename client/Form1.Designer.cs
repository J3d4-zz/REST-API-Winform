namespace client
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
            this.GetAll = new System.Windows.Forms.Button();
            this.GetId = new System.Windows.Forms.Button();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.InfoConsole = new System.Windows.Forms.ListBox();
            this.UpdateId = new System.Windows.Forms.Button();
            this.DeleteId = new System.Windows.Forms.Button();
            this.Authenticate = new System.Windows.Forms.Button();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Register = new System.Windows.Forms.Button();
            this.userNameLogin = new System.Windows.Forms.TextBox();
            this.passwordLogin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GetAll
            // 
            this.GetAll.Location = new System.Drawing.Point(143, 38);
            this.GetAll.Name = "GetAll";
            this.GetAll.Size = new System.Drawing.Size(75, 23);
            this.GetAll.TabIndex = 1;
            this.GetAll.Text = "GetAll";
            this.GetAll.UseVisualStyleBackColor = true;
            this.GetAll.Click += new System.EventHandler(this.GetAll_Click);
            // 
            // GetId
            // 
            this.GetId.Location = new System.Drawing.Point(143, 67);
            this.GetId.Name = "GetId";
            this.GetId.Size = new System.Drawing.Size(75, 23);
            this.GetId.TabIndex = 2;
            this.GetId.Text = "GetId";
            this.GetId.UseVisualStyleBackColor = true;
            this.GetId.Click += new System.EventHandler(this.GetId_Click);
            // 
            // IdBox
            // 
            this.IdBox.Location = new System.Drawing.Point(224, 81);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(100, 20);
            this.IdBox.TabIndex = 3;
            this.IdBox.Text = "ID";
            // 
            // InfoConsole
            // 
            this.InfoConsole.FormattingEnabled = true;
            this.InfoConsole.Location = new System.Drawing.Point(340, 12);
            this.InfoConsole.Name = "InfoConsole";
            this.InfoConsole.Size = new System.Drawing.Size(1233, 264);
            this.InfoConsole.TabIndex = 4;
            // 
            // UpdateId
            // 
            this.UpdateId.Location = new System.Drawing.Point(143, 96);
            this.UpdateId.Name = "UpdateId";
            this.UpdateId.Size = new System.Drawing.Size(75, 23);
            this.UpdateId.TabIndex = 5;
            this.UpdateId.Text = "UpdateId";
            this.UpdateId.UseVisualStyleBackColor = true;
            this.UpdateId.Click += new System.EventHandler(this.UpdateId_Click);
            // 
            // DeleteId
            // 
            this.DeleteId.Location = new System.Drawing.Point(143, 125);
            this.DeleteId.Name = "DeleteId";
            this.DeleteId.Size = new System.Drawing.Size(75, 23);
            this.DeleteId.TabIndex = 6;
            this.DeleteId.Text = "DeleteId";
            this.DeleteId.UseVisualStyleBackColor = true;
            this.DeleteId.Click += new System.EventHandler(this.DeleteId_Click);
            // 
            // Authenticate
            // 
            this.Authenticate.Location = new System.Drawing.Point(12, 197);
            this.Authenticate.Name = "Authenticate";
            this.Authenticate.Size = new System.Drawing.Size(100, 27);
            this.Authenticate.TabIndex = 7;
            this.Authenticate.Text = "Autehenticate";
            this.Authenticate.UseVisualStyleBackColor = true;
            this.Authenticate.Click += new System.EventHandler(this.Authenticate_Click);
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(12, 12);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(100, 20);
            this.FirstName.TabIndex = 10;
            this.FirstName.Text = "Firs Name";
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(12, 38);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(100, 20);
            this.LastName.TabIndex = 11;
            this.LastName.Text = "Last Name";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(12, 64);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(100, 20);
            this.Username.TabIndex = 12;
            this.Username.Text = "Username";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(12, 90);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(100, 20);
            this.Password.TabIndex = 13;
            this.Password.Text = "Password";
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(12, 116);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(100, 23);
            this.Register.TabIndex = 15;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // userNameLogin
            // 
            this.userNameLogin.Location = new System.Drawing.Point(12, 145);
            this.userNameLogin.Name = "userNameLogin";
            this.userNameLogin.Size = new System.Drawing.Size(100, 20);
            this.userNameLogin.TabIndex = 16;
            this.userNameLogin.Text = "Username";
            // 
            // passwordLogin
            // 
            this.passwordLogin.Location = new System.Drawing.Point(12, 171);
            this.passwordLogin.Name = "passwordLogin";
            this.passwordLogin.Size = new System.Drawing.Size(100, 20);
            this.passwordLogin.TabIndex = 17;
            this.passwordLogin.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1585, 540);
            this.Controls.Add(this.passwordLogin);
            this.Controls.Add(this.userNameLogin);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.Authenticate);
            this.Controls.Add(this.DeleteId);
            this.Controls.Add(this.UpdateId);
            this.Controls.Add(this.InfoConsole);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.GetId);
            this.Controls.Add(this.GetAll);
            this.Name = "Form1";
            this.Text = "REST client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetAll;
        private System.Windows.Forms.Button GetId;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.ListBox InfoConsole;
        private System.Windows.Forms.Button UpdateId;
        private System.Windows.Forms.Button DeleteId;
        private System.Windows.Forms.Button Authenticate;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.TextBox userNameLogin;
        private System.Windows.Forms.TextBox passwordLogin;
    }
}

