using System.Windows.Forms;

namespace WindowsFormsStudent
{
    partial class Form1Resources
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            // ── Controls ──────────────────────────────────────────────
            this.lblTitle      = new System.Windows.Forms.Label();
            this.lblId         = new System.Windows.Forms.Label();
            this.lblName       = new System.Windows.Forms.Label();
            this.lblClass      = new System.Windows.Forms.Label();
            this.lblAge        = new System.Windows.Forms.Label();
            this.lblPhoto      = new System.Windows.Forms.Label();
            this.txtId         = new System.Windows.Forms.TextBox();
            this.txtName       = new System.Windows.Forms.TextBox();
            this.txtClass      = new System.Windows.Forms.TextBox();
            this.txtAge        = new System.Windows.Forms.TextBox();
            this.picStudent    = new System.Windows.Forms.PictureBox();
            this.btnBrowse     = new System.Windows.Forms.Button();
            this.btnAdd        = new System.Windows.Forms.Button();
            this.btnUpdate     = new System.Windows.Forms.Button();
            this.btnDelete     = new System.Windows.Forms.Button();
            this.btnClear      = new System.Windows.Forms.Button();
            this.grpInfo       = new System.Windows.Forms.GroupBox();
            this.grpPhoto      = new System.Windows.Forms.GroupBox();
            this.dgvStudents   = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.grpInfo.SuspendLayout();
            this.grpPhoto.SuspendLayout();
            this.SuspendLayout();

