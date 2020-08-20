using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace PruebaMappeoDictionary.Models
{
    public class PruebaMappingDictionaryViewModel
    {
        //Guid.NewGuid().ToString();
        public Dictionary<string, SubClassMappingDictionary> SubClassMappingDictionary { get; set; }
    }
    public class SubClassMappingDictionary
    {
        [Display(Name = "Propiedad")]
        public string StringProp { get; set; }
        public Dictionary<string, SubSubClassMappingDictionary> SubSubClassMappingDictionary { get; set; }
    }
    public class SubSubClassMappingDictionary
    {
        public string StrField { get; set; }
    }
}
