using System;
using System.Collections.Generic;
using System.Data;
using System.Xml;

namespace KeyNotePeopleLoader
{
    //class manager. Get the data from the source and validate it
    public class Provider
    {
        private IValidator _validator;
        private  List<Person> _result;
        private IDataSource _dataSource;

        //Inversion Of Controller
        public Provider(IValidator validator, IDataSource dataSource)
        {
            _validator = validator;
            _dataSource = dataSource;
        }

        //Template method
        public virtual List<Person> GetPeople() 
        {
            List<Person> result = null;
            if (_validator.Validate(_dataSource.GetData()))
            { }

            return result;
        }
    }
}
