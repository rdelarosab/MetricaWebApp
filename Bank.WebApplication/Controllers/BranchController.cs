using System;
using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using Bank.WebApplication.ViewModels;

namespace Bank.WebApplication.Controllers
{
    public class BranchController : Controller
    {
        // GET: Branch
        public ActionResult Index(int idBanco, string nombreBanco)
        {
            IndexBranchVM viewModel = new IndexBranchVM();
            using (var sv = new ServiceBank.BankServiceSoapClient())
            {
                var lstModelService = sv.GetAllBranchs(idBanco);
                viewModel.BranchVm = Mapper.Map<List<BranchVM>>(lstModelService);
                viewModel.BankId = idBanco;
                viewModel.BankName = nombreBanco;
            }

            return View(viewModel);
        }

        // GET: Home/Create
        public ActionResult Create(int idBanco)
        {
            var viewModel = new BranchVM();
            viewModel.IdBanco = idBanco;
            return View(viewModel);
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(BranchVM viewModel)
        {
            try
            {
                var serviceModel = Mapper.Map<ServiceBank.BranchBE>(viewModel);
                using (var sv = new ServiceBank.BankServiceSoapClient())
                {
                    var result = sv.InsertBranch(serviceModel);
                }

                return RedirectToAction("Index", new {idBanco = viewModel.IdBanco});
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int idSucursal)
        {
            BranchVM viewModel;
            using (var sv = new ServiceBank.BankServiceSoapClient())
            {
                var modelService = sv.GetBranch(idSucursal);
                viewModel = Mapper.Map<BranchVM>(modelService);
            }
            return View(viewModel);
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(BranchVM viewModel)
        {
            try
            {
                var serviceModel = Mapper.Map<ServiceBank.BranchBE>(viewModel);
                using (var sv = new ServiceBank.BankServiceSoapClient())
                {
                    var result = sv.UpdateBranch(serviceModel);
                }

                return RedirectToAction("Index", new { idBanco = viewModel.IdBanco });
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int idSucursal)
        {
            BranchVM viewModel;
            using (var sv = new ServiceBank.BankServiceSoapClient())
            {
                var modelService = sv.GetBranch(idSucursal);
                viewModel = Mapper.Map<BranchVM>(modelService);
            }
            return View(viewModel);
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(BranchVM viewModel)
        {
            try
            {
                var serviceModel = Mapper.Map<ServiceBank.BranchBE>(viewModel);
                using (var sv = new ServiceBank.BankServiceSoapClient())
                {
                    var result = sv.DeleteBranch(serviceModel.IdSucursal);
                }

                return RedirectToAction("Index", new { idBanco = viewModel.IdBanco });
            }
            catch (Exception ex)
            {
                return View();
            }
        }
    }
}
