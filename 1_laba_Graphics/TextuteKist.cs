using System.Drawing;

namespace _1_laba_Graphics
{
    public class TextuteKist : Shape
    {
        Image texture;
        public TextuteKist(int x, int y)
        {
            texture = Image.FromFile(@"C:\Users\Пользователь\Downloads\kirpich.jpg");
            this.x = x;
            this.y = y;
        }

        public override void Paint(Graphics graphic)
        {
            TextureBrush tBrush = new TextureBrush(texture);
            Pen tPen = new Pen(tBrush, 2);
            graphic.FillEllipse(tBrush, x, y, 60, 60);
        }
    }
}
