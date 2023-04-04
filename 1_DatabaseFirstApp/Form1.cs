using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_DatabaseFirstApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            groupBox1.Visible = false;
        }
        NorthwindEntities1 db = new NorthwindEntities1();
        private void btnListele_Click(object sender, EventArgs e)
        {
            //dgv.DataSource = db.Employees.ToList();
            GridFill();
        }
        bool isAdd;
        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true ; 
            isAdd = true ;
            groupBox1.Text = "Ekle" ;
        }

        private void değiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            id = (int)dgv.CurrentRow.Cells[0].Value;
            groupBox1.Visible = true;
            isAdd = false;
            groupBox1.Text = "Güncelleştir";
            id = (int)dgv.CurrentRow.Cells[0].Value;
            txtName.Text = dgv.CurrentRow.Cells[1].Value.ToString();
            txtSurname.Text = dgv.CurrentRow.Cells[2].Value.ToString();
            txtCity.Text = dgv.CurrentRow.Cells[3].Value.ToString();
            txtCountry.Text = dgv.CurrentRow.Cells[4].Value.ToString();
        }
        int id;
        private void çıkarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            id= (int)dgv.CurrentRow.Cells[0].Value;
            Employees employee = db.Employees.Find(id);
            //db.Employees.Remove(employee);
            db.Entry(employee).State =EntityState.Deleted;
            db.SaveChanges();
            //dgv.DataSource = db.Employees.ToList();
            GridFill();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {
                var employee = new Employees()
                {
                    FirstName = txtName.Text,
                    LastName =txtSurname.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text
                };
                db.Employees.Add(employee);
                db.Entry(employee).State =EntityState.Added;
                db.SaveChanges();
            }
            else
            {
                var employee = db.Employees.Find(id);
                employee.FirstName = txtName.Text;
                employee.LastName = txtSurname.Text;
                employee.City = txtCity.Text;   
                employee.Country= txtCountry.Text;  
            }
            db.SaveChanges();
            txtName.Text = txtSurname.Text=txtCity.Text=txtCountry.Text ="";
            groupBox1.Visible=false;
            //dgv.DataSource = db.Employees.ToList();
            GridFill();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgv.DataSource = db.Employees.Where(i=>i.FirstName.Contains(txtSearch.Text)|| i.LastName.Contains(txtSearch.Text) || i.City.Contains(txtSearch.Text) || i.Country.Contains(txtSearch.Text)).Select(i=> new
            {
                i.FirstName,
                i.LastName,
                i.City,
                i.Country
            }).ToList();
        }
        private void GridFill()
        {
          //  var query = from e in db.Employees
          //              select new
          //              {
          //                  e.EmployeeID,
          //                  e.FirstName,
          //                  e.LastName,
          //                  e.City,
          //                  e.Country
          //              };
            //2. yöntem
            var query2 = db.Employees.Select(e=> new
            {
                ID = e.EmployeeID,
                AD = e.FirstName,
                SOYAD = e.LastName,
                ŞEHİR = e.City,
                ÜLKE = e.Country
            });
            dgv.DataSource = query2.ToList();
        }
    }
}
