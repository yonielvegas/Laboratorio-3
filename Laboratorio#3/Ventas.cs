using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    internal class Ventas
    {
        private decimal[] importes;

        public Ventas(int numVentas)
        {
            importes = new decimal[numVentas];
        }

        public void AgregarVenta(int indice, decimal importe)
        {
            importes[indice] = importe;
        }

        public decimal[] ObtenerImportesEntre(decimal min, decimal max)
        {
            // Filtrar importes entre min y max
            return Array.FindAll(importes, x => x >= min && x <= max);
        }

        public void OrdenarImportes()
        {
            Array.Sort(importes);
        }

        public decimal[] ObtenerImportes()
        {
            return importes;
        }
    }
}
