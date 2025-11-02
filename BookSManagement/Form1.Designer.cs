namespace BookSManagement
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
            this.GrpAdd = new System.Windows.Forms.GroupBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYearPublished = new System.Windows.Forms.MaskedTextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GrpDel = new System.Windows.Forms.GroupBox();
            this.lblBookDetail = new System.Windows.Forms.Label();
            this.txtRemoveISBN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.GrpBookList = new System.Windows.Forms.GroupBox();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearPublished = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrpAdd.SuspendLayout();
            this.GrpDel.SuspendLayout();
            this.GrpBookList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // GrpAdd
            // 
            this.GrpAdd.Controls.Add(this.btnNew);
            this.GrpAdd.Controls.Add(this.btnAdd);
            this.GrpAdd.Controls.Add(this.label4);
            this.GrpAdd.Controls.Add(this.txtYearPublished);
            this.GrpAdd.Controls.Add(this.txtISBN);
            this.GrpAdd.Controls.Add(this.label3);
            this.GrpAdd.Controls.Add(this.txtAuthor);
            this.GrpAdd.Controls.Add(this.label2);
            this.GrpAdd.Controls.Add(this.txtTitle);
            this.GrpAdd.Controls.Add(this.label1);
            this.GrpAdd.Location = new System.Drawing.Point(14, 13);
            this.GrpAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrpAdd.Name = "GrpAdd";
            this.GrpAdd.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrpAdd.Size = new System.Drawing.Size(341, 146);
            this.GrpAdd.TabIndex = 0;
            this.GrpAdd.TabStop = false;
            this.GrpAdd.Text = "افزودن";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(85, 117);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "جدید";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(7, 117);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "افزودن";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "سال انتشار";
            // 
            // txtYearPublished
            // 
            this.txtYearPublished.Location = new System.Drawing.Point(166, 100);
            this.txtYearPublished.Mask = "0000";
            this.txtYearPublished.Name = "txtYearPublished";
            this.txtYearPublished.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtYearPublished.Size = new System.Drawing.Size(100, 22);
            this.txtYearPublished.TabIndex = 3;
            this.txtYearPublished.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtYearPublished.ValidatingType = typeof(int);
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(137, 72);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtISBN.Size = new System.Drawing.Size(129, 22);
            this.txtISBN.TabIndex = 2;
            this.txtISBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "ISBN";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(137, 44);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(129, 22);
            this.txtAuthor.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "نویسنده";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(137, 15);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(129, 22);
            this.txtTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "عنوان کتاب";
            // 
            // GrpDel
            // 
            this.GrpDel.Controls.Add(this.lblBookDetail);
            this.GrpDel.Controls.Add(this.txtRemoveISBN);
            this.GrpDel.Controls.Add(this.label5);
            this.GrpDel.Controls.Add(this.btnDel);
            this.GrpDel.Location = new System.Drawing.Point(371, 13);
            this.GrpDel.Name = "GrpDel";
            this.GrpDel.Size = new System.Drawing.Size(450, 146);
            this.GrpDel.TabIndex = 1;
            this.GrpDel.TabStop = false;
            this.GrpDel.Text = "حذف بر اساس ISBN";
            // 
            // lblBookDetail
            // 
            this.lblBookDetail.Location = new System.Drawing.Point(6, 72);
            this.lblBookDetail.Name = "lblBookDetail";
            this.lblBookDetail.Size = new System.Drawing.Size(423, 63);
            this.lblBookDetail.TabIndex = 13;
            this.lblBookDetail.Text = "مشخصات کتاب:";
            // 
            // txtRemoveISBN
            // 
            this.txtRemoveISBN.Location = new System.Drawing.Point(170, 39);
            this.txtRemoveISBN.Name = "txtRemoveISBN";
            this.txtRemoveISBN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRemoveISBN.Size = new System.Drawing.Size(180, 22);
            this.txtRemoveISBN.TabIndex = 12;
            this.txtRemoveISBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRemoveISBN.TextChanged += new System.EventHandler(this.txtRemoveISBN_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 14);
            this.label5.TabIndex = 11;
            this.label5.Text = "ISBN";
            // 
            // btnDel
            // 
            this.btnDel.Enabled = false;
            this.btnDel.Location = new System.Drawing.Point(354, 38);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 10;
            this.btnDel.Text = "حذف";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // GrpBookList
            // 
            this.GrpBookList.Controls.Add(this.dgvBooks);
            this.GrpBookList.Location = new System.Drawing.Point(12, 165);
            this.GrpBookList.Name = "GrpBookList";
            this.GrpBookList.Size = new System.Drawing.Size(810, 426);
            this.GrpBookList.TabIndex = 2;
            this.GrpBookList.TabStop = false;
            this.GrpBookList.Text = "لیست کتاب ها";
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooks.BackgroundColor = System.Drawing.Color.White;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Author,
            this.YearPublished,
            this.ISBN});
            this.dgvBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBooks.Location = new System.Drawing.Point(3, 18);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(804, 405);
            this.dgvBooks.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "عنوان کتاب";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Author
            // 
            this.Author.DataPropertyName = "Author";
            this.Author.HeaderText = "نویسنده";
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            // 
            // YearPublished
            // 
            this.YearPublished.DataPropertyName = "YearPublished";
            this.YearPublished.HeaderText = "سال انتشار";
            this.YearPublished.Name = "YearPublished";
            this.YearPublished.ReadOnly = true;
            // 
            // ISBN
            // 
            this.ISBN.DataPropertyName = "ISBN";
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 596);
            this.Controls.Add(this.GrpBookList);
            this.Controls.Add(this.GrpDel);
            this.Controls.Add(this.GrpAdd);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GrpAdd.ResumeLayout(false);
            this.GrpAdd.PerformLayout();
            this.GrpDel.ResumeLayout(false);
            this.GrpDel.PerformLayout();
            this.GrpBookList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpAdd;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtYearPublished;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox GrpDel;
        private System.Windows.Forms.TextBox txtRemoveISBN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.GroupBox GrpBookList;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Label lblBookDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearPublished;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
    }
}

