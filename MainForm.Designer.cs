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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.bookTitleLable = new System.Windows.Forms.Label();
            this.authorNameLable = new System.Windows.Forms.Label();
            this.bookTitleList = new System.Windows.Forms.ListBox();
            this.readStatusList = new System.Windows.Forms.ListBox();
            this.priceList = new System.Windows.Forms.ListBox();
            this.authorNameList = new System.Windows.Forms.ListBox();
            this.readStatusLable = new System.Windows.Forms.Label();
            this.priceLable = new System.Windows.Forms.Label();
            this.addBookButton = new System.Windows.Forms.Button();
            this.menuBox = new System.Windows.Forms.GroupBox();
            this.getTotalPrice = new System.Windows.Forms.Button();
            this.menuBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(128, 687);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.SystemColors.Info;
            this.splitter2.Location = new System.Drawing.Point(128, 0);
            this.splitter2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(181, 687);
            this.splitter2.TabIndex = 1;
            this.splitter2.TabStop = false;
            // 
            // splitter3
            // 
            this.splitter3.BackColor = System.Drawing.SystemColors.Info;
            this.splitter3.Location = new System.Drawing.Point(309, 0);
            this.splitter3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(187, 687);
            this.splitter3.TabIndex = 2;
            this.splitter3.TabStop = false;
            // 
            // splitter4
            // 
            this.splitter4.BackColor = System.Drawing.SystemColors.Info;
            this.splitter4.Location = new System.Drawing.Point(496, 0);
            this.splitter4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(106, 687);
            this.splitter4.TabIndex = 3;
            this.splitter4.TabStop = false;
            // 
            // bookTitleLable
            // 
            this.bookTitleLable.AutoSize = true;
            this.bookTitleLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTitleLable.Location = new System.Drawing.Point(190, 7);
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
            this.authorNameLable.Location = new System.Drawing.Point(368, 7);
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
            this.bookTitleList.Location = new System.Drawing.Point(128, 37);
            this.bookTitleList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bookTitleList.Name = "bookTitleList";
            this.bookTitleList.Size = new System.Drawing.Size(182, 654);
            this.bookTitleList.TabIndex = 7;
            this.bookTitleList.TabStop = false;
            // 
            // readStatusList
            // 
            this.readStatusList.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.readStatusList.FormattingEnabled = true;
            this.readStatusList.Location = new System.Drawing.Point(496, 37);
            this.readStatusList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.readStatusList.Name = "readStatusList";
            this.readStatusList.Size = new System.Drawing.Size(107, 693);
            this.readStatusList.TabIndex = 9;
            this.readStatusList.TabStop = false;
            // 
            // priceList
            // 
            this.priceList.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.priceList.FormattingEnabled = true;
            this.priceList.Location = new System.Drawing.Point(602, 37);
            this.priceList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.priceList.Name = "priceList";
            this.priceList.Size = new System.Drawing.Size(116, 654);
            this.priceList.TabIndex = 10;
            this.priceList.TabStop = false;
            // 
            // authorNameList
            // 
            this.authorNameList.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.authorNameList.FormattingEnabled = true;
            this.authorNameList.Location = new System.Drawing.Point(309, 37);
            this.authorNameList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.authorNameList.Name = "authorNameList";
            this.authorNameList.Size = new System.Drawing.Size(188, 654);
            this.authorNameList.TabIndex = 11;
            this.authorNameList.TabStop = false;
            // 
            // readStatusLable
            // 
            this.readStatusLable.AutoSize = true;
            this.readStatusLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readStatusLable.Location = new System.Drawing.Point(507, 11);
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
            this.priceLable.Location = new System.Drawing.Point(626, 11);
            this.priceLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.priceLable.Name = "priceLable";
            this.priceLable.Size = new System.Drawing.Size(78, 13);
            this.priceLable.TabIndex = 13;
            this.priceLable.Text = "Buying Price";
            // 
            // addBookButton
            // 
            this.addBookButton.Location = new System.Drawing.Point(9, 37);
            this.addBookButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(65, 19);
            this.addBookButton.TabIndex = 14;
            this.addBookButton.Text = "Add Book";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuBox
            // 
            this.menuBox.BackColor = System.Drawing.SystemColors.GrayText;
            this.menuBox.Controls.Add(this.getTotalPrice);
            this.menuBox.Controls.Add(this.addBookButton);
            this.menuBox.Location = new System.Drawing.Point(0, 0);
            this.menuBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.menuBox.Name = "menuBox";
            this.menuBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.menuBox.Size = new System.Drawing.Size(128, 701);
            this.menuBox.TabIndex = 15;
            this.menuBox.TabStop = false;
            this.menuBox.Text = "Menu";
            // 
            // getTotalPrice
            // 
            this.getTotalPrice.Location = new System.Drawing.Point(9, 61);
            this.getTotalPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.getTotalPrice.Name = "getTotalPrice";
            this.getTotalPrice.Size = new System.Drawing.Size(64, 20);
            this.getTotalPrice.TabIndex = 15;
            this.getTotalPrice.Text = "Total Price";
            this.getTotalPrice.UseVisualStyleBackColor = true;
            this.getTotalPrice.Click += new System.EventHandler(this.getTotalPrice_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(718, 687);
            this.Controls.Add(this.menuBox);
            this.Controls.Add(this.priceLable);
            this.Controls.Add(this.readStatusLable);
            this.Controls.Add(this.authorNameList);
            this.Controls.Add(this.priceList);
            this.Controls.Add(this.readStatusList);
            this.Controls.Add(this.authorNameLable);
            this.Controls.Add(this.bookTitleLable);
            this.Controls.Add(this.bookTitleList);
            this.Controls.Add(this.splitter4);
            this.Controls.Add(this.splitter3);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Book Management System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.Label bookTitleLable;
        private System.Windows.Forms.Label authorNameLable;
        private System.Windows.Forms.ListBox bookTitleList;
        private System.Windows.Forms.ListBox readStatusList;
        private System.Windows.Forms.ListBox priceList;
        private System.Windows.Forms.ListBox authorNameList;
        private System.Windows.Forms.Label readStatusLable;
        private System.Windows.Forms.Label priceLable;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.GroupBox menuBox;
        private System.Windows.Forms.Button getTotalPrice;
    }
}

