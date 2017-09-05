using System.Web.Mvc;
using Model.Models;
using Negocio.Business;
using System.Collections.Generic;


namespace SistemasFAC.Controllers
{
    public class TipoEventoController : Controller
    {

        private GerenciadorTipoEventos gerenciador;
        private TipoEvento servico;

        public TipoEventoController()
        {
            servico = new TipoEvento() { Id = 1 };
            gerenciador = new GerenciadorTipoEventos();
        }

        public ActionResult Index()
        {
           
            List<Servico> servicos = gerenciador.ObterTodos(servico.Id);
            if (servicos==null || servicos.Count==1)
            {
                servicos = null;
            }
            return View(servicos);
        }

        public ActionResult Create()
        {
            ViewBag.ListaDescricao = new SelectList(gerenciador.ObterTodos(), "Descricao");
            return View();
        }
        public ActionResult Details(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(TipoEvento tipoevento)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    gerenciador.Adicionar(tipoevento);
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
                TipoEvento tipoevento = gerenciador.Obter(id);
                if (tipoevento != null)
                {
                    return View(tipoevento);
                }

            }
            return RedirectToAction("Index");


        }

        // POST: Editora/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, TipoEvento tipoevento)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    gerenciador.Editar(tipoevento);
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
                TipoEvento tipoevento = gerenciador.Obter(id);
                if (tipoevento != null)
                {
                    return View();
                }


            }
            return View();
        }

        // POST: Editora/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, TipoEvento tipoevento)
        {
            try
            {
                gerenciador.Remover(tipoevento);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

    }
}