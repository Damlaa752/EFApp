using _2_CodeFirstApp.Context;
using _2_CodeFirstApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_CodeFirstApp
{
    public partial class FrmAdd : Form
    {
        public FrmAdd()
        {
            InitializeComponent();
        }
        public bool isEducator;
        CourseDbContext db = new CourseDbContext();
        FrmCourse fc = (FrmCourse)Application.OpenForms["FrmCourse"];
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isEducator)
            {
                db.Educators.Add(new Educator(txtName.Text,txtSurname.Text));
                db.SaveChanges();
                fc.cbEducatorFill();
            }
            else
            {
                db.Students.Add(new Student(txtName.Text, txtSurname.Text));
                db.SaveChanges();
                fc.gbStudentsFill();
            }
        }
    }
}
