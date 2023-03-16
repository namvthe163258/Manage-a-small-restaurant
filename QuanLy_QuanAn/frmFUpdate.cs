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
    public partial class frmFUpdate : Form
    {
        public frmFUpdate()
        {
            InitializeComponent();
        }
        public IFoodRepository FoodRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Food ProductInfor { get; set; }


        private void Details_Load(object sender, EventArgs e)
        {

            textBox1.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {
                textBox1.Text = ProductInfor.Id.ToString();
                textBox3.Text = ProductInfor.Name;
                textBox2.Text = ProductInfor.Price.ToString();
                textBox4.Text = ProductInfor.Desciption;
                textBox5.Text = ProductInfor.IdCategory.ToString();
              
            }
        }

        private void lb_Tieude_Click(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                var food = new Food
                {

                    Id = int.Parse(textBox1.Text),
                    Name = textBox3.Text,
                    Price = int.Parse(textBox2.Text),
                    Desciption = textBox4.Text,
                    IdCategory = int.Parse(textBox5.Text),
               


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
            MessageBox.Show("This food is updated", "Success");

            this.Close();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
