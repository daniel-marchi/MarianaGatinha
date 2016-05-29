using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Repositorio.Testes
{
    [TestClass]
    public class CadastroTestes
    {
        [TestMethod]
        public void CadastrarTelefoneComPessoaInexistente()
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
        public void CadastrarTelefoneComPessoaExistente()
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
    }
}
