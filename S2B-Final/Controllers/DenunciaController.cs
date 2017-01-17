using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using S2B_Final.Data.Repositories.Interfaces;
using S2B_Final.Data.Repositories.Implementation;
using S2B_Final.Models;
using AutoMapper;

namespace S2B_Final.Controllers
{
    public class DenunciaController : Controller
    {
        private readonly IDenunciaRepository _denunciaRepository;
        public DenunciaController()
        {
            this._denunciaRepository = new DenunciaRepository(new Data.UO.UnitOfWork());
        }

        // GET: Denuncia
        public ActionResult Index()
        {
            var modelo = Mapper.Map<List<DenunciaModel>, List<DenunciaDisplayViewModel>>(_denunciaRepository.GetAll().ToList());
            return View(modelo);
        }

        // GET: Denuncia/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Denuncia/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Denuncia/Create
        [HttpPost]
        public ActionResult Create(DenunciaCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                DenunciaModel aluno = Mapper.Map<DenunciaCreateViewModel, DenunciaModel>(model);
                this._denunciaRepository.Add(aluno);

                List<DenunciaModel> lista = new List<DenunciaModel>();
                lista = _denunciaRepository.GetAll().OrderBy(u => u.ID).ToList();
                var modelo = Mapper.Map<List<DenunciaModel>, List<DenunciaDisplayViewModel>>(lista);

                return View("Index", modelo);

            }
            else
            {
                return View();
            }
        }

        // GET: Denuncia/Edit/5
        public ActionResult Edit(int id)
        {
            var modelo = Mapper.Map<DenunciaModel, DenunciaEditViewModel>(_denunciaRepository.GetById(id));
            return View(modelo);
        }

        // POST: Denuncia/Edit/5
        [HttpPost]
        public ActionResult Edit(DenunciaEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                DenunciaModel aluno = Mapper.Map<DenunciaEditViewModel, DenunciaModel>(model);
                this._denunciaRepository.Update(aluno);

                List<DenunciaModel> lista = new List<DenunciaModel>();
                lista = _denunciaRepository.GetAll().OrderBy(u => u.ID).ToList();
                var modelo = Mapper.Map<List<DenunciaModel>, List<DenunciaDisplayViewModel>>(lista);

                return View("Index", modelo);

            }
            else
            {
                return View();
            }
        }

        // GET: Denuncia/Delete/5
        public ActionResult Delete(int id)
        {
            var modelo = Mapper.Map<DenunciaModel, DenunciaDeleteViewModel>(_denunciaRepository.GetById(id));
            return View(modelo);
        }

        // POST: Denuncia/Delete/5
        [HttpPost]
        public ActionResult Delete(DenunciaDeleteViewModel model)
        {
            if (ModelState.IsValid)
            {
                DenunciaModel aluno = Mapper.Map<DenunciaDeleteViewModel, DenunciaModel>(model);
                this._denunciaRepository.Remove(aluno);

                List<DenunciaModel> lista = new List<DenunciaModel>();
                lista = _denunciaRepository.GetAll().OrderBy(u => u.ID).ToList();
                var modelo = Mapper.Map<List<DenunciaModel>, List<DenunciaDisplayViewModel>>(lista);

                return View("Index", modelo);

            }
            else
            {
                return View();
            }
        }

        public ActionResult Pesquisar(string searchBy, string search)
        {
            List<DenunciaModel> lista = new List<DenunciaModel>();
            switch (searchBy)
            {
                case "Local":
                    lista = _denunciaRepository.PesquisarPorLocal(search.Trim()).ToList();
                    break;
                default:
                    lista = _denunciaRepository.GetAll().OrderBy(u => u.ID).ToList();
                    break;
            }
            var modelo = Mapper.Map<List<DenunciaModel>, List<DenunciaDisplayViewModel>>(lista);
            return PartialView("_List", modelo);
        }
    }
}
