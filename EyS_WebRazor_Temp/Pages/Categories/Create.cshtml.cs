using EyS_WebRazor_Temp.Data;
using EyS_WebRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EyS_WebRazor_Temp.Pages.Categories
{
		[BindProperties]
    public class CreateModel : PageModel
    {
		private readonly ApplicationDbContext _db;
        public Category Category { get; set; }
        public CreateModel (ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            _db.Categories.Add(Category);
            _db.SaveChanges();
            TempData["Success"] = "Category created successfully";
            return RedirectToPage("Index");
        }
    }
}
