using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Repositorio.Testes
{
    [TestClass]
    public class CadastroTestes
    {
        [TestMethod]
        public void CadastrarTelefoneComPessoaInexistenteTeste()
        {
            var cadastro = new Cadastro();

            var nome = "Jaspion";
            var cpf = "484.849.453-24";
            var ddd = "54";
            var numero = "969696556";
            var tipo = "Celular";

            var assert = cadastro.CadastrarTelefone(nome, cpf, ddd, numero, tipo);

            Assert.IsTrue(assert);

        }

        [TestMethod]
        public void CadastrarTelefoneComPessoaExistenteTeste()
        {
            var cadastro = new Cadastro();

            var nome = "Jaspion";
            var cpf = "484.849.453-24";
            var ddd = "54";
            var numero = "00000000";
            var tipo = "Celular";

            var assert = cadastro.CadastrarTelefone(nome, cpf, ddd, numero, tipo);

            Assert.IsTrue(assert);

        }

        [TestMethod]
        public void ListarTelefonesTeste()
        {
            var telefones = new Cadastro().ListarTelefones();

            Assert.IsTrue(telefones.Any());
        }

        [TestMethod]
        public void BuscarTelefonesDoJaspionTeste()
        {
            var telefones = new Cadastro().BuscarTelefonesPorNome("Jaspion");

            Assert.IsTrue(telefones.Any());
        }
    }
}
