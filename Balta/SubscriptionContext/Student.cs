using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Balta.NotificationContext;
using Balta.SharedContext;

namespace Balta.SubscriptionContext
{
    public class Student : BaseContent
    {
        public Student()
        {
            Subscriptions = new List<Subscription>();
        }
        public string Email { get; set; }
        public string Name { get; set; }
        public User User { get; set; }
        public List<Subscription> Subscriptions { get; set; }
        public void CreateSubscription(Subscription subscription)
        {
            if (IsPremium)
            {
                AddNotification(new Notification("Premium", "O aluno ja contem uma assinatura ativa!"));
                return;
            }
            Subscriptions.Add(subscription);
        }
        public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);
    }
}