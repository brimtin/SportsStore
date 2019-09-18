using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using System.Collections.Generic;
using System.Linq;

namespace SportsStore.Component
{
    public class NavigationMenuViewComponent: ViewComponent
    {
        private IProductRepository repository;
        public NavigationMenuViewComponent(IProductRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
           ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(repository.Products
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
