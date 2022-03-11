//namespace ConsoleApp1;
// se devo implementare classi particolari, ad esempio un vettore di norma sempre=1
/// <summary>
/// Documentazione della classe Vec: Vec è 3-D normalizzato, occhio.
/// </summary>

public class Vec
{
    public double x, y, z;

    public Vec(double x, double y, double z)
    //in C++ nome variabile del costruttore diverse da quelle dei membri
    //in c# per accedere ai membri this.x, this.y...
    {    
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public override string ToString()
    {
        return $"<{this.x}, {this.y}, {this.z}>";
    }
    
    //main, in C# va incluso in una classe
    class Program
    {
        static void Main(string[] args)
        {
            Vec v = new Vec(1.0, 2.0, 3.0);
            Console.WriteLine(v);
        }


    }
    
    //funzione che stampi a video il vettore
    
}
