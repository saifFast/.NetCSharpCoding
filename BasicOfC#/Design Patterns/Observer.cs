using System;
using System.Collections.Generic;

namespace BasicOfC_.Design_Patterns
{
    public interface ISubject
    {
        void Register(IObserver o);
        void Unregister(IObserver o);
        void Notify();
    }

    public interface IObserver
    {
        void Update(string headline);
    }

    public class NewsStation : ISubject
    {
        List<IObserver> Observables = new List<IObserver>();
        private string CurrentNews = string.Empty;

        public void PlayNews(string headline)
        {
            CurrentNews = headline;
            Notify();
        }

        public void Notify()
        {
            foreach (var o in Observables)
            {
                o.Update(CurrentNews);
            }
        }

        public void Register(IObserver o)
        {
            Observables.Add(o);
        }

        public void Unregister(IObserver o)
        {
            Observables.Remove(o);
        }
    }

    public class MobileNews : IObserver
    {
        public void Update(string headline)
        {
            Console.WriteLine("Mobile: " + headline);
        }
    }
}
