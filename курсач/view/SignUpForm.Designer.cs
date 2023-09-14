
namespace курсач
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.password = new System.Windows.Forms.TextBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.signUpName = new System.Windows.Forms.TextBox();
            this.signUpNameLabel = new System.Windows.Forms.Label();
            this.repeatPass = new System.Windows.Forms.TextBox();
            this.repeatLabel = new System.Windows.Forms.Label();
            this.signUpAge = new System.Windows.Forms.TextBox();
            this.signUpAgeLabel = new System.Windows.Forms.Label();
            this.signUpLogin = new System.Windows.Forms.TextBox();
            this.signUpLoginLabel = new System.Windows.Forms.Label();
            this.signUpPhone = new System.Windows.Forms.TextBox();
            this.signUpPhoneLabel = new System.Windows.Forms.Label();
            this.signUpSUF = new System.Windows.Forms.Button();
            this.TextLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Georgia", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password.Location = new System.Drawing.Point(32, 436);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(226, 32);
            this.password.TabIndex = 9;
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passLabel.Location = new System.Drawing.Point(32, 410);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(186, 23);
            this.passLabel.TabIndex = 8;
            this.passLabel.Text = "Введите Ваш пароль:";
            // 
            // signUpName
            // 
            this.signUpName.Font = new System.Drawing.Font("Georgia", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signUpName.Location = new System.Drawing.Point(32, 101);
            this.signUpName.Name = "signUpName";
            this.signUpName.Size = new System.Drawing.Size(226, 32);
            this.signUpName.TabIndex = 7;
            this.signUpName.TextChanged += new System.EventHandler(this.signUpName_TextChanged);
            // 
            // signUpNameLabel
            // 
            this.signUpNameLabel.AutoSize = true;
            this.signUpNameLabel.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signUpNameLabel.Location = new System.Drawing.Point(32, 74);
            this.signUpNameLabel.Name = "signUpNameLabel";
            this.signUpNameLabel.Size = new System.Drawing.Size(168, 23);
            this.signUpNameLabel.TabIndex = 6;
            this.signUpNameLabel.Text = "Введите Ваше имя:";
            // 
            // repeatPass
            // 
            this.repeatPass.Font = new System.Drawing.Font("Georgia", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.repeatPass.Location = new System.Drawing.Point(32, 528);
            this.repeatPass.Name = "repeatPass";
            this.repeatPass.PasswordChar = '*';
            this.repeatPass.Size = new System.Drawing.Size(226, 32);
            this.repeatPass.TabIndex = 11;
            // 
            // repeatLabel
            // 
            this.repeatLabel.AutoSize = true;
            this.repeatLabel.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.repeatLabel.Location = new System.Drawing.Point(32, 502);
            this.repeatLabel.Name = "repeatLabel";
            this.repeatLabel.Size = new System.Drawing.Size(173, 23);
            this.repeatLabel.TabIndex = 10;
            this.repeatLabel.Text = "Повторите пароль:";
            // 
            // signUpAge
            // 
            this.signUpAge.Font = new System.Drawing.Font("Georgia", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signUpAge.Location = new System.Drawing.Point(32, 182);
            this.signUpAge.Name = "signUpAge";
            this.signUpAge.Size = new System.Drawing.Size(226, 32);
            this.signUpAge.TabIndex = 13;
            this.signUpAge.TextChanged += new System.EventHandler(this.signUpAge_TextChanged);
            // 
            // signUpAgeLabel
            // 
            this.signUpAgeLabel.AutoSize = true;
            this.signUpAgeLabel.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signUpAgeLabel.Location = new System.Drawing.Point(32, 156);
            this.signUpAgeLabel.Name = "signUpAgeLabel";
            this.signUpAgeLabel.Size = new System.Drawing.Size(189, 23);
            this.signUpAgeLabel.TabIndex = 12;
            this.signUpAgeLabel.Text = "Введите Ваш возраст:";
            // 
            // signUpLogin
            // 
            this.signUpLogin.Font = new System.Drawing.Font("Georgia", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signUpLogin.Location = new System.Drawing.Point(32, 351);
            this.signUpLogin.Name = "signUpLogin";
            this.signUpLogin.Size = new System.Drawing.Size(226, 32);
            this.signUpLogin.TabIndex = 15;
            // 
            // signUpLoginLabel
            // 
            this.signUpLoginLabel.AutoSize = true;
            this.signUpLoginLabel.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signUpLoginLabel.Location = new System.Drawing.Point(32, 325);
            this.signUpLoginLabel.Name = "signUpLoginLabel";
            this.signUpLoginLabel.Size = new System.Drawing.Size(175, 23);
            this.signUpLoginLabel.TabIndex = 14;
            this.signUpLoginLabel.Text = "Введите Ваш логин:";
            // 
            // signUpPhone
            // 
            this.signUpPhone.Font = new System.Drawing.Font("Georgia", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signUpPhone.Location = new System.Drawing.Point(32, 270);
            this.signUpPhone.Name = "signUpPhone";
            this.signUpPhone.Size = new System.Drawing.Size(226, 32);
            this.signUpPhone.TabIndex = 17;
            // 
            // signUpPhoneLabel
            // 
            this.signUpPhoneLabel.AutoSize = true;
            this.signUpPhoneLabel.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signUpPhoneLabel.Location = new System.Drawing.Point(32, 244);
            this.signUpPhoneLabel.Name = "signUpPhoneLabel";
            this.signUpPhoneLabel.Size = new System.Drawing.Size(226, 23);
            this.signUpPhoneLabel.TabIndex = 16;
            this.signUpPhoneLabel.Text = "Введите номер телефона:";
            this.signUpPhoneLabel.Click += new System.EventHandler(this.signUpPhoneLabel_Click);
            // 
            // signUpSUF
            // 
            this.signUpSUF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpSUF.Font = new System.Drawing.Font("Comic Sans MS", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signUpSUF.Location = new System.Drawing.Point(237, 578);
            this.signUpSUF.Name = "signUpSUF";
            this.signUpSUF.Size = new System.Drawing.Size(204, 65);
            this.signUpSUF.TabIndex = 18;
            this.signUpSUF.Text = "Зарегистрироваться";
            this.signUpSUF.UseVisualStyleBackColor = true;
            this.signUpSUF.Click += new System.EventHandler(this.signUpSUF_Click);
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.3F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.TextLabel.Location = new System.Drawing.Point(3, 22);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(460, 23);
            this.TextLabel.TabIndex = 19;
            this.TextLabel.Text = "Заполните необходимую информацию для регистрации";
            this.TextLabel.Click += new System.EventHandler(this.TextLabel_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(462, 667);
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.signUpSUF);
            this.Controls.Add(this.signUpPhone);
            this.Controls.Add(this.signUpPhoneLabel);
            this.Controls.Add(this.signUpLogin);
            this.Controls.Add(this.signUpLoginLabel);
            this.Controls.Add(this.signUpAge);
            this.Controls.Add(this.signUpAgeLabel);
            this.Controls.Add(this.repeatPass);
            this.Controls.Add(this.repeatLabel);
            this.Controls.Add(this.password);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.signUpName);
            this.Controls.Add(this.signUpNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox signUpName;
        private System.Windows.Forms.Label signUpNameLabel;
        private System.Windows.Forms.TextBox repeatPass;
        private System.Windows.Forms.Label repeatLabel;
        private System.Windows.Forms.TextBox signUpAge;
        private System.Windows.Forms.Label signUpAgeLabel;
        private System.Windows.Forms.TextBox signUpLogin;
        private System.Windows.Forms.Label signUpLoginLabel;
        private System.Windows.Forms.TextBox signUpPhone;
        private System.Windows.Forms.Label signUpPhoneLabel;
        private System.Windows.Forms.Button signUpSUF;
        private System.Windows.Forms.Label TextLabel;
    }
}