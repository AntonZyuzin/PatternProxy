using System;
using System.Collections.Generic;
using System.Text;

namespace PatternProxy
{
    class LazyImage : Drawable
    {
        string path = "C:/img.jpeg";
        public void Draw()
        {
            Image img = new Image(path);
            img.Draw();
        }
    }
}
