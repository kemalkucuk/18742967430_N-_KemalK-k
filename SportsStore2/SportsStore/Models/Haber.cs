using System;
using System.Collections.Generic;
using System.Xml;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Models
{
    public class Haber
    {
        
            private ResponseDatalar dt;

            public string adi { get; set; }
            public string metin { get; set; }
            public string kategori { get; set; }
            public string resmi { get; set; }
      



        public static List<ResponseDatalar> Lines { get; set; } = new List<ResponseDatalar>();
            public virtual void AddItem2()
    {
        ResponseData result = new ResponseData();
        try
        {
            var rlink = string.Format("https://www.yenimesaj.com.tr/xml-yazilar.php");
            result.Data = new List<ResponseDatalar>();
            XmlDocument doc = new XmlDocument();
            doc.Load(rlink);
            if (doc.SelectNodes("rss.xml.yazi").Count < 1)
            {

                result.hata = "Veri bulunamadı";
            }
            foreach (XmlNode node in doc.SelectNodes("rss.xml.yazi"))
            {
                ResponseDatalar dt = new ResponseDatalar();
                dt.adi = node.Attributes["baslik"].Value;
                dt.metin = node.Attributes["metin"].Value;
                dt.kategori = node.Attributes["kategoriler"].Value;
                dt.resmi = node.Attributes["fotograf"].Value;
            }
            Lines.Add(dt);
        }
        catch (Exception ex)
        {

            result.hata = ex.Message;
        }

            }
        }
        public class ResponseData
        {
            public List<ResponseDatalar> Data { get; set; }
            public string hata { get; set; }
        }


public class ResponseDatalar
{
    private ResponseDatalar dt;

    public string adi { get; set; }
    public string metin { get; set; }
    public string kategori { get; set; }
    public string resmi { get; set; }
}

}
