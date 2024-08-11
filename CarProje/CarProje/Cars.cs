using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static CarProje.EnumofClass;
using Type = CarProje.EnumofClass.Type;
namespace CarProje
{
    public class Cars
    {
        public int Id { get; set; }

        public string Brand { get; set; }

        public Colors Color { get; set; }

        public string Model { get; set; }

        public Type BanType { get; set; }

        public string CreateYear { get; set; }

        public string Run { get; set; }

    }
}
