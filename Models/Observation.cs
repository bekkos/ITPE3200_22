namespace ITPE3200_22.Models
{
    public class Observation
    {
        int id;
        string title { get; set; }
        int[] latLng { get; set; }
        string description { get; set; }
    }
}
