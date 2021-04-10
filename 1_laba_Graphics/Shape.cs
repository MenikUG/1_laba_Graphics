using System.Drawing;

namespace _1_laba_Graphics
{
    public abstract class Shape
    {
        public int x;
        public int y;
        public Color color;

        public abstract void Paint(Graphics graphic);
    }
}
