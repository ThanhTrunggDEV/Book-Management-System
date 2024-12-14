namespace BookManagementSystem
{
    partial class addBookForm
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
            this.bookTitleTextBox = new System.Windows.Forms.TextBox();
            this.readOrNot = new System.Windows.Forms.CheckBox();
            this.authorNameTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.addTitleBookLable = new System.Windows.Forms.Label();
            this.addAuthorNameLable = new System.Windows.Forms.Label();
            this.addPriceLable = new System.Windows.Forms.Label();
            this.addBookButton = new System.Windows.Forms.Button();
            this.originalPriceTextBook = new System.Windows.Forms.TextBox();
            this.originalPriceLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bookTitleTextBox
            // 
            this.bookTitleTextBox.Location = new System.Drawing.Point(127, 39);
            this.bookTitleTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.bookTitleTextBox.Name = "bookTitleTextBox";
            this.bookTitleTextBox.Size = new System.Drawing.Size(161, 20);
            this.bookTitleTextBox.TabIndex = 0;
            // 
            // readOrNot
            // 
            this.readOrNot.AutoSize = true;
            this.readOrNot.Location = new System.Drawing.Point(127, 163);
            this.readOrNot.Margin = new System.Windows.Forms.Padding(2);
            this.readOrNot.Name = "readOrNot";
            this.readOrNot.Size = new System.Drawing.Size(90, 17);
            this.readOrNot.TabIndex = 1;
            this.readOrNot.Text = "Already Read";
            this.readOrNot.UseVisualStyleBackColor = true;
            // 
            // authorNameTextBox
            // 
            this.authorNameTextBox.Location = new System.Drawing.Point(127, 73);
            this.authorNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.authorNameTextBox.Name = "authorNameTextBox";
            this.authorNameTextBox.Size = new System.Drawing.Size(161, 20);
            this.authorNameTextBox.TabIndex = 2;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(127, 109);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(161, 20);
            this.priceTextBox.TabIndex = 3;
            // 
            // addTitleBookLable
            // 
            this.addTitleBookLable.AutoSize = true;
            this.addTitleBookLable.Location = new System.Drawing.Point(68, 42);
            this.addTitleBookLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addTitleBookLable.Name = "addTitleBookLable";
            this.addTitleBookLable.Size = new System.Drawing.Size(55, 13);
            this.addTitleBookLable.TabIndex = 4;
            this.addTitleBookLable.Text = "Book Title";
            // 
            // addAuthorNameLable
            // 
            this.addAuthorNameLable.AutoSize = true;
            this.addAuthorNameLable.Location = new System.Drawing.Point(54, 76);
            this.addAuthorNameLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addAuthorNameLable.Name = "addAuthorNameLable";
            this.addAuthorNameLable.Size = new System.Drawing.Size(69, 13);
            this.addAuthorNameLable.TabIndex = 5;
            this.addAuthorNameLable.Text = "Author Name";
            // 
            // addPriceLable
            // 
            this.addPriceLable.AutoSize = true;
            this.addPriceLable.Location = new System.Drawing.Point(92, 112);
            this.addPriceLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addPriceLable.Name = "addPriceLable";
            this.addPriceLable.Size = new System.Drawing.Size(31, 13);
            this.addPriceLable.TabIndex = 6;
            this.addPriceLable.Text = "Price";
            // 
            // addBookButton
            // 
            this.addBookButton.Location = new System.Drawing.Point(127, 184);
            this.addBookButton.Margin = new System.Windows.Forms.Padding(2);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(56, 19);
            this.addBookButton.TabIndex = 7;
            this.addBookButton.Text = "Add";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // originalPriceTextBook
            // 
            this.originalPriceTextBook.Location = new System.Drawing.Point(127, 138);
            this.originalPriceTextBook.Name = "originalPriceTextBook";
            this.originalPriceTextBook.Size = new System.Drawing.Size(161, 20);
            this.originalPriceTextBook.TabIndex = 8;
            // 
            // originalPriceLable
            // 
            this.originalPriceLable.AutoSize = true;
            this.originalPriceLable.Location = new System.Drawing.Point(54, 141);
            this.originalPriceLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.originalPriceLable.Name = "originalPriceLable";
            this.originalPriceLable.Size = new System.Drawing.Size(69, 13);
            this.originalPriceLable.TabIndex = 9;
            this.originalPriceLable.Text = "Original Price";
            // 
            // addBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(365, 227);
            this.Controls.Add(this.originalPriceLable);
            this.Controls.Add(this.originalPriceTextBook);
            this.Controls.Add(this.addBookButton);
            this.Controls.Add(this.addPriceLable);
            this.Controls.Add(this.addAuthorNameLable);
            this.Controls.Add(this.addTitleBookLable);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.authorNameTextBox);
            this.Controls.Add(this.readOrNot);
            this.Controls.Add(this.bookTitleTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "addBookForm";
            this.Text = "Add Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bookTitleTextBox;
        private System.Windows.Forms.CheckBox readOrNot;
        private System.Windows.Forms.TextBox authorNameTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label addTitleBookLable;
        private System.Windows.Forms.Label addAuthorNameLable;
        private System.Windows.Forms.Label addPriceLable;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.TextBox originalPriceTextBook;
        private System.Windows.Forms.Label originalPriceLable;
    }
}