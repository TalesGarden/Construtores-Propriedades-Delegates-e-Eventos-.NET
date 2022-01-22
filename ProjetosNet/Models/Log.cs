//Modelo de projeto Singleton

using System;

namespace ProjetosNet.Models
{

    public class Log
    {
        private static Log log;
        public string propLog { get; set; }
        private Log()
        {
            
        }
        public static Log GetInstance()
        {
            if( log == null)
            {
                log = new Log();
            }
            return log;
        }
    }


}