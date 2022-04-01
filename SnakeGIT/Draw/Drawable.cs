using SharpDX;
using SharpDX.Direct2D1;

namespace SnakeGIT
{
    public abstract class Drawable
    {
        protected SolidColorBrush brush;
        public int x;
        public int y;
        public int width = Constants.SPRITE_SIZE - 1;
        public int height = Constants.SPRITE_SIZE - 1;

        public void Initialize(RenderTarget renderTarget, Color color)
        {
            brush = new SolidColorBrush(renderTarget, color);
        }
    }
}