using QuanLy_QuanAn.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_QuanAn.Repository
{
    public interface IFoodRepository
    {
        IEnumerable<Food> GetProducts();
        Food GetProductByID(int id);
        void InsertProduct(Food product);
        void DeleteProduct(int id);
        void UpdateProduct(Food product);
    }
}
