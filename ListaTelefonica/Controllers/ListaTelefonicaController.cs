using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ListaTelefonica.Models;

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
            // Feito segundo
            CadastrarTelefone(Nome, Cpf, Ddd, Numero, Tipo);

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


        private void CadastrarTelefone(string Nome, string Cpf, string Ddd, string Numero, string Tipo)
        {
            using (var context = new ListaTelefonicaEntities())
            {
                var cpf = Cpf.Replace(".", "").Replace("-", "");
                var pessoa = context.Pessoa.FirstOrDefault(x => x.CPF == cpf);

                var telefone = new Telefone();
                telefone.Tipo = Tipo;
                telefone.Ddd = Ddd.Replace("(", "").Replace(")", "");
                telefone.Numero = Numero.Replace("-", "");
                telefone.Data = DateTime.Now;

                if (pessoa == null)
                {
                    pessoa = new Pessoa();
                    pessoa.Nome = Nome;
                    pessoa.CPF = cpf;
                    pessoa.Telefone.Add(telefone);

                    context.Pessoa.Add(pessoa);
                }
                else
                {
                    pessoa.Telefone.Add(telefone);
                    context.Pessoa.Attach(pessoa);
                }

                context.SaveChanges();
            }

        }
    }
}