using System;

namespace StrategyPattern
{
    /*
    This real-world code demonstrates the Strategy pattern which encapsulates sorting algorithms 
    in the form of sorting objects. This allows clients to dynamically change sorting strategies 
    including Quicksort, Shellsort, and Mergesort. 

    
    The classes and objects participating in this pattern are:

    Strategy  (SortStrategy)
        declares an interface common to all supported algorithms. Context uses this interface 
        to call the algorithm defined by a ConcreteStrategy

    ConcreteStrategy  (QuickSort, ShellSort, MergeSort)
        implements the algorithm using the Strategy interface

    Context  (SortedList)
        is configured with a ConcreteStrategy object
        maintains a reference to a Strategy object
        may define an interface that lets Strategy access its data.
    

    OUTPUT:
    QuickSorted list
     Anna
     Jimmy
     Samual
     Sandra
     Vivek

    ShellSorted list
     Anna
     Jimmy
     Samual
     Sandra
     Vivek

    MergeSorted list
     Anna
     Jimmy
     Samual
     Sandra
     Vivek
    */

    class Program
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
            // Two contexts following different strategies
            SortedList studentRecords = new SortedList();

            studentRecords.Add("Samual");
            studentRecords.Add("Jimmy");
            studentRecords.Add("Sandra");
            studentRecords.Add("Vivek");
            studentRecords.Add("Anna");

            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();

            // Wait for user
            Console.ReadKey();
        }
    }
}