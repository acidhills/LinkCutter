using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ViewModels
{
    public class LinkVM
    {
        public string shortUrl { get; set; }
        public string originalUrl { get; set; }
        public int visitors { get; set; }
        public string created { get; set; }
    }
}
