using SharpDX;
using SharpDX.Direct2D1;

namespace SnakeGIT
{
    public class Fruits : Drawable
    {
        public void Draw(RenderTarget renderTarget, SharpDX.Direct2D1.Factory factory)
        {
            var x = this.x * Constants.SPRITE_SIZE + 1;
            var y = this.y * Constants.SPRITE_SIZE + 1;
            var rectangleGeometry = new RectangleGeometry(factory, new RectangleF(x, y, width, height));
            renderTarget.FillGeometry(rectangleGeometry, brush, null);
        }
    }
}