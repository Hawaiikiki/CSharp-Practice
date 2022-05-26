// See https://aka.ms/new-console-template for more information
/*
1. Describe the problem generics address.

- We can write less code and code is more easily reused. Also, because there is no need to box the value type with generics, performance can be improved as well.
- Generics are type-safe as well.

* Type safe: Compiilier will validate types while compiling and throws an error if we try to assign the wrong type to a variable.

2. How would you create a list of strings, using the generic List class?

List<string> listOfStrings = new List<string>();
here, <string> is generics part. (List<T>)

3. How many generic type parameters does the Dictionary class have?

- It has 2 generic type parameters. First parameter determines the key data type and second parameter determines value data type.

4. True/False. When a generic class has multiple type parameters, they must all match.

False: They can be different types

5. What method is used to add items to a List object?

- We use generics method to add object to List. In other words, List<T>.Add(T) is the method we can use to add items to a generics List. 

6. Name two methods that cause items to be removed from a List.

- We can use .Remove(T) to remove the first occurent of a specific object from the List<T>.
- RemoveAll(Predicate<T>) removes all elements that match the conditions defined by the specified predicate. 
- Also, we can use .Clear() to remove all elements from the list<T>

7. How do you indicate that a class has a generic type parameter?

- We can indicate that a class has a generic type by adding <T> after the class name
e.g. class List<T> 

* We use generic classes to encapsulate operations that are not specific to a particular data type. 

8. True/False. Generic classes can only have one generic type parameter.

False: For example, when we create Dictionary variable, we need to specify key type and value type. Dictionary class has two generic type parameters

9. True/False. Generic type constraints limit what can be used for the generic type.

True: class List<T> where T: class will limit the generic type to be only class

* We can also do class MyClass<T,U> where T: class where U: struct

10. True/False. Constraints let you use the methods of the thing you are constraining to.

True: By declaring the constraints, we can use the operations and method calls of the constraining type

 */

// Practice working with Generics

using Day7;
using Day7.Repository;


// 1. Create a custom Stack Class
//MyStack<int> stackInt = new MyStack<int>();
//stackInt.Push(5);
//stackInt.Push(6);
//stackInt.Count();
//stackInt.Get();

// 2. Create a Generic List data structure
//MyList<int> listInt = new MyList<int> { 5, 6 };
//listInt.GetAll();
//listInt.Add(7);
//listInt.Add(8);
//listInt.GetAll(); 
//Console.WriteLine(listInt.Remove(2));

//Console.WriteLine(listInt.Contains(5));

//listInt.InsertAt(2, 0);
//listInt.GetAll();
//listInt.DeleteAt(1);
//listInt.GetAll();
//listInt.Find(1);

// 3. Implement a Generic Repository <T> class
GenericRepository<MyList<int>> gr = new GenericRepository<MyList<int>>();
gr.Add(new MyList<int> { 1});

GenericRepository<string> gr2 = new GenericRepository<string>();
gr2.Add("Hello");
gr2.Add("World!");
List<string> lst = (List<string>)gr2.GetAll();
foreach(var item in lst)
{
    Console.WriteLine(item);
}
gr2.Remove("Hello");
gr2.Save();
Console.WriteLine(gr2.GetById(0));