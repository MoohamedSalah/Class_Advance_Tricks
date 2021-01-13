using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Class_With_Mosh
{
    public class VideoEventArg :EventArgs 
    {
        public Video Video { get; set; }
    }
    class VideoEncode
    {
        //Event Define
        //1-Define a delegate in old Way
        //2-Define an event based on that delegate (Event and delegate in the samr step by generic)
        //3-Raise the Event

        public event EventHandler<VideoEventArg> VideoEncoded;

        protected  virtual void onVideoEncoded(Video video )
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArg() { Video=video});
        }
        public void Encode(Video video)
        {
            Console.WriteLine("this encode...");
            Thread.Sleep(3000);
            onVideoEncoded(video);
        }
    }
}
