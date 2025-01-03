

using Linear_Stack_;

CustumStack<int> custumStack = new();


custumStack.Push(5); 
custumStack.Push(6); 
custumStack.Push(7);
Console.WriteLine(custumStack.Count);

Console.WriteLine(custumStack.Peek());


Console.WriteLine(new string('*', 40));

custumStack.Pop();



foreach (var item in custumStack.List)
{
    Console.WriteLine(item);
};



Console.WriteLine(new string('*', 100));

Stack<int> stack = new Stack<int>();

stack.Push(5);

stack.Peek();
Console.WriteLine(stack.Count);