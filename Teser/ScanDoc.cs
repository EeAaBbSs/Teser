using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Teser
{
    public class ScanDoc
    {
        public string FindObject(string inputData)
        {
            inputData = inputData.Replace("\n", " ");
            string findRes;
            if (inputData.Contains("Объект капитального строительства") == true)
            {
                findRes = "Объект капитального строительства";
            }
            else if (inputData.Contains("Земельный участок") == true)
            {
                findRes = "Земельный участок";
            }
            else
            {
                throw new Exception("Это не ОКС и не ЗУ!");
            }
            return findRes;
        }

        public string FindKadNumber(string inputData)
        {
            inputData = inputData.Replace("\n", " ");
            string findRes;
            string[] arForNumAndCost = inputData.Split(' ');
            int indOfSecondR = Array.IndexOf(arForNumAndCost, "номер:");
            if (Array.IndexOf(arForNumAndCost, "номер:") == -1)
            {
                throw new Exception("Кадастровый номер не найден!");
            }
            else
            {
                findRes = $"{arForNumAndCost[indOfSecondR + 1]}";
            }
            return findRes;
        }

        public string FindKadCost(string inputData)
        {
            inputData = inputData.Replace("\n", " ");
            string findRes;
            string[] arForNumAndCost = inputData.Split(' ');
            int indOfThirdR = Array.IndexOf(arForNumAndCost, "руб.:");
            if (Array.IndexOf(arForNumAndCost, "номер:") == -1)
            {
                throw new Exception("Кадастровая стоимость не найдена");
            }
            else
            {
                findRes = $"{arForNumAndCost[indOfThirdR + 1]}";
            }
            return findRes;
        }

        public string FindKDdateDetermenation(string inputData)
        {
            string findRes;
            if (inputData.Length < 20)
            {
                while (inputData.Length < 20)
                {
                    inputData += "_";
                }
            }
            inputData = inputData.Replace(":", "%3A");
            string http = @$"http://www.udmbti.ru/?kadN={inputData}&btn=Узнать+кадастровую+стоимость+объекта#top-c";
            string l = "</span><br />Дата оценки: <span style=\"color: #3399ff;\">";
            WebRequest req = WebRequest.Create(@"" + http);
            WebResponse resp = req.GetResponse();
            Stream stream = resp.GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            findRes = sr.ReadToEnd();
            findRes = findRes.Substring(findRes.IndexOf(l), l.Length + 10);
            findRes = findRes.Remove(0, l.Length);
            findRes = findRes.Replace('-', '.');
            return findRes;
        }

    }
}