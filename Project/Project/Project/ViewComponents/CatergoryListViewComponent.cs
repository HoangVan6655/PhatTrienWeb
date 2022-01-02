using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectPhatTrienWeb.ViewComponents
{
    public class CatergoryListViewComponent : ViewComponent
    {
        private readonly DataBasePhatTrienWebContext _context;

        public CatergoryListViewComponent(DataBasePhatTrienWebContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Catergory> catList = await _context.Catergories.ToListAsync();
            return View(catList);
        }
    }
}
