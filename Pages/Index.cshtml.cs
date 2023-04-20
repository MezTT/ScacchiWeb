using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Scacchi;

namespace Scacchi.Pages
{
    public class IndexModel : PageModel
    {
        protected UserData? CurrentUser {
            get {
                object? r;
                HttpContext.Items.TryGetValue(nameof(CurrentUser), out r);
                return (UserData?)r ?? null;
            }
            set {
                HttpContext.Items.Add(nameof(CurrentUser), value);
            }
        } 

        protected bool LoggedIn {
            get {
                return HttpContext.Items.ContainsKey(nameof(CurrentUser));
            }
        }

        private readonly ILogger<IndexModel> _logger;


        public IndexModel(ILogger<IndexModel> logger) {
            _logger = logger;
        }

        public void OnGet() {

        }

        public void OnGetLogout() {

            if (HttpContext.Items.ContainsKey(nameof(CurrentUser)))
                HttpContext.Items.Remove(nameof(CurrentUser));

        }

        public void OnPostLogin([FromBody] object args) {

        }
    }
}