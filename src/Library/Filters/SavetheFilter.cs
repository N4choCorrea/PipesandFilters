using System;
using System.Drawing;

namespace CompAndDel
{
    public class SavetheFilter : IFilter
    {
        public int NumLastPhoto { get; private set; }

        private string nameofPhoto;

        public string NameofPhoto{
            get
            {
                return this.nameofPhoto;
            }
            set
            {
                if (this.nameofPhoto != value)
                {
                    this.NumLastPhoto = 0;
                    this.nameofPhoto = value;
                }
            }
        }
    
    public IPicture Filter(IPicture image)
    {
        this.NumLastPhoto+=1;
        PictureProvider provider = new PictureProvider();
        provider.SavePicture(image, $"../../Imgs/{this.nameofPhoto}{this.NumLastPhoto}.jpg");
        provider.SavePicture(image, @$"../../Imgs/ImagePublic,jpg");
        return image;
    }
    }
}