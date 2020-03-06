using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaticPageBigData.Models
{
    public class MainPageModel
    {
        public UrlModel UrlModel { get; set; }
        public IEnumerable<UrlModel> UrlModels { get; set; }
    }
}
