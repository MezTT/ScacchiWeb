using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Scacchi {
    
    public class ChessModel : PageModel {

        readonly ILogger<ChessModel> _logger;

        public ChessModel(ILogger<ChessModel> logger) {
            _logger = logger;
        }

        public void OnGet() {

        }

        public IActionResult OnGetLogin([FromBody] object args) {
            try{

                return new JsonResult(true);

            }
            catch {
                return BadRequest();
            }
        }

    }

}