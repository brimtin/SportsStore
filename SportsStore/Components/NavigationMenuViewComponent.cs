using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Component
{
    public class NavigationMenuViewComponent: ViewComponent
    {
        public string Invoke()
        {
            return "Hello from the nav view Component";
        }
    }
}
