using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AppUserController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [HttpPost]
        [Route("Register")]
        public async Task<object> CreateAppUser(AppUserModel appUserModel)
        {
            var appUser = new AppUser()
            {
                UserName = appUserModel.UserName,
                Email = appUserModel.Email,
                FullName = appUserModel.FullName
            };

            try
            {
                var result = await _userManager.CreateAsync(appUser, appUserModel.Password);
                return Ok(result);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
