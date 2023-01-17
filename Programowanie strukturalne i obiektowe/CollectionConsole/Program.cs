using System;

namespace CollectionConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCollection testCollection = new TestCollection();
            // testCollection.TestArrayCollection();
            //testCollection.TestObjectArrayCollection();

            TestListCollection testListCollection = new TestListCollection();
            testListCollection.FirstTest();
        }
    }
}
