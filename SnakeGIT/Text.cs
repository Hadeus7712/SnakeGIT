using System;
using System.Diagnostics;
using SharpDX;
using SharpDX.Direct2D1;
using SharpDX.Direct3D;
using SharpDX.Direct3D11;
using SharpDX.DirectWrite;
using SharpDX.DXGI;
using SharpDX.Windows;


namespace SnakeGIT
{
    class Text : Drawable
    {
        private TextFormat _textFormatStats;
        public TextFormat TextFormatStats { get => _textFormatStats; }


        private SharpDX.DirectWrite.Factory _writeFactory;
        public SharpDX.DirectWrite.Factory WriteFactory { get => _writeFactory; }



        public Text(RenderForm form)
        {
            _writeFactory = new SharpDX.DirectWrite.Factory();


            _textFormatStats = new TextFormat(_writeFactory, "Calibri", 30);
            _textFormatStats.ParagraphAlignment = ParagraphAlignment.Near;
            _textFormatStats.TextAlignment = TextAlignment.Leading;

        }

    }
}
