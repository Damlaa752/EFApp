using _3_SahibindenApp.Context;
using _3_SahibindenApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_SahibindenApp
{
    public partial class FrmCarAdd : Form
    {
        public FrmCarAdd()
        {
            InitializeComponent();
            BrandFill();
        }
        CarsDbContext db = new CarsDbContext();
        FrmBrandAndColor fbc;
        public void BrandFill()
        {
           cbBrand.Items.Clear();
            foreach (var brand in db.Brands)
            {
                cbBrand.Items.Add(brand.Name);
            }

        }
        public void Colorfill()
        {
            cbColor.Items.Clear();
            foreach(var color in db.Colors)
            {
                cbColor.Items.Add(color.Name);
            }
        }
        private void btnBrandAdd_Click(object sender, EventArgs e)
        {
            fbc = new FrmBrandAndColor();
            fbc.isBrand = true;           
            fbc.Show();
        }

        private void btnColorAdd_Click(object sender, EventArgs e)
        {
            fbc = new FrmBrandAndColor();
            fbc.isBrand = false;
            fbc.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool sonuc = true;
            if (txtYear.Text.Length < 5)
            {
            for (int i = 0; i < txtYear.Text.Length; i++)
            {
                if (!char.IsDigit(txtYear.Text[i]))
                        sonuc =false;
                }
               MessageBox.Show("Yılı doğru giriniz.");
                
            }
            Car car = new Car(cbBrand.Text,txtModel.Text, int.Parse(txtYear.Text), txtKm.Text,double.Parse(txtPrice.Text), int.Parse(cbColor.Text), txtCity.Text);
            db.Cars.Add(car);   
            db.SaveChanges();
            FrmList f = new FrmList();
            f.Show();
            f.DbVeriCekme();
        }

        private void değiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
