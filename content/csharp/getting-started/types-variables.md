# Learning About Built-In Types and Variables

## C# Identifiers
An identifier is a name used to identify a class, variable, function, or any other user-defined item. The basic rules for naming classes in C# are as follows −

A name must begin with a letter that could be followed by a sequence of letters, digits (0 - 9) or underscore. The first character in an identifier cannot be a digit.

It must not contain any embedded space or symbol such as? - + ! @ # % ^ & * ( ) [ ] { } . ; : " ' / and \. However, an underscore ( _ ) can be used.

It should not be a C# keyword.

```{class=snippet}
class Calculation
class Demo
void display()
void getMarks()
int a;
int marks;
int rank;
double res_marks;
```

## C# data type

Common datatype: 
![alt text](https://www.theengineeringprojects.com/wp-content/uploads/2018/02/introduction-to-data-types-in-C-1.png "data type")

Datatype structure
![alt text](https://www.theengineeringprojects.com/wp-content/uploads/2018/02/introduction-to-data-types-in-C-Sharp-768x541.jpg "data type")

## Adding Variables

In this lesson, you'll create a simple Hello World program, and then you'll learn how you can customize the behavior of the program by adding variables to it.

This simple program just prints "Hello World!" to the console:

```{class=snippet}
Console.WriteLine("Hello World!");
```
```{class=REPL}
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello World!");
    }
}
```

> **Tip** {.tip .newLanguage }    
> It's programming tradition that the first program one writes in a new language print out the phrase, "Hello World".

You can change this greeting to be more personalized by using a variable. On the line above this one, you can add a variable that holds your name, like this:

```c#
var name = "Steve"; // use your name here
```

There are a few new elements to this line of code. First, you're using a C# keyword, ``var``, which you can think of as *variable*. The ``var`` keyword is shorthand for whatever the type on the other side of the assignment operator (``=``) might be. In this case, the value in double quotes (``"Steve"`` in the example above) is a *string*. Strings are one of the built-in types in C#, and are used to represent text values. You can also declare a variable by specifying its type explicitly. In this example, the equivalent statement would be ``string name = "Steve";``.

> **Tip** {.tip .javascript}    
> Although Javascript also uses ``var`` for variable declaration, don't let that confuse you. The C# ``var`` is strongly typed, meaning that unlike Javascript's dynamic type system, the variable being declared will be of a specific type, just as if that type's name had been used to declare it.   

The ``//`` on the line represents a single-line comment. Everything on the line that follows these two characters is ignored by the compiler. You can use these comments on a line all by themselves, or following other code as in this case. Comments are useful for explaining why you're doing something a certain way in your application, but avoid the temptation to overuse them or to use them to explain complicated code. A better solution is to make the code less complicated.

Now that you have a variable representing your name, you can use it in the next line so that the program greets *you*, rather than the world. To do that, remove the word *World* and replace it with ``{name}``. Note that these are curly braces around the name of the variable. By using this convention, you're letting C# know that you want it to substitute the value of the variable ``name`` in that location. The last thing you need to do for this convention to work is prefix the string with a ``$`` sign. When completed, the two lines of code should look like this:

```{.snippet}
var name = "Steve"; // use your name here
Console.WriteLine($"Hello {name}!");
```
```{.REPL}
using System;

class Program
{
    static void Main()
    {
        var name = "Steve"; // use your name here
        Console.WriteLine($"Hello {name}!");
    }
}
```

Run the program. 

> **Tip** {.tip .CLI}    
> From a command prompt in the project folder, you can run the program by typing ``dotnet run``.

> **Tip** {.tip .visualstudio}    
> Within Visual Studio, ctrl+F5 will run the console application, launching a new console window.

You should see the output that includes your name (or "Steve" if you decided to just use the code above).


## C# Comment
Comments can be used to explain C# code, and to make it more readable. It can also be used to prevent execution when testing alternative code.

Single-line comments start with two forward slashes (//).
Any text between // and the end of the line is ignored by C# (will not be executed).
This example uses a single-line comment before a line of code:

```{.snippet}
Console.WriteLine("Hello World!");  // This is a comment
```

## C# Multi-line Comments
Multi-line comments start with /* and ends with */.
Any text between /* and */ will be ignored by C#.
This example uses a multi-line comment (a comment block) to explain the code:

```{.snippet}
/* The code below will print the words Hello World
to the screen, and it is amazing */
Console.WriteLine("Hello World!"); 
```

## Static keyword in C#
static is a modifier in C# which is applicable for the following:
- Classes
- Variables
- Methods
- Constructor
It is also applicable to properties, event, and operators. To create a static member(class, variable, methods, constructor), precede its declaration with the keyword static. When a member is declared static, it can be accessed with the name of its class directly.

A static class is declared with the help of static keyword. A static class can only contain static data members, static methods, and a static constructor. It is not allowed to create objects of the static class. Static classes are sealed, means one cannot inherit a static class from another class.
```C#
// C# program to illustrate the 
// concept of a static class 
using System; 
  
// Creating static class 
// Using static keyword 
static class Tutorial { 
  
    // Static data members of Tutorial 
    public static string Topic = "Static class"; 
} 
  
// Driver Class 
public class GFG { 
  
    // Main Method 
    static public void Main() 
    { 
  
        // Accessing the static data members of Tutorial 
        Console.WriteLine("Topic name is : {0} ", Tutorial.Topic); 
    } 
} 
```
### Static Variable
A static variable is declared with the help of static keyword. When a variable is declared as static, then a single copy of the variable is created and shared among all objects at the class level. Static variables are accessed with the name of the class, they do not require any object for access.
```c#
// C# program to illustrate the 
// concept of static varaible 
using System; 
  
class Vehicle { 
  
    // Creating static variable 
    // Using static keyword 
    public static string Model_color = "Black"; 
} 
  
// Driver Class 
public class GFG { 
  
    // Main Method 
    static public void Main() 
    { 
  
        // Accessing the static variable 
        // using its class name 
        Console.WriteLine("Color of XY model is  : {0} ", 
                                    Vehicle.Model_color); 
    } 
} 
```
### Static Method
A static method is declared with the help of static keyword. Static methods are accessed with the name of the class. A static method can access static and non-static fields, static fields are directly accessed by the static method without class name whereas non-static fields require objects.
```c#

// C# program to illustrate the 
// concept of static method 
using System; 
  
class Nparks { 
  
    static public int t = 104; 
  
    // Creating static method 
    // Using static keyword 
    public static void total() 
    { 
        Console.WriteLine("Total number of national parks"+ 
                           " present in India is :{0}", t); 
    } 
} 
  
// Driver Class 
public class GFG { 
  
    // Main Method 
    static public void Main() 
    { 
  
        // Accessing the static method 
        // using its class name 
        Nparks.total(); 
    } 
} 
```
### Limitation of using static keyword:
- static keyword cannot be used by indexers, finalizers, or types other than classes.
- A static member is not referenced through an instance.
- In C#, it is not allowed to use this to reference static methods or property accessors.
- In C#, if static keyword is used with the class, then the static class always contain static members.


## Next Steps

Create another variable to represent the greeting. Change the ``Console.WriteLine`` statement to construct the greeting from your new greeting variable and the name variable used above. You'll learn more about working with strings like this in the next lesson.

<!--
(possible exercise once ReadLine is available in REPL)
Using just the ``ReadLine`` and ``WriteLine`` methods and your current knowledge of variables, you can have the user pass in quite a few bits of information. Using this approach, create a console application that asks the user a few questions and then generates some custom output for them. For instance, your program could generate their "hacker name" by asking them their favorite color, their astrology sign, and their street address number. The result might be something like "Your hacker name is RedGemini480."
-->
