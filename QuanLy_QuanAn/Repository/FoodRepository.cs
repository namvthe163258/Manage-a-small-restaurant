using QuanLy_QuanAn.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_QuanAn.Repository
{
    public class FoodRepository : IFoodRepository
    {
        public Food GetProductByID(int id) => DAO.Instance.GetProductByID(id);
        public IEnumerable<Food> GetProducts() => DAO.Instance.GetProductList();
        public void InsertProduct(Food product) => DAO.Instance.AddNew(product);
        public void DeleteProduct(int productId) => DAO.Instance.Remove(productId);
        public void UpdateProduct(Food product) => DAO.Instance.Update(product);
    }
}
