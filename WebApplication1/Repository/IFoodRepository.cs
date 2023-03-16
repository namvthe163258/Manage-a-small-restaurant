using WebApplication1.DataAccess;

namespace WebApplication1.Repository
{
    public interface IFoodRepository
    {
        IEnumerable<Food> GetFoodList();
        Food GetFoodByID(int foodID);
        
        void InsertFood(Food food);

        void DeleteFood(int foodId);

        void UpdateFood(Food food);
    }
}
