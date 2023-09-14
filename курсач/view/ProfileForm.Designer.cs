
namespace курсач
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            this.myService = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.balanceUser = new System.Windows.Forms.Label();
            this.phoneUser = new System.Windows.Forms.Label();
            this.ageUser = new System.Windows.Forms.Label();
            this.nameUser = new System.Windows.Forms.Label();
            this.balance = new System.Windows.Forms.Label();
            this.phoneNumb = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.servList = new System.Windows.Forms.ListBox();
            this.makeService = new System.Windows.Forms.Button();
            this.historyButton = new System.Windows.Forms.Button();
            this.balanceButton = new System.Windows.Forms.Button();
            this.paybox = new System.Windows.Forms.TextBox();
            this.payButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // myService
            // 
            this.myService.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.myService.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("myService.BackgroundImage")));
            this.myService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myService.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.myService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myService.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myService.Location = new System.Drawing.Point(503, 29);
            this.myService.Name = "myService";
            this.myService.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.myService.Size = new System.Drawing.Size(248, 82);
            this.myService.TabIndex = 0;
            this.myService.Text = "Мои услуги";
            this.myService.UseVisualStyleBackColor = true;
            this.myService.Click += new System.EventHandler(this.myService_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightPink;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.balanceUser);
            this.panel1.Controls.Add(this.phoneUser);
            this.panel1.Controls.Add(this.ageUser);
            this.panel1.Controls.Add(this.nameUser);
            this.panel1.Controls.Add(this.balance);
            this.panel1.Controls.Add(this.phoneNumb);
            this.panel1.Controls.Add(this.age);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Controls.Add(this.servList);
            this.panel1.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 656);
            this.panel1.TabIndex = 1;
            // 
            // balanceUser
            // 
            this.balanceUser.AutoSize = true;
            this.balanceUser.Location = new System.Drawing.Point(99, 159);
            this.balanceUser.Name = "balanceUser";
            this.balanceUser.Size = new System.Drawing.Size(58, 24);
            this.balanceUser.TabIndex = 9;
            this.balanceUser.Text = "label1";
            // 
            // phoneUser
            // 
            this.phoneUser.AutoSize = true;
            this.phoneUser.Location = new System.Drawing.Point(114, 113);
            this.phoneUser.Name = "phoneUser";
            this.phoneUser.Size = new System.Drawing.Size(58, 24);
            this.phoneUser.TabIndex = 8;
            this.phoneUser.Text = "label1";
            // 
            // ageUser
            // 
            this.ageUser.AutoSize = true;
            this.ageUser.Location = new System.Drawing.Point(99, 63);
            this.ageUser.Name = "ageUser";
            this.ageUser.Size = new System.Drawing.Size(58, 24);
            this.ageUser.TabIndex = 7;
            this.ageUser.Text = "label1";
            // 
            // nameUser
            // 
            this.nameUser.AutoSize = true;
            this.nameUser.Location = new System.Drawing.Point(68, 16);
            this.nameUser.Name = "nameUser";
            this.nameUser.Size = new System.Drawing.Size(58, 24);
            this.nameUser.TabIndex = 6;
            this.nameUser.Text = "label1";
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.Location = new System.Drawing.Point(3, 159);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(75, 24);
            this.balance.TabIndex = 5;
            this.balance.Text = "Баланс:";
            // 
            // phoneNumb
            // 
            this.phoneNumb.AutoSize = true;
            this.phoneNumb.Location = new System.Drawing.Point(3, 113);
            this.phoneNumb.Name = "phoneNumb";
            this.phoneNumb.Size = new System.Drawing.Size(95, 24);
            this.phoneNumb.TabIndex = 4;
            this.phoneNumb.Text = "Телефон:";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(3, 63);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(81, 24);
            this.age.TabIndex = 3;
            this.age.Text = "Возраст:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(3, 16);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(50, 24);
            this.name.TabIndex = 2;
            this.name.Text = "Имя:";
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.BackgroundImage")));
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.ErrorImage = null;
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(324, 16);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(110, 105);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // servList
            // 
            this.servList.BackColor = System.Drawing.Color.LavenderBlush;
            this.servList.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.servList.FormattingEnabled = true;
            this.servList.ItemHeight = 29;
            this.servList.Items.AddRange(new object[] {
            "Список Ваших услуг:"});
            this.servList.Location = new System.Drawing.Point(0, 279);
            this.servList.Name = "servList";
            this.servList.Size = new System.Drawing.Size(458, 381);
            this.servList.TabIndex = 0;
            this.servList.SelectedIndexChanged += new System.EventHandler(this.servList_SelectedIndexChanged);
            // 
            // makeService
            // 
            this.makeService.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("makeService.BackgroundImage")));
            this.makeService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.makeService.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.makeService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.makeService.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.makeService.Location = new System.Drawing.Point(503, 172);
            this.makeService.Name = "makeService";
            this.makeService.Size = new System.Drawing.Size(248, 82);
            this.makeService.TabIndex = 2;
            this.makeService.Text = "Записаться на услугу";
            this.makeService.UseVisualStyleBackColor = true;
            this.makeService.Click += new System.EventHandler(this.makeService_Click);
            // 
            // historyButton
            // 
            this.historyButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("historyButton.BackgroundImage")));
            this.historyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.historyButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.historyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historyButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.historyButton.Location = new System.Drawing.Point(503, 315);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(248, 82);
            this.historyButton.TabIndex = 3;
            this.historyButton.Text = "История посещения";
            this.historyButton.UseVisualStyleBackColor = true;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // balanceButton
            // 
            this.balanceButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("balanceButton.BackgroundImage")));
            this.balanceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.balanceButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.balanceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.balanceButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.balanceButton.Location = new System.Drawing.Point(503, 459);
            this.balanceButton.Name = "balanceButton";
            this.balanceButton.Size = new System.Drawing.Size(248, 82);
            this.balanceButton.TabIndex = 4;
            this.balanceButton.Text = "Пополнить баланс";
            this.balanceButton.UseVisualStyleBackColor = true;
            this.balanceButton.Click += new System.EventHandler(this.balanceButton_Click);
            // 
            // paybox
            // 
            this.paybox.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paybox.Location = new System.Drawing.Point(503, 562);
            this.paybox.Name = "paybox";
            this.paybox.Size = new System.Drawing.Size(145, 33);
            this.paybox.TabIndex = 5;
            this.paybox.TextChanged += new System.EventHandler(this.paybox_TextChanged);
            // 
            // payButton
            // 
            this.payButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("payButton.BackgroundImage")));
            this.payButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.payButton.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.payButton.Location = new System.Drawing.Point(642, 562);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(119, 33);
            this.payButton.TabIndex = 6;
            this.payButton.Text = "Пополнить";
            this.payButton.UseVisualStyleBackColor = true;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(773, 691);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.paybox);
            this.Controls.Add(this.balanceButton);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.makeService);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.myService);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Профиль";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button myService;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button makeService;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.ListBox servList;
        private System.Windows.Forms.Button balanceButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox paybox;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.Label balanceUser;
        private System.Windows.Forms.Label phoneUser;
        private System.Windows.Forms.Label ageUser;
        private System.Windows.Forms.Label nameUser;
        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.Label phoneNumb;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label name;
    }
}