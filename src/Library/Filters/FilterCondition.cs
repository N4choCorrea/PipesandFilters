using System;
using System.Drawing;
using CognitiveCoreUCU;
namespace CompAndDel.Filters
{
    public class FilterCondition : IFilterCondition
    {
        public bool Filter { get; set; }
        string path { get; set; }
        public IPicture EffectFilter (IPicture image)
        {
            CognitiveFace cogFace = new CognitiveFace(true, Color.Aqua);
            cog.Recognize(@$" Luke.jpg");
            if (cog.FaceFound)
            {
                this.Filter = true;
            }
            else
            {
                this.Filter = false;
            }
            return image;
        }
        }

        
            
    }
}