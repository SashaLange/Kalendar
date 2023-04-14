using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalendar
{
    internal class Disaresalt
    {
        public static void MySerialize(List<eat> eat)
        {
            string json = JsonConvert.SerializeObject(eat);
            File.WriteAllText("D:\\Desktop\\Еда.json", json);
        }
        public static List<eat> MyDeserialize() {
            string json = File.ReadAllText("D:\\Desktop\\Еда.json");
            List<eat> eat = JsonConvert.DeserializeObject<List<eat>>(json);
            return eat;

        }
    }
}
