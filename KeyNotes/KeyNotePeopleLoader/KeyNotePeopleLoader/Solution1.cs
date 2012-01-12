using System;
using System.Xml;
using System.Data;
using System.Collections.Generic;

namespace KeyNotePeopleLoader
{
    public static class Solution1
    {
        /// <summary>
        /// Get data from different sources (xml, data-base, web-service), validate it and then save.
        /// </summary>
        /// <param name="origin"></param>
        public static void Run(string origin)
        {
            List<Person> people = null;

            if (origin == "xml")
            {
                XmlDocument xml = GetDataFromXml();
                if (ValidateDataFromXml(xml))
                {
                    people = GetPeopleFromXml(xml);
                }
            }
            else if (origin == "bbdd")
            {
                DataTable table = GetdataFromBBDD();
                if (ValidateDataFromDataTable(table))
                {
                    people = GetPeopleFromBBDD(table);
                }
            }
            else if (origin == "webservice")
            {
                XmlDocument xml = GetDataFromWebService();
                if (ValidateDtaFromWebService(xml))
                {
                    people = GetPeopleFromWebService(xml);
                }
            }

            if ((people != null) && (people.Count > 0))
                savePeople(people);
        }

        private static List<Person> GetPeopleFromXml(XmlDocument xml)
        {
            List<Person> resultado = null;
            return resultado;
        }
        private static bool ValidateDataFromXml(XmlDocument xml)
        {
            bool result = true;
            return result;
        }
        private static XmlDocument GetDataFromXml()
        {
            return new XmlDocument();
        }

        private static List<Person> GetPeopleFromWebService(XmlDocument xml)
        {
            List<Person> result = null;
            return result;
        }
        private static XmlDocument GetDataFromWebService()
        {
            return new XmlDocument();
        }
        private static bool ValidateDtaFromWebService(XmlDocument xml)
        {
            bool result = true;

            return result;
        }

        private static List<Person> GetPeopleFromBBDD(DataTable table)
        {
            List<Person> result = null;
            return result;
        }
        private static bool ValidateDataFromDataTable(DataTable table)
        {
            bool result = false;
            return result;
        }
        private static DataTable GetdataFromBBDD()
        {
            return new DataTable();
        }


        private static void savePeople(List<Person> people)
        {
        }
    }
}
