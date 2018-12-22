using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public class NotificationService
    {
        public void OnVideoEncoded(object source,VideoEventArgs args)
        {
            Console.WriteLine("Encode finish.");
            args.Video.TextState = Video.NotificationState.Sent;
        }
    }
}
