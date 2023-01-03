using BugerEats.PageObjects.Cadastro;
using BugerEats.Steps;
using BugerEats.Steps.Cadastro;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BugerEats.Feature.Cadastro
{
    [TestClass]
    public class CadastroFeature : Hooks
    {
        [TestMethod]
        public void RetornarHomeTest()
        {
            Console.WriteLine("Dado: Acesse a tela de '/Cadastro' para fazer Entregas");
            Console.WriteLine("Quando: Clicar no boão [Voltar para home]");
            Console.WriteLine("Então: O sistema deverá direcionar usuário a '/Home'");

            HomeSteps.ClickCadastro();
            CadastroSteps.ClickRetornaHome();
            HomeSteps.CheckElementosHome();
        }

        [TestMethod]
        public void CampoObrigatorioTest()
        {
            Console.WriteLine("Dado: Acesse a tela de '/Cadastro para fazer Entregas'");
            Console.WriteLine("E: Manter os campos obrigatórios em branco");
            Console.WriteLine("Quando: clicar no botão [Cadastre-se para fazer entregas]");
            Console.WriteLine("Então: O sistema deverá informar mensagem abaixo dos campos obrigatórios");

            HomeSteps.ClickCadastro();
            CadastroSteps.ClickConfirmarCadastro();
            CadastroSteps.CheckCamposObrigatorios();
        }

        [TestMethod]
        public void CpfInvalidoTest()
        {
            Console.WriteLine("Dado: Que o usuário deseja cadastrar para fazer entregas");
            Console.WriteLine("Quando: Preencher formulário com um CPF inválido");
            Console.WriteLine("E: Clicar em [Cadastre-se para fazer entregas]");
            Console.WriteLine("Então: O sistema deverá validar os dados do usuário e exibir mensagem de erro abaixo do campo @CPF");

            HomeSteps.ClickCadastro();
            CadastroSteps.SetPreecherCpf();
            CadastroSteps.ClickFinalizaCadastroEntrega();
            CadastroSteps.CheckCpfInvalido();
        }

        [TestMethod]
        public void WhatsAppInvalidoTest()
        {
            Console.WriteLine("Dado: Que o usuário deseja cadastrar para fazer entregas");
            Console.WriteLine("Quando: Preencher formulário com o número do WhatsApp inválido");
            Console.WriteLine("E: Clicar em [Cadastre-se para fazer entregas]");
            Console.WriteLine("Então: O sistema deve validar as informações e exibir mensagem de erro abaixo do campo @WhatsApp");

            HomeSteps.ClickCadastro();
            CadastroSteps.PreencheDados();
            CadastroSteps.ClickFinalizaCadastroEntrega();
            CadastroSteps.CheckWhatsAppInvalido();
        }

        [TestMethod]
        public void CepInvalidoTest()
        {
            Console.WriteLine("Dado: Que o usuário deseja cadastrar para fazer entregas");
            Console.WriteLine("Quando: Preencher fomrulário com CEP inválido");
            Console.WriteLine("E: Clicar em [Buscar CEP]");
            Console.WriteLine("Então: O sistema deverá validar o CEP e exibir mensagem de erro abaixo do campo @CEP");

            HomeSteps.ClickCadastro();
            CadastroSteps.SetPreencherCep("123");
            CadastroSteps.ClickBuscaCep();
            CadastroSteps.CheckCepInvalido();
        }

        [TestMethod]
        public void BuscaCepTestTest()
        {
            Console.WriteLine("Dado: Acesse a tela de '/Cadastro para fazer Entregas'");
            Console.WriteLine("Quando: Informar um CEP válido");
            Console.WriteLine("Então: O sistema informará ao usuário os dados da Busca, preenchendo os campos @Logradouro, @Bairro, @Cidade");
            
            HomeSteps.ClickCadastro();
            CadastroSteps.SetPreencherCep("17402374");
            CadastroSteps.ClickBuscaCep();
            CadastroSteps.CheckBuscaCep("Rua da Aroeira", "Jardim Paineiras", "Garça/SP");
        }

        [TestMethod]
        public void CastreParaFazerEntregaTest()
        {
            Console.WriteLine("Dado: Que o usuário deseja cadastrar para fazer entregas");
            Console.WriteLine("Quando: Preencher formulário com dados válidos");
            Console.WriteLine("E: Clicar em [Cadastre-se para fazer entregas]");
            Console.WriteLine("Então: O sistema deverá validar os dados do usuário e exibir mensagem de sucesso");
            Console.WriteLine("E: E o sistema deve redirecionar a '/Home'");

            HomeSteps.ClickCadastro();
            CadastroSteps.PreencheDados();
            CadastroSteps.PreencheEndereco("17402374", "340", "Teste Complemento");
            CadastroSteps.PreencheMetodoEntrega();
            CadastroSteps.ClickFinalizaCadastroEntrega();
         }
    }
}
