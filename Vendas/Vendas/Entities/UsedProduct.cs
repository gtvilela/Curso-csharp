﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Vendas.Entities
{
    class UsedProduct : Product
    {
        public DateTime  ManufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(DateTime manufactureDate, string name, double price): base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string priceTag()
        {
            return Name
                + "(used) $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + "(Manufacture date: "
                + ManufactureDate.ToString("dd/MM/yyyy")
                + ")";
        }
    }
}
