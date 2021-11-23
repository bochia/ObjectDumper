using System;
using System.Collections.Generic;
using System.Text.Json;

namespace ObjectDumperExperimenting
{
    class Program
    {
        private const int numberOfObjectToCreate = 4;

        static void Main(string[] args)
        {

            var objects = CreateObjects(numberOfObjectToCreate);
            Console.WriteLine(objects.Dump());
        }

        public static IList<Object> CreateObjects(int numberOfObjectToCreate)
        {
            var objects = new List<Object>();
            var randomNumberGenerator = new Random();
            PlainOldObject obj;
            ComplexObject complexObj;

            for (int i = 0; i < numberOfObjectToCreate; i++)
            {

                obj = new PlainOldObject(randomNumberGenerator.Next(),
                                                      Guid.NewGuid().ToString());

                complexObj = new ComplexObject(randomNumberGenerator.Next(),
                                                Guid.NewGuid().ToString(),
                                                obj);

                objects.Add(complexObj);
            }

            return objects;
        }

    }
}
