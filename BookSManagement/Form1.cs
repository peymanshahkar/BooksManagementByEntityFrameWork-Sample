using BookSManagement.Adapter;
using BookSManagement.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookSManagement
{
    public partial class Form1 : Form
    {
        private Library library;
        public Form1()
        {
            InitializeComponent();
            InitializeComponents2();
            library = new Library();
            BookBindingSource = new BindingSource();
            Book = new Book();
            BookBindingSource.DataSource = Book;
            DataBinding();
        }
        private void InitializeComponents2()
        {
            dgvBooks.AutoGenerateColumns = false;
        }
        private List<Book> Dsbooks;
        private Book Book;
        private BindingSource BookBindingSource;
        private void RefreshGrid()
        {
            Dsbooks = library.ListBooks();
            dgvBooks.DataSource = Dsbooks;

        }
        private void DataBinding()
        {
            txtTitle.DataBindings.Add(
                new Binding("Text", BookBindingSource, "Title", true, DataSourceUpdateMode.OnPropertyChanged));
            txtAuthor.DataBindings.Add(
                new Binding("Text", BookBindingSource, "Author", true, DataSourceUpdateMode.OnPropertyChanged));
            txtISBN.DataBindings.Add(
                new Binding("Text", BookBindingSource, "ISBN", true, DataSourceUpdateMode.OnPropertyChanged));
            txtYearPublished.DataBindings.Add(
                new Binding("Text", BookBindingSource, "YearPublished", true, DataSourceUpdateMode.OnPropertyChanged));
        }
        private void Clear()
        {
            Book = new Book();
            BookBindingSource.DataSource = Book;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear();
            txtTitle.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = library.AddBook(Book);
                if (result)
                {
                    RefreshGrid();
                    MessageBox.Show($"کتاب با مشخصات:{Book.GetBookInfo()}" + '\n' + "افزوده شد", ""
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew_Click(null, null);
                }
                else
                {
                    MessageBox.Show($"کتاب با مشخصات:{Book.GetBookInfo()}" + '\n' + "ذخیره نشد", "خطا"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = library.RemoveBook(txtRemoveISBN.Text.Trim());
                if (result)
                {
                    MessageBox.Show("کتاب انتخابی شما با موفقیت حذف گردید", "نتیجه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();
                    txtRemoveISBN.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("کتاب انتخابی حذف نشد");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtRemoveISBN_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRemoveISBN.Text))
            {
                lblBookDetail.Text = "مشخصات کتاب: ";
                return;
            }

            var result = library.GetBookByISBN(txtRemoveISBN.Text.Trim());
            if (result != null)
            {
                lblBookDetail.Text = "مشخصات کتاب: " + result.GetBookInfo();
                btnDel.Enabled = true;
            }
            else
            {
                lblBookDetail.Text = "مشخصات کتاب: ";
                btnDel.Enabled = false;

            }
        }
    }
}
