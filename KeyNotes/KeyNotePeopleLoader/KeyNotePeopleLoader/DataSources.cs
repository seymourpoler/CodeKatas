using System;
using System.Collections.Generic;
using System.Data;
using System.Xml;

namespace KeyNotePeopleLoader
{

    //Polymophic, implements the interface
    public class DataSourceXml : IDataSource
    {
        public  DTO GetData() {

            DTO dto = new DTO();
            dto.Xml = new XmlDocument();
            return dto;
        }
    }

    public class DataSourceFile : IDataSource
    {
        public DTO GetData()
        {
            DTO dto = new DTO();
            dto.String = string.Empty;
            return dto;
        }
    }

    public class DataSourceWebService : IDataSource
    {
        public DTO GetData()
        {
            DTO dto = new DTO();
            dto.XmlNodeList = null;
            return dto;
        }
    }

    public class DataSourceDataBase : IDataSource
    {
        public DTO GetData()
        {
            DTO dto = new DTO();
            dto.DataTable = new DataTable();
            return dto;
        }
    }
}
