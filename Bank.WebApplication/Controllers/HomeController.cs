using System;
using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using Bank.WebApplication.ViewModels;

namespace Bank.WebApplication.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<BankVM> viewModel;
            using (var sv = new ServiceBank.BankServiceSoapClient())
            {
                var lstModelService = sv.GetAllBanks();
                viewModel = Mapper.Map<List<BankVM>>(lstModelService);
            }

            return View(viewModel);
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(BankVM viewModel)
        {
            try
            {
                var serviceModel = Mapper.Map<ServiceBank.BankBE>(viewModel);
                using (var sv = new ServiceBank.BankServiceSoapClient())
                {
                    var result = sv.InsertBank(serviceModel);
                }

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int idBanco)
        {
            BankVM viewModel;
            using (var sv = new ServiceBank.BankServiceSoapClient())
            {
                var modelService = sv.GetBank(idBanco);
                viewModel = Mapper.Map<BankVM>(modelService);
            }
            return View(viewModel);
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(BankVM viewModel)
        {
            try
            {
                var serviceModel = Mapper.Map<ServiceBank.BankBE>(viewModel);
                using (var sv = new ServiceBank.BankServiceSoapClient())
                {
                    var result = sv.UpdateBank(serviceModel);
                }

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int idBanco)
        {
            BankVM viewModel;
            using (var sv = new ServiceBank.BankServiceSoapClient())
            {
                var modelService = sv.GetBank(idBanco);
                viewModel = Mapper.Map<BankVM>(modelService);
            }
            return View(viewModel);
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(BankVM viewModel)
        {
            try
            {
                var serviceModel = Mapper.Map<ServiceBank.BankBE>(viewModel);
                using (var sv = new ServiceBank.BankServiceSoapClient())
                {
                    var result = sv.DeleteBank(serviceModel.IdBanco);
                }

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }
    }
}
