using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelesteModStudioGUI.utils
{
    internal class ModStudio
    {
        internal static byte GetImageByExtension(string extension)
        {
            switch (extension)
            {
                case ".yaml":
                    return (byte)ModStudioImage.Mountain; //Mountain.png

                case ".dat":
                    return (byte)ModStudioImage.GreenGem;

                default:
                    return (byte)ModStudioImage.DefaultFile;
            }
        }
    }
}