using OpenQA.Selenium;

namespace BugerEats.PageObjects.Cadastro
{
    public class CadastroPage
    {

        #region Botões

        public static By BtnCadastrese = By.XPath("//*[@id=\"page-home\"]/div/main/a");
        public static By BtnBuscarCep = By.XPath("//*[@id=\"page-deliver\"]/form/fieldset[2]/div[1]/div[2]/input");
        public static By BtnRetornaHome = By.CssSelector("#page-deliver > header > a");
        public static By BtnFechar = By.XPath("/html/body/div[5]/div/div[6]/button[1]");
        public static By FinalizaCadastro = By.CssSelector("button[class=\"button-success\"]");

        #endregion

        #region Mensagem de Erro

        public static By ObrigatorioNome = By.XPath("//*[@id=\"page-deliver\"]/form/fieldset[1]/div[1]/div[1]/span");
        public static By ObrigatporioCpf = By.XPath("//*[@id=\"page-deliver\"]/form/fieldset[1]/div[1]/div[2]/span");
        public static By ObrigatórioEmail = By.XPath("//*[@id=\"page-deliver\"]/form/fieldset[1]/div[2]/div[1]/span");
        public static By ObrigatorioCep = By.XPath("//*[@id=\"page-deliver\"]/form/fieldset[2]/div[1]/div[1]/span");
        public static By ObrigatorioNumero = By.XPath("//*[@id=\"page-deliver\"]/form/fieldset[2]/div[3]/div[1]/span");
        public static By ObrigatorioMetodoEntrega = By.XPath("//*[@id=\"page-deliver\"]/form/fieldset[3]/span");
        public static By ObrigatorioUpload = By.XPath("//*[@id=\"page-deliver\"]/form/span");
        public static By CpfInvalido = By.CssSelector("#page-deliver > form > fieldset:nth-child(2) > div:nth-child(2) > div:nth-child(2) > span");
        public static By CepInvalido = By.XPath("//*[@id=\"page-deliver\"]/form/fieldset[2]/div[1]/div[1]/span");
        public static By WhatsAppInvalido = By.XPath("//*[@id=\"page-deliver\"]/form/fieldset[1]/div[2]/div[2]/span");

        #endregion

        #region Mensagem de Sucesso

        public static By ImgSucesso = By.XPath("/html/body/div[5]/div/div[1]/div[2]");
        public static By Titulo = By.XPath("//*[@id=\"swal2-title\"]");
        public static By Conteudo = By.XPath("//*[@id=\"swal2-html-container\"]");

        #endregion

        #region Mapeando Campos do Formulário

        public static By NomeCompleto = By.XPath("//*[@id=\"page-deliver\"]/form/fieldset[1]/div[1]/div[1]/input");
        public static By Cpf = By.XPath("//*[@id=\"page-deliver\"]/form/fieldset[1]/div[1]/div[2]/input");
        public static By Email = By.XPath("//*[@id=\"page-deliver\"]/form/fieldset[1]/div[2]/div[1]/input");
        public static By WhatsApp = By.XPath("//*[@id=\"page-deliver\"]/form/fieldset[1]/div[2]/div[2]/input");
        public static By Cep = By.XPath("//*[@id=\"page-deliver\"]/form/fieldset[2]/div[1]/div[1]/input");
        public static By Logradouro = By.XPath("//*[@id=\"page-deliver\"]/form/fieldset[2]/div[2]/input");
        public static By Numero = By.XPath("//*[@id=\"page-deliver\"]/form/fieldset[2]/div[3]/div[1]/input");
        public static By Complemento = By.XPath("//*[@id=\"page-deliver\"]/form/fieldset[2]/div[3]/div[2]/input");
        public static By Bairro = By.XPath("//*[@id=\"page-deliver\"]/form/fieldset[2]/div[4]/div[1]/input");
        public static By Cidade = By.XPath("//*[@id=\"page-deliver\"]/form/fieldset[2]/div[4]/div[2]/input");
        public static By Moto = By.XPath("//*[@id=\"page-deliver\"]/form/fieldset[3]/ul/li[1]/img");
        public static By Bicicleta = By.XPath("//*[@id=\"page-deliver\"]/form/fieldset[3]/ul/li[2]/img");
        public static By Carro = By.XPath("//*[@id=\"page-deliver\"]/form/fieldset[3]/ul/li[3]/img");
        public static By Upload = By.XPath("//*[@id=\"page-deliver\"]/form/div/input");

        #endregion
    }
}
