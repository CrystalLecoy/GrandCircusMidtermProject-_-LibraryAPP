namespace WindowsFormsApplication1
{
    partial class ucAddBook
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxAddAuthor = new System.Windows.Forms.TextBox();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.textBoxAddTitle = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxAddAuthor);
            this.groupBox1.Controls.Add(this.buttonAddBook);
            this.groupBox1.Controls.Add(this.textBoxAddTitle);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(305, 115);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Book to Library";
            // 
            // textBoxAddAuthor
            // 
            this.textBoxAddAuthor.Location = new System.Drawing.Point(2, 54);
            this.textBoxAddAuthor.Name = "textBoxAddAuthor";
            this.textBoxAddAuthor.Size = new System.Drawing.Size(306, 20);
            this.textBoxAddAuthor.TabIndex = 11;
            this.textBoxAddAuthor.Enter += new System.EventHandler(this.textBoxAddAuthor_Enter);
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Location = new System.Drawing.Point(205, 79);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(100, 23);
            this.buttonAddBook.TabIndex = 13;
            this.buttonAddBook.Text = "Add Book";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // textBoxAddTitle
            // 
            this.textBoxAddTitle.Location = new System.Drawing.Point(2, 30);
            this.textBoxAddTitle.Name = "textBoxAddTitle";
            this.textBoxAddTitle.Size = new System.Drawing.Size(305, 20);
            this.textBoxAddTitle.TabIndex = 12;
            this.textBoxAddTitle.Enter += new System.EventHandler(this.textBoxAddTitle_Enter);
            // 
            // ucAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ucAddBook";
            this.Size = new System.Drawing.Size(312, 121);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxAddAuthor;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.TextBox textBoxAddTitle;
    }
}
