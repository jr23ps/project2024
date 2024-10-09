using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace project.Pages
{
    public class Tyrannosaurus_rexModel : PageModel
    {
        public string question1 { get; set; }
        public string question2 { get; set; }
        public string question3 { get; set; }
        public void OnGet()
        {
        }
    }
}
