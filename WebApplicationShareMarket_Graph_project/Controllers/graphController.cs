using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace WebApplicationShareMarket_Graph_project.Controllers
{
    public class graphController : Controller
    {
        // GET: graph
        public ActionResult Index()

        {
            string[] xAxis = { "paytm", "KPIT", "Wipro", "KPMG", "Mastercard", "EY", "HCL", "winjit" };
            string[] yAxis = { "10000", "40000", "50000", "70000", "100000", "120000", "130000", "60000" };
            var chartResponse = new Chart(width: 600, height: 400)
                                .AddSeries(
                                 chartType: "Column",
                                 xValue: xAxis,
                                 yValues: yAxis)

                               .GetBytes("png");
                                                                     
            return File(chartResponse, "image/png");
        }
    }
}