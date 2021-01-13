using System;

namespace Class_With_Mosh
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> maultible = number => number * number;

            var ahmed = Person.PersonName("ahmed");
            ahmed.Hallo("MOhamed");
            Console.WriteLine(maultible(5));

            var videoEncode = new VideoEncode();//publicher
            var massage = new Massage();//Subscriber

            //VideoEncoder list of pointer to th method
            videoEncode.VideoEncoded += massage.onVideoEncoder;//subscribtion(refrencr or pointer t tis method)


            videoEncode.Encode(new Video() { Title = "video1" });

            string postword = "the number of word my love to miss your fraind";
            var smoll = postword.shortString(6);
            Console.WriteLine(smoll);

        }
    }
}
