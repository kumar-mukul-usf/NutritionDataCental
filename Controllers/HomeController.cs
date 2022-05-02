using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NutritionDataCental.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace NutritionDataCental.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult main()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Search()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SearchResult()
        {
           
            return View();
        }


            public IActionResult Stats()
        {
            return View();
        }
        
        //HttpClient httpClient;

        //static string BASE_URL = "https://fdc.nal.usda.gov/api/v1";
        //static string API_KEY = "h2yajvuVfIU3rANaMCaKR72an0bZWhhXC1NvOhhR"; //Add your API key here inside ""

        //public ApplicationDbContext dbContext;

        //public HomeController(ApplicationDbContext context)
        //{
          //  dbContext = context;
        //}
        
        //public async Task<IActionResult> Index()
        //{
          //  httpClient = new HttpClient();
            // httpClient.DefaultRequestHeaders.Accept.Clear();
         //   httpClient.DefaultRequestHeaders.Add("X-Api-Key", API_KEY);
         //   httpClient.DefaultRequestHeaders.Accept.Add(
          //      new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

          //  string NUTRITION_DATA_API_PATH = BASE_URL + "/v1/foods";
          //  string NutriData = "";

          //  FoodNutrient nutri = null;

            //httpClient.BaseAddress = new Uri(NUTRITION_DATA_API_PATH);
         //   httpClient.BaseAddress = new Uri(NUTRITION_DATA_API_PATH);

           // try
           // {
                //HttpResponseMessage response = httpClient.GetAsync(NUTRITION_DATA_API_PATH)
                //                                        .GetAwaiter().GetResult();
             //   HttpResponseMessage response = httpClient.GetAsync(NUTRITION_DATA_API_PATH)
               //                                         .GetAwaiter().GetResult();



             //   if (response.IsSuccessStatusCode)
               // {
                 //   NutriData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
              //  }

              //  if (!NutriData.Equals(""))
               // {
                   
                 //   nutri = JsonConvert.DeserializeObject<FoodNutrient>(NutriData);
               // }

              //  dbContext.FoodNutrient.Add(nutri);
              //  await dbContext.SaveChangesAsync();
            //}
           // catch (Exception e)
            // {
                // This is a useful place to insert a breakpoint and observe the error message
               // Console.WriteLine(e.Message);
          //  }

          //  return View(nutri);
        // }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
       // {
         //   return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
       // }
    }
}
