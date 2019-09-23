using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace Qc.QcProjectSdk.Sample.Pages
{
  public class IndexModel : PageModel
  {
    private readonly QcProjectService _service;
    public IndexModel(QcProjectService service)
    {
        _service = service;
    }
    public IActionResult OnPostGetTest()
    {
      return new JsonResult(new { msg = "ok" }, new JsonSerializerSettings() { Formatting = Formatting.Indented });
    }
  }
}
