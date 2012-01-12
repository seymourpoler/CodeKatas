using System;
using System.Xml;
using System.Data;

namespace KeyNotePeopleLoader
{
    //data from the sources 
    public class DTO
    {
        public XmlDocument Xml{get; set;}  //--> from xml
        public string String { get; set; }  //--> from file
        public XmlNodeList XmlNodeList { get; set; } //--> from web-service
        public DataTable DataTable { get; set; }  //--> from database

        public DTO()
        {
            Xml = null;
            String = string.Empty;
            XmlNodeList = null;
            DataTable = null;
        }
    }
}
