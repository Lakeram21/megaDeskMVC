using System.ComponentModel.DataAnnotations;

namespace MegaDesk.Model
{
    public class Delivery
    {
        public int DeliveryId { get; set; }

        [Display(Name ="Delivery")]
        public string DeliveryName { get; set; }
        public decimal PriceUnder1000 { get; set; }
        public decimal PriceBetween1000And2000 { get; set; }
        public decimal PriceOver2000 { get; set; }
    }
}