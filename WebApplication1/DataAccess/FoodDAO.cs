namespace WebApplication1.DataAccess
{
    public class FoodDAO
    {
        //---------------------------------------------------------------------
        //Using Singleton Pattern
        private static FoodDAO instance = null;
        private static readonly object instanceLock = new object();
        public static FoodDAO Instance
        {
            get
            {
                lock (instanceLock)
                {

                    if (instance == null)
                    {
                        instance = new FoodDAO();
                    }
                    return instance;
                }
            }


        }
        //-------------------------------------------------------------------------
        public IEnumerable<Food> GetFoodList()
        {
            var foods = new List<Food>();
            try
            {
                using var context = new QuanLyQuanAnContext();
                foods = context.Foods.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return foods;
        }
        public Food GetFoodByID(int foodID)
        {
            Food food = null;
            try
            {

                using var context = new QuanLyQuanAnContext();
                food = context.Foods.SingleOrDefault(c => c.Id == foodID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return food;
        }
        //-------------------------------------------------------------------------
        public void AddNew(Food food)
        {
            try
            {
                Food _food = GetFoodByID(food.Id);
                if (_food == null)
                {
                    using var context = new QuanLyQuanAnContext();
                    context.Foods.Add(food);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The food is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //--------------------------------------------------------------------------
        public void Update(Food food)
        {
            try
            {
                Food _food = GetFoodByID(food.Id);
                if (_food != null)
                {
                    using var context = new QuanLyQuanAnContext();
                    context.Foods.Update(food);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The food does not elready exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //----------------------------------------------------------------------------
        public void Remove(int foodID)
        {
            try
            {
                Food food = GetFoodByID(foodID);
                if (food != null)
                {
                    using var context = new QuanLyQuanAnContext();
                    context.Foods.Remove(food);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The food does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

