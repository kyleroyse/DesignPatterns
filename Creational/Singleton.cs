using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonDesignPattern
{
    // eager initialization of singleton pattern
    public class Singleton{
        private static Singleton instance = new Singleton();
        private Singleton()
        {

        }
        public static Singleton GetInstance
        {
            get
            {
                return instance;
            }
        }
    }

    // lazy initialization of singleton
    public class LazySingleton
    {
        private static LazySingleton instance = null;
        private Singleton()
        {

        }
        public static LazySingleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LazySingleton();
                }
                return instance;
            }
        }
    }

    // Thread-safe initialization of singleton pattern
    public class ThreadSafeSingleton
    {
        private static ThreadSafeSingleton instance = null;
        private Singleton()
        {

        }
        private static object lockThis = new Object();
        public static ThreadSafeSingleton GetInstance
        {
            get
            {
                lock (lockThis)
                {
                    if (instance == null)
                    {
                        instance = new ThreadSafeSingleton();
                    }
                    return instance;
                }
            }
        }
    }
}

