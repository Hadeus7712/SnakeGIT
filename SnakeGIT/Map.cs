using System;
using System.Diagnostics;
using SharpDX;
using SharpDX.Direct2D1;
using SharpDX.Direct3D;
using SharpDX.Direct3D11;
using SharpDX.DirectInput;
using SharpDX.DXGI;
using SharpDX.Windows;


namespace SnakeGIT
{
    class Map : Drawable
    {
        public static int size = Constants.MAPSIZE * Constants.SPRITE_SIZE;
        public static int leftX = Constants.MAPX * Constants.SPRITE_SIZE;
        public static int upperY = Constants.MAPY * Constants.SPRITE_SIZE;
        public static int rightX = leftX + size;
        public static int bottomY = upperY + size;
        public void generateMAP(RenderTarget renderTarget, SharpDX.Direct2D1.Factory factory, int a)
        {
            if (a == 1)
            {
                var rectangleGeometry = new RectangleGeometry(factory, new RectangleF(leftX, upperY, size, height));
                renderTarget.FillGeometry(rectangleGeometry, brush, null);
                rectangleGeometry = new RectangleGeometry(factory, new RectangleF(leftX, bottomY, size, height));
                renderTarget.FillGeometry(rectangleGeometry, brush, null);
                rectangleGeometry = new RectangleGeometry(factory, new RectangleF(leftX, upperY, height, size));
                renderTarget.FillGeometry(rectangleGeometry, brush, null);
                rectangleGeometry = new RectangleGeometry(factory, new RectangleF(rightX, upperY, height, size));
                renderTarget.FillGeometry(rectangleGeometry, brush, null);
            }
            else if (a == 2)
            {
                var rectangleGeometry = new RectangleGeometry(factory, new RectangleF(leftX + size + 9 * Constants.SPRITE_SIZE, upperY, size, height));
                renderTarget.FillGeometry(rectangleGeometry, brush, null);
                rectangleGeometry = new RectangleGeometry(factory, new RectangleF(leftX + size + 9 * Constants.SPRITE_SIZE, bottomY, size, height));
                renderTarget.FillGeometry(rectangleGeometry, brush, null);
                rectangleGeometry = new RectangleGeometry(factory, new RectangleF(leftX + size + 9 * Constants.SPRITE_SIZE, upperY, height, size));
                renderTarget.FillGeometry(rectangleGeometry, brush, null);
                rectangleGeometry = new RectangleGeometry(factory, new RectangleF(rightX + size + 9 * Constants.SPRITE_SIZE, upperY, height, size));
                renderTarget.FillGeometry(rectangleGeometry, brush, null);
            }


        }
    }
}
