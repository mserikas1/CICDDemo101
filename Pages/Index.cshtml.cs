using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CICDDemo101.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            BusinessLogic.CalculatePrice(-1);
        }
    }

    public static class BusinessLogic
    {
        public static int CalculatePrice(int qty)
        {
            if (qty < 0)
            {
                throw new ArgumentOutOfRangeException("qty is less then 0");
            }

            return 0;
        }
    }
}