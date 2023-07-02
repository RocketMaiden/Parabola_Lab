namespace Parabola_Lab
{
    public class Parabola
    {
        float a;
        float b;
        float c;

        public Parabola(float x1, float x2, float h)
        {
            a = (float)(-h / (Math.Pow((x1 - x2) * 0.5f, 2)));
            b = -2 * a * h;
            c = a * (float)Math.Pow((x1 + x2)*0.5f, 2) + h;
        }

        public float Draw(float x)
        {
            return (float)(a * Math.Pow(x, 2) + b * x + c);
        }
    }
}
