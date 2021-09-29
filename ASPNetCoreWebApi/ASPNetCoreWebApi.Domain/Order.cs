﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNetCoreWebApi.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsShipped { get; set; }
        public decimal Subtotal { get; set; }
        public decimal? SubtotalWithPromo { get; set; }
        public string UserId { get; set; }
        [NotMapped]
        public string UserEmail { get; set; }
        [Required]
        public virtual ApplicationUser User { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public int? PromoCodeId { get; set; }
        public virtual PromoCode PromoCode { get; set; }
    }
}
