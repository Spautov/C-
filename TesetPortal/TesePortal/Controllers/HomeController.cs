using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TesePortal.Models;
using TesePortal.Models.Request;

namespace TesePortal.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {

        private ApplicationUserManager UserManager
        {
            get
            {
                return HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
        }

        private ApplicationRoleManager RoleManager
        {
            get
            {
                return HttpContext.GetOwinContext().GetUserManager<ApplicationRoleManager>();
            }
        }

        DemandContext db = new DemandContext();
       
        public async Task<ActionResult> Index()
        {
            ControllerContext CtrlCntx = this.ControllerContext;
            
            var userName = CtrlCntx.HttpContext.User.Identity.Name;
            var ident = await UserManager.FindByNameAsync(userName);
           

            var roles = await UserManager.GetRolesAsync(ident.Id);
            foreach (var rol in roles)
            {
                if (rol == "Operator")
                {
                    return View(db.WorkItems);
                }
                else if (rol == "Tehnik")
                {
                    ViewBag.Users = UserManager.Users;
                    ViewBag.WorkItems = db.WorkItems;
                    ViewBag.WorkItemNodes = db.WorkItemNodes;


                    return View("Tehnik", db.Requests);
                }
            }
            
            return View(db.WorkItems);
        }




        public ActionResult Operator(int Id)
        {
            
            WorkItem workItem = null;
            foreach (var wri in db.WorkItems)
            {
                if (wri.Id == Id)
                {
                   
                    workItem = wri;
                    
                    break;
                }
            }
            if (workItem != null)
            {
                ViewBag.WorkItem = workItem;
            }
            
            return View();

        }

        [HttpPost]
        public async Task<ActionResult> Operator(Demand model, string Id)
        {
            ControllerContext CtrlCntx = this.ControllerContext;
            var userName = CtrlCntx.HttpContext.User.Identity.Name;
            var ident = await UserManager.FindByNameAsync(userName);
             // IdentityUser user = new IdentityUser { UserName = model.UserName, PhoneNumber = model.PhoneNumber };
             Demand request = new Demand()
            {
                OperatorId = ident.Id,
                WorkItemId = int.Parse(Id),
                WorkItemNodeId = model.WorkItemNodeId,
                CreationDate = DateTime.Now,
                CommentOfOperator = model.CommentOfOperator,
                IsCritical = model.IsCritical,
                Status = 0
            };
            var result = db.Requests.Add(request);
            db.SaveChanges();

            //IdentityResult result = await UserManager.CreateAsync(user, model.Password);

            if (result != null)
            {

                return View("Success");
            }
            return View("Crash");
        }

    }

}