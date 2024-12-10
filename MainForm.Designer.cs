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
            this.bookTitleLable = new System.Windows.Forms.Label();
            this.authorNameLable = new System.Windows.Forms.Label();
            this.bookTitleList = new System.Windows.Forms.ListBox();
            this.readStatusList = new System.Windows.Forms.ListBox();
            this.priceList = new System.Windows.Forms.ListBox();
            this.authorNameList = new System.Windows.Forms.ListBox();
            this.readStatusLable = new System.Windows.Forms.Label();
            this.priceLable = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookTitleLable
            // 
            this.bookTitleLable.AutoSize = true;
            this.bookTitleLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTitleLable.Location = new System.Drawing.Point(85, 9);
            this.bookTitleLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bookTitleLable.Name = "bookTitleLable";
            this.bookTitleLable.Size = new System.Drawing.Size(65, 13);
            this.bookTitleLable.TabIndex = 4;
            this.bookTitleLable.Text = "Book Title";
            // 
            // authorNameLable
            // 
            this.authorNameLable.AutoSize = true;
            this.authorNameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorNameLable.Location = new System.Drawing.Point(296, 11);
            this.authorNameLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.authorNameLable.Name = "authorNameLable";
            this.authorNameLable.Size = new System.Drawing.Size(80, 13);
            this.authorNameLable.TabIndex = 5;
            this.authorNameLable.Text = "Author Name";
            // 
            // bookTitleList
            // 
            this.bookTitleList.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bookTitleList.FormattingEnabled = true;
            this.bookTitleList.Location = new System.Drawing.Point(0, 28);
            this.bookTitleList.Margin = new System.Windows.Forms.Padding(2);
            this.bookTitleList.Name = "bookTitleList";
            this.bookTitleList.Size = new System.Drawing.Size(242, 693);
            this.bookTitleList.TabIndex = 7;
            this.bookTitleList.TabStop = false;
            // 
            // readStatusList
            // 
            this.readStatusList.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.readStatusList.FormattingEnabled = true;
            this.readStatusList.Location = new System.Drawing.Point(455, 28);
            this.readStatusList.Margin = new System.Windows.Forms.Padding(2);
            this.readStatusList.Name = "readStatusList";
            this.readStatusList.Size = new System.Drawing.Size(129, 719);
            this.readStatusList.TabIndex = 9;
            this.readStatusList.TabStop = false;
            // 
            // priceList
            // 
            this.priceList.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.priceList.FormattingEnabled = true;
            this.priceList.Location = new System.Drawing.Point(578, 28);
            this.priceList.Margin = new System.Windows.Forms.Padding(2);
            this.priceList.Name = "priceList";
            this.priceList.Size = new System.Drawing.Size(141, 667);
            this.priceList.TabIndex = 10;
            this.priceList.TabStop = false;
            // 
            // authorNameList
            // 
            this.authorNameList.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.authorNameList.FormattingEnabled = true;
            this.authorNameList.Location = new System.Drawing.Point(242, 28);
            this.authorNameList.Margin = new System.Windows.Forms.Padding(2);
            this.authorNameList.Name = "authorNameList";
            this.authorNameList.Size = new System.Drawing.Size(213, 706);
            this.authorNameList.TabIndex = 11;
            this.authorNameList.TabStop = false;
            // 
            // readStatusLable
            // 
            this.readStatusLable.AutoSize = true;
            this.readStatusLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readStatusLable.Location = new System.Drawing.Point(469, 9);
            this.readStatusLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.readStatusLable.Name = "readStatusLable";
            this.readStatusLable.Size = new System.Drawing.Size(94, 13);
            this.readStatusLable.TabIndex = 12;
            this.readStatusLable.Text = "Reading Status";
            // 
            // priceLable
            // 
            this.priceLable.AutoSize = true;
            this.priceLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLable.Location = new System.Drawing.Point(604, 9);
            this.priceLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.priceLable.Name = "priceLable";
            this.priceLable.Size = new System.Drawing.Size(78, 13);
            this.priceLable.TabIndex = 13;
            this.priceLable.Text = "Buying Price";
            // 
            // menuStrip
            // 
            this.menuStrip.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBookToolStripMenuItem,
            this.toolStripSeparator1,
            this.totaToolStripMenuItem,
            this.toolStripSeparator2,
            this.editBookToolStripMenuItem});
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(129, 82);
            // 
            // addBookToolStripMenuItem
            // 
            this.addBookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addBookToolStripMenuItem.Image")));
            this.addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            this.addBookToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.addBookToolStripMenuItem.Text = "Add Book";
            this.addBookToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // totaToolStripMenuItem
            // 
            this.totaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("totaToolStripMenuItem.Image")));
            this.totaToolStripMenuItem.Name = "totaToolStripMenuItem";
            this.totaToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.totaToolStripMenuItem.Text = "Total Price";
            this.totaToolStripMenuItem.Click += new System.EventHandler(this.getTotalPrice_Click);
            // 
            // editBookToolStripMenuItem
            // 
            this.editBookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editBookToolStripMenuItem.Image")));
            this.editBookToolStripMenuItem.Name = "editBookToolStripMenuItem";
            this.editBookToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.editBookToolStripMenuItem.Text = "Edit Book";
            this.editBookToolStripMenuItem.Click += new System.EventHandler(this.editBookButton_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(242, 687);
            this.splitter1.TabIndex = 17;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(242, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(213, 687);
            this.splitter2.TabIndex = 18;
            this.splitter2.TabStop = false;
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(455, 0);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(119, 687);
            this.splitter3.TabIndex = 19;
            this.splitter3.TabStop = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(718, 687);
            this.ContextMenuStrip = this.menuStrip;
            this.Controls.Add(this.readStatusLable);
            this.Controls.Add(this.priceList);
            this.Controls.Add(this.readStatusList);
            this.Controls.Add(this.splitter3);
            this.Controls.Add(this.authorNameLable);
            this.Controls.Add(this.authorNameList);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.bookTitleLable);
            this.Controls.Add(this.bookTitleList);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.priceLable);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Book Management System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label bookTitleLable;
        private System.Windows.Forms.Label authorNameLable;
        private System.Windows.Forms.ListBox bookTitleList;
        private System.Windows.Forms.ListBox readStatusList;
        private System.Windows.Forms.ListBox priceList;
        private System.Windows.Forms.ListBox authorNameList;
        private System.Windows.Forms.Label readStatusLable;
        private System.Windows.Forms.Label priceLable;
        private System.Windows.Forms.ContextMenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem addBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editBookToolStripMenuItem;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

