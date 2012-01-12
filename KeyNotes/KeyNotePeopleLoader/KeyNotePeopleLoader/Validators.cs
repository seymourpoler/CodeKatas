using System;
using System.Collections.Generic;
using System.Data;
using System.Xml;

namespace KeyNotePeopleLoader
{
    

    public class ValidatorDataBase : IValidator
    {
        public  bool Validate(DTO dto)
        {
            bool result = true;
            DataTable table = dto.DataTable;
            return result;
        }
    }

    public class ValidatorFile : IValidator
    {
        public  bool Validate(DTO dto)
        {
            bool result = true;
            string value = dto.String;
            return result;
        }
    }

    public class ValidatorWebService : IValidator
    {
        public  bool Validate(DTO dto)
        {
            bool result = true;
            XmlNodeList nodeList = dto.XmlNodeList;
            return result;
        }
    }

    public class ValidatorXml : IValidator
    {
        public  bool Validate(DTO dto)
        {
            bool result = true;
            XmlDocument xml = dto.Xml;
            return result;
        }
    }
}
