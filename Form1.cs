using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

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
            if (!ValidateInputs()) return;

            Student newStudent = new Student
            {
                Id        = int.Parse(txtId.Text),
                Name      = txtName.Text,
                Class     = txtClass.Text,
                Age       = int.Parse(txtAge.Text),
                ImageData = _currentImageData
            };

            _dbContext.AddStudent(newStudent);
            ReFreshGrid();
            ClearFields();
            MessageBox.Show("Student added successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            Student updatedStudent = new Student
            {
                Id        = int.Parse(txtId.Text),
                Name      = txtName.Text,
                Class     = txtClass.Text,
                Age       = int.Parse(txtAge.Text),
                ImageData = _currentImageData
            };

            _dbContext.UpdateStudent(updatedStudent);
            ReFreshGrid();
            ClearFields();
            MessageBox.Show("Student updated successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Please enter a Student ID to delete.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this student?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                int id = int.Parse(txtId.Text);
                _dbContext.DeleteStudent(id);
                ReFreshGrid();
                ClearFields();
                MessageBox.Show("Student deleted successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // ← الجديد: زرار Clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ReFreshGrid()
        {
            dgvStudents.DataSource = null;
            dgvStudents.DataSource = _dbContext.GetAllStudent();

            if (dgvStudents.Columns["ImageData"] != null)
                dgvStudents.Columns["ImageData"].Visible = false;
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudents.Rows[e.RowIndex];
                txtId.Text    = row.Cells["Id"].Value.ToString();
                txtName.Text  = row.Cells["Name"].Value.ToString();
                txtClass.Text = row.Cells["Class"].Value.ToString();
                txtAge.Text   = row.Cells["Age"].Value.ToString();

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
            picStudent.Image  = null;
            _currentImageData = null;
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtClass.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtId.Text, out _) || !int.TryParse(txtAge.Text, out _))
            {
                MessageBox.Show("ID and Age must be valid numbers.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
