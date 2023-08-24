using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Models.Siniflar;

namespace TravelTrip.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        //Context sınıfından c isimli bir nesne ürettim. 
        //c nesnesi yardımı ile de hakkımızda tablosunu listeledim.
        Context c=new Context();
        public ActionResult Index()
        {
            var degerler=c.Hakkimizdas.ToList();
            return View(degerler);
        }
    }
}