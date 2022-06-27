using System.ComponentModel.DataAnnotations;

namespace MegaDesk.Model
{
    public class Desk
    {
        // public const short MAX_WIDTH = 96;
        // public const short MIN_WIDTH = 24;
        // public const short MAX_DEPTH = 48;
        // public const short MIN_DEPTH = 12;
        // public const short MAX_DRAWER = 7;
        // public const short MIN_DRAWER = 0;

        public int DeskId { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }

        [Display(Name ="Number of Drawers")]
        public int NumberOfDrawers { get; set; }

        [Display(Name ="Desktop Materials")]
        public int DesktopMaterialId { get; set; }

        public DesktopMaterial DesktopMaterial { get; set; }

        public DeskQuote DeskQuote  { get; set; }


    }
}