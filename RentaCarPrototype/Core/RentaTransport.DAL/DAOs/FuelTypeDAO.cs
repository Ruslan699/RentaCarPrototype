﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RentaTransport.DAL.DAOs
{
    [Table("FuelTypes")]
    public class FuelTypeDAO : BaseDAO
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
