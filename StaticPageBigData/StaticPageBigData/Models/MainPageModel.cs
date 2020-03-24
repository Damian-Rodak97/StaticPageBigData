using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace StaticPageBigData.Models
{
    public class MainPageModel
    {
        public UrlModel UrlModel { get; set; }
        [BindProperty]
        public List<UrlModel> UrlModels { get; set; }
    }
}
