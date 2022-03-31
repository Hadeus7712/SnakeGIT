using System.Collections.Generic;
using SharpDX;
using SharpDX.Direct2D1;
using SharpDX.DirectInput;

namespace SnakeGIT
{
    public class HealthBar : Drawable
    {

        public void Draw(RenderTarget renderTarget, SharpDX.Direct2D1.Factory factory, int x, int y)
        {
            /*var dx = this.x * Constants.SPRITE_SIZE + 1;
            var dy = this.y * Constants.SPRITE_SIZE + 1;*/
            var rectangleGeometry = new RectangleGeometry(factory, new RectangleF(x, y, width, height));
            renderTarget.FillGeometry(rectangleGeometry, brush, null);


        }
    }
}
