using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adonet_db_videogame
{
    public class Videogame
    {
        public long Id { get; set; }
        public string name { get; set; }
        public string overview { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public string software_house_id { get; set; }

    }
}
