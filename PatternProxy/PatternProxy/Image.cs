using System;
using System.Collections.Generic;
using System.Text;

namespace PatternProxy
{
    class Image : Drawable
    {
        public Image(string path)
        {
            Console.WriteLine("подгрузка");
            Console.WriteLine(path);
        }

        public void Draw()
        {
            Console.WriteLine("отрисовка");
        }
    }
}

