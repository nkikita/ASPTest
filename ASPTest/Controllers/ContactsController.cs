using ASPTest.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using System.Reflection.Emit;
using System.Xml.Linq;

namespace ASPTest.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Check(Contact cont) 
        {
            if(ModelState.IsValid)
            {
                string textToWrite = $"Name: {cont.Name}, Email: {cont.Email}, Age: {cont.Age}, Message: {cont.Mess}\n";

                await System.IO.File.AppendAllTextAsync("C:/Users/nikit/OneDrive/Рабочий стол/codes/vs/ASPTest/ASPTest/dbimitation.txt", textToWrite);

                return View("ContTHX");

            }
            return View("Index");
        }
    }
}