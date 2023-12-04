using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Ponto_Eletronico.Service.Interface;

namespace Ponto_Eletronico.Service
{
    public class SiteConnect : IConnect
    {
        private string? baseUrl { get; set; }
        public SiteConnect(IConfiguration config)
        {
            baseUrl = config.GetSection("baseUrl").Value;

        }

        void IConnect.hr(string dia, string atividade, string hrs, IWebDriver driver)
        {
            driver.Navigate().GoToUrl(baseUrl);

            // Encontrar os elementos HTML do formulário pelo seu id e atribuir os valores
            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_txtAtividade")).SendKeys(atividade);
            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_cboGestor")).SendKeys("1");
            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_cboEmpresa")).SendKeys("1");
            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_txtQtdeHoras")).SendKeys(hrs);
            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_txtData")).SendKeys(dia);

            // Clicar no botão de salvar
            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_cmdSalvar")).Click();
        }
    }
}
