namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.keywordRadioButton = new System.Windows.Forms.RadioButton();
            this.displayLibraryButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.titleRadioButton = new System.Windows.Forms.RadioButton();
            this.authorRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.resultsListView = new System.Windows.Forms.ListView();
            this.titleTB = new System.Windows.Forms.TextBox();
            this.statusTB = new System.Windows.Forms.TextBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.textBoxAddAuthor = new System.Windows.Forms.TextBox();
            this.textBoxAddTitle = new System.Windows.Forms.TextBox();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchButton);
            this.groupBox2.Controls.Add(this.keywordRadioButton);
            this.groupBox2.Controls.Add(this.displayLibraryButton);
            this.groupBox2.Controls.Add(this.searchTextBox);
            this.groupBox2.Controls.Add(this.titleRadioButton);
            this.groupBox2.Controls.Add(this.authorRadioButton);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(16, 71);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(407, 197);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(141, 81);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(220, 28);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // keywordRadioButton
            // 
            this.keywordRadioButton.AutoSize = true;
            this.keywordRadioButton.Location = new System.Drawing.Point(16, 124);
            this.keywordRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.keywordRadioButton.Name = "keywordRadioButton";
            this.keywordRadioButton.Size = new System.Drawing.Size(83, 21);
            this.keywordRadioButton.TabIndex = 4;
            this.keywordRadioButton.TabStop = true;
            this.keywordRadioButton.Text = "Keyword";
            this.keywordRadioButton.UseVisualStyleBackColor = true;
            // 
            // displayLibraryButton
            // 
            this.displayLibraryButton.Location = new System.Drawing.Point(141, 117);
            this.displayLibraryButton.Margin = new System.Windows.Forms.Padding(4);
            this.displayLibraryButton.Name = "displayLibraryButton";
            this.displayLibraryButton.Size = new System.Drawing.Size(220, 28);
            this.displayLibraryButton.TabIndex = 3;
            this.displayLibraryButton.Text = "Display Library";
            this.displayLibraryButton.UseVisualStyleBackColor = true;
            this.displayLibraryButton.Click += new System.EventHandler(this.displayLibraryButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(141, 47);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(219, 22);
            this.searchTextBox.TabIndex = 2;
            // 
            // titleRadioButton
            // 
            this.titleRadioButton.AutoSize = true;
            this.titleRadioButton.Location = new System.Drawing.Point(16, 85);
            this.titleRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.titleRadioButton.Name = "titleRadioButton";
            this.titleRadioButton.Size = new System.Drawing.Size(56, 21);
            this.titleRadioButton.TabIndex = 2;
            this.titleRadioButton.TabStop = true;
            this.titleRadioButton.Text = "Title";
            this.titleRadioButton.UseVisualStyleBackColor = true;
            // 
            // authorRadioButton
            // 
            this.authorRadioButton.AutoSize = true;
            this.authorRadioButton.Location = new System.Drawing.Point(16, 47);
            this.authorRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.authorRadioButton.Name = "authorRadioButton";
            this.authorRadioButton.Size = new System.Drawing.Size(71, 21);
            this.authorRadioButton.TabIndex = 1;
            this.authorRadioButton.TabStop = true;
            this.authorRadioButton.Text = "Author";
            this.authorRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(153, 113);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(11, 10);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // resultsListView
            // 
            this.resultsListView.FullRowSelect = true;
            this.resultsListView.GridLines = true;
            this.resultsListView.HideSelection = false;
            this.resultsListView.Location = new System.Drawing.Point(457, 80);
            this.resultsListView.Margin = new System.Windows.Forms.Padding(4);
            this.resultsListView.MultiSelect = false;
            this.resultsListView.Name = "resultsListView";
            this.resultsListView.Size = new System.Drawing.Size(1092, 486);
            this.resultsListView.TabIndex = 3;
            this.resultsListView.UseCompatibleStateImageBehavior = false;
            this.resultsListView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // titleTB
            // 
            this.titleTB.Location = new System.Drawing.Point(16, 309);
            this.titleTB.Margin = new System.Windows.Forms.Padding(4);
            this.titleTB.Name = "titleTB";
            this.titleTB.Size = new System.Drawing.Size(405, 22);
            this.titleTB.TabIndex = 5;
            this.titleTB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // statusTB
            // 
            this.statusTB.Location = new System.Drawing.Point(289, 353);
            this.statusTB.Margin = new System.Windows.Forms.Padding(4);
            this.statusTB.Name = "statusTB";
            this.statusTB.Size = new System.Drawing.Size(132, 22);
            this.statusTB.TabIndex = 7;
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(289, 400);
            this.checkButton.Margin = new System.Windows.Forms.Padding(4);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(133, 28);
            this.checkButton.TabIndex = 10;
            this.checkButton.Text = "Check Out";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // textBoxAddAuthor
            // 
            this.textBoxAddAuthor.Location = new System.Drawing.Point(2, 67);
            this.textBoxAddAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAddAuthor.Name = "textBoxAddAuthor";
            this.textBoxAddAuthor.Size = new System.Drawing.Size(406, 22);
            this.textBoxAddAuthor.TabIndex = 11;
            // 
            // textBoxAddTitle
            // 
            this.textBoxAddTitle.Location = new System.Drawing.Point(2, 37);
            this.textBoxAddTitle.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAddTitle.Name = "textBoxAddTitle";
            this.textBoxAddTitle.Size = new System.Drawing.Size(405, 22);
            this.textBoxAddTitle.TabIndex = 12;
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Location = new System.Drawing.Point(273, 97);
            this.buttonAddBook.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(133, 28);
            this.buttonAddBook.TabIndex = 13;
            this.buttonAddBook.Text = "Add Book";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxAddAuthor);
            this.groupBox1.Controls.Add(this.buttonAddBook);
            this.groupBox1.Controls.Add(this.textBoxAddTitle);
            this.groupBox1.Location = new System.Drawing.Point(16, 435);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 142);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Book to Library";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1567, 612);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.statusTB);
            this.Controls.Add(this.titleTB);
            this.Controls.Add(this.resultsListView);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton authorRadioButton;
        private System.Windows.Forms.RadioButton titleRadioButton;
        private System.Windows.Forms.RadioButton keywordRadioButton;
        private System.Windows.Forms.Button displayLibraryButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListView resultsListView;
        private System.Windows.Forms.TextBox titleTB;
        private System.Windows.Forms.TextBox statusTB;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.TextBox textBoxAddAuthor;
        private System.Windows.Forms.TextBox textBoxAddTitle;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

