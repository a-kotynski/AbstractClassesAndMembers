using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Virtual Modifier   - has a body {} 
 Abstract Modifier  - doesn't have a body {}
    - indicates that a class or a member is missing implementation


 Abstract Members (methods)
    - do not include implementation
    - if a member (method) is declared as abstract, the containing class needs to
      be declared as abstract too
 
 Derived Classes
    - must implement all abstract members in the base abstract class

 Abstract Classes
    - cannot be instantiated i.e. no var something = new Something();
 
 
 Why to use Abstract:
    - when you want to provide some common behaviour, while forcing other
      developers to follow your design


 */

namespace AbstractClassesAndMembers
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public abstract void Draw();
        public void Copy()
        {
            Console.WriteLine("Copy shape into  clipboard.");
        }
        public void Select()
        {
            Console.WriteLine("Select the shape.");
        }
    }
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a circle");
        }
    }
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle();
            circle.Draw();

            var rectangle = new Rectangle();
            rectangle.Draw();

            Console.ReadLine();
        }
    }
}
