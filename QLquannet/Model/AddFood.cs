﻿using DAL;
using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLquannet.FoodModel
{
    public partial class AddFood : Form
    {
        public string imagePath;
        public string CatID;
        private AddFoodDAL addFoodDAL;
        public AddFood()
        {
            InitializeComponent();
            addFoodDAL = new AddFoodDAL();
        }
        private void AddFood_Load(object sender, EventArgs e)
        {
            LoadComboBox(cboCategory, "SELECT CategoryName FROM Category");

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = openFileDialog.FileName;
                }
            }
        }

        public static byte[] ImageToByteArray(string imagePath)
        {
            using (Image image = Image.FromFile(imagePath))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, ImageFormat.Jpeg);
                    return ms.ToArray();
                }
            }
        }


        private void btnConfirmAddFood_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] imageBytes = ImageToByteArray(imagePath);
                CheckCboID();

                FoodDTO food = new FoodDTO
                {
                    FoodName = txtFoodName.Text,
                    Price = Convert.ToDecimal(txtPrice.Text),
                    IntakePrice = Convert.ToDecimal(txtIntakePrice.Text),
                    Inventory = Convert.ToInt32(txtInventory.Text),
                    CategoryID = Convert.ToInt32(CatID),
                    Image = imageBytes
                };

                addFoodDAL.SaveFood(food);
                MessageBox.Show("Thêm món ăn thành công!");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi!");
            }
        }

        private void LoadComboBox(ComboBox comboBox, string query)
        {
            DataTable dt = addFoodDAL.GetCategories();
            foreach (DataRow row in dt.Rows)
            {
                comboBox.Items.Add(row["CategoryName"].ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckCboID()
        {
            CatID = addFoodDAL.GetCategoryID(cboCategory.SelectedItem.ToString()).ToString();
        }
    }
}
