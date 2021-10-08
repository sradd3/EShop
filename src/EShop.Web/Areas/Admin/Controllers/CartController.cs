﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EShop.Services.Contracts;

namespace EShop.Web.Areas.Admin.Controllers
{
    [Area(AreaConstants.AdminArea)]
    public class CartController : BaseController
    {
        private readonly ICartService _cartService;
        private readonly ICartDetailService _cartDetailService;

        public CartController(ICartService cartDetailService, ICartDetailService cartDetailService1)
        {
            _cartService = cartDetailService;
            _cartDetailService = cartDetailService1;
        }

        public async Task<IActionResult> Index()
        {
            var model = await _cartService.GetUserCartsForAdmin();
            return View(model);
        }

        public async Task<IActionResult> ShowCartDetails(int id)
        {
            var cartDetails = await _cartDetailService.GetCartDetailsForAdmin(id);
            return View(cartDetails);
        }
    }
}
