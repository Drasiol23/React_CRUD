using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyStore.Pages.Clients
{
    public class DeleteModel : PageModel
    {
        public String deletedMessage = "";

        public void OnGet()
        {
            deletedMessage = "Deleted Successfully";
        }

        public void OnPost()
        {
            deletedMessage = "Deleted Successfully";

        }
    }
}
