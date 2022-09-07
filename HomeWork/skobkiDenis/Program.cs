bool CheckSequens(String sequens)
{
    if (sequens.Length%2==1) return false;
    else
    {
    Stack<char>mystack = new Stack<char>();
                                                                 

    for(int i = 0; i <= sequens.Length-1; i++)
    {
        
        if(sequens[i]=='{' || sequens[i]=='[' ||sequens[i]=='(')
        {
            mystack.Push(sequens[i]);
        }
        else if(sequens[i]=='}' || sequens[i]==']' || sequens[i]==')')
        {
            if (mystack.Count==0) return false;
            if(CompareChar(mystack.Pop(), sequens[i])==false) return false;
        }
    }
     return true;
    }
}


 bool CompareChar(char a, char b)
{

    if (a == '(' && b== ')' || a == '[' && b == ']' || a == '{' && b== '}') return true ;
    else return false;

}


Console.WriteLine("Введите последовательность скобок: ");
string seq = Console.ReadLine();
if (CheckSequens(seq) == true) Console.WriteLine("Последовательность правильная");
else Console.WriteLine("Последовательность неправильная");
