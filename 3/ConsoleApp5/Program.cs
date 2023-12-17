class Programm
{
    public class MyQueue
    {
        private Stack<int> inputStack;
        private Stack<int> outputStack;

        public MyQueue()
        {
            inputStack = new Stack<int>();
            outputStack = new Stack<int>();
        }

        public void Push(int x)
        {
            inputStack.Push(x);
        }

        private void ShiftStacks()
        {
            if (outputStack.Count == 0)
            {
                while (inputStack.Count > 0)
                {
                    outputStack.Push(inputStack.Pop());
                }
            }
        }

        public int Pop()
        {
            ShiftStacks();
            if (outputStack.Count > 0)
            {
                return outputStack.Pop();
            }
            throw new InvalidOperationException("Queue is empty");
        }

        public int Peek()
        {
            ShiftStacks();
            if (outputStack.Count > 0)
            {
                return outputStack.Peek();
            }
            throw new InvalidOperationException("Queue is empty");
        }

        public bool Empty()
        {
            return inputStack.Count == 0 && outputStack.Count == 0;
        }
    }
    public class MinStack
    {
        private Stack<int> stack;
        private Stack<int> minStack;

        public MinStack()
        {
            stack = new Stack<int>();
            minStack = new Stack<int>();
        }

        public void Push(int val)
        {
            stack.Push(val);

            if (minStack.Count == 0 || val <= minStack.Peek())
            {
                minStack.Push(val);
            }
        }

        public void Pop()
        {
            if (stack.Count > 0)
            {
                int popped = stack.Pop();

                if (popped == minStack.Peek())
                {
                    minStack.Pop();
                }
            }
        }

        public int Top()
        {
            if (stack.Count > 0)
            {
                return stack.Peek();
            }
            throw new InvalidOperationException("Stack is empty");
        }

        public int GetMin()
        {
            if (minStack.Count > 0)
            {
                return minStack.Peek();
            }
            throw new InvalidOperationException("Stack is empty");
        }
    }
    public static bool stack1(string s)
    {
        if (s.Length % 2 != 0)
        {
            return false;
        }
        Dictionary<char, char> dictionary = new Dictionary<char, char>
    {
        { ')', '(' },
        { '}', '{' },
        { ']', '[' }
    };

        Stack<char> stack = new Stack<char>();

        foreach (char c in s)
        {
            if (dictionary.ContainsValue(c))
            {
                stack.Push(c);
            }
            else if (dictionary.ContainsKey(c))
            {
                if (stack.Count == 0 || stack.Pop() != dictionary[c])
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        return stack.Count == 0;
    }

    static void Main()
    {

        Console.WriteLine("\n1\n");

        string input1 = "()";
        Console.WriteLine("Input: " + input1 + " Output: " + stack1(input1));
        string input2 = "()[]{}";
        Console.WriteLine("Input: " + input2 + " Output: " + stack1(input2));
        string input3 = "(]";
        Console.WriteLine("Input: " + input3 + " Output: " + stack1(input3));

        Console.WriteLine("\n3\n");

        MinStack minStack = new MinStack();
        minStack.Push(-2);
        minStack.Push(0);
        minStack.Push(-3);
        Console.WriteLine("getMin(): " + minStack.GetMin());
        minStack.Pop();
        Console.WriteLine("top(): " + minStack.Top());
        Console.WriteLine("getMin(): " + minStack.GetMin());

        Console.WriteLine("\n4\n");

        MyQueue myQueue = new MyQueue();
        myQueue.Push(1);
        myQueue.Push(2);
        Console.WriteLine("peek(): " + myQueue.Peek());
        Console.WriteLine("pop(): " + myQueue.Pop());
        Console.WriteLine("empty(): " + myQueue.Empty());

    }
}
