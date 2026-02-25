using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsStudent;

namespace WindowsFormsStudent
{
    public partial class Form1Resources : Form
    {
        private SchoolDbContext _dbContext;
        private byte[] _currentImageData = null;

        public Form1Resources()
        {
            InitializeComponent();
            _dbContext = new SchoolDbContext();
            ReFreshGrid();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read))
                    {
                        _currentImageData = new byte[fs.Length];
                        fs.Read(_currentImageData, 0, (int)fs.Length);
                    }
                    DisplayImage(_currentImageData);
                }
            }
        }

        private void DisplayImage(byte[] imageData)
        {
            if (imageData != null && imageData.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    picStudent.Image = Image.FromStream(ms);
                    picStudent.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            else
            {
                picStudent.Image = null;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student newStudent = new Student
            {
                Id = int.Parse(txtId.Text),
                Name = txtName.Text,
                Class= txtClass.Text,
                Age = int.Parse(txtAge.Text),
                ImageData = _currentImageData
            };

            _dbContext.AddStudent(newStudent);
            ReFreshGrid();
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student updatedStudent = new Student
            {
                Id = int.Parse(txtId.Text),
                Name = txtName.Text,
                Class = txtClass.Text,
                Age = int.Parse(txtAge.Text),
                ImageData = _currentImageData
            };

            _dbContext.UpdateStudent(updatedStudent);
            ReFreshGrid();
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            _dbContext.DeleteStudent(id);
            ReFreshGrid();
            ClearFields();
        }

        private void ReFreshGrid()
        {
            dgvStudents.DataSource = null;
            dgvStudents.DataSource = _dbContext.GetAllStudent();

            if (dgvStudents.Columns["ImageData"] != null)
            {
                dgvStudents.Columns["ImageData"].Visible = false;
            }
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudents.Rows[e.RowIndex];
                txtId.Text = row.Cells["Id"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtClass.Text = row.Cells["Class"].Value.ToString();
                txtAge.Text = row.Cells["Age"].Value.ToString();

                _currentImageData = row.Cells["ImageData"].Value as byte[];
                DisplayImage(_currentImageData);
            }
        }

        private void ClearFields()
        {
            txtId.Clear();
            txtName.Clear();
            txtClass.Clear();
            txtAge.Clear();
            picStudent.Image = null;
            _currentImageData = null;
        }
       
    }
}