using System.ComponentModel.DataAnnotations;

namespace MegaDesk.Model
{
    public class DesktopMaterial
    {
        public int DesktopMaterialId { get; set; }

        [Display(Name ="Desktop Material")]
        public string DesktopMaterialName { get; set; }
        public float Cost { get; set; }
    }
}