// See https://aka.ms/new-console-template for more information


void centuryConvert(int n)
{
    double micro = (double)(n * 3155673600000000);
    decimal nano = ((decimal)(n) * 3155673600000000000);
    Console.WriteLine(
        $"{n} centuries = {n*100} years = {n*36524} days = {n*876576} hours = {n*52594560} minutes = "+
        $"{n*3155673600} seconds = {n* 3155673600000} milliseconds = {micro} microseconds = {nano} nanoseconds"
        );
}
centuryConvert(1);
centuryConvert(5);
centuryConvert(10);

/*
Controlling Flow and Converting Types 

1. What happens when you divide an int variable by 0?

DivideByZeroException is thrown

2. What happens when you divide a double variable by 0?

DivideByZeroException is thrown

3. What happens when you overflow an int variable, that is, set it to a value beyond its
range?

When we go above the maximum value of the signed integer, the result usually becomes a negative number.

4. What is the difference between x = y++; and x = ++y;?

y++ means that increment happens after using y value, and ++y means increment happens before using y value.

5. What is the difference between break, continue, and return when used inside a loop
statement?

Break stops the loop and breaks it. Continue simply skips that loop and continue with next loops. Return is used when we reached desired result and return that result and exit the loop.

6. What are the three parts of a for statement and which of them are required?

First statement is executed before the execution of the code block, declare and initialize a local loop variable. Can't be accessed from outside of for loop
Second statement defines the condition for executing the code block.If it evaluates true, next iteration is executed. Must be a Boolean expression.
Third statement is executed every time after the code block has been executed. Defines what happens after each execution of the body of the loop. There can be multiple iterators.
all the sections of the for statement are optional.
for ( ; ;){
    infinite for loop
}

7. What is the difference between the = and == operators?
= is used to assigns value and == is an operator used to compare two values and return Boolean.

8. Does the following statement compile? for ( ; true; ) ;

Statement compiles. 

9. What does the underscore _ represent in a switch expression?

underscore(_) is used to replace default case. 

10. What interface must an object implement to be enumerated over by using the foreach
statement?

Object must implements System.Collections.IEnumerable or System.Collections.Generic.IEnumerable<T>

 */

// for loops