            // ── lblTitle ──────────────────────────────────────────────
            this.lblTitle.Text      = "🎓 Student Management System";
            this.lblTitle.Font      = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 80, 160);
            this.lblTitle.Location  = new System.Drawing.Point(20, 15);
            this.lblTitle.Size      = new System.Drawing.Size(500, 40);
            this.lblTitle.AutoSize  = false;

            // ── grpInfo (Student Info GroupBox) ───────────────────────
            this.grpInfo.Text      = "Student Information";
            this.grpInfo.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpInfo.ForeColor = System.Drawing.Color.FromArgb(30, 80, 160);
            this.grpInfo.Location  = new System.Drawing.Point(20, 65);
            this.grpInfo.Size      = new System.Drawing.Size(430, 220);

            // ── lblId ─────────────────────────────────────────────────
            this.lblId.Text      = "Student ID:";
            this.lblId.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblId.Location  = new System.Drawing.Point(15, 35);
            this.lblId.Size      = new System.Drawing.Size(100, 22);
            this.grpInfo.Controls.Add(this.lblId);

            this.txtId.Location  = new System.Drawing.Point(125, 33);
            this.txtId.Size      = new System.Drawing.Size(280, 26);
            this.txtId.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtId.TabIndex  = 0;
            this.grpInfo.Controls.Add(this.txtId);

            // ── lblName ───────────────────────────────────────────────
            this.lblName.Text     = "Full Name:";
            this.lblName.Font     = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblName.Location = new System.Drawing.Point(15, 80);
            this.lblName.Size     = new System.Drawing.Size(100, 22);
            this.grpInfo.Controls.Add(this.lblName);

            this.txtName.Location = new System.Drawing.Point(125, 78);
            this.txtName.Size     = new System.Drawing.Size(280, 26);
            this.txtName.Font     = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtName.TabIndex = 1;
            this.grpInfo.Controls.Add(this.txtName);

            // ── lblClass ──────────────────────────────────────────────
            this.lblClass.Text     = "Class:";
            this.lblClass.Font     = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblClass.Location = new System.Drawing.Point(15, 125);
            this.lblClass.Size     = new System.Drawing.Size(100, 22);
            this.grpInfo.Controls.Add(this.lblClass);

            this.txtClass.Location = new System.Drawing.Point(125, 123);
            this.txtClass.Size     = new System.Drawing.Size(280, 26);
            this.txtClass.Font     = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtClass.TabIndex = 2;
            this.grpInfo.Controls.Add(this.txtClass);

            // ── lblAge ────────────────────────────────────────────────
            this.lblAge.Text     = "Age:";
            this.lblAge.Font     = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblAge.Location = new System.Drawing.Point(15, 170);
            this.lblAge.Size     = new System.Drawing.Size(100, 22);
            this.grpInfo.Controls.Add(this.lblAge);

            this.txtAge.Location = new System.Drawing.Point(125, 168);
            this.txtAge.Size     = new System.Drawing.Size(280, 26);
            this.txtAge.Font     = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtAge.TabIndex = 3;
            this.grpInfo.Controls.Add(this.txtAge);

            // ── grpPhoto (Photo GroupBox) ─────────────────────────────
            this.grpPhoto.Text      = "Student Photo";
            this.grpPhoto.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpPhoto.ForeColor = System.Drawing.Color.FromArgb(30, 80, 160);
            this.grpPhoto.Location  = new System.Drawing.Point(470, 65);
            this.grpPhoto.Size      = new System.Drawing.Size(200, 220);

            // ── picStudent ────────────────────────────────────────────
            this.picStudent.Location  = new System.Drawing.Point(15, 30);
            this.picStudent.Size      = new System.Drawing.Size(170, 140);
            this.picStudent.SizeMode  = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picStudent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpPhoto.Controls.Add(this.picStudent);

            // ── btnBrowse ─────────────────────────────────────────────
            this.btnBrowse.Text      = "📁 Browse Photo";
            this.btnBrowse.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBrowse.Location  = new System.Drawing.Point(15, 180);
            this.btnBrowse.Size      = new System.Drawing.Size(170, 30);
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(70, 130, 180);
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.TabIndex  = 4;
            this.btnBrowse.Click    += new System.EventHandler(this.btnBrowse_Click);
            this.grpPhoto.Controls.Add(this.btnBrowse);

            // ── Action Buttons ────────────────────────────────────────
            // btnAdd
            this.btnAdd.Text      = "➕ Add Student";
            this.btnAdd.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location  = new System.Drawing.Point(20, 305);
            this.btnAdd.Size      = new System.Drawing.Size(155, 40);
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.TabIndex  = 5;
            this.btnAdd.Click    += new System.EventHandler(this.btnAdd_Click);

            // btnUpdate
            this.btnUpdate.Text      = "✏️ Update";
            this.btnUpdate.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location  = new System.Drawing.Point(190, 305);
            this.btnUpdate.Size      = new System.Drawing.Size(130, 40);
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(255, 153, 0);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.TabIndex  = 6;
            this.btnUpdate.Click    += new System.EventHandler(this.btnUpdate_Click);

            // btnDelete
            this.btnDelete.Text      = "🗑️ Delete";
            this.btnDelete.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location  = new System.Drawing.Point(335, 305);
            this.btnDelete.Size      = new System.Drawing.Size(115, 40);
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.TabIndex  = 7;
            this.btnDelete.Click    += new System.EventHandler(this.btnDelete_Click);

            // btnClear
            this.btnClear.Text      = "🔄 Clear";
            this.btnClear.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.Location  = new System.Drawing.Point(465, 305);
            this.btnClear.Size      = new System.Drawing.Size(105, 40);
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.TabIndex  = 8;
            this.btnClear.Click    += new System.EventHandler(this.btnClear_Click);

            // ── dgvStudents ───────────────────────────────────────────
            this.dgvStudents.Location                       = new System.Drawing.Point(20, 365);
            this.dgvStudents.Size                           = new System.Drawing.Size(650, 220);
            this.dgvStudents.TabIndex                       = 9;
            this.dgvStudents.RowTemplate.Height             = 30;
            this.dgvStudents.ColumnHeadersHeightSizeMode    = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.AutoSizeColumnsMode            = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.SelectionMode                  = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.BackgroundColor                = System.Drawing.Color.White;
            this.dgvStudents.BorderStyle                    = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvStudents.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 80, 160);
            this.dgvStudents.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvStudents.ColumnHeadersDefaultCellStyle.Font      = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.dgvStudents.EnableHeadersVisualStyles      = false;
            this.dgvStudents.CellClick                     += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellClick);

            // ── Form ──────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(700, 610);
            this.Text                = "Student Management System";
            this.Font                = new System.Drawing.Font("Segoe UI", 9.5F);
            this.BackColor           = System.Drawing.Color.FromArgb(245, 248, 255);
            this.StartPosition       = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle     = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox         = false;

            // ── Add controls to Form ──────────────────────────────────
            this.grpInfo.Controls.Add(this.lblId);
            this.grpInfo.Controls.Add(this.txtId);
            this.grpInfo.Controls.Add(this.lblName);
            this.grpInfo.Controls.Add(this.txtName);
            this.grpInfo.Controls.Add(this.lblClass);
            this.grpInfo.Controls.Add(this.txtClass);
            this.grpInfo.Controls.Add(this.lblAge);
            this.grpInfo.Controls.Add(this.txtAge);

            this.grpPhoto.Controls.Add(this.picStudent);
            this.grpPhoto.Controls.Add(this.btnBrowse);

            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.grpPhoto);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvStudents);

            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.grpInfo.ResumeLayout(false);
            this.grpPhoto.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label       lblTitle;
        private System.Windows.Forms.Label       lblId;
        private System.Windows.Forms.Label       lblName;
        private System.Windows.Forms.Label       lblClass;
        private System.Windows.Forms.Label       lblAge;
        private System.Windows.Forms.Label       lblPhoto;
        private System.Windows.Forms.TextBox     txtId;
        private System.Windows.Forms.TextBox     txtName;
        private System.Windows.Forms.TextBox     txtClass;
        private System.Windows.Forms.TextBox     txtAge;
        private System.Windows.Forms.PictureBox  picStudent;
        private System.Windows.Forms.Button      btnBrowse;
        private System.Windows.Forms.Button      btnAdd;
        private System.Windows.Forms.Button      btnUpdate;
        private System.Windows.Forms.Button      btnDelete;
        private System.Windows.Forms.Button      btnClear;
        private System.Windows.Forms.GroupBox    grpInfo;
        private System.Windows.Forms.GroupBox    grpPhoto;
        private System.Windows.Forms.DataGridView dgvStudents;
    }
}
