using Microsoft.AspNetCore.Mvc;
using ShabbatGuests.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using ShabbatGuests.ViewModel;

namespace ShabbatGuests.Controllers
{
    public class HostController : Controller
    {
        public IActionResult Index()
        {
            List<FoodCategory> foodCategories = DAL.Get.foodCategories.Include(c => c.foods).ToList();
            List<Guest> guests = DAL.Get.guests.Include(g => g.foods).ToList();
            VMHostMain hm = new VMHostMain { foodCategories = foodCategories, guests = guests };
            return View(hm);
        }


        public IActionResult FoodDetails(int? id)
        {
            if (id == null) return RedirectToAction(nameof(Index));
            Food food = DAL.Get.foods.ToList().Find(f => f.Id == id);
            if (food == null) return RedirectToAction(nameof(Index));
            return View(food);
        }


        public IActionResult CategoryDetails(int? id)
        {
            if (id == null) return RedirectToAction(nameof(Index));
            FoodCategory category = DAL.Get.foodCategories.Include(c=>c.foods).ToList().Find(f => f.Id == id);
            if (category == null) return RedirectToAction(nameof(Index));
            return View(category);
        }

        public IActionResult AddCategory()
        {
            return View();

        }

        public IActionResult AddFood(int? Id)
        {
            if(Id==null) return RedirectToAction(nameof(Index));
            List<FoodCategory> foodCategories = DAL.Get.foodCategories.Include(c => c.foods).ToList();
            FoodCategory foodCategory = foodCategories.Find(c => c.Id == Id);


            VMAddFood vm = new VMAddFood()
            {

            };

            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddFood(VMAddFood vm)
        {
            DAL.Get.foodCategories.ToList().Find(c => c.Id == vm.CategoryId).AddFood(vm.food);
            return View();

        }

        public IActionResult Edit(int? Id)
        {
            return View();

        }

        public IActionResult Delete(int? Id)
        {
            return View();

        }
    }


}
