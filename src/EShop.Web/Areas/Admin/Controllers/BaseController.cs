using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EShop.Common.Constants;
using Microsoft.AspNetCore.Authorization;

namespace EShop.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = IdentityRoleNames.Admin)]
    public class BaseController : Controller
    {

    }
}
