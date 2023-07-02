namespace TestParabola
{
    using Parabola_Lab;
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Parabola parabola = new Parabola(-2, 2, 7);
            Assert.Equal(-1.75f, parabola.ShowAttributes().a);
            Assert.Equal(0, parabola.ShowAttributes().b);
            Assert.Equal(7, parabola.ShowAttributes().c);
        }
    }
}