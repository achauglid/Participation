using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_rick_and_morty
{

   /* public override string ToString()
    {
        return $"
    }
    */
    public class InfoObject
    {
        public int count { get; set; }
        public int pages { get; set; }
        public string prev { get; set; }
    }
    public class ResultObject
    {
        public int id { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public string species { get; set; }
        public string gender { get; set; }
        public string image { get; set; }
        public string url { get; set; }
    }

    class Class1
    {

        public InfoObject Info { get; set; }
        public List<ResultObject> results { get; set; }
    }
}
