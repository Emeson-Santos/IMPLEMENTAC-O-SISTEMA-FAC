using System.Web.Mvc;
using Model.Models;
using Negocio.Business;

namespace SistemasFAC.Controllers
{
    public class ServicoController : Controller
    {
        private GerenciadorServico gerenciador;

        public ServicoController()
        {
            gerenciador = new GerenciadorServico();
        }

        public ActionResult Index()
        {
            return View(gerenciador.ObterTodos());
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Servico servico)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    gerenciador.Adicionar(servico);
                    return RedirectToAction("Index");
                }
            }
            catch
            {

            }
            return View();
        }

        // GET: Editora/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id.HasValue)
            {
                Servico servico = gerenciador.Obter(id);
                if (servico != null)
                {
                    return View(servico);
                }

            }
            return RedirectToAction("Index");
        }

        // POST: Editora/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Servico servico)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    gerenciador.Editar(servico);
                }
                return RedirectToAction("Index");
            }
            catch
            {

            }
            return RedirectToAction("Index");
        }

        // GET: Editora/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id.HasValue)
            {
                Servico servico = gerenciador.Obter(id);
                if (servico != null)
                {
                    return View();
                }


            }
            return RedirectToAction("Index");
        }

        // POST: Editora/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Servico servico)
        {
            try
            {
                gerenciador.Remover(servico);

                return RedirectToAction("Index");
            }
            catch
            {

            }
            return RedirectToAction("Index");
        }
    }
}
