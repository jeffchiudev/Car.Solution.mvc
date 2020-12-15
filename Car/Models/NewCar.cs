using System.Collections.Generic;

namespace Car.Models
{
    public class NewCar
    {
        public string MakeModel{ get; set; }
        public int Price{ get; set; }
        public int Miles{ get; set; }
        
        private static List<NewCar> _instances = new List<NewCar> {};

        public NewCar(string makeModel, int price, int miles)
        {
            MakeModel = makeModel;
            Price = price;
            Miles = miles;
            _instances.Add(this);
        }

        public static List<NewCar> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }
    }
}

// public string MakeModel { get; set; }
//     public int Price { get; set; }
//     public int Miles { get; set; }

//     public static string MakeSound(string sound)
//     {
//       return "Our cars sound like + sound";
//     }

//     public void SetPrice(int newPrice)
//     {
//       Price = newPrice;
//     }

//     public Car(string makeModel, int price, int miles)
//     {
//         MakeModel = makeModel;
//         Price = price;
//         Miles = miles;
//     }

//     public string GetMakeModel()
//     {
//       return MakeModel;
//     }

//     public int GetPrice()
//     {
//       return Price;
//     }

//     public int GetMiles()
//     {
//       return Miles;
//     }

//     public bool WorthBuying(int maxPrice)
//     {
//       return (Price <= maxPrice);
//     }
//   }
// }