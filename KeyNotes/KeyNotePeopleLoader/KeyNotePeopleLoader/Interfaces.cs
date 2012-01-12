using System;
using System.Collections.Generic;
using System.Data;
using System.Xml;

namespace KeyNotePeopleLoader
{
    public interface IValidator
    {   //Validate the data
        bool Validate(DTO dto);
    }

    public interface IDataSource
    {   //get the data and transform it in Data Transfer Object
        DTO GetData();
    }

}
