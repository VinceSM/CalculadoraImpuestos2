using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CalculadoraImpuestos.Model
{
    public static class StaticPersistence
    {
        public static List<Producto> Productos { get; } = new List<Producto>
        {
            new Producto("COCA-COLA", 100.0m),
            new Producto("SPRITE", 50.0m),
            new Producto("FANTA", 200.0m)
        };

        public static List<Location> Countries { get; } = new List<Location>
        {
            new Location("España", null),
            new Location("Italia", null),
            new Location("Alemania", null)
        };

        public static List<Location> States { get; } = new List<Location>
        {
            new Location(null, "Mississippi"),
            new Location(null, "Texas"),
            new Location(null, "Kentucky")
        };
    }
}
