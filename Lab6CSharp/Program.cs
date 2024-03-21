using Lab6CSharp;

class Program
{
    public static void Main(string[]Args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Detail d1 = new Detail();
        Detail d2 = new Detail("test detail", 500);
        Detail d3 = new Detail(d2);
        d1.Show();
        d2.Show();
        d3.Show();

        Mechanism m1 = new Mechanism();
        Mechanism m2 = new Mechanism("test mechanism", 500, 5);
        Mechanism m3 = new Mechanism(m2);
        m1.Show();
        m2.Show();
        m3.Show();

        Node n1 = new Node();
        Node n2 = new Node("test node", 500, "newtype");
        Node n3 = new Node(n2);
        n1.Show();
        n2.Show();
        n3.Show();

        Product p1 = new Product();
        Product p2 = new Product("test product", 500, "iron");
        Product p3 = new Product(p2);
        p1.Show();
        p2.Show();
        p3.Show();


        Console.WriteLine(d2.CompareTo(d1));
        Console.WriteLine(d2.CompareTo(d3));
        Console.WriteLine(d1.CompareTo(d2));
    }
}