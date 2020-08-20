using System;
using Microsoft.AspNetCore.Mvc;
using PruebaMappeoDictionary.Models;

namespace PruebaMappeoDictionary.Controllers
{
    public class PruebaMappingDictionaryController : Controller
    {
        public IActionResult Index()
        {
            PruebaMappingDictionaryViewModel vm = new PruebaMappingDictionaryViewModel
            {
                SubClassMappingDictionary = new System.Collections.Generic.Dictionary<string, SubClassMappingDictionary>
                {
                    { Guid.NewGuid().ToString(),
                        new SubClassMappingDictionary{
                            StringProp = "string prop",
                            SubSubClassMappingDictionary = new System.Collections.Generic.Dictionary<string, SubSubClassMappingDictionary>
                            {
                                { Guid.NewGuid().ToString(), new SubSubClassMappingDictionary{
                                    StrField = "Campo de texto 1"
                                } },
                                { Guid.NewGuid().ToString(), new SubSubClassMappingDictionary{
                                    StrField = "Campo de texto 2"
                                }
                                }
                            }
                        }
                    }
                }
            };
            return View(vm);
        }

        [HttpPost]
        public IActionResult Index(PruebaMappingDictionaryViewModel model)
        {
            return Json(model);
        }
    }
}
