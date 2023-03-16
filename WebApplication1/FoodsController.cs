using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Repository;
using WebApplication1.DataAccess;
using System.Diagnostics;

namespace WebApplication1
{
    public class FoodsController : Controller
    {
        IFoodRepository foodRepository = null;

        public FoodsController() => foodRepository = new FoodRepository();


        // GET: FoodController
        public ActionResult Index()
        {
            var foodList = foodRepository.GetFoodList();
            return View(foodList);
        }

        // GET: FoodController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var food = foodRepository.GetFoodByID(id.Value);
            if (food == null)
            {
                return NotFound();
            }
            return View(food);
        }
            // GET: FoodController/Create
            public ActionResult Create()
        {
            return View();
        }

        // POST: FoodController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Food food)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    foodRepository.InsertFood(food);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View(food);
            }
        }

        // GET: FoodController/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var food = foodRepository.GetFoodByID(id.Value);
            if (food == null)
            {
                return NotFound();
            }
            return View(food);
        }

        // POST: FoodController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Food food)
        {
            try
            {
                if (id != food.Id)
                {
                    return NotFound();
                }
                if (ModelState.IsValid)
                {
                    foodRepository.UpdateFood(food);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View(food);
            }
        }

        // GET: FoodController/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var food = foodRepository.GetFoodByID(id.Value);
            if (food == null)
            {
                return NotFound();
            }
            return View(food);
        }

        // POST: FoodController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                foodRepository.DeleteFood(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }
    }
}
