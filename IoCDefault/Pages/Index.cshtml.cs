using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IoCDefault.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IoCDefault.Pages
{
    public class IndexModel : PageModel
    {

        public IndexModel(IEmailService emailService)
        {
        }

        public void OnGet()
        {
        }
    }
}
