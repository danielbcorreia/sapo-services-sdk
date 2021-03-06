namespace pt.sapo.gis.trace
{
    using System;
    using System.IO;

    /**
    * @author GIS Team 
     * Entry property to wrap an exception 
     */
    public class ExceptionEntryProperty : EntryProperty
    {
        public Exception Exception { get; private set; }

        public ExceptionEntryProperty(Exception e)
        {
            Exception = e;
            this["message"] = e.Message;
            this["stack"] = e.StackTrace;
        }
    }
}