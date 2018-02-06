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
            this.viewQuoteGrid = new System.Windows.Forms.DataGridView();
            this.displayError = new System.Windows.Forms.Label();
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
            // mainMenuButton
            // 
            this.mainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuButton.Location = new System.Drawing.Point(249, 349);
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
            this.viewQuoteLabel.Location = new System.Drawing.Point(272, 32);
            this.viewQuoteLabel.Name = "viewQuoteLabel";
            this.viewQuoteLabel.Size = new System.Drawing.Size(113, 22);
            this.viewQuoteLabel.TabIndex = 24;
            this.viewQuoteLabel.Text = "View Quote";
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
            this.viewQuoteGrid.Location = new System.Drawing.Point(12, 70);
            this.viewQuoteGrid.Name = "viewQuoteGrid";
            this.viewQuoteGrid.Size = new System.Drawing.Size(623, 188);
            this.viewQuoteGrid.TabIndex = 25;
            this.viewQuoteGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewQuoteGrid_CellContentClick);
            // 
            // displayError
            // 
            this.displayError.AutoSize = true;
            this.displayError.Location = new System.Drawing.Point(12, 54);
            this.displayError.Name = "displayError";
            this.displayError.Size = new System.Drawing.Size(35, 13);
            this.displayError.TabIndex = 26;
            this.displayError.Text = "label1";
            this.displayError.Visible = false;
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
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 411);
            this.Controls.Add(this.displayError);
            this.Controls.Add(this.viewQuoteGrid);
            this.Controls.Add(this.viewQuoteLabel);
            this.Controls.Add(this.mainMenuButton);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            ((System.ComponentModel.ISupportInitialize)(this.viewQuoteGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.Label viewQuoteLabel;
        private System.Windows.Forms.DataGridView viewQuoteGrid;
        private System.Windows.Forms.Label displayError;
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