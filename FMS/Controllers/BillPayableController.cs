﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FMS.Core;
using AutoMapper;
using FMS.Core.Abstract;
using FMS.Models.BillPayable;
using FMS.Core.Model;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FMS.Controllers
{
    public class BillPayableController : Controller
    {
        //private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public BillPayableController( IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult CreateBill()
        {
            //ViewBag["billNumber"] = TempData["billNumber"] ?? null;

            var viewModel = new CreatePayableView();

            viewModel.TransactionDate = DateTime.Now.ToString("dd/MM/yyyy");

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult SaveBill(CreatePayableView viewModel)
        {

            var payable = new BillPayable()
                {
                    Id = viewModel.Id,
                    PayerId = viewModel.PayerId,
                    Description = viewModel.Description,
                    Organisation = viewModel.Organisation,
                    Economic = viewModel.Economic,
                    GeoCode = viewModel.GeoCode,
                    Fund = viewModel.Fund,
                    Function = viewModel.Function,
                    Quantity = viewModel.Quantity,
                    Rate = viewModel.Rate,
                    Amount = viewModel.Amount,
                    TransactionDate = viewModel.TransactionDate
                };

            Random random = new Random();
            int randomNumber = random.Next(0, 10000);

            payable.BillNumber = Convert.ToString(randomNumber);

            _unitOfWork.BillPayablesRepository.Insert(payable);
            _unitOfWork.SaveChanges();

            TempData["billNumber"] = randomNumber;

            return RedirectToAction("CreateBill");
        }

        public IActionResult ReviewBill()
        {
            return View();
        }

        public IActionResult ApproveBill()
        {
            return View();
        }

        public IActionResult FinalizeBill()
        {
            return View();
        }
    }
}
