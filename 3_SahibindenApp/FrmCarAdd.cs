using _3_SahibindenApp.Context;
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
        FrmBrandAndColor fbc = new FrmBrandAndColor();
        public void BrandFill()
        {
           cbBrand.Items.Clear();
            foreach (var brand in db.Brands)
            {
                cbBrand.Items.Add(brand.Name);
            }

        }
        private void btnBrandAdd_Click(object sender, EventArgs e)
        {
            FrmBrandAndColor fbc = new FrmBrandAndColor();
            fbc.Show();
            fbc.isBrand = true;
        }

        private void btnColorAdd_Click(object sender, EventArgs e)
        {
            FrmBrandAndColor fbc = new FrmBrandAndColor();
            fbc.Show();
            fbc.isBrand = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FrmList f = new FrmList();
            f.Show();
        }
    }
}
