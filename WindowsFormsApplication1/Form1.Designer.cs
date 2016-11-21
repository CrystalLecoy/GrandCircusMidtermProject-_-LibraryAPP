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
            this.ucAddBook1 = new WindowsFormsApplication1.ucAddBook();
            this.groupBox2.SuspendLayout();
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
            this.groupBox2.Location = new System.Drawing.Point(12, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 160);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(106, 66);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(165, 23);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // keywordRadioButton
            // 
            this.keywordRadioButton.AutoSize = true;
            this.keywordRadioButton.Location = new System.Drawing.Point(12, 101);
            this.keywordRadioButton.Name = "keywordRadioButton";
            this.keywordRadioButton.Size = new System.Drawing.Size(66, 17);
            this.keywordRadioButton.TabIndex = 4;
            this.keywordRadioButton.TabStop = true;
            this.keywordRadioButton.Text = "Keyword";
            this.keywordRadioButton.UseVisualStyleBackColor = true;
            // 
            // displayLibraryButton
            // 
            this.displayLibraryButton.Location = new System.Drawing.Point(106, 95);
            this.displayLibraryButton.Name = "displayLibraryButton";
            this.displayLibraryButton.Size = new System.Drawing.Size(165, 23);
            this.displayLibraryButton.TabIndex = 3;
            this.displayLibraryButton.Text = "Display Library";
            this.displayLibraryButton.UseVisualStyleBackColor = true;
            this.displayLibraryButton.Click += new System.EventHandler(this.displayLibraryButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(106, 38);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(165, 20);
            this.searchTextBox.TabIndex = 2;
            // 
            // titleRadioButton
            // 
            this.titleRadioButton.AutoSize = true;
            this.titleRadioButton.Location = new System.Drawing.Point(12, 69);
            this.titleRadioButton.Name = "titleRadioButton";
            this.titleRadioButton.Size = new System.Drawing.Size(45, 17);
            this.titleRadioButton.TabIndex = 2;
            this.titleRadioButton.TabStop = true;
            this.titleRadioButton.Text = "Title";
            this.titleRadioButton.UseVisualStyleBackColor = true;
            // 
            // authorRadioButton
            // 
            this.authorRadioButton.AutoSize = true;
            this.authorRadioButton.Location = new System.Drawing.Point(12, 38);
            this.authorRadioButton.Name = "authorRadioButton";
            this.authorRadioButton.Size = new System.Drawing.Size(56, 17);
            this.authorRadioButton.TabIndex = 1;
            this.authorRadioButton.TabStop = true;
            this.authorRadioButton.Text = "Author";
            this.authorRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(115, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(8, 8);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // resultsListView
            // 
            this.resultsListView.FullRowSelect = true;
            this.resultsListView.GridLines = true;
            this.resultsListView.HideSelection = false;
            this.resultsListView.Location = new System.Drawing.Point(343, 65);
            this.resultsListView.MultiSelect = false;
            this.resultsListView.Name = "resultsListView";
            this.resultsListView.Size = new System.Drawing.Size(820, 396);
            this.resultsListView.TabIndex = 3;
            this.resultsListView.UseCompatibleStateImageBehavior = false;
            this.resultsListView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // titleTB
            // 
            this.titleTB.Location = new System.Drawing.Point(12, 251);
            this.titleTB.Name = "titleTB";
            this.titleTB.Size = new System.Drawing.Size(305, 20);
            this.titleTB.TabIndex = 5;
            // 
            // statusTB
            // 
            this.statusTB.Location = new System.Drawing.Point(217, 287);
            this.statusTB.Name = "statusTB";
            this.statusTB.Size = new System.Drawing.Size(100, 20);
            this.statusTB.TabIndex = 7;
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(217, 325);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(100, 23);
            this.checkButton.TabIndex = 10;
            this.checkButton.Text = "Check Out";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // ucAddBook1
            // 
            this.ucAddBook1.Book = null;
            this.ucAddBook1.Location = new System.Drawing.Point(12, 364);
            this.ucAddBook1.Name = "ucAddBook1";
            this.ucAddBook1.Size = new System.Drawing.Size(312, 121);
            this.ucAddBook1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1028, 497);
            this.Controls.Add(this.ucAddBook1);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.statusTB);
            this.Controls.Add(this.titleTB);
            this.Controls.Add(this.resultsListView);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private ucAddBook ucAddBook1;
    }
}

