using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using KonkorApi.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace KonkorApi.Repository
{
    public class AuthRepository : IDisposable
    {
        private AuthContext _ctx;

        private UserManager<IdentityUser> _newUserManager;

        private UserManager<IdentityUser> _userManager;

        public AuthRepository()
        {
            _ctx = new AuthContext();
            _userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(_ctx));
            _newUserManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(_ctx));
        }

        public async Task<IdentityResult> RegisterUser(UserModel userModel)
        {
            IdentityUser user = new IdentityUser
            {
                UserName = userModel.UserName
            };

            var result = await _userManager.CreateAsync(user, userModel.Password);

            return result;
        }

        public async Task<IdentityResult> AddUser(UserModel userModel)
        {
            IdentityResult result;
            IdentityUser user = new IdentityUser
            {
                UserName = userModel.UserName
            };

            var identityUser = await _userManager.FindByNameAsync(user.UserName);
            if (identityUser == null)
            {
                result = await _userManager.CreateAsync(user, userModel.Password);
            }
            else
            {
                result = await _userManager.RemovePasswordAsync(identityUser.Id);
                result = await _userManager.AddPasswordAsync(identityUser.Id, userModel.Password);
            }

            return result;
        }

        public async Task<IdentityUser> FindUser(string userName, string password)
        {
            IdentityUser user = await _newUserManager.FindAsync(userName, password);

            return user;
        }

        public void Dispose()
        {
            _ctx.Dispose();
            _userManager.Dispose();
        }
    }
}