﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI.Models
{
    public class PaymentDetail
    {
        [Key]
        public int PaymentDetailId { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string CardOwnerName { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string CardNumber { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string EpxirationDate { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string SecurityCode { get; set; }
    }
}
