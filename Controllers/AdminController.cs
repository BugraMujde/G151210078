using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace G151210078.Controllers
{
    public class AdminController : Controller
    {

        private UserManager<IdentityUser> userManager;

        public AdminController( UserManager<IdentityUser> usrMgr)
        {
            userManager = usrMgr;
        }

        public ViewResult Index() => View();

        public ViewResult Users() => View(userManager.Users);

        private void Errors(IdentityResult result)
        {
            throw new NotImplementedException();
        }
    }
}
