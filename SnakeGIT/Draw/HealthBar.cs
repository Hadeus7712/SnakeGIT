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
            var rectangleGeometry = new RectangleGeometry(factory, new RectangleF(x, y, width, height));
            renderTarget.FillGeometry(rectangleGeometry, brush, null);


        }
    }
}
