using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ListaTelefonica.Models;
using Repositorio;

namespace ListaTelefonica.Controllers
{
    public class ListaTelefonicaController : Controller
    {
        // GET: ListaTelefonica
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(string Nome, string Cpf, string Ddd, string Numero, string Tipo)
        {
            var cadastro = new Cadastro();

            cadastro.CadastrarTelefone(Nome, Cpf, Ddd, Numero, Tipo);
            
            // Feito segundo
            //CadastrarTelefone(Nome, Cpf, Ddd, Numero, Tipo);

            // Feito primeiro
            //    using (var context = new ListaTelefonicaEntities())
            //    {


            //        var pessoa = new Pessoa();
            //    pessoa.Nome = Nome;
            //    pessoa.CPF = Cpf.Replace(".", "").Replace("-", string.Empty);

            //    var telefone = new Telefone();
            //    telefone.Tipo = Tipo;
            //    telefone.Ddd = Ddd.Replace("(", "").Replace(")", "");
            //    telefone.Numero = Numero.Replace("-", "");
            //    telefone.Data = DateTime.Now;

            //    pessoa.Telefone.Add(telefone);

            //    context.Pessoa.Add(pessoa);

            //    context.SaveChanges();
            //}

            return View();
        }


        
    }
}