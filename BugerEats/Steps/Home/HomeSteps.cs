using BugerEats.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BugerEats.Steps
{
    public class HomeSteps : Hooks
    {
        public static void CheckElementosHome()
        {
            Assert.IsTrue(Driver.FindElement(HomePage.Logo).Displayed);
            Assert.IsTrue(Driver.FindElement(HomePage.Titulo).Displayed);
            Assert.IsTrue(Driver.FindElement(HomePage.SubTitulo).Displayed);
            Assert.IsTrue(Driver.FindElement(HomePage.BtnCadastro).Displayed);
        }

        public static void ClickCadastro()
        { 
            Driver.FindElement(HomePage.BtnCadastro).Click();
        }
    }
}