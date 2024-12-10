namespace BookManagementSystem
{
    partial class editBookForm
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
            this.findBookTitle = new System.Windows.Forms.TextBox();
            this.searchBookButton = new System.Windows.Forms.Button();
            this.bookTitle = new System.Windows.Forms.TextBox();
            this.authorName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.readStatus = new System.Windows.Forms.CheckBox();
            this.price = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.titleSearchLable = new System.Windows.Forms.Label();
            this.bookTitleLable = new System.Windows.Forms.Label();
            this.authorNameLable = new System.Windows.Forms.Label();
            this.priceLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // findBookTitle
            // 
            this.findBookTitle.Location = new System.Drawing.Point(108, 33);
            this.findBookTitle.Name = "findBookTitle";
            this.findBookTitle.Size = new System.Drawing.Size(154, 20);
            this.findBookTitle.TabIndex = 0;
            // 
            // searchBookButton
            // 
            this.searchBookButton.Location = new System.Drawing.Point(268, 31);
            this.searchBookButton.Name = "searchBookButton";
            this.searchBookButton.Size = new System.Drawing.Size(75, 23);
            this.searchBookButton.TabIndex = 1;
            this.searchBookButton.Text = "Search";
            this.searchBookButton.UseVisualStyleBackColor = true;
            this.searchBookButton.Click += new System.EventHandler(this.searchBookButton_Click);
            // 
            // bookTitle
            // 
            this.bookTitle.Location = new System.Drawing.Point(108, 75);
            this.bookTitle.Name = "bookTitle";
            this.bookTitle.Size = new System.Drawing.Size(154, 20);
            this.bookTitle.TabIndex = 2;
            // 
            // authorName
            // 
            this.authorName.Location = new System.Drawing.Point(108, 111);
            this.authorName.Name = "authorName";
            this.authorName.Size = new System.Drawing.Size(154, 20);
            this.authorName.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // readStatus
            // 
            this.readStatus.AutoSize = true;
            this.readStatus.Location = new System.Drawing.Point(108, 186);
            this.readStatus.Name = "readStatus";
            this.readStatus.Size = new System.Drawing.Size(85, 17);
            this.readStatus.TabIndex = 5;
            this.readStatus.Text = "Read Status";
            this.readStatus.UseVisualStyleBackColor = true;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(108, 149);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(154, 20);
            this.price.TabIndex = 6;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(108, 209);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 7;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // titleSearchLable
            // 
            this.titleSearchLable.AutoSize = true;
            this.titleSearchLable.BackColor = System.Drawing.SystemColors.Info;
            this.titleSearchLable.Location = new System.Drawing.Point(24, 36);
            this.titleSearchLable.Name = "titleSearchLable";
            this.titleSearchLable.Size = new System.Drawing.Size(78, 13);
            this.titleSearchLable.TabIndex = 8;
            this.titleSearchLable.Text = "Searching Title";
            // 
            // bookTitleLable
            // 
            this.bookTitleLable.AutoSize = true;
            this.bookTitleLable.BackColor = System.Drawing.SystemColors.Info;
            this.bookTitleLable.Location = new System.Drawing.Point(42, 78);
            this.bookTitleLable.Name = "bookTitleLable";
            this.bookTitleLable.Size = new System.Drawing.Size(60, 13);
            this.bookTitleLable.TabIndex = 9;
            this.bookTitleLable.Text = "Found Title";
            // 
            // authorNameLable
            // 
            this.authorNameLable.AutoSize = true;
            this.authorNameLable.BackColor = System.Drawing.SystemColors.Info;
            this.authorNameLable.Location = new System.Drawing.Point(33, 114);
            this.authorNameLable.Name = "authorNameLable";
            this.authorNameLable.Size = new System.Drawing.Size(69, 13);
            this.authorNameLable.TabIndex = 10;
            this.authorNameLable.Text = "Author Name";
            // 
            // priceLable
            // 
            this.priceLable.AutoSize = true;
            this.priceLable.BackColor = System.Drawing.SystemColors.Info;
            this.priceLable.Location = new System.Drawing.Point(71, 152);
            this.priceLable.Name = "priceLable";
            this.priceLable.Size = new System.Drawing.Size(31, 13);
            this.priceLable.TabIndex = 11;
            this.priceLable.Text = "Price";
            // 
            // editBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(392, 254);
            this.Controls.Add(this.priceLable);
            this.Controls.Add(this.authorNameLable);
            this.Controls.Add(this.bookTitleLable);
            this.Controls.Add(this.titleSearchLable);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.price);
            this.Controls.Add(this.readStatus);
            this.Controls.Add(this.authorName);
            this.Controls.Add(this.bookTitle);
            this.Controls.Add(this.searchBookButton);
            this.Controls.Add(this.findBookTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "editBookForm";
            this.Text = "Edit Book Information By Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox findBookTitle;
        private System.Windows.Forms.Button searchBookButton;
        private System.Windows.Forms.TextBox bookTitle;
        private System.Windows.Forms.TextBox authorName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.CheckBox readStatus;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label titleSearchLable;
        private System.Windows.Forms.Label bookTitleLable;
        private System.Windows.Forms.Label authorNameLable;
        private System.Windows.Forms.Label priceLable;
    }
}