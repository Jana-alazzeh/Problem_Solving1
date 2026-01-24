/* task is to create a function that does four basic mathematical operations.

The function should take three arguments - operation(string/char), value1(number), value2(number).
The function should return result of numbers after applying the chosen operation.

Examples(Operator, value1, value2) --> output
('+', 4, 7) --> 11
('-', 15, 18) --> -3
('*', 5, 5) --> 25
('/', 49, 7) --> 7 */

using System;


double result = MyOps.basicOp('+', 42, 7);
double r = MyOps.basicOp('-', 42, 7);
double re = MyOps.basicOp('*', 42, 7);
double res = MyOps.basicOp('/', 42, 7);



Console.WriteLine($"The result is: {result}");

// تغيير اسم الكلاس لتجنب الخطأ
public static class MyOps 
    
{
    public static double basicOp(char op, double val1, double val2)
    {
        switch (op)
        {
            case '+': return val1 + val2;
            case '-': return val1 - val2;
            case '*': return val1 * val2;
            case '/': return val1 / val2;
            default: return 0;
        }
    }



/*For every positive integer N, there exists a unique sequence starting with 1 and ending with N and such that every number in the sequence is either the double of the preceeding number or the double plus 1.

For example, given N = 13, the sequence is [1, 3, 6, 13], because . . . :

 3 =  2*1 +1
 6 =  2*3
 13 = 2*6 +1
Write a function that returns this sequence given a number N. Try generating the elements of the resulting list in ascending order, i.e., without resorting to a list reversal or prependig the elements to a list.*/

    







    



    
}
