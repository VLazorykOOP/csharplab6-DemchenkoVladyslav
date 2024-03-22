using Lab6CSharp;
using System.Diagnostics;

class Program
{
    public static void Main(string[] Args)
    {
        //   Console.OutputEncoding = System.Text.Encoding.UTF8;
        //   Detail d1 = new Detail();
        //   Detail d2 = new Detail("test detail", 500);
        //   Detail d3 = new Detail(d2);
        //   d1.Show();
        //   d2.Show();
        //   d3.Show();

        //   Mechanism m1 = new Mechanism();
        //   Mechanism m2 = new Mechanism("test mechanism", 500, 5);
        //   Mechanism m3 = new Mechanism(m2);
        //   m1.Show();
        //   m2.Show();
        //   m3.Show();

        //   Node n1 = new Node();
        //   Node n2 = new Node("test node", 500, "newtype");
        //   Node n3 = new Node(n2);
        //   n1.Show();
        //   n2.Show();
        //   n3.Show();

        //   Product p1 = new Product();
        //   Product p2 = new Product("test product", 500, "iron");
        //   Product p3 = new Product(p2);
        //   p1.Show();
        //   p2.Show();
        //   p3.Show();


        //   Console.WriteLine(d2.CompareTo(d1));
        //   Console.WriteLine(d2.CompareTo(p3));
        //   Console.WriteLine(m1.CompareTo(d2));
        Trans[] vehicles = new Trans[]
     {
            new Car("Toyota", "ABC123", 120, 500),
            new Motorcycle("Honda", "DEF456", 100, 0, true),
            new Truck("Volvo", "GHI789", 80, 2000, true),
            new Car("BMW", "JKL012", 150, 600),
            new Truck("MAN", "MNO345", 70, 3000, false)
     };

        //   foreach (Trans vehicle in vehicles)
        //   {
        //       vehicle.DisplayInfo();
        //   }

        //   int requiredCapacity = 1000;
        //   Console.WriteLine($"\nVehicles with capacity >= {requiredCapacity}:");
        //   foreach (Trans vehicle in vehicles)
        //   {
        //       if (vehicle.CompareTo(requiredCapacity) == 1)
        //       {
        //           vehicle.DisplayInfo();
        //       }
        //   }

        //   Console.WriteLine(vehicles[0].Equals(vehicles[1]));
        //   Console.WriteLine(vehicles[0].Equals(vehicles[0]));
        Motorcycle a = new Motorcycle("Honda", "DEF456", 100, 0, true);
        foreach (object o in a)
        {
            Console.WriteLine(o.ToString());
        }
    }
}