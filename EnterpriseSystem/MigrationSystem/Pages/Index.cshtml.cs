using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UserDomain.Contexts;

namespace MigrationSystem.Pages
{
    public class IndexModel : PageModel
    {
        private readonly UserDbContext UserDbContext;
        public IndexModel(UserDbContext userDbContext)
        {
            UserDbContext = userDbContext;
        }

        public void OnGet()
        {
            var lstUser = UserDbContext.UserInfos.ToList();
        }
    }
}
