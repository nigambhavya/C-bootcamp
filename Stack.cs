using System;

namespace Examples{
 
    public class Stack{

        //State
        //Array of Integers
		static int max = 10;
		int[] stk = new int[max];
		int top = 0;
		
        //public void Push(Stack this,int item)
        public void Push(int item){  
			
			if(top >= max ){
				Console.WriteLine("Overflow");
			}
			else
				stk[++top] = item;
        }

        public int Pop(){  
			if (top < 0)
            {
                Console.WriteLine("Underflow");
                return 0;
            }
            else
            {
                int value = stk[top--];
                return value;
            }
		}

    }

    public class Program{

    public static  void Main(){

        Stack s1=new Stack();
        s1.Push(1);
        s1.Push(20);
        s1.Push(44);
        s1.Push(999);

   		int topItem=s1.Pop();
        Console.WriteLine(topItem);
        topItem=s1.Pop();
        Console.WriteLine(topItem);
        topItem=s1.Pop();
        Console.WriteLine(topItem);
        topItem=s1.Pop();
        Console.WriteLine(topItem);
    }

    }
 
}
