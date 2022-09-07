using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppDETAug2022.Pages
{
    public class hellowebModel : PageModel
    {
        public string Message { get; set; } 
        public int Discount { get; set; }
        //HTTPGET
        public void OnGet()
        {
            Message = "ASP.NetCore isRocking!!";
            Discount = 15;
        }
    }
}
