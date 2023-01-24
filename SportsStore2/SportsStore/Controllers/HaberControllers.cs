/*using System;
using System.Collections.Generic;
using System.Xml;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HaberControllers : ControllerBase
    {
        [HttpPost]
        public ResponseData Run() {

            ResponseData result = new ResponseData(); 
            try
            {
                var rlink = string.Format("https://www.yenimesaj.com.tr/xml-yazilar.php");
                result.Data = new List<ResponseDatalar>();
                XmlDocument doc = new XmlDocument();
                doc.Load(rlink);
                if(doc.SelectNodes("rss.xml.yazi").Count < 1)
                {

                result.hata = "Veri bulunamadı";
                }
                foreach(XmlNode node in doc.SelectNodes("rss.xml.yazi"))
                {
                    ResponseDatalar dt = new ResponseDatalar();
                    dt.adi = node.Attributes["baslik"].Value;
                    dt.metin = node.Attributes["metin"].Value;
                    dt.kategori = node.Attributes["kategoriler"].Value;
                    dt.resmi = node.Attributes["fotograf"].Value;
                }
            }
            catch (Exception ex)
            {

                result.hata = ex.Message;
            }
           

            return result;
        }
      
    }
}
*/