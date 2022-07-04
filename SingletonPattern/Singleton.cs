
using System;

namespace SingletonPattern
{
    public class Singleton
    {
        private static Singleton instance;
        public string message;

        private Singleton()
        {
            message = "initialized";
        }

        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                    return new Singleton();
                return instance;
            }
        }


    }
}
