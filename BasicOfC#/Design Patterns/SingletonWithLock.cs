using System;


namespace BasicOfC_.Design_Patterns
{
    public class SingletonWithLock
    {
        private static SingletonWithLock instance = null;
        private static object lockInstance = new object();

        private SingletonWithLock()
        {

        }

        public static SingletonWithLock Instance
        {
            get
            {
                lock (lockInstance)
                {
                    if (instance == null)
                    {
                        instance = new SingletonWithLock();
                    }
                }
                return instance;
            }
        }

        public void ShowMessage()
        {
            Console.WriteLine("Hey");
        }
    }
}
