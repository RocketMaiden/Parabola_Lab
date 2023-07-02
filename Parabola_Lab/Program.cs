using Parabola_Lab;

Console.WriteLine("Enter your X1 coordinate");
float x1;
float.TryParse(Console.ReadLine(), out x1);

Console.WriteLine("Enter your X2 coordinate");
float x2;
float.TryParse(Console.ReadLine(), out x2);

Console.WriteLine("Enter your height");
float h;
float.TryParse(Console.ReadLine(), out h);

Console.WriteLine("Enter your step for drawing a parabola");
float step;
float.TryParse(Console.ReadLine(), out step);

Parabola parabola = new Parabola(x1, x2, h);

float x = x1;

while (x <= x2)
{
    Console.WriteLine($"{x}, {parabola.Draw(x)}");
    x += step;
}

