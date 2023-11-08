// See https://aka.ms/new-console-template for more information
using Delegatesandevents;

class Program
{
    public static void Main()
    {
        Video video = new Video();
        video.Title = "Testvideo";
        Mailservice mailservice = new Mailservice();//subscriber
        VideoEncoder vcd= new VideoEncoder(); //publisher
        vcd.VideoEncoded += mailservice.OnvideoEncoded;
        vcd.Encode(video);
    }
    class Mailservice
    {
        public void OnvideoEncoded(object source,EventArgs e)
        {
            Console.WriteLine("mail sent succesffully");
        }
    }
}
