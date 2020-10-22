using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WikiClone.Models
{
    public class Change
    {
        public int ChangeId { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }

        public int ArticleId { get; set; }
        public Article Article { get; set; }
    }
}
