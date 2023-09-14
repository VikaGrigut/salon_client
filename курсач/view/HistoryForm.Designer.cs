
namespace курсач
{
    partial class HistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryForm));
            this.historyList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // historyList
            // 
            this.historyList.BackColor = System.Drawing.Color.Lavender;
            this.historyList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.historyList.Font = new System.Drawing.Font("Segoe Script", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.historyList.FormattingEnabled = true;
            this.historyList.ItemHeight = 29;
            this.historyList.Items.AddRange(new object[] {
            "Ваша история записей:"});
            this.historyList.Location = new System.Drawing.Point(96, 37);
            this.historyList.Name = "historyList";
            this.historyList.Size = new System.Drawing.Size(595, 379);
            this.historyList.TabIndex = 0;
            this.historyList.SelectedIndexChanged += new System.EventHandler(this.historyList_SelectedIndexChanged);
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.historyList);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HistoryForm";
            this.Text = "История";
            this.Load += new System.EventHandler(this.HistoryForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox historyList;
    }
}