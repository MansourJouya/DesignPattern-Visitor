using System;
using System.Collections.Generic;

/// <summary>
/// Interface for defining operations that can be performed on elements.
/// </summary>
public interface IVisitor
{
    void Visit(ConcreteElementA element);
    void Visit(ConcreteElementB element);
}

/// <summary>
/// Interface representing an element that can accept a visitor.
/// </summary>
public interface IElement
{
    void Accept(IVisitor visitor);
}

/// <summary>
/// Concrete implementation of the element A.
/// </summary>
public class ConcreteElementA : IElement
{
    /// <summary>
    /// Accepts a visitor and invokes the appropriate visit method.
    /// </summary>
    /// <param name="visitor">The visitor to accept.</param>
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }

    /// <summary>
    /// Operation specific to ConcreteElementA.
    /// </summary>
    public void OperationA()
    {
        Console.WriteLine("ConcreteElementA: OperationA() executed.");
    }
}

/// <summary>
/// Concrete implementation of the element B.
/// </summary>
public class ConcreteElementB : IElement
{
    /// <summary>
    /// Accepts a visitor and invokes the appropriate visit method.
    /// </summary>
    /// <param name="visitor">The visitor to accept.</param>
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }

    /// <summary>
    /// Operation specific to ConcreteElementB.
    /// </summary>
    public void OperationB()
    {
        Console.WriteLine("ConcreteElementB: OperationB() executed.");
    }
}

/// <summary>
/// Concrete visitor that implements operations for each element type.
/// </summary>
public class ConcreteVisitor : IVisitor
{
    /// <summary>
    /// Visits a ConcreteElementA and performs the operation.
    /// </summary>
    /// <param name="element">The ConcreteElementA to visit.</param>
    public void Visit(ConcreteElementA element)
    {
        Console.WriteLine("ConcreteVisitor: Visiting ConcreteElementA.");
        element.OperationA();
    }

    /// <summary>
    /// Visits a ConcreteElementB and performs the operation.
    /// </summary>
    /// <param name="element">The ConcreteElementB to visit.</param>
    public void Visit(ConcreteElementB element)
    {
        Console.WriteLine("ConcreteVisitor: Visiting ConcreteElementB.");
        element.OperationB();
    }
}

/// <summary>
/// Client code demonstrating the use of the Visitor pattern.
/// </summary>
public class Program
{
    /// <summary>
    /// Main entry point for the program.
    /// </summary>
    public static void Main(string[] args)
    {
        // Create elements to be visited.
        IElement elementA = new ConcreteElementA();
        IElement elementB = new ConcreteElementB();

        // Create a visitor instance.
        IVisitor visitor = new ConcreteVisitor();

        // Accept the visitor to perform operations on the elements.
        Console.WriteLine("Visiting elements:");
        elementA.Accept(visitor);
        elementB.Accept(visitor);
    }
}
