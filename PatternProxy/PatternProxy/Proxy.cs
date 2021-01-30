using System;

namespace PatternProxy
{
    class Proxy
    {
        static void Main(string[] args)
        {
            LazyImage limg = new LazyImage();
            limg.Draw();
        }
    }
}
