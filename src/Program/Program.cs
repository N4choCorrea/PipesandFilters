using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {
            PictureProvider provider = new PictureProvider();
            IPicture picture = provider.GetPicture(@"../../Imgs/luke.jpg");
            IPipe pipeNull = new PipeNull();
            IFilter filternegative = new FilterNegative();
            IPipe pipe1 = new PipeSerial(filternegative, pipeNull);
            IFilter filtergray = new FilterGreyscale();
            IPipe pipe2 = new PipeSerial(filtergray, pipe1);

            SavetheFilter saveFilter = new SavetheFilter();
            saveFilter.NameofPhoto = "Beer";
            IPipe pipe3 = new PipeSerial(saveFilter, pipeNull);
            IPipe pipe4 = new PipeSerial (filternegative, pipe3);
            IPipe pipe5 = new PipeSerial (filtergray, pipe4);
            IPipe pipe6 = new PipeSerial (saveFilter, pipe4);
            IPicture picture2 = provider.GetPicture(@"../../Imgs/beer.jpg");
            pipe4.Send(picture2);
           saveFilter.NameofPhoto = "Luke";
           IFilter filterpublish = new TwitterFilter();
            IPipe pipe7 = new PipeSerial(filterpublish, pipeNull);
            IPipe pipe8 = new PipeSerial(saveFilter, pipe7);
            IPipe pipe9 = new PipeSerial(filternegative, pipe8);
            IPipe pipe10 = new PipeSerial(filtergray, pipe9);
            IPipe pipe11 = new PipeSerial(saveFilter, pipe10);
            IPipe pipe12 = new PipeSerial(filtergray, pipe11);
            IPicture picture3 = provider.GetPicture(@"../../Imgs/luke.jpg");
            pipe12.Send(picture3);
            IPicture picture4 = provider.GetPicture(@"../../Imgs/beer.jpg");
            IPicture picture5 = provider.GetPicture(@"../../Imgs/luke.jpg");
            FilterCondition filtercondition = new FilterCondition();
            IPipe pipe13 = new PipeSerial(filtercondition, pipeNull);
            IPipe pipe14 = new PipeSerial(saveFilter, pipe13);
            IPipe pipe15 = new PipeSerial(filternegative, pipe14);
            IPipe pipe16 = new PipeSerial(filtergray, pipe15);
            IPipe pipecond = new PipeConditional(filtercondition, pipe16, pipe12);
            IPipe pipe17 = new PipeSerial(saveFilter, pipecond);
            IPipe pipe18 = new PipeSerial(filtergray, pipe17);



            

        }
    }
}
