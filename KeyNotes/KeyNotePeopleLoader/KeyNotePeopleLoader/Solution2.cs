using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KeyNotePeopleLoader
{
    public static class Solution2
    {
        public static void Run(Source source)
        {
            //get the data
            IDataSource dataSource = FactoryDataSource.Create(source);
            //validate the data
            IValidator validator = FactoryValidator.Create(source);

            //get the data from the source, validate it --> IOC
            Provider provider = new Provider(validator, dataSource);

            //Pattern: Template method
            List<Person> listPeople = provider.GetPeople();

            //Save the data
            RepositoryPerson bbdd = new RepositoryPerson();
            bbdd.Save(listPeople);
        }
    }
}
