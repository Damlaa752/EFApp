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
    public partial class FrmCourse : Form
    {
        public FrmCourse()
        {
            InitializeComponent();
            btnList_Click(null, new EventArgs());//başlangıçtada liste gözüksün diye yaptık.
            cbEducatorFill();
            gbStudentsFill();

        }
        CourseDbContext db = new CourseDbContext();
        public void gbStudentsFill()
        {
            gbStudents.Controls.Clear();
            int studentCount=db.Students.Count();
            int y=0,x=0;
            foreach (var student in db.Students)
            {

                CheckBox check = new CheckBox();
                check.Name = $"check{student.Name}";
                check.Text = $"{student.Name} {student.Surname}";
                y += 25;
                if (y > gbStudents.Location.Y)
                {
                    y = 0;
                    x += 50;
                }
                check.Location = new Point(10 + x, y);
                gbStudents.Controls.Add(check);
            }
        }

        public void cbEducatorFill()
        {
           cbEducator.Items.Clear();
            foreach (var educator in db.Educators)
            {
                cbEducator.Items.Add($"{educator.Name} {educator.Surname}");
            }
        }

       
        private void btnSave_Click(object sender, EventArgs e)
        {
           
            Course course = new Course(txtName.Text,dtpStartDate.Value,dtpEndDate.Value);
            
            string[] array = cbEducator.Text.Split(' ');
            Educator educator = new Educator(array[0], array[1]);
            course.EducatorId = db.Educators.FirstOrDefault(i=>i.Name== educator.Name && i.Surname == educator.Surname).Id;
            foreach (var item in gbStudents.Controls)
            {
                if( (item as CheckBox).Checked)
                {
                    array = (item as CheckBox).Text.Split(' ');
                    Student s = new Student(array[0], array[1]);
                    Student student = db.Students.FirstOrDefault(i => i.Name == s.Name && i.Surname == s.Surname);
                    course.Students.Add(student);
                }
            }
            db.Courses.Add(course);
            db.SaveChanges();
            btnList_Click(sender, e);
        }

        private void lblEducator_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAdd f = new FrmAdd();
            f.Text = "Eğitmen Ekle";
            f.isEducator= true;
            f.Show();
        }

        private void lblStudent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAdd f = new FrmAdd();
            f.Text = "Öğrenci Ekle";
            f.isEducator = false;
            f.Show();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            //1. yöntem
            dgv.DataSource = db.Courses.Select(i=> new {
                ID =i.Id,
                AD =i.Name,
                BASLANGIÇTARİHİ = i.StartDate,
                BİTİŞTARİHİ = i.EndDate,
                EĞİTMEN = i.EducatorId
            }).ToList();
            //Join ile 2 yöntemle yapılabilir
            //1.yöntem Linq yazılıs tarzı
            //var query = from c in db.Courses
            //            join t in db.Educators on c.EducatorId equals t.Id
            //            select new
            //            {
            //                ID = c.Id,
            //                AD = c.Name,
            //                BAŞLANGIÇTARİHİ = c.StartDate,
            //                BİTİŞTARİHİ = c.EndDate,
            //                EGİTMEN = t.Name + " "+ t.Surname
            //            };
            //dgv.DataSource =  query.ToList();


            //2.yöntem Lambda yazış tarzı
           // dgv.DataSource = db.Courses.Join(db.Educators, c => c.EducatorId, t => /t.Id, /(c, t) => new
           // {
           //     ID = c.Id,
           //     AD = c.Name,
           //     BAŞLANGIÇTARİHİ = c.StartDate,
           //     BİTİŞTARİHİ = c.EndDate,
           //     EGİTMEN = t.Name + " " + t.Surname
           // }).ToList();

        }
    }
}
