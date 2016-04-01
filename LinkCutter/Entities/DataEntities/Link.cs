using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataEntities
{
    public class Link
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Original { set; get; }
        public int Visitors { get; set; }
        public DateTime Created { get; set; }
    }
}
