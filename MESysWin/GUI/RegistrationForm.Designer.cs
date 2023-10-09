namespace MESysWin.GUI
{
    partial class RegistrationForm
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
            System.Windows.Forms.GroupBox groupBoxLogin;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.userToolStripMenuItem_Click = new System.Windows.Forms.LinkLabel();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.buttonOk_Click = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            groupBoxLogin = new System.Windows.Forms.GroupBox();
            groupBoxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLogin
            // 
            groupBoxLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            groupBoxLogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            groupBoxLogin.Controls.Add(this.textBoxPhone);
            groupBoxLogin.Controls.Add(this.textBoxEmail);
            groupBoxLogin.Controls.Add(this.textBoxMiddleName);
            groupBoxLogin.Controls.Add(this.textBoxSecondName);
            groupBoxLogin.Controls.Add(this.textBoxName);
            groupBoxLogin.Controls.Add(this.userToolStripMenuItem_Click);
            groupBoxLogin.Controls.Add(this.checkBoxShowPassword);
            groupBoxLogin.Controls.Add(this.buttonOk_Click);
            groupBoxLogin.Controls.Add(this.label1);
            groupBoxLogin.Controls.Add(this.textBoxLogin);
            groupBoxLogin.Controls.Add(this.textBoxPassword);
            groupBoxLogin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            groupBoxLogin.Location = new System.Drawing.Point(0, -8);
            groupBoxLogin.Name = "groupBoxLogin";
            groupBoxLogin.Size = new System.Drawing.Size(360, 464);
            groupBoxLogin.TabIndex = 1;
            groupBoxLogin.TabStop = false;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPhone.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxPhone.Location = new System.Drawing.Point(48, 312);
            this.textBoxPhone.MaximumSize = new System.Drawing.Size(256, 28);
            this.textBoxPhone.MaxLength = 14;
            this.textBoxPhone.MinimumSize = new System.Drawing.Size(256, 28);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(256, 26);
            this.textBoxPhone.TabIndex = 11;
            this.textBoxPhone.Text = " Номер телефона";
            this.textBoxPhone.Enter += new System.EventHandler(this.PhoneTextEnter);
            this.textBoxPhone.Leave += new System.EventHandler(this.PhoneTextLeave);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEmail.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxEmail.Location = new System.Drawing.Point(48, 272);
            this.textBoxEmail.MaximumSize = new System.Drawing.Size(256, 28);
            this.textBoxEmail.MaxLength = 14;
            this.textBoxEmail.MinimumSize = new System.Drawing.Size(256, 28);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(256, 26);
            this.textBoxEmail.TabIndex = 10;
            this.textBoxEmail.Text = " Электронная почта";
            this.textBoxEmail.Enter += new System.EventHandler(this.EmailTextEnter);
            this.textBoxEmail.Leave += new System.EventHandler(this.EmailTextLeave);
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMiddleName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMiddleName.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxMiddleName.Location = new System.Drawing.Point(48, 152);
            this.textBoxMiddleName.MaximumSize = new System.Drawing.Size(256, 28);
            this.textBoxMiddleName.MinimumSize = new System.Drawing.Size(256, 28);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(256, 26);
            this.textBoxMiddleName.TabIndex = 9;
            this.textBoxMiddleName.Text = " Отчество";
            this.textBoxMiddleName.Enter += new System.EventHandler(this.MiddleNameTextEnter);
            this.textBoxMiddleName.Leave += new System.EventHandler(this.MiddleNameTextLeave);
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSecondName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSecondName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSecondName.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxSecondName.Location = new System.Drawing.Point(48, 112);
            this.textBoxSecondName.MaximumSize = new System.Drawing.Size(256, 28);
            this.textBoxSecondName.MinimumSize = new System.Drawing.Size(256, 28);
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(256, 26);
            this.textBoxSecondName.TabIndex = 8;
            this.textBoxSecondName.Text = " Фамилия";
            this.textBoxSecondName.Enter += new System.EventHandler(this.SecondNameTextEnter);
            this.textBoxSecondName.Leave += new System.EventHandler(this.SecondNameTextLeave);
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxName.Location = new System.Drawing.Point(48, 72);
            this.textBoxName.MaximumSize = new System.Drawing.Size(256, 28);
            this.textBoxName.MinimumSize = new System.Drawing.Size(256, 28);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(256, 26);
            this.textBoxName.TabIndex = 7;
            this.textBoxName.Text = " Имя";
            this.textBoxName.Enter += new System.EventHandler(this.NameTextEnter);
            this.textBoxName.Leave += new System.EventHandler(this.NameTextLeave);
            // 
            // userToolStripMenuItem_Click
            // 
            this.userToolStripMenuItem_Click.ActiveLinkColor = System.Drawing.Color.Silver;
            this.userToolStripMenuItem_Click.AutoSize = true;
            this.userToolStripMenuItem_Click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userToolStripMenuItem_Click.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userToolStripMenuItem_Click.LinkColor = System.Drawing.Color.Gray;
            this.userToolStripMenuItem_Click.Location = new System.Drawing.Point(48, 400);
            this.userToolStripMenuItem_Click.Name = "userToolStripMenuItem_Click";
            this.userToolStripMenuItem_Click.Size = new System.Drawing.Size(229, 15);
            this.userToolStripMenuItem_Click.TabIndex = 6;
            this.userToolStripMenuItem_Click.TabStop = true;
            this.userToolStripMenuItem_Click.Text = "Уже зарегистрированы в системе? Войти";
            this.userToolStripMenuItem_Click.VisitedLinkColor = System.Drawing.Color.Silver;
            this.userToolStripMenuItem_Click.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.userToolStripMenuItem_Click_LinkClicked);
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Location = new System.Drawing.Point(288, 240);
            this.checkBoxShowPassword.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(15, 14);
            this.checkBoxShowPassword.TabIndex = 4;
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            // 
            // buttonOk_Click
            // 
            this.buttonOk_Click.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk_Click.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonOk_Click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOk_Click.FlatAppearance.BorderSize = 0;
            this.buttonOk_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk_Click.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOk_Click.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonOk_Click.Location = new System.Drawing.Point(48, 360);
            this.buttonOk_Click.Name = "buttonOk_Click";
            this.buttonOk_Click.Size = new System.Drawing.Size(264, 35);
            this.buttonOk_Click.TabIndex = 1;
            this.buttonOk_Click.Text = "Войти";
            this.buttonOk_Click.UseVisualStyleBackColor = false;
            this.buttonOk_Click.Click += new System.EventHandler(this.buttonOk_Click_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(104, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxLogin.Location = new System.Drawing.Point(48, 192);
            this.textBoxLogin.MaximumSize = new System.Drawing.Size(256, 28);
            this.textBoxLogin.MinimumSize = new System.Drawing.Size(256, 28);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(256, 26);
            this.textBoxLogin.TabIndex = 2;
            this.textBoxLogin.Text = " Логин";
            this.textBoxLogin.Enter += new System.EventHandler(this.LoginTextEnter);
            this.textBoxLogin.Leave += new System.EventHandler(this.LoginTextLeave);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxPassword.Location = new System.Drawing.Point(48, 232);
            this.textBoxPassword.MaximumSize = new System.Drawing.Size(256, 28);
            this.textBoxPassword.MaxLength = 14;
            this.textBoxPassword.MinimumSize = new System.Drawing.Size(256, 28);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(256, 26);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.Text = " Пароль";
            this.textBoxPassword.Enter += new System.EventHandler(this.PasswordTextEnter);
            this.textBoxPassword.Leave += new System.EventHandler(this.PasswordTextLeave);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 450);
            this.Controls.Add(groupBoxLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Регистрация";
            groupBoxLogin.ResumeLayout(false);
            groupBoxLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.TextBox textBoxSecondName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.LinkLabel userToolStripMenuItem_Click;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
        private System.Windows.Forms.Button buttonOk_Click;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
    }
}