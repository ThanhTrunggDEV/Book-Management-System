namespace BookManagementSystem
{
    partial class Add_Book_Form
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
            this.SuspendLayout();
            // 
            // bookTitleTextBox
            // 
            this.bookTitleTextBox.Location = new System.Drawing.Point(169, 69);
            this.bookTitleTextBox.Name = "bookTitleTextBox";
            this.bookTitleTextBox.Size = new System.Drawing.Size(213, 22);
            this.bookTitleTextBox.TabIndex = 0;
            // 
            // readOrNot
            // 
            this.readOrNot.AutoSize = true;
            this.readOrNot.Location = new System.Drawing.Point(169, 177);
            this.readOrNot.Name = "readOrNot";
            this.readOrNot.Size = new System.Drawing.Size(113, 20);
            this.readOrNot.TabIndex = 1;
            this.readOrNot.Text = "Already Read";
            this.readOrNot.UseVisualStyleBackColor = true;
            // 
            // authorNameTextBox
            // 
            this.authorNameTextBox.Location = new System.Drawing.Point(169, 108);
            this.authorNameTextBox.Name = "authorNameTextBox";
            this.authorNameTextBox.Size = new System.Drawing.Size(213, 22);
            this.authorNameTextBox.TabIndex = 2;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(169, 149);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(213, 22);
            this.priceTextBox.TabIndex = 3;
            // 
            // addTitleBookLable
            // 
            this.addTitleBookLable.AutoSize = true;
            this.addTitleBookLable.Location = new System.Drawing.Point(95, 72);
            this.addTitleBookLable.Name = "addTitleBookLable";
            this.addTitleBookLable.Size = new System.Drawing.Size(68, 16);
            this.addTitleBookLable.TabIndex = 4;
            this.addTitleBookLable.Text = "Book Title";
            // 
            // addAuthorNameLable
            // 
            this.addAuthorNameLable.AutoSize = true;
            this.addAuthorNameLable.Location = new System.Drawing.Point(78, 111);
            this.addAuthorNameLable.Name = "addAuthorNameLable";
            this.addAuthorNameLable.Size = new System.Drawing.Size(85, 16);
            this.addAuthorNameLable.TabIndex = 5;
            this.addAuthorNameLable.Text = "Author Name";
            // 
            // addPriceLable
            // 
            this.addPriceLable.AutoSize = true;
            this.addPriceLable.Location = new System.Drawing.Point(116, 155);
            this.addPriceLable.Name = "addPriceLable";
            this.addPriceLable.Size = new System.Drawing.Size(38, 16);
            this.addPriceLable.TabIndex = 6;
            this.addPriceLable.Text = "Price";
            // 
            // addBookButton
            // 
            this.addBookButton.Location = new System.Drawing.Point(169, 203);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(75, 23);
            this.addBookButton.TabIndex = 7;
            this.addBookButton.Text = "Add";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // Add_Book_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(487, 279);
            this.Controls.Add(this.addBookButton);
            this.Controls.Add(this.addPriceLable);
            this.Controls.Add(this.addAuthorNameLable);
            this.Controls.Add(this.addTitleBookLable);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.authorNameTextBox);
            this.Controls.Add(this.readOrNot);
            this.Controls.Add(this.bookTitleTextBox);
            this.Name = "Add_Book_Form";
            this.Text = "Add_Book_Form";
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
    }
}