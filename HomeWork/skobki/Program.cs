Console.WriteLine("Введите скобочную последовательность - ");
string posledovatelnost = Console.ReadLine();
//string[] posledovatelnost = new string[]{"(","(","[","{","}","{","}","]",")",")"};

string[] Translate( string test)
{
string[] posledovatelnost = new string[test.Length];
for (int i = 0; i < test.Length; i++)
{
    posledovatelnost[i] = $"{test[i]}";
}
return posledovatelnost;
}

void ProverkaPosledovatelnosti( string[] pos)
{
    var stack = new Stack<string>();
    stack.Push("1");
    for (int i = 0; i < pos.Length; i++)
    {
        if(stack.Peek() == "(" && pos[i] == ")")
        {
            stack.Pop();
        }
        else if(stack.Peek() == "{" && pos[i] == "}")
        {
            stack.Pop();
        }
        else if(stack.Peek() == "[" && pos[i] == "]")
        {
            stack.Pop();
        }
        else stack.Push(pos[i]);

    }
    var item1 = stack.Pop();
if( item1 == "1") Console.WriteLine("Последовательность правильная");
else Console.WriteLine("Последовательность не правильная");  
}
ProverkaPosledovatelnosti(Translate(posledovatelnost));