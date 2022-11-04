﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeFirst.Entity
{
    public class Musteri
    {
        [Key]
        public int MusteriID { get; set; }
        public string MusteriAd { get; set; }
        public string MusteriUnvan { get; set; }
        //add-migration RenameMusteriSoyadtoMusteriUnvanInMusterisTable Koduyla Rename verdik
        public string MusteriSehir { get; set; }
    }
}
