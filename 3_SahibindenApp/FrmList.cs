using _3_SahibindenApp.Context;
using _3_SahibindenApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = System.Drawing.Color;

namespace _3_SahibindenApp
{
    public partial class FrmList : Form
    {
        public FrmList()
        {
            InitializeComponent();
            btnFilter.BackColor = Color.FromArgb(60, 160, 208);
          
        }
        CarsDbContext carsDbContext = new CarsDbContext();
        public void DbVeriCekme()
        {
            var query = carsDbContext.Cars.ToList();
            dgvCarList.DataSource = query;
        }
        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCarAdd f = new FrmCarAdd();
            f.Show();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id= (int)dgvCarList.CurrentRow.Cells[0].Value;
            var entity = carsDbContext.Cars.Find(id);
            carsDbContext.Entry(entity).State = EntityState.Deleted;
            carsDbContext.SaveChanges();
            MessageBox.Show("Kayıt Başarıyla Silindi.");
        }

        private void değiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dgvCarList.DataSource = carsDbContext.Cars.Select(i=> new {
                MODEL =i.Model,
                YIL = i.Year,
                FİYAT = i.Price,
                ŞEHİR = i.City
                }).ToList();
           
        }

 
    }
}
