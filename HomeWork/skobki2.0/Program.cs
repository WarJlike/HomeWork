Console.WriteLine("Введите скобочную последовательность - ");
string posledovatelnost = Console.ReadLine();
void ProverkaPosledovatelnosti( string pos)
{
    Stack<char> stack = new Stack<char>();
    stack.Push('1');
    for (int i = 0; i < pos.Length; i++)
    {
        if(stack.Peek() == '(' && pos[i] == ')')
        {
            stack.Pop();
        }
        else if(stack.Peek() == '{' && pos[i] == '}')
        {
            stack.Pop();
        }
        else if(stack.Peek() == '[' && pos[i] == ']')
        {
            stack.Pop();
        }
        else stack.Push(pos[i]);

    }
    var item1 = stack.Pop();
if( item1 == '1') Console.WriteLine("Последовательность правильная");
else Console.WriteLine("Последовательность не правильная");  
}
ProverkaPosledovatelnosti(posledovatelnost);