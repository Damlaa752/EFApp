using _3_SahibindenApp.Context;
using _3_SahibindenApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_SahibindenApp
{
    public partial class FrmBrandAndColor : Form
    {
        public FrmBrandAndColor()
        {
            InitializeComponent();

        }
        CarsDbContext db = new CarsDbContext();
        FrmCarAdd carAdd = (FrmCarAdd)Application.OpenForms["FrmCarAdd"];
        public bool isBrand;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isBrand)
            {
                db.Brands.Add(new Brand(txtBrand.Text));
            }
            else
            {
                db.Colors.Add(new Color(txtBrand.Text));
            }
            db.SaveChanges();
            carAdd.BrandFill();
            carAdd.Colorfill();
            


        }
    }
}
