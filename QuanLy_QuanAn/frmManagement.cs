using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuanLy_QuanAn
{
    public partial class frmManagement : Form
    {
        IFoodRepository foodRepository = new FoodRepository();
        BindingSource source;

        

        public frmManagement()
        { 
            InitializeComponent();
            Sortdata();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            dgvFoodList.CellDoubleClick += dgvFoodList_CellDoubleClick;
        }

        private void dgvFoodList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmFUpdate frmFoodDetails = new frmFUpdate()
            {
                Text = "Update food",
                InsertOrUpdate = true,
                ProductInfor = GetFoodObject(),
                FoodRepository = foodRepository,
            };
            if (frmFoodDetails.ShowDialog() == DialogResult.OK)
            {
                LoadFoodList();
                source.Position = source.Count - 1;
            }
        }

        private void Sortdata()
        {
            var dt = foodRepository.GetProducts();
            source = new BindingSource();
            source.DataSource = dt;
            cbo_Search.DisplayMember = "Name";
            cbo_Search.ValueMember = "Name";
            cbo_Search.DataSource = dt;
        }

        private Food GetFoodObject()
        {
            Food car = null;
            try
            {
                car = new Food
                {
                    Id = int.Parse(txt_ID.Text),
                    Name = txt_FName.Text,
                    Price = int.Parse(txt_Price.Text),
                    Desciption = txt_Desc.Text,
                    IdCategory = int.Parse(txt_Cate.Text)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get food");

            }
            return car;
        }

        public void LoadFoodList()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select f.id, f.name, f.idCategory, e.name as Category, f.price, f.Desciption from Food f, FoodCategory e where f.idCategory = e.id ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvFoodList.DataSource = dt;
            con.Close();

            var foods = foodRepository.GetProducts();
            try {
                source = new BindingSource();
                source.DataSource = dt;

                txt_ID.DataBindings.Clear();
                txt_FName.DataBindings.Clear();
                txt_Price.DataBindings.Clear();
                txt_Desc.DataBindings.Clear();
                txt_Cate.DataBindings.Clear();

                txt_ID.DataBindings.Add("Text", source, "id");
                txt_FName.DataBindings.Add("Text", source, "name");
                txt_Price.DataBindings.Add("Text", source, "price");
                txt_Desc.DataBindings.Add("Text", source, "Desciption");
                txt_Cate.DataBindings.Add("Text", source, "idCategory");

                dgvFoodList.DataSource = null;
                dgvFoodList.DataSource = source;
                if (foods.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;

                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "load food list");
            }
        }


        private void ClearText()
        {
            txt_ID.Text = string.Empty;
            txt_FName.Text = string.Empty;
            txt_Price.Text = string.Empty;
            txt_Desc.Text = string.Empty;
            txt_Cate.Text = string.Empty;

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadFoodList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmFAdd frmFoodDetails = new frmFAdd()
            {
                Text = "Add food",
                InsertOrUpdate = false,
                FoodRepository = foodRepository
            };
            if (frmFoodDetails.ShowDialog() == DialogResult.OK)
            {
                LoadFoodList();
                source.Position = source.Count - 1;
            }
            btnLoad_Click(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var food = GetFoodObject();
                foodRepository.DeleteProduct(food.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a food");
            }
            btnLoad_Click(sender, e);
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            frmFUpdate frmFoodDetails = new frmFUpdate()
           {
                Text = "Update food",
                InsertOrUpdate = true,
                ProductInfor = GetFoodObject(),
                FoodRepository = foodRepository,
            };
            if (frmFoodDetails.ShowDialog() == DialogResult.OK)
            {
                LoadFoodList();
                source.Position = source.Count - 1;
            }
            btnLoad_Click(sender, e);
        }

        SqlConnection con = new SqlConnection(DAO.GetConnection());


        private void btn_Search_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Food where name = @name", con);
            cmd.Parameters.AddWithValue("name", cbo_Search.Text);
            //cmd.Parameters.AddWithValue("MemberName", int.Parse(txtSearch.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvFoodList.DataSource = dt;
            con.Close();
        }

        private void cbo_Search_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvFoodList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
