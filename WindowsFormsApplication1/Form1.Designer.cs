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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.authorRadioButton = new System.Windows.Forms.RadioButton();
            this.titleRadioButton = new System.Windows.Forms.RadioButton();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.displayLibraryButton = new System.Windows.Forms.Button();
            this.keywordRadioButton = new System.Windows.Forms.RadioButton();
            this.searchButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
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
            this.groupBox2.Location = new System.Drawing.Point(0, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 159);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
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
            this.authorRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
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
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(106, 38);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(165, 20);
            this.searchTextBox.TabIndex = 2;
            this.searchTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.keywordRadioButton.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(359, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(405, 173);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 497);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ListBox listBox1;
    }
}

