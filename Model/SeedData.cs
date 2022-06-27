using Microsoft.EntityFrameworkCore;

namespace MegaDesk.Model
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MegaDeskContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MegaDeskContext>>()))
            {
                // Look for any movies.
                if (context.DesktopMaterial.Any())
                {
                    return;   // DB has been seeded
                }

                context.DesktopMaterial.AddRange(
                    new DesktopMaterial
                    {
                        DesktopMaterialId=1,
                        DesktopMaterialName="Oak",
                        Cost= 200
                    },
                     new DesktopMaterial
                    {
                        DesktopMaterialId=2,
                        DesktopMaterialName="Laminate",
                        Cost= 100
                    },
                     new DesktopMaterial
                    {
                        DesktopMaterialId=3,
                        DesktopMaterialName="Pine",
                        Cost= 50
                    },
                     new DesktopMaterial
                    {
                        DesktopMaterialId=4,
                        DesktopMaterialName="Rosewood",
                        Cost= 200
                    },
                     new DesktopMaterial
                    {
                        DesktopMaterialId=5,
                        DesktopMaterialName="Veneer",
                        Cost= 200
                    }
                   
                );
                context.SaveChanges();

                // Delivery
                context.Delivery.AddRange(
                    new Delivery
                    {
                        DeliveryId=1,
                        DeliveryName= "No Rush",
                        PriceUnder1000=0,
                        PriceBetween1000And2000=0,
                        PriceOver2000=0
                    },
                    new Delivery
                    {
                        DeliveryId=3,
                        DeliveryName= "Rush 5 day",
                        PriceUnder1000=40,
                        PriceBetween1000And2000=50,
                        PriceOver2000=60
                    },
                    new Delivery
                    {
                        DeliveryId=2,
                        DeliveryName= "Rush 3 Day",
                        PriceUnder1000=60,
                        PriceBetween1000And2000=70,
                        PriceOver2000=80
                    },
                    new Delivery
                    {
                        DeliveryId=4,
                        DeliveryName= "Rush 7 Day",
                        PriceUnder1000=30,
                        PriceBetween1000And2000=35,
                        PriceOver2000=40
                    }
                );
                
                context.SaveChanges();
            }
        }
    }
}