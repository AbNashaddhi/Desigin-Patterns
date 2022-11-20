using Desigin_Patterns.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desigin_Patterns.ObserverPattern
{
    public class OBSERVER:IObserver
    {
        public string UserName { get; set; }
        public OBSERVER(string userName, ISubject subject)
        {
            UserName = userName;
            subject.RegisterObserver(this);
        }

        public void update(string availabiliy)
        {
            Console.WriteLine("Hello " + UserName + ", Product is now " + availabiliy + " on Amazon");
        }
    }
}
