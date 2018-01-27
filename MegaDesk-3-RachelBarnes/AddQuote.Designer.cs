namespace MegaDesk_3_RachelBarnes
{
    partial class AddQuote
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
            this.customerName = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.nameLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.newQuoteLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.depthLabel = new System.Windows.Forms.Label();
            this.surfaceLabel = new System.Windows.Forms.Label();
            this.widthBox = new System.Windows.Forms.NumericUpDown();
            this.depthBox = new System.Windows.Forms.NumericUpDown();
            this.surfaceBox = new System.Windows.Forms.ComboBox();
            this.drawersLabel = new System.Windows.Forms.Label();
            this.drawersBox = new System.Windows.Forms.NumericUpDown();
            this.rushOrderLabel = new System.Windows.Forms.Label();
            this.threeDaysButton = new System.Windows.Forms.RadioButton();
            this.fiveDayButton = new System.Windows.Forms.RadioButton();
            this.sevenDayButton = new System.Windows.Forms.RadioButton();
            this.widthDescription = new System.Windows.Forms.Label();
            this.depthDescription = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.mainMenuButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.widthBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawersBox)).BeginInit();
            this.SuspendLayout();
            // 
            // customerName
            // 
            this.customerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerName.Location = new System.Drawing.Point(167, 56);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(202, 24);
            this.customerName.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(167, 101);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(127, 24);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(102, 59);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(52, 18);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(55, 106);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(99, 18);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "Today\'s Date:";
            // 
            // newQuoteLabel
            // 
            this.newQuoteLabel.AutoSize = true;
            this.newQuoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newQuoteLabel.Location = new System.Drawing.Point(163, 19);
            this.newQuoteLabel.Name = "newQuoteLabel";
            this.newQuoteLabel.Size = new System.Drawing.Size(109, 22);
            this.newQuoteLabel.TabIndex = 4;
            this.newQuoteLabel.Text = "New Quote";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(104, 147);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(50, 18);
            this.widthLabel.TabIndex = 5;
            this.widthLabel.Text = "Width:";
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthLabel.Location = new System.Drawing.Point(100, 189);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(51, 18);
            this.depthLabel.TabIndex = 6;
            this.depthLabel.Text = "Depth:";
            // 
            // surfaceLabel
            // 
            this.surfaceLabel.AutoSize = true;
            this.surfaceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surfaceLabel.Location = new System.Drawing.Point(55, 280);
            this.surfaceLabel.Name = "surfaceLabel";
            this.surfaceLabel.Size = new System.Drawing.Size(99, 18);
            this.surfaceLabel.TabIndex = 7;
            this.surfaceLabel.Text = "Surface Type:";
            // 
            // widthBox
            // 
            this.widthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthBox.Location = new System.Drawing.Point(167, 145);
            this.widthBox.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.widthBox.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(120, 24);
            this.widthBox.TabIndex = 8;
            this.widthBox.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // depthBox
            // 
            this.depthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthBox.Location = new System.Drawing.Point(167, 187);
            this.depthBox.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.depthBox.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.depthBox.Name = "depthBox";
            this.depthBox.Size = new System.Drawing.Size(120, 24);
            this.depthBox.TabIndex = 9;
            this.depthBox.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // surfaceBox
            // 
            this.surfaceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surfaceBox.FormattingEnabled = true;
            this.surfaceBox.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.surfaceBox.Location = new System.Drawing.Point(167, 277);
            this.surfaceBox.Name = "surfaceBox";
            this.surfaceBox.Size = new System.Drawing.Size(121, 26);
            this.surfaceBox.TabIndex = 10;
            this.surfaceBox.Text = "Select...";
            // 
            // drawersLabel
            // 
            this.drawersLabel.AutoSize = true;
            this.drawersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawersLabel.Location = new System.Drawing.Point(12, 235);
            this.drawersLabel.Name = "drawersLabel";
            this.drawersLabel.Size = new System.Drawing.Size(142, 18);
            this.drawersLabel.TabIndex = 11;
            this.drawersLabel.Text = "Number of Drawers:";
            // 
            // drawersBox
            // 
            this.drawersBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawersBox.Location = new System.Drawing.Point(167, 233);
            this.drawersBox.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.drawersBox.Name = "drawersBox";
            this.drawersBox.Size = new System.Drawing.Size(120, 24);
            this.drawersBox.TabIndex = 12;
            // 
            // rushOrderLabel
            // 
            this.rushOrderLabel.AutoSize = true;
            this.rushOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushOrderLabel.Location = new System.Drawing.Point(65, 327);
            this.rushOrderLabel.Name = "rushOrderLabel";
            this.rushOrderLabel.Size = new System.Drawing.Size(89, 18);
            this.rushOrderLabel.TabIndex = 13;
            this.rushOrderLabel.Text = "Rush Order:";
            // 
            // threeDaysButton
            // 
            this.threeDaysButton.AutoSize = true;
            this.threeDaysButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeDaysButton.Location = new System.Drawing.Point(167, 327);
            this.threeDaysButton.Name = "threeDaysButton";
            this.threeDaysButton.Size = new System.Drawing.Size(60, 19);
            this.threeDaysButton.TabIndex = 14;
            this.threeDaysButton.TabStop = true;
            this.threeDaysButton.Text = "3 days";
            this.threeDaysButton.UseVisualStyleBackColor = true;
            // 
            // fiveDayButton
            // 
            this.fiveDayButton.AutoSize = true;
            this.fiveDayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveDayButton.Location = new System.Drawing.Point(244, 327);
            this.fiveDayButton.Name = "fiveDayButton";
            this.fiveDayButton.Size = new System.Drawing.Size(60, 19);
            this.fiveDayButton.TabIndex = 15;
            this.fiveDayButton.TabStop = true;
            this.fiveDayButton.Text = "5 days";
            this.fiveDayButton.UseVisualStyleBackColor = true;
            // 
            // sevenDayButton
            // 
            this.sevenDayButton.AutoSize = true;
            this.sevenDayButton.Location = new System.Drawing.Point(322, 329);
            this.sevenDayButton.Name = "sevenDayButton";
            this.sevenDayButton.Size = new System.Drawing.Size(56, 17);
            this.sevenDayButton.TabIndex = 16;
            this.sevenDayButton.TabStop = true;
            this.sevenDayButton.Text = "7 days";
            this.sevenDayButton.UseVisualStyleBackColor = true;
            // 
            // widthDescription
            // 
            this.widthDescription.AutoSize = true;
            this.widthDescription.Location = new System.Drawing.Point(307, 145);
            this.widthDescription.Name = "widthDescription";
            this.widthDescription.Size = new System.Drawing.Size(115, 26);
            this.widthDescription.TabIndex = 17;
            this.widthDescription.Text = "(width must be\r\nbetween 24-96 inches)";
            // 
            // depthDescription
            // 
            this.depthDescription.AutoSize = true;
            this.depthDescription.Location = new System.Drawing.Point(310, 187);
            this.depthDescription.Name = "depthDescription";
            this.depthDescription.Size = new System.Drawing.Size(112, 26);
            this.depthDescription.TabIndex = 18;
            this.depthDescription.Text = "(depth must be \r\nbetween12-48 inches)";
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(96, 364);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 26);
            this.submitButton.TabIndex = 19;
            this.submitButton.Text = "Submit Quote";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuButton.Location = new System.Drawing.Point(192, 364);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(161, 26);
            this.mainMenuButton.TabIndex = 20;
            this.mainMenuButton.Text = "Back to Main Menu";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.mainMenuButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.depthDescription);
            this.Controls.Add(this.widthDescription);
            this.Controls.Add(this.sevenDayButton);
            this.Controls.Add(this.fiveDayButton);
            this.Controls.Add(this.threeDaysButton);
            this.Controls.Add(this.rushOrderLabel);
            this.Controls.Add(this.drawersBox);
            this.Controls.Add(this.drawersLabel);
            this.Controls.Add(this.surfaceBox);
            this.Controls.Add(this.depthBox);
            this.Controls.Add(this.widthBox);
            this.Controls.Add(this.surfaceLabel);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.newQuoteLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.customerName);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            ((System.ComponentModel.ISupportInitialize)(this.widthBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawersBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label newQuoteLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label surfaceLabel;
        private System.Windows.Forms.NumericUpDown widthBox;
        private System.Windows.Forms.NumericUpDown depthBox;
        private System.Windows.Forms.ComboBox surfaceBox;
        private System.Windows.Forms.Label drawersLabel;
        private System.Windows.Forms.NumericUpDown drawersBox;
        private System.Windows.Forms.Label rushOrderLabel;
        private System.Windows.Forms.RadioButton threeDaysButton;
        private System.Windows.Forms.RadioButton fiveDayButton;
        private System.Windows.Forms.RadioButton sevenDayButton;
        private System.Windows.Forms.Label widthDescription;
        private System.Windows.Forms.Label depthDescription;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button mainMenuButton;
    }
}