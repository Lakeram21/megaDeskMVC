using System.ComponentModel.DataAnnotations;

namespace MegaDesk.Model
{
    public class DeskQuote
    {
         private const float BASE_DESK_PRICE = 200;
         private const float SURFACE_AREA_COST = 1;
         private const double DRAWER_COST = 50;

        public int DeskQuoteId {get;set;}

         [Display(Name = "Customer Name")]
         public string CustomerName { get; set; }

        [Display(Name = "Quote Date")]
        public DateTime QuoteDate { get; set; }

        [Display(Name = "Quote Price")]
        [DisplayFormat(DataFormatString ="{0:C}")]
        public float QuotePrice { get; set; }

        public int DeskId { get; set; } 
        
        [Display(Name ="Delivery Type")]
        public int DeliveryId { get; set; }

        /*Navigation Property*/

        public Desk Desk { get; set; }

        public Delivery Delivery { get; set; }


        public float calculateQuote()
        {
            float final_price = BASE_DESK_PRICE;

             // get the area
             int area = this.Desk.Depth * this.Desk.Width;

             // evaluate the surface area
             switch(this.Desk.DesktopMaterial.DesktopMaterialName)
             {
                 case "Laminate":
                     final_price = final_price + this.Desk.DesktopMaterial.Cost;
                     break;
                 case "Oak":
                     final_price = final_price + this.Desk.DesktopMaterial.Cost;
                     break;
                 case "Pine":
                     final_price= final_price + this.Desk.DesktopMaterial.Cost;
                     break;
                 case "Rosewood":
                     final_price=final_price + this.Desk.DesktopMaterial.Cost;
                     break;
                 case "Veneer":
                     final_price = final_price + this.Desk.DesktopMaterial.Cost;
                     break;
             }


             // evaluate the surface area
             if(area > 1000)
             {
                 final_price = final_price +( area-1000);
             }

             //evaluate the Drawers
             final_price = final_price + (this.Desk.NumberOfDrawers * 50);
            
             // determine the rush hour
             switch(this.Delivery.DeliveryName)
             {
                 case "Rush 3 days":
                     if(area < 1000)
                     {
                         final_price= final_price + 60;
                     }
                     if(area>= 1000 && area <= 2000)
                     {
                         final_price = final_price + 70;
                     }
                     else
                     {
                         final_price= final_price+80;
                     }
                     break;
                 case "Rush 5 days":
                      if(area < 1000)
                     {
                         final_price= final_price + 40;
                     }
                     if(area>= 1000 && area <= 2000)
                     {
                         final_price= final_price+ 50;
                     }
                     else
                     {
                         final_price= final_price+60;
                     }
                     break;
                 case "Rush 7 days":
                      if(area < 1000)
                     {
                         final_price= final_price + 30;
                     }
                     if(area>= 1000 && area <= 2000)
                     {
                         final_price= final_price + 35;
                     }
                     else
                     {
                         final_price= final_price+40;
                     }
                     break;
                 case "No Rush":
                    
                     break; 
             } 
             this.QuotePrice = final_price;
             return final_price;
        }

    }
}