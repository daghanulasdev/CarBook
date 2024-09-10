using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.TestimonialViewComponents
{
    public class _TestimonialComponentPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
