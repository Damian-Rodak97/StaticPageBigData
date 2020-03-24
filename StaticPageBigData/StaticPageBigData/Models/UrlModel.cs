using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaticPageBigData.Models
{
    public class UrlModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Url { get; set; }
        public bool IsSelected { get; set; }
        public string IsHtml { get; set; }
    }
}
