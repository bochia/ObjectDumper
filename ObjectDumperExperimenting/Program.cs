using System;
using System.Collections.Generic;
using System.Text.Json;

namespace ObjectDumperExperimenting
{
    class Program
    {
        private const int numberOfObjectToCreate = 4;


        /// <summary>
        /// This method is to demonstrate how the .Dump() extension method can be used. 
        /// Notice that it can dump ANY object, which includes collections of objects. 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            var objects = CreateObjects(numberOfObjectToCreate);
            Console.WriteLine(objects.Dump());
        }


        /// <summary>
        /// Helper method to create a list of complex objects for demonstration purposes. 
        /// </summary>
        /// <param name="numberOfObjectToCreate"></param>
        /// <returns></returns>
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
