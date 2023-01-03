using BugerEats.Steps;
using BugerEats.Steps.Cadastro;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BugerEats.Feature.Home
{
    [TestClass]
    public class HomeFeature : Hooks
    {
        [TestMethod]
        public void CheckHomeTest()
        {
            Console.WriteLine("Dado: Que deseja acessar BugEats");
            Console.WriteLine("Quando: Acessar url");
            Console.WriteLine("Então: Deve ser direcionado a Home da aplicação");

            HomeSteps.CheckElementosHome();
        }
    }
}
