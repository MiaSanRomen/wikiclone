using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WikiClone.Models
{
    public class Image
    {
        public int ImageId { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }

        public int BlockInfoId { get; set; }
        public BlockInfo BlockInfo { get; set; }
    }
}
