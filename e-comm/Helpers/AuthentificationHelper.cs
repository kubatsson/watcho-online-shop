using e_comm.DB.Domain;
using e_comm.DB.EF;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace e_comm.Helpers
{

    public static class AuthentificationHelper
    {
        private const string loggedUser = "loggedUser";

        public static void setLoggedUser(this HttpContext context, User userAccount, bool saveCookie = false)
        {
            DBcon dbContext = context.RequestServices.GetService<DBcon>();

            string oldToken = context.Request.GetCookieJson<string>(loggedUser);

            if (oldToken != null)
            {
                Token remove = dbContext.Tokens.FirstOrDefault(i => i.Value == oldToken);

                if (remove != null)
                {
                    dbContext.Tokens.Remove(remove);
                    dbContext.SaveChanges();
                }
            }

            if (userAccount != null)
            {
                string token = Guid.NewGuid().ToString();

                dbContext.Tokens.Add(new Token
                {
                    Value = token,
                    UserId = userAccount.Id,
                    Created = DateTime.Now

                });

                dbContext.SaveChanges();
                context.Response.SetCookieJson(loggedUser, token);
            }
        }

        public static User GetLoggedUser(this HttpContext context)
        {
            DBcon dbContext = context.RequestServices.GetService<DBcon>();

            string token = context.Request.GetCookieJson<string>(loggedUser);

            if (token == null)
                return null;

            return dbContext.Tokens
                .Where(x => x.Value == token)
                .Select(s => s.User)
                .SingleOrDefault();
        }

        public static string GetCurrentCookie(this HttpContext context)
        {
            return context.Request.GetCookieJson<string>(loggedUser);
        }
    }
}
