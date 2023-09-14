
namespace курсач
{
    partial class MakeServiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeServiceForm));
            this.servicesBox = new System.Windows.Forms.ComboBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.selectServLabel = new System.Windows.Forms.Label();
            this.selectDataLabel = new System.Windows.Forms.Label();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.enrollButton = new System.Windows.Forms.Button();
            this.backLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // servicesBox
            // 
            this.servicesBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.servicesBox.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.servicesBox.FormattingEnabled = true;
            this.servicesBox.Items.AddRange(new object[] {
            "Стрижка",
            "Укладка волос",
            "Окрашивание волос",
            "Маникюр",
            "Макияж",
            "Массаж"});
            this.servicesBox.Location = new System.Drawing.Point(33, 70);
            this.servicesBox.Name = "servicesBox";
            this.servicesBox.Size = new System.Drawing.Size(305, 35);
            this.servicesBox.TabIndex = 0;
            this.servicesBox.SelectedIndexChanged += new System.EventHandler(this.servicesBox_SelectedIndexChanged);
            this.servicesBox.TextChanged += new System.EventHandler(this.servicesBox_TextChanged);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.priceLabel.Location = new System.Drawing.Point(33, 142);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(140, 25);
            this.priceLabel.TabIndex = 1;
            this.priceLabel.Text = "Цена услуги:";
            // 
            // PriceBox
            // 
            this.PriceBox.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PriceBox.Location = new System.Drawing.Point(33, 169);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(305, 35);
            this.PriceBox.TabIndex = 2;
            this.PriceBox.TextChanged += new System.EventHandler(this.PriceBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 3;
            // 
            // selectServLabel
            // 
            this.selectServLabel.AutoSize = true;
            this.selectServLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.selectServLabel.Location = new System.Drawing.Point(33, 43);
            this.selectServLabel.Name = "selectServLabel";
            this.selectServLabel.Size = new System.Drawing.Size(189, 25);
            this.selectServLabel.TabIndex = 4;
            this.selectServLabel.Text = "Выберите услугу:";
            // 
            // selectDataLabel
            // 
            this.selectDataLabel.AutoSize = true;
            this.selectDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.selectDataLabel.Location = new System.Drawing.Point(33, 243);
            this.selectDataLabel.Name = "selectDataLabel";
            this.selectDataLabel.Size = new System.Drawing.Size(227, 25);
            this.selectDataLabel.TabIndex = 5;
            this.selectDataLabel.Text = "Забронировать дату:";
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Font = new System.Drawing.Font("Georgia", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateTimePicker.ImeMode = System.Windows.Forms.ImeMode.On;
            this.DateTimePicker.Location = new System.Drawing.Point(33, 267);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(305, 32);
            this.DateTimePicker.TabIndex = 6;
            this.DateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // enrollButton
            // 
            this.enrollButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enrollButton.Font = new System.Drawing.Font("Comic Sans MS", 14.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enrollButton.Location = new System.Drawing.Point(207, 361);
            this.enrollButton.Name = "enrollButton";
            this.enrollButton.Size = new System.Drawing.Size(191, 56);
            this.enrollButton.TabIndex = 9;
            this.enrollButton.Text = "Записаться";
            this.enrollButton.UseVisualStyleBackColor = true;
            this.enrollButton.Click += new System.EventHandler(this.enrollButton_Click);
            // 
            // backLabel
            // 
            this.backLabel.AutoSize = true;
            this.backLabel.BackColor = System.Drawing.Color.Transparent;
            this.backLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.backLabel.Location = new System.Drawing.Point(0, 0);
            this.backLabel.Name = "backLabel";
            this.backLabel.Size = new System.Drawing.Size(40, 31);
            this.backLabel.TabIndex = 10;
            this.backLabel.Text = "←";
            this.backLabel.Click += new System.EventHandler(this.backLabel_Click);
            // 
            // MakeServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(458, 483);
            this.Controls.Add(this.backLabel);
            this.Controls.Add(this.enrollButton);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.selectDataLabel);
            this.Controls.Add(this.selectServLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.servicesBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MakeServiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Запись";
            this.Load += new System.EventHandler(this.MakeServiceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox servicesBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label selectServLabel;
        private System.Windows.Forms.Label selectDataLabel;
        private System.Windows.Forms.Button enrollButton;
        private System.Windows.Forms.Label backLabel;
        protected internal System.Windows.Forms.DateTimePicker DateTimePicker;
    }
}