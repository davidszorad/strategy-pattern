using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Structural
{
    /*
    Define a family of algorithms, encapsulate each one, and make them interchangeable. 
    Strategy lets the algorithm vary independently from clients that use it. 
        
    This structural code demonstrates the Strategy pattern which encapsulates functionality 
    in the form of an object. This allows clients to dynamically change algorithmic strategies.

    OUTPUT:
    Called ConcreteStrategyA.AlgorithmInterface()
    Called ConcreteStrategyB.AlgorithmInterface()
    Called ConcreteStrategyC.AlgorithmInterface()
    */

    /// <summary>
    /// Main startup class for Structural
    /// Strategy Design Pattern.
    /// </summary>
    class Main
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void MainStructural()
        {
            Context context;

            // Three contexts following different strategies
            context = new Context(new ConcreteStrategyA());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyB());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyC());
            context.ContextInterface();

            // Wait for user
            Console.ReadKey();
        }
    }
}
