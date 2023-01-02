using BugerEats.PageObjects.Cadastro;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace BugerEats.Steps.Cadastro
{
    public class CadastroSteps : Hooks
    {
        public static void ClickConfirmarCadastro()
        {
            Driver.FindElement(CadastroPage.FinalizaCadastro).Click();
        }

        public static void ClickBuscaCep()
        {
            Driver.FindElement(CadastroPage.BtnBuscarCep).Click();
        }

        public static void ClickRetornaHome()
        {
            Driver.FindElement(CadastroPage.BtnRetornaHome).Click();
        }

        public static void SetPreencherCep(string cep)
        {
            Driver.FindElement(CadastroPage.Cep).SendKeys(cep.ToString());
        }

        public static void FinalizaCadastroEntrega()
        {
            Driver.FindElement(CadastroPage.FinalizaCadastro).Click();
        }

        public static void CheckCamposObrigatorios()
        {
            Assert.IsTrue(Driver.FindElement(CadastroPage.ObrigatorioNome).Displayed);
            Assert.IsTrue(Driver.FindElement(CadastroPage.ObrigatporioCpf).Displayed);
            Assert.IsTrue(Driver.FindElement(CadastroPage.ObrigatórioEmail).Displayed);
            Assert.IsTrue(Driver.FindElement(CadastroPage.ObrigatorioCep).Displayed);
            Assert.IsTrue(Driver.FindElement(CadastroPage.ObrigatorioNumero).Displayed);
            Assert.IsTrue(Driver.FindElement(CadastroPage.ObrigatorioMetodoEntrega).Displayed);
            Assert.IsTrue(Driver.FindElement(CadastroPage.ObrigatorioUpload).Displayed);
        }

        public static void CheckBuscaCep(string logradouro, string bairro, string cidade)
        {
            Assert.IsTrue(Driver.FindElement(CadastroPage.Logradouro).Displayed, logradouro);
            Assert.IsTrue(Driver.FindElement(CadastroPage.Bairro).Displayed, bairro);
            Assert.IsTrue(Driver.FindElement(CadastroPage.Cidade).Displayed, cidade);
        }

        public static void CheckCadastro()
        {
            Assert.IsTrue(Driver.FindElement(CadastroPage.ImgSucesso).Displayed);
            Assert.IsTrue(Driver.FindElement(CadastroPage.Titulo).Displayed);
            Assert.IsTrue(Driver.FindElement(CadastroPage.Conteudo).Displayed);
        }

        public static void CheckCpfInvalido()
        {
            Assert.IsTrue(Driver.FindElement(CadastroPage.CpfInvalido).Displayed);
        }

        public static void CheckCepInvalido()
        {
            Assert.IsTrue(Driver.FindElement(CadastroPage.CepInvalido).Displayed);
        }

        public static void CheckWhatsAppInvalido()
        {
            Assert.IsTrue(Driver.FindElement(CadastroPage.WhatsAppInvalido).Displayed);
        }

        #region Preencher Formulário

        public static void PreencheDados(string nome, string cpf, string email, string whatsapp)
        {
            Driver.FindElement(CadastroPage.NomeCompleto).SendKeys(nome);
            Driver.FindElement(CadastroPage.Cpf).SendKeys(cpf);
            Driver.FindElement(CadastroPage.Email).SendKeys(email);
            Driver.FindElement(CadastroPage.WhatsApp).SendKeys(whatsapp);
        }

        public static void PreencheEndereco(string cep, string numero, string complemento)
        {
            Driver.FindElement(CadastroPage.Cep).SendKeys(cep);
            ClickBuscaCep();
            Driver.FindElement(CadastroPage.Numero).SendKeys(numero);
            Driver.FindElement(CadastroPage.Complemento).SendKeys(complemento);
        }

        public static void PreencheMetodoEntrega()
        {
            Driver.FindElement(CadastroPage.Moto).Click();

            string caminho = "C:\\BugerEats\\BugerEats\\BugerEats\\Deploy\\Moto.png";

            bool arquivoExiste = File.Exists(caminho);
            if (arquivoExiste == true)
            {
                Driver.FindElement(CadastroPage.Upload).SendKeys(caminho);
            }
            else
            {
                Console.WriteLine("Arquivo Inexistente");
                Assert.Fail();
            }
        }

        #endregion
    }
}