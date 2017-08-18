using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using Bank.WebApplication.ViewModels;

namespace Bank.WebApplication.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index(int bancoId, string nombreBanco)
        {
            IndexOrderVM viewModel = new IndexOrderVM();
            using (var sv = new ServiceBank.BankServiceSoapClient())
            {
                var lstModelService = sv.GetAllOrdersByBank(bancoId);
                viewModel.OrderVm = Mapper.Map<List<OrderVM>>(lstModelService);
                viewModel.BankId = bancoId;
                viewModel.BankName = nombreBanco;
            }

            return View(viewModel);
        }

        // GET: Order/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Order/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Order/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Order/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Order/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Order/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Order/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
