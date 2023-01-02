using OpenQA.Selenium;

namespace BugerEats.PageObjects
{
    public class HomePage
    {
        public static By Logo = By.XPath("//*[@id=\"page-home\"]/div/header/img");
        public static By Titulo = By.XPath("//*[@id=\"page-home\"]/div/main/h1");
        public static By SubTitulo = By.XPath("//*[@id=\"page-home\"]/div/main/p");
        public static By BtnCadastro = By.XPath("//*[@id=\"page-home\"]/div/main/a");
    }
}
