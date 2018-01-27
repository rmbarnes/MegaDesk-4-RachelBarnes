namespace MegaDesk_3_RachelBarnes
{
    partial class SearchQuotes
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
            this.searchQuotesBox = new System.Windows.Forms.ComboBox();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.viewQuoteLabel = new System.Windows.Forms.Label();
            this.searchQuoteBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // searchQuotesBox
            // 
            this.searchQuotesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQuotesBox.FormattingEnabled = true;
            this.searchQuotesBox.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.searchQuotesBox.Location = new System.Drawing.Point(121, 78);
            this.searchQuotesBox.Name = "searchQuotesBox";
            this.searchQuotesBox.Size = new System.Drawing.Size(222, 26);
            this.searchQuotesBox.TabIndex = 11;
            this.searchQuotesBox.Text = "Select...";
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuButton.Location = new System.Drawing.Point(138, 343);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(161, 26);
            this.mainMenuButton.TabIndex = 23;
            this.mainMenuButton.Text = "Back to Main Menu";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // viewQuoteLabel
            // 
            this.viewQuoteLabel.AutoSize = true;
            this.viewQuoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewQuoteLabel.Location = new System.Drawing.Point(117, 27);
            this.viewQuoteLabel.Name = "viewQuoteLabel";
            this.viewQuoteLabel.Size = new System.Drawing.Size(226, 22);
            this.viewQuoteLabel.TabIndex = 25;
            this.viewQuoteLabel.Text = "Search by Surface Type";
            // 
            // searchQuoteBox
            // 
            this.searchQuoteBox.Location = new System.Drawing.Point(121, 134);
            this.searchQuoteBox.Name = "searchQuoteBox";
            this.searchQuoteBox.ReadOnly = true;
            this.searchQuoteBox.Size = new System.Drawing.Size(222, 20);
            this.searchQuoteBox.TabIndex = 26;
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.searchQuoteBox);
            this.Controls.Add(this.viewQuoteLabel);
            this.Controls.Add(this.mainMenuButton);
            this.Controls.Add(this.searchQuotesBox);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox searchQuotesBox;
        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.Label viewQuoteLabel;
        private System.Windows.Forms.TextBox searchQuoteBox;
    }
}