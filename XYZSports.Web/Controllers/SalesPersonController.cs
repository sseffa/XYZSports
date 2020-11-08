﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using XYZSports.Core;
using XYZSports.DAL;
using XYZSports.Web.ViewModels;

namespace XYZSports.Web.Controllers
{
    public class SalesPersonController : Controller
    {
        ISalesPersonService _salesPersonService;
        ISalesPersonRepository _salesPersonRepo;
        public SalesPersonController(ISalesPersonService salesPersonServiceService, ISalesPersonRepository salesPersonRepo)
        {
            _salesPersonService = salesPersonServiceService;
            _salesPersonRepo = salesPersonRepo;
        }

        public async Task<ActionResult> Index()
        {
            var salesPeople = await _salesPersonRepo.GetWithOrders();
            return View(salesPeople);
        }

        public async Task<ActionResult> Edit(int Id)
        {
            var person = await _salesPersonRepo.GetByID(Id);

            return View(new EditSalespersonViewModel(person));
        }

        [HttpPost]
        public async Task<ActionResult> Edit(EditSalespersonViewModel vm)
        {
            await _salesPersonService.UpdateSalesPersonContact(vm.GetPerson());

            return Redirect("/SalesPerson/Index");
        }

    }
}