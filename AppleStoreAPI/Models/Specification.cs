using System.ComponentModel.DataAnnotations;

namespace AppleStoreAPI.Models
{
    public class Specification
    {
        public int Id { get; set; }
        public SpecType SpecKey { get; set; }
        [MaxLength(300)]
        public string SpecValue { get; set; }

        public int  ProductId { get; set; }

    }
    public enum SpecType
    {
        Ram,
        Screen,
        Battery,
        Camera,
        StrapMaterial,
        WaterResistance,
        ScreenType,
        BatteryLife,
        ScreenSize,
        Storage,
        Processor,
        NoiseCancellation,
        ChargingCase,
        Compatibility,
        Color,
        Material,
        Signal,
        Charger,
        Design,
        USB,

    }
}
