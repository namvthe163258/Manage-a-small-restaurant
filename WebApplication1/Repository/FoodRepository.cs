using WebApplication1.DataAccess;

namespace WebApplication1.Repository
{
    public class FoodRepository : IFoodRepository
    {
        public void DeleteFood(int foodId) => FoodDAO.Instance.Remove(foodId);

        public Food GetFoodByID(int foodID) => FoodDAO.Instance.GetFoodByID(foodID);

        public IEnumerable<Food> GetFoodList() => FoodDAO.Instance.GetFoodList();

        public void InsertFood(Food food) => FoodDAO.Instance.AddNew(food);

        public void UpdateFood(Food food) => FoodDAO.Instance.Update(food);
    }
}
