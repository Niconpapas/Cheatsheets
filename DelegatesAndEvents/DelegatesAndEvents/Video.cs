using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public class Video
    {
        public enum NotificationState
        {
            NotSent,
            Sent
        }

        private string name;
        private NotificationState emailState;
        private NotificationState textState;
        
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public NotificationState EmailState
        {
            get { return this.emailState; }
            set
            {
                if(Enum.IsDefined(typeof(NotificationState),value))
                {
                    this.emailState = value;
                }
                else
                {
                    this.emailState = NotificationState.NotSent;
                }
            }
        }
        public NotificationState TextState
        {
            get { return this.textState; }
            set
            {
                if(Enum.IsDefined(typeof(NotificationState),value))
                {
                    this.textState = value;
                }
                else
                {
                    this.textState = NotificationState.NotSent;
                }
            }
        }
        

    }
}
