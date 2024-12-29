namespace BookManagementSystem
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lvBooks = new System.Windows.Forms.ListView();
            this.colOrder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBuyingPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOriginalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colReadingStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtn_Add = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtn_Del = new System.Windows.Forms.ToolStripButton();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.tsLbl_OriginalPrice = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsLbl_BuyingPrice = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsLblDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tm = new System.Windows.Forms.Timer(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsCbbOption = new System.Windows.Forms.ToolStripComboBox();
            this.tsTb = new System.Windows.Forms.ToolStripTextBox();
            this.tsBtn_Edit = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvBooks
            // 
            this.lvBooks.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvBooks.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lvBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colOrder,
            this.colTitle,
            this.colAuthor,
            this.colReadingStatus,
            this.colBuyingPrice,
            this.colOriginalPrice});
            this.lvBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvBooks.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvBooks.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lvBooks.FullRowSelect = true;
            this.lvBooks.GridLines = true;
            this.lvBooks.HideSelection = false;
            this.lvBooks.Location = new System.Drawing.Point(0, 0);
            this.lvBooks.Name = "lvBooks";
            this.lvBooks.Size = new System.Drawing.Size(803, 640);
            this.lvBooks.TabIndex = 1;
            this.lvBooks.UseCompatibleStateImageBehavior = false;
            this.lvBooks.View = System.Windows.Forms.View.Details;
            this.lvBooks.SelectedIndexChanged += new System.EventHandler(this.lvBooks_SelectedIndexChanged);
            // 
            // colOrder
            // 
            this.colOrder.Text = "Order";
            this.colOrder.Width = 50;
            // 
            // colTitle
            // 
            this.colTitle.Text = "Title";
            this.colTitle.Width = 250;
            // 
            // colAuthor
            // 
            this.colAuthor.Text = "Author";
            this.colAuthor.Width = 200;
            // 
            // colBuyingPrice
            // 
            this.colBuyingPrice.Text = "Buying Price";
            this.colBuyingPrice.Width = 100;
            // 
            // colOriginalPrice
            // 
            this.colOriginalPrice.Text = "Original Price";
            this.colOriginalPrice.Width = 100;
            // 
            // colReadingStatus
            // 
            this.colReadingStatus.Text = "Status";
            this.colReadingStatus.Width = 100;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip2);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lvBooks);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(803, 640);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(803, 687);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtn_Add,
            this.toolStripSeparator3,
            this.tsBtn_Del,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.tsCbbOption,
            this.tsTb,
            this.tsBtn_Edit});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(434, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // tsBtn_Add
            // 
            this.tsBtn_Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtn_Add.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_Add.Image")));
            this.tsBtn_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_Add.Name = "tsBtn_Add";
            this.tsBtn_Add.Size = new System.Drawing.Size(23, 22);
            this.tsBtn_Add.Text = "Add Book";
            this.tsBtn_Add.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtn_Del
            // 
            this.tsBtn_Del.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtn_Del.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_Del.Image")));
            this.tsBtn_Del.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_Del.Name = "tsBtn_Del";
            this.tsBtn_Del.Size = new System.Drawing.Size(23, 22);
            this.tsBtn_Del.Text = "Delete Book";
            this.tsBtn_Del.Click += new System.EventHandler(this.tsBtn_Del_Click);
            // 
            // statusStrip2
            // 
            this.statusStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLbl_OriginalPrice,
            this.tsLbl_BuyingPrice,
            this.tsLblDateTime});
            this.statusStrip2.Location = new System.Drawing.Point(0, 0);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(803, 22);
            this.statusStrip2.TabIndex = 1;
            // 
            // tsLbl_OriginalPrice
            // 
            this.tsLbl_OriginalPrice.Name = "tsLbl_OriginalPrice";
            this.tsLbl_OriginalPrice.Size = new System.Drawing.Size(78, 17);
            this.tsLbl_OriginalPrice.Text = "Original Price";
            // 
            // tsLbl_BuyingPrice
            // 
            this.tsLbl_BuyingPrice.Name = "tsLbl_BuyingPrice";
            this.tsLbl_BuyingPrice.Size = new System.Drawing.Size(73, 17);
            this.tsLbl_BuyingPrice.Text = "Buying Price";
            // 
            // tsLblDateTime
            // 
            this.tsLblDateTime.Name = "tsLblDateTime";
            this.tsLblDateTime.Size = new System.Drawing.Size(60, 17);
            this.tsLblDateTime.Text = "Date Time";
            // 
            // tm
            // 
            this.tm.Enabled = true;
            this.tm.Interval = 1000;
            this.tm.Tick += new System.EventHandler(this.tm_Tick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsCbbOption
            // 
            this.tsCbbOption.Items.AddRange(new object[] {
            "Title",
            "Author",
            "Status",
            "Buying Price",
            "Original Price"});
            this.tsCbbOption.Name = "tsCbbOption";
            this.tsCbbOption.Size = new System.Drawing.Size(100, 25);
            this.tsCbbOption.Text = "Title";
            this.tsCbbOption.ToolTipText = "Option To Edit";
            this.tsCbbOption.TextChanged += new System.EventHandler(this.tsCbbOption_TextChanged);
            // 
            // tsTb
            // 
            this.tsTb.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tsTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tsTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsTb.Name = "tsTb";
            this.tsTb.Size = new System.Drawing.Size(200, 25);
            // 
            // tsBtn_Edit
            // 
            this.tsBtn_Edit.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tsBtn_Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtn_Edit.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_Edit.Image")));
            this.tsBtn_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_Edit.Name = "tsBtn_Edit";
            this.tsBtn_Edit.Size = new System.Drawing.Size(23, 22);
            this.tsBtn_Edit.Text = "Edit";
            this.tsBtn_Edit.Click += new System.EventHandler(this.tsBtn_Edit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(803, 687);
            this.Controls.Add(this.toolStripContainer1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Management System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lvBooks;
        private System.Windows.Forms.ColumnHeader colOrder;
        private System.Windows.Forms.ColumnHeader colTitle;
        private System.Windows.Forms.ColumnHeader colAuthor;
        private System.Windows.Forms.ColumnHeader colReadingStatus;
        private System.Windows.Forms.ColumnHeader colBuyingPrice;
        private System.Windows.Forms.ColumnHeader colOriginalPrice;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtn_Add;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsBtn_Del;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel tsLbl_OriginalPrice;
        private System.Windows.Forms.ToolStripStatusLabel tsLbl_BuyingPrice;
        private System.Windows.Forms.ToolStripStatusLabel tsLblDateTime;
        private System.Windows.Forms.Timer tm;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripComboBox tsCbbOption;
        private System.Windows.Forms.ToolStripTextBox tsTb;
        private System.Windows.Forms.ToolStripButton tsBtn_Edit;
    }
}

