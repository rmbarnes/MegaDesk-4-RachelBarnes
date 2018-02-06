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
            this.viewQuoteGrid = new System.Windows.Forms.DataGridView();
            this.displayError = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drawer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surfaceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rushOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.viewQuoteGrid)).BeginInit();
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
            this.searchQuotesBox.Location = new System.Drawing.Point(223, 77);
            this.searchQuotesBox.Name = "searchQuotesBox";
            this.searchQuotesBox.Size = new System.Drawing.Size(222, 26);
            this.searchQuotesBox.TabIndex = 11;
            this.searchQuotesBox.Text = "Select...";
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuButton.Location = new System.Drawing.Point(240, 342);
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
            this.viewQuoteLabel.Location = new System.Drawing.Point(219, 26);
            this.viewQuoteLabel.Name = "viewQuoteLabel";
            this.viewQuoteLabel.Size = new System.Drawing.Size(226, 22);
            this.viewQuoteLabel.TabIndex = 25;
            this.viewQuoteLabel.Text = "Search by Surface Type";
            // 
            // viewQuoteGrid
            // 
            this.viewQuoteGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewQuoteGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customer,
            this.date,
            this.width,
            this.depth,
            this.drawer,
            this.surfaceType,
            this.rushOrder,
            this.price});
            this.viewQuoteGrid.Location = new System.Drawing.Point(12, 122);
            this.viewQuoteGrid.Name = "viewQuoteGrid";
            this.viewQuoteGrid.RowHeadersWidth = 40;
            this.viewQuoteGrid.Size = new System.Drawing.Size(623, 188);
            this.viewQuoteGrid.TabIndex = 26;
            // 
            // displayError
            // 
            this.displayError.AutoSize = true;
            this.displayError.Location = new System.Drawing.Point(12, 106);
            this.displayError.Name = "displayError";
            this.displayError.Size = new System.Drawing.Size(35, 13);
            this.displayError.TabIndex = 27;
            this.displayError.Text = "label1";
            this.displayError.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(451, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // customer
            // 
            this.customer.HeaderText = "Customer";
            this.customer.Name = "customer";
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.Width = 70;
            // 
            // width
            // 
            this.width.HeaderText = "Width";
            this.width.Name = "width";
            this.width.Width = 60;
            // 
            // depth
            // 
            this.depth.HeaderText = "Depth";
            this.depth.Name = "depth";
            this.depth.Width = 60;
            // 
            // drawer
            // 
            this.drawer.HeaderText = "Number of Drawers";
            this.drawer.Name = "drawer";
            this.drawer.Width = 60;
            // 
            // surfaceType
            // 
            this.surfaceType.HeaderText = "Surface Type";
            this.surfaceType.Name = "surfaceType";
            // 
            // rushOrder
            // 
            this.rushOrder.HeaderText = "Rush Order Days";
            this.rushOrder.Name = "rushOrder";
            this.rushOrder.Width = 60;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.Width = 70;
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 411);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.displayError);
            this.Controls.Add(this.viewQuoteGrid);
            this.Controls.Add(this.viewQuoteLabel);
            this.Controls.Add(this.mainMenuButton);
            this.Controls.Add(this.searchQuotesBox);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            ((System.ComponentModel.ISupportInitialize)(this.viewQuoteGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox searchQuotesBox;
        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.Label viewQuoteLabel;
        private System.Windows.Forms.DataGridView viewQuoteGrid;
        private System.Windows.Forms.Label displayError;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn width;
        private System.Windows.Forms.DataGridViewTextBoxColumn depth;
        private System.Windows.Forms.DataGridViewTextBoxColumn drawer;
        private System.Windows.Forms.DataGridViewTextBoxColumn surfaceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn rushOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}