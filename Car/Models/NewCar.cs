using systme.Collections.Generic;

namespace Car.Models
{
    public class NewCar
    {
        public string MakeModel{get;set;}
        public int Price{get;set;}
        public int Miles{get;set;}

        public NewCar(string makeModel, int price, int miles)
        {
            MakeModel = makeModel;
            Price = price;
            Miles = miles;
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