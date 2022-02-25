using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI.WebControls;
using ExpressoApi.Data;
using ExpressoApi.Models;

namespace ExpressoApi.Controllers
{
    public class MenusController : ApiController
    {
        private ExpressoDbContext expressoDbContext = new ExpressoDbContext();

        public IHttpActionResult getMenus()
        {
            var menus = expressoDbContext.Menus.Include("SubMenus");
            return Ok(menus);
        }

        public IHttpActionResult GetMenu(Int16 id)
        {
            var menu = expressoDbContext.Menus.Include("SubMenus").FirstOrDefault(q => q.Id == id);
            if (menu == null)
            {
                return NotFound();
            }

            return Ok(menu);
        }
    }
}
