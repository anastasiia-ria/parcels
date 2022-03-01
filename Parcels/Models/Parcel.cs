// using System.Collections.Generic;

namespace Parcels.Models
{

  public class Parcel
  {
    public int Width { get; set; }
    public int Length { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    // private static List<Parcel> _instances = new List<Parcel> { };

    public Parcel(int width, int length, int height, int weight)
    {
      Width = width;
      Length = length;
      Height = height;
      Weight = weight;
      // _instances.Add(this);
    }

    // public static List<Parcel> GetAll()
    // {
    //   return _instances;
    // }
  }
}