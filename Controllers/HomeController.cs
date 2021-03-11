using GRM_Task.Models;
using GRM_Task.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace GRM_Task.Controllers
{
    public class HomeController : Controller
    {
        private readonly ItemRepository _itemRepository = new ItemRepository();

        public HomeController(ItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
            var combinations = _itemRepository.GetAllCombinations();
            ViewData["CombinationCount"] = combinations.Count();
        }

        [HttpGet]
        public IActionResult Index()
        {
            var items = _itemRepository.GetAllItems();
            return View(items);
        }

        [HttpGet]
        public ActionResult<List<ItemsCombination>> GetAllCombinations()
        {
            var combinations = _itemRepository.GetAllCombinations();
            ViewData["CombinationCount"] = combinations.Count();
            return combinations;
        }

        [HttpPost]
        public IActionResult Index([FromForm] CompareModel comparedItems)
        {
            var nextCombination = _itemRepository.CompareItems(comparedItems);

            if (nextCombination != null)
            {
                return PartialView("_ItemComparePartial", nextCombination);
            }

            var items = _itemRepository.GetAllItems();
            return View(items);
        }

        [HttpPut]
        public ActionResult<List<Item>> Edit([FromBody] CompareModel comparedItems)
        {
            var nextCombination = _itemRepository.CompareItems(comparedItems);

            return _itemRepository.GetAllItems();
        }

        [HttpGet]
        public ActionResult<CompareModel> GetNextCombination()
        {
            var nextCombination = _itemRepository.GetNextCombination();

            if (nextCombination != null)
            {
                return _itemRepository.GetNextCombination();
            }

            return NoContent();
        }

        [HttpGet]
        public IActionResult ItemsComparePartialView()
        {
            return PartialView("~/Views/Shared/_ItemComparePartial.cshtml", _itemRepository.GetNextCombination() ?? null);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
