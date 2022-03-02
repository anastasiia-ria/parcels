// using System.Collections.Generic;

namespace Parcels.Models
{

  public class Parcel
  {
    public int Width { get; set; }
    public int Length { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public int Volume { get; set; }
    // private static List<Parcel> _instances = new List<Parcel> { };

    public Parcel(int width, int length, int height, int weight)
    {
      Width = width;
      Length = length;
      Height = height;
      Weight = weight;
      Volume = 0;
      // _instances.Add(this);
    }

    public int GetVolume(int width, int length, int height)
    {
      int volume = width * length * height;
      Volume = volume;
      return volume;
    }

    public int CostToShip(int volume, int weight)
    {
      int cost = volume * weight;
      return cost;
    }
    // public static List<Parcel> GetAll()
    // {
    //   return _instances;
    // }
  }
}