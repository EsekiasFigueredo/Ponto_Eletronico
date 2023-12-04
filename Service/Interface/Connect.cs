using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponto_Eletronico.Service.Interface
{
    public interface IConnect
    {
        void hr(string dia, string atividade, string hrs, IWebDriver driver);
    }
}
