namespace MegaDesk_3_RachelBarnes
{
    partial class ViewAllQuotes
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
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.viewQuoteLabel = new System.Windows.Forms.Label();
            this.viewQuoteBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuButton.Location = new System.Drawing.Point(139, 348);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(161, 26);
            this.mainMenuButton.TabIndex = 22;
            this.mainMenuButton.Text = "Back to Main Menu";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // viewQuoteLabel
            // 
            this.viewQuoteLabel.AutoSize = true;
            this.viewQuoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewQuoteLabel.Location = new System.Drawing.Point(163, 31);
            this.viewQuoteLabel.Name = "viewQuoteLabel";
            this.viewQuoteLabel.Size = new System.Drawing.Size(113, 22);
            this.viewQuoteLabel.TabIndex = 24;
            this.viewQuoteLabel.Text = "View Quote";
            // 
            // viewQuoteBox
            // 
            this.viewQuoteBox.Location = new System.Drawing.Point(38, 84);
            this.viewQuoteBox.Name = "viewQuoteBox";
            this.viewQuoteBox.ReadOnly = true;
            this.viewQuoteBox.Size = new System.Drawing.Size(352, 20);
            this.viewQuoteBox.TabIndex = 25;
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.viewQuoteBox);
            this.Controls.Add(this.viewQuoteLabel);
            this.Controls.Add(this.mainMenuButton);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.Label viewQuoteLabel;
        private System.Windows.Forms.TextBox viewQuoteBox;
    }
}