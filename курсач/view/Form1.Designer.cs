
namespace курсач
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ToMenu = new System.Windows.Forms.Button();
            this.Welcom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ToMenu
            // 
            this.ToMenu.BackColor = System.Drawing.Color.Transparent;
            this.ToMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ToMenu.BackgroundImage")));
            this.ToMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ToMenu.Location = new System.Drawing.Point(486, 237);
            this.ToMenu.Name = "ToMenu";
            this.ToMenu.Size = new System.Drawing.Size(134, 66);
            this.ToMenu.TabIndex = 0;
            this.ToMenu.Tag = "";
            this.ToMenu.Text = "Вход";
            this.ToMenu.UseVisualStyleBackColor = false;
            this.ToMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // Welcom
            // 
            this.Welcom.BackColor = System.Drawing.Color.Transparent;
            this.Welcom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Welcom.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Welcom.ForeColor = System.Drawing.Color.Maroon;
            this.Welcom.Location = new System.Drawing.Point(290, 26);
            this.Welcom.Name = "Welcom";
            this.Welcom.Size = new System.Drawing.Size(478, 87);
            this.Welcom.TabIndex = 1;
            this.Welcom.Text = "Добро пожаловать!";
            this.Welcom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Welcom.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Welcom);
            this.Controls.Add(this.ToMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ToMenu;
        private System.Windows.Forms.Label Welcom;
    }
}

