using Alura.RPA.Domain.Entities;
using Alura.RPA.Domain.Repositories;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Alura.RPA.Domain.Services
{
    public class CursoServices
    {
        private const string pathChromeDriver = "C:\\webdriver";
        private readonly ICursosRepository cursosRepository;

        public CursoServices(ICursosRepository cursosRepository)
        {
            this.cursosRepository = cursosRepository;
        }
        private string GetTextByClassName(IWebDriver driver, string classname)
        {
            IWebElement element = driver.FindElement(By.ClassName(classname));
            return element.Text;
        }
        private string GetText(IWebDriver driver, string xpath)
        {
            IWebElement element = driver.FindElement(By.XPath(xpath));
            return element.Text;
        }
        private void Fill(IWebDriver driver, string xpath, string input)
        {
            IWebElement element = driver.FindElement(By.XPath(xpath));
            element.SendKeys(input);
        }
        private void PushButton(IWebDriver driver, string xpath)
        {
            IWebElement element = driver.FindElement(By.XPath(xpath));
            element.Click();

        }
        public void GetCursoInformation()
        {
            using var driver = new ChromeDriver(pathChromeDriver);
            driver.Navigate().GoToUrl("https://www.alura.com.br");
            Fill(driver, "/html/body/main/section[1]/header/div/nav/div[2]/form/input", "RPA");
            Thread.Sleep(5000);
            PushButton(driver, "/html/body/main/section[1]/header/div/nav/div[2]/form/button");
            Thread.Sleep(5000);
            PushButton(driver, "//*[@id=\"busca-resultados\"]/ul/li[1]/a/div/h4");
            Thread.Sleep(2000);
            string titulo = GetText(driver, "/html/body/section[1]/div/div[1]/p[2]");
            string professor = GetTextByClassName(driver, "instructor-title--name");
            string cargaHoraria = GetText(driver, "/html/body/section[1]/div/div[2]/div[1]/div/div[1]/div/p[1]");
            string descricao = GetText(driver, "/html/body/section[2]/div[1]/div/ul");

            driver.Quit();



            Cursos cursos = new Cursos()
            {
                CargaHoraria = cargaHoraria,
                Descricao = descricao,
                Professor = professor,
                Titulo = titulo,
            };

            cursosRepository.Create(cursos);


        }
    }
}
