using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WikiClone.Models
{
    public class Link
    {
        public int LinkId { get; set; }
        public string Name { get; set; }

        public int ArticleId { get; set; }
        public Article Article { get; set; }
    }
}
