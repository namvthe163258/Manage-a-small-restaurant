using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using QuanLy_QuanAn.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_QuanAn.Repository
{
    public class DAO
    {
        private static DAO instance = null;
        private static readonly object instanceLock = new object();
        private QuanLyQuanAnContext dc = new QuanLyQuanAnContext(GetConnection());
        public static string GetConnection()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            return config.GetConnectionString("QuanLyQuanAnDB");
        }

        public static DAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new DAO();
                    }
                    return instance;
                }
            }
        }
        //-------------------------------------------------
        public IEnumerable<Food> GetProductList()
        {
            var products = new List<Food>();
            try
            {
                using var context = new QuanLyQuanAnContext();
                products = context.Foods.ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return products;
        }
        //-------------------------------------------------
        public Food GetProductByID(int productID)
        {
            Food prd = null;
            try
            {
                using var context = new QuanLyQuanAnContext();
                prd = context.Foods.SingleOrDefault(c => c.Id == productID);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return prd;
        }
        //-------------------------------------------------

        public void AddNew(Food product)
        {
            try
            {
                dc.Foods.Add(product);
                dc.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        //------------------------------------------------------
        public void Update(Food product)
        {
            try
            {
                Food _product = GetProductByID(product.Id);
                if (_product != null)
                {
                    using var context = new QuanLyQuanAnContext();
                    context.Foods.Update(product);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The product is already exist.");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        //------------------------------------------------------
        public void Remove(int productID)
        {
            try
            {
                Food product = GetProductByID(productID);
                if (product != null)
                {
                    using var context = new QuanLyQuanAnContext();
                    context.Foods.Remove(product);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The product is already exist.");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
