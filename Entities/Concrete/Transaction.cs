using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Transaction : IEntity
    {
        public int Id { get; set; }
        public int SellerId { get; set; }
        public int BuyerId { get; set; }
        public int SelledProductId { get; set; }
        public bool DeliveryStatus { get; set; }
    }
}
