using System;

namespace KeyNotePeopleLoader
{
    public static class FactoryValidator
    {   //Create the different validators
        public static IValidator Create(Source source)
        {
            IValidator result = null;

            switch (source)
            {
                case Source.DataBase:
                    result = new ValidatorDataBase();
                    break;
                case Source.File:
                    result = new ValidatorFile();
                    break;
                case Source.WebService:
                    result = new ValidatorWebService();
                    break;
                case Source.Xml:
                    result = new ValidatorXml();
                    break;

                default:
                    throw new Exception("Source not found.");
                    break;
            }

            return result;
        }
    }

    public static class FactoryDataSource
    {  //Create the different sources for getting the data.
        public static IDataSource Create(Source source)
        {
            IDataSource result = null;

            switch (source)
            {
                case Source.DataBase:
                    result = new DataSourceDataBase();
                    break;
                case Source.File:
                    result = new DataSourceFile();
                    break;
                case Source.WebService:
                    result = new DataSourceWebService();
                    break;
                case Source.Xml:
                    result = new DataSourceXml();
                    break;

                default:
                    throw new Exception("Data Source not found.");
                    break;
            }

            return result;
        }
    }
}
