using _3_SahibindenApp;
using _3_SahibindenApp.Context;
using _3_SahibindenApp.Models;
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
	public partial class FrmList : Form
	{
		public FrmList()
		{
			InitializeComponent();
			btnFilter.BackColor = System.Drawing.Color.FromArgb(67, 125, 185);
			GridFill();
			checkListColorFill();

		}

		private void checkListColorFill()
		{
			foreach (var item in db.Colors.OrderBy(i => i.Name))
			{
				checkListColor.Items.Add(item.Name);
			}
		}

		CarsDbContext db = new CarsDbContext();
		public void GridFill(string param = null)
		{
			if (param == null)
			{
				var query = from c in db.Cars
							join b in db.Brands on c.BrandID equals b.ID
							join r in db.Colors on c.ColorID equals r.ID
							select new
							{
								Id = c.ID,
								Marka = b.Name,
								Model = c.Model,
								Yıl = c.Year,
								Km = c.Km,
								Fiyat = c.Price,
								Renk = r.Name,
								Şehir = c.City
							};

				dgvCarList.DataSource = query.ToList();
			}
			else
			{
				var query = from c in db.Cars
							join b in db.Brands on c.BrandID equals b.ID
							join r in db.Colors on c.ColorID equals r.ID
							where ((c.Model.Contains(txtSearch.Text) || b.Name.Contains(txtSearch.Text)) && (c.Price >= min_price && c.Price <= max_price) && (c.Year >= min_year && c.Year <= max_year) && (c.Km >= min_km && c.Km <= max_km) && (check_colors.Any(x => x == r.Name)))
							select new
							{
								Id = c.ID,
								Marka = b.Name,
								Model = c.Model,
								Yıl = c.Year,
								Km = c.Km,
								Fiyat = c.Price,
								Renk = r.Name,
								Şehir = c.City
							};
				dgvCarList.DataSource = query.ToList();
			}
			if (selectedindex > 0)
			{
				dgvCarList.Rows[0].Selected = false;
				dgvCarList.Rows[selectedindex].Selected = true;
			}

		}

	
		FrmCar fc ;
		private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Application.OpenForms["FrmCar"] == null)
				fc = new FrmCar();
			else
				fc = (FrmCar)Application.OpenForms["FrmCar"];

			fc.isAdd = true;
			fc.Show();//Show

		}

		public int id;

		public int selectedindex = 0;
		private void değiştirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Application.OpenForms["FrmCar"] == null)
				fc = new FrmCar();
			else
				fc = (FrmCar)Application.OpenForms["FrmCar"];

			selectedindex = dgvCarList.CurrentRow.Index;
			fc.isAdd = false;
			id = (int)dgvCarList.CurrentRow.Cells[0].Value;
			fc.cbBrand.Text = dgvCarList.CurrentRow.Cells[1].Value.ToString();
			fc.txtModel.Text = dgvCarList.CurrentRow.Cells[2].Value.ToString();
			fc.txtYear.Text = dgvCarList.CurrentRow.Cells[3].Value.ToString();
			fc.txtKm.Text = dgvCarList.CurrentRow.Cells[4].Value.ToString();
			fc.txtPrice.Text = dgvCarList.CurrentRow.Cells[5].Value.ToString();
			fc.cbColor.Text = dgvCarList.CurrentRow.Cells[6].Value.ToString();
			fc.txtCity.Text = dgvCarList.CurrentRow.Cells[7].Value.ToString();
			fc.Show();
		}

		private void silToolStripMenuItem_Click(object sender, EventArgs e)
		{
			id = (int)dgvCarList.CurrentRow.Cells[0].Value;
			Car car = db.Cars.Find(id);
			var result = MessageBox.Show("Silmek istediğinizden emin misiniz.", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
			if (result == DialogResult.Yes)
			{
				db.Entry(car).State = EntityState.Deleted;
				db.SaveChanges();
			}

			GridFill();
		}
		private void btnFilter_Click(object sender, EventArgs e)
		{
			DefaulValue();
			GridFill("filtreli");
			ControlClear();
		}

		private void ControlClear()
		{
			foreach (var item in this.Controls)
			{
				if (item is TextBox)
				{
					(item as TextBox).Clear();
				}
			}

			checkListColor.ClearSelected();
			foreach (var item in checkListColor.CheckedItems.OfType<object>().ToArray())
			{
				checkListColor.SetItemChecked(checkListColor.Items.IndexOf(item), false);
			}
		}

		int min_price, max_price, min_year, max_year, min_km, max_km;
		List<string> check_colors;
		private void DefaulValue()
		{
			//Price
			if (txtMinPrice.Text == string.Empty)
				min_price = 0;
			else
				min_price = int.Parse(txtMinPrice.Text);

			if (txtMaxPrice.Text == string.Empty)
				max_price = 999999999;
			else
				max_price = int.Parse(txtMaxPrice.Text);


			//Year
			if (txtMinYear.Text == string.Empty)
				min_year = 0;
			else
				min_year = int.Parse(txtMinYear.Text);

			if (txtMaxYear.Text == string.Empty)
				max_year = DateTime.Now.Year;
			else
				max_year = int.Parse(txtMaxYear.Text);

			//Km
			if (txtMinKm.Text == string.Empty)
				min_km = 0;
			else
				min_km = int.Parse(txtMinKm.Text);

			if (txtMaxKm.Text == string.Empty)
				max_km = 1000000;
			else
				max_km = int.Parse(txtMaxKm.Text);

			int index = 0;
			check_colors = new List<string>();
			foreach (var item in checkListColor.Items)
			{
				if (checkListColor.CheckedItems.Contains(item))
				{
					check_colors.Add(item.ToString());
					index++;
				}
			}

			if (index == 0)
			{
				foreach (var item in checkListColor.Items)
				{
					check_colors.Add(item.ToString());

				}
			}
		}
	}
}