using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NamedTrianglesProblemTestUI.Controllers
{
  [Route("demo")]
  public class DemoController : Controller
  {
    [Route("")]
    [Route("index")]
    [Route("~/")]
    public IActionResult Index()
    {
      return View();
    }

    [Route("demo1")]
    public IActionResult Demo1()
    {
      return new JsonResult("Hello");
    }

    [Route("demo2/{fullName}")]
    public IActionResult Demo2(string fullName)
    {
      return new JsonResult("Hello " + fullName);
    }
  }
}
