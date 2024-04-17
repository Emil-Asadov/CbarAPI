using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml;
using WebApplicationCbarAPI.Models;

namespace WebApplicationCbarAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpPost]
        [Route("AllCurrency")]
        public ActionResult GetAllCurrency()
        {
            //Test
            var date = DateTime.Now.ToString("dd.MM.yyyy");
            var lst = new List<ServiceFields>();
            var xmlDoc = new XmlDocument();
            var url = $"https://www.cbar.az/currencies/{date}.xml?wsdl";
            xmlDoc.Load(url);
            var currencyList = xmlDoc.GetElementsByTagName("ValType")[1];
            //var xmlList = xmlDoc.GetElementsByTagName("Valute");
            var cls = new ServiceFields();
            foreach (XmlNode item in currencyList)
            {
                cls = new ServiceFields
                {
                    Date = xmlDoc.ChildNodes[1].Attributes[0].Value,
                    ValuteCode = item.Attributes[0].Value,
                    Nominal = item.ChildNodes[0].InnerText,
                    Name = item.ChildNodes[1].InnerText,
                    Value = item.ChildNodes[2].InnerText
                };
                lst.Add(cls);
            }
            return Ok(lst);
        }

        [HttpPost]
        [Route("AllCurrencyChooseDate")]
        public ActionResult GetAllCurrencyChooseDate(string dateInp)
        {
            var date = dateInp;
            var lst = new List<ServiceFields>();
            var xmlDoc = new XmlDocument();
            var url = $"https://www.cbar.az/currencies/{date}.xml?wsdl";
            xmlDoc.Load(url);
            var currencyList = xmlDoc.GetElementsByTagName("ValType")[1];
            //var xmlList = xmlDoc.GetElementsByTagName("Valute");
            var cls = new ServiceFields();
            foreach (XmlNode item in currencyList)
            {
                cls = new ServiceFields
                {
                    Date = xmlDoc.ChildNodes[1].Attributes[0].Value,
                    ValuteCode = item.Attributes[0].Value,
                    Nominal = item.ChildNodes[0].InnerText,
                    Name = item.ChildNodes[1].InnerText,
                    Value = item.ChildNodes[2].InnerText
                };
                lst.Add(cls);
            }
            return Ok(lst);
        }

        [HttpPost]
        [Route("AllMetals")]
        public ActionResult GetAllMetals()
        {
            var date = DateTime.Now.ToString("dd.MM.yyyy");
            var lst = new List<ServiceFields>();
            var xmlDoc = new XmlDocument();
            var url = $"https://www.cbar.az/currencies/{date}.xml?wsdl";
            xmlDoc.Load(url);
            var metalsList = xmlDoc.GetElementsByTagName("ValType")[0];
            //var xmlList = xmlDoc.GetElementsByTagName("Valute");
            var cls = new ServiceFields();
            foreach (XmlNode item in metalsList)
            {
                cls = new ServiceFields
                {
                    Date = xmlDoc.ChildNodes[1].Attributes[0].Value,
                    ValuteCode = item.Attributes[0].Value,
                    Nominal = item.ChildNodes[0].InnerText,
                    Name = item.ChildNodes[1].InnerText,
                    Value = item.ChildNodes[2].InnerText
                };
                lst.Add(cls);
            }
            return Ok(lst);
        }

        [HttpPost]
        [Route("AllMetalsChooseDate")]
        public ActionResult GetAllMetalsChooseDate(string dateInp)
        {
            var date = dateInp;
            var lst = new List<ServiceFields>();
            var xmlDoc = new XmlDocument();
            var url = $"https://www.cbar.az/currencies/{date}.xml?wsdl";
            xmlDoc.Load(url);
            var metalsList = xmlDoc.GetElementsByTagName("ValType")[0];
            //var xmlList = xmlDoc.GetElementsByTagName("Valute");
            var cls = new ServiceFields();
            foreach (XmlNode item in metalsList)
            {
                cls = new ServiceFields
                {
                    Date = xmlDoc.ChildNodes[1].Attributes[0].Value,
                    ValuteCode = item.Attributes[0].Value,
                    Nominal = item.ChildNodes[0].InnerText,
                    Name = item.ChildNodes[1].InnerText,
                    Value = item.ChildNodes[2].InnerText
                };
                lst.Add(cls);
            }
            return Ok(lst);
        }

        [HttpPost]
        [Route("ChooseCurrency")]
        public ActionResult GetChooseCurrencyCurrenDate(string currency)
        {
            var date = DateTime.Now.ToString("dd.MM.yyyy");
            var xmlDoc = new XmlDocument();
            var url = $"https://www.cbar.az/currencies/{date}.xml?wsdl";
            xmlDoc.Load(url);
            var currencyList = xmlDoc.GetElementsByTagName("ValType")[1];
            //var xmlList = xmlDoc.GetElementsByTagName("Valute");
            var cls = new ServiceFields();
            foreach (XmlNode item in currencyList)
            {
                if (!item.Attributes[0].Value.Equals(currency.ToUpper()))
                    continue;
                cls = new ServiceFields
                {
                    Date = xmlDoc.ChildNodes[1].Attributes[0].Value,
                    ValuteCode = item.Attributes[0].Value,
                    Nominal = item.ChildNodes[0].InnerText,
                    Name = item.ChildNodes[1].InnerText,
                    Value = item.ChildNodes[2].InnerText
                };
                break;
            }
            return Ok(cls);
        }

        [HttpPost]
        [Route("ChooseMetal")]
        public ActionResult GetChooseMetalCurrenDate(string metal)
        {
            var date = DateTime.Now.ToString("dd.MM.yyyy");
            var xmlDoc = new XmlDocument();
            var url = $"https://www.cbar.az/currencies/{date}.xml?wsdl";
            xmlDoc.Load(url);
            var currencyList = xmlDoc.GetElementsByTagName("ValType")[0];
            //var xmlList = xmlDoc.GetElementsByTagName("Valute");
            var cls = new ServiceFields();
            foreach (XmlNode item in currencyList)
            {
                if (!item.Attributes[0].Value.Equals(metal.ToUpper()))
                    continue;
                cls = new ServiceFields
                {
                    Date = xmlDoc.ChildNodes[1].Attributes[0].Value,
                    ValuteCode = item.Attributes[0].Value,
                    Nominal = item.ChildNodes[0].InnerText,
                    Name = item.ChildNodes[1].InnerText,
                    Value = item.ChildNodes[2].InnerText
                };
                break;
            }
            return Ok(cls);
        }
    }
}
