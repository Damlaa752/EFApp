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
    public partial class FrmBrandAndColor : Form
    {
        public FrmBrandAndColor()
        {
            InitializeComponent();
           
        }
        CarsDbContext db = new CarsDbContext();
        public bool isBrand;
        private void btnSave_Click(object sender, EventArgs e)
        {
           
            if (isBrand)
            {
                Brand brand = new Brand(1,txtName.Text);
                db.Brands.Add(brand);
                
            }
            db.SaveChanges();
            txtName.Text=string.Empty;
        }
    }
}
