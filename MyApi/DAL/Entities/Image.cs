using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Image
    {
        long Id { get; set; }
        long Width { get; set; }
        long Height { get; set; }
        public string Name { get; set; }



        ICollection<Effect> effects;
    }
}
