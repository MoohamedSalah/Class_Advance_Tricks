using System;

namespace Class_With_Mosh
{
    public class Massage  
    {
        public void onVideoEncoder(object Sander, VideoEventArg e)
        {
            Console.WriteLine("Massage to vedio  "+ e.Video.Title);
        }

    }
}
