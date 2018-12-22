using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person newPerson1 = new Person() { FirstName = "Paul", LastName = "McDuck" };
            Video newVideo = new Video() { Name = "DirHard.mp4" };
            VideoEncoder videoEncoder = new VideoEncoder();//Publisher

            NotificationService notificationService = new NotificationService();//Subscriber
            EmailService emailService = new EmailService();

            videoEncoder.VideoEncoded += notificationService.OnVideoEncoded;
            videoEncoder.VideoEncoded += emailService.OnVideoEncoded;

            videoEncoder.Encode(newVideo);


            Console.WriteLine("-----");
            Console.WriteLine(newVideo.Name + ", " + newVideo.EmailState + ", " + newVideo.TextState);
            Console.ReadKey();
        }
    }
    public class EmailService
    {
        public void OnVideoEncoded(object source,VideoEventArgs arg)
        {
            Console.WriteLine("Text Sent!");
            arg.Video.EmailState = Video.NotificationState.Sent;
        }
    }
    
}
