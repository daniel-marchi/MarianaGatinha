using System;
using System.Linq;

namespace Repositorio
{
    public class Cadastro
    {
        public bool CadastrarTelefone(string Nome, string Cpf, string Ddd, string Numero, string Tipo)
        {
            try
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

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        //Olá Amiguinho
    }
}
