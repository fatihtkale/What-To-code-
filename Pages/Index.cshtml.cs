using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspnetcoreapp.Pages
{
    public class IndexModel : PageModel
    {
        [HttpPost]
        public async Task<IActionResult> OnPostAsync()
        {
            // Just here to refresh page :p
            return null;
        }
    }
}
