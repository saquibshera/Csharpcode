using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegatesandevents
{
   
    internal class VideoEncoder
    {
        //craete delegate
        //craete the event 
        //raise the event
        public delegate void VideoEncodedEventhandler(object source, EventArgs e);

        public event VideoEncodedEventhandler VideoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine("Video encoding....");
            Thread.Sleep(3000);
            OnVideoEncoded();
        }
        public  void OnVideoEncoded()  //raising event
        {
            if (VideoEncoded != null)
            {
                    VideoEncoded(this, EventArgs.Empty);
            }
        }
    }
}
