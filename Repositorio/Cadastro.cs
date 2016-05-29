using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositorio
{
    public class Cadastro
    {
        public bool CadastrarTelefone(string Nome, string Cpf, string Ddd, string Numero, string Tipo)
        {
            try
            {
                var repoPessoa = new GenericRepository<Pessoa>();                

                var pessoa = new Pessoa();
                pessoa.Nome = Nome;
                pessoa.CPF = Cpf.Replace(".", "").Replace("-", "");
                pessoa.Telefone.Add(new Telefone
                {
                    Tipo = Tipo,
                    Ddd = Ddd.Replace("(", "").Replace(")", ""),
                    Numero = Numero.Replace("-", ""),
                    Data = DateTime.Now,
                });

                repoPessoa.Add(pessoa);
                repoPessoa.Save();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Telefone> ListarTelefones()
        {
            var repoTel = new GenericRepository<Telefone>();

            return repoTel.GetAll().ToList();
        }

        public List<Telefone> BuscarTelefonesPorNome(string nome)
        {
            var repoTel = new GenericRepository<Telefone>();

            return repoTel.FindBy(x=>x.Pessoa.Nome == nome).ToList();
        }
    }   

    
}
