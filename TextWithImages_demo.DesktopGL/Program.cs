using System;

namespace TextWithImages_demo.DesktopGL
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new TextWithImagesDemo())
                game.Run();
        }
    }
}
