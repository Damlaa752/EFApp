using _3_SahibindenApp.Context;
using _3_SahibindenApp.Models;
using _3_SahibindenApp;
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


namespace _3_Sahibinden
{
	public partial class FrmCar : Form
	{
		public FrmCar()
		{
			InitializeComponent();
			cbBrandFill();
			cbColorFill();
		}
		CarsDbContext db = new CarsDbContext();
		public void cbColorFill()
		{
			cbColor.DisplayMember = "Name";
			cbColor.ValueMember = "Id";
			cbColor.DataSource = db.Colors.OrderBy(i => i.Name).ToList();
		}

		public void cbBrandFill()
		{
			cbBrand.DisplayMember = "Name";
			cbBrand.ValueMember = "Id";
			cbBrand.DataSource = db.Brands.OrderBy(i => i.Name).ToList();
		}

		public bool isAdd;
		FrmList fl;
		private void btnSave_Click(object sender, EventArgs e)
		{
			if (Application.OpenForms["FrmList"] == null)
				fl = new FrmList();
			else
				fl = (FrmList)Application.OpenForms["FrmList"];


			if (isAdd)
			{
				//Ekleme
				Car car = new Car(txtModel.Text, Convert.ToInt32(txtYear.Text), Convert.ToInt32(txtKm.Text), Convert.ToDouble(txtPrice.Text), txtCity.Text);
				car.BrandID = (int)cbBrand.SelectedValue;
				car.ColorID = (int)cbColor.SelectedValue;

				db.Entry(car).State = EntityState.Added;
			}
			else
			{
				//Güncelleme
				Car car = db.Cars.Find(fl.id);
				car.Model = txtModel.Text;
				car.Year = Convert.ToInt32(txtYear.Text);
				car.Km = Convert.ToInt32(txtKm.Text);
				car.Price = Convert.ToDouble(txtPrice.Text);
				car.City = txtCity.Text;

				car.BrandID = (int)cbBrand.SelectedValue;
				car.ColorID = (int)cbColor.SelectedValue;

				db.Entry(car).State = EntityState.Modified;

			}
			db.SaveChanges();
			fl.GridFill();
		}

		FrmBrandAndColor fbc;
		private void btnBrand_Click(object sender, EventArgs e)
		{
			if (Application.OpenForms["FrmBrandAndColor"] == null)
				fbc = new FrmBrandAndColor();
			else
				fbc = (FrmBrandAndColor)Application.OpenForms["FrmBrandAndColor"];
			fbc.Show();
			fbc.tabControl1.SelectedIndex = 0;
			isBrandAdd = true;
		}

		private void btnColor_Click(object sender, EventArgs e)
		{
			if (Application.OpenForms["FrmBrandAndColor"] == null)
				fbc = new FrmBrandAndColor();
			else
				fbc = (FrmBrandAndColor)Application.OpenForms["FrmBrandAndColor"];

			fbc.Show();
			fbc.tabControl1.SelectedIndex = 1;
			isColorAdd = true;
		}
		//Brand
		public bool isBrandAdd, isColorAdd;
		public string brand_name, color_name;
		private void değiştirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Application.OpenForms["FrmBrandAndColor"] == null)
				fbc = new FrmBrandAndColor();
			else
				fbc = (FrmBrandAndColor)Application.OpenForms["FrmBrandAndColor"];

			isBrandAdd = false;
			fbc.Show();
			fbc.tabControl1.SelectedIndex = 0;
			fbc.txtBrand.Text = cbBrand.Text;
			brand_name = cbBrand.Text;
		}

		private void silToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Brand brand = db.Brands.Find(cbBrand.SelectedValue);
			db.Entry(brand).State = EntityState.Deleted;
			db.SaveChanges();
			cbBrandFill();

		}

		//Color toolstrip
		//Değiştir
		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
			if (Application.OpenForms["FrmBrandAndColor"] == null)
				fbc = new FrmBrandAndColor();
			else
				fbc = (FrmBrandAndColor)Application.OpenForms["FrmBrandAndColor"];

			isColorAdd = false;
			fbc.Show();
			fbc.tabControl1.SelectedIndex = 1;
			fbc.txtColor.Text = cbColor.Text;
			color_name = cbColor.Text;
		}

		//Sil
		private void toolStripMenuItem2_Click(object sender, EventArgs e)
		{
           var color = db.Colors.Find(cbColor.SelectedValue);
			db.Entry(color).State = EntityState.Deleted;
			db.SaveChanges();
			cbColorFill();
		}
	}
}
