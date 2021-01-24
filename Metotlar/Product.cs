using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class Product
    {
        internal string Name;
        internal int Price;
        internal string Description;

        //Property aşağıdakilerin her biri kendine ait bir özellik"property"
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public string StokAdedi { get; set; }

            
    }
}
