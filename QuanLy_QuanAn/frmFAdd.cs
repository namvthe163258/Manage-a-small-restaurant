using Microsoft.EntityFrameworkCore.Migrations;
using QuanLy_QuanAn.DataAccess;
using QuanLy_QuanAn.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_QuanAn
{
    public partial class frmFAdd : Form
    {
        public frmFAdd()
        {
            InitializeComponent();
        }

        public IFoodRepository FoodRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Food ProductInfor { get; set; }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmFAdd_Load(object sender, EventArgs e)
        {
            txt_FName.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {
                txt_FName.Text = ProductInfor.Name;
                txt_Price.Text = ProductInfor.Price.ToString();
                txt_Des.Text = ProductInfor.Desciption;
                txt_Cate.Text = ProductInfor.IdCategory.ToString();
                
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                var food = new Food
                {

                    Name = txt_FName.Text,
                    Price = int.Parse(txt_Price.Text),
                    Desciption = txt_Des.Text,
                    IdCategory = int.Parse(txt_Cate.Text),
                    

                };
                if (InsertOrUpdate == false)
                {
                    FoodRepository.InsertProduct(food);
                }
                else
                {
                    FoodRepository.UpdateProduct(food);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Notice" : "Update a product");
            }
            this.Close();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
