using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article18
{
    namespace Article18
    {
        public class Song
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Author { get; set; }

            public override string ToString()
            {
                return $"{Id} - {Name} - {Author}";
            }
        }
    }
}
