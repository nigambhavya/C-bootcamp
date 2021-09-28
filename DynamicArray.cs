using System;
 
namespace Examples{

    public class Array{

        public static void Rsize(ref int[] source,int resize){

            int[] temp =new int[resize];
            for(int i=0;i<source.Length;i++){

                temp[i]=source[i];
            }
            source=temp;
        }
    }

    public class DynamicIntegerArray{

        private int[] buffer=new int[5];
		private int itemsCount, capacity;
		public int ItemsCount
		{
			get
			{
				return this.itemsCount;
			}
				}
		
		public int Capacity
		{
			get
			{
				return buffer.Length;
			}
		}
		
		public int this[int index]
		{
			get{
				return buffer[index];
			}
			
			set{
				if(index>=buffer.Length){

                Array.Rsize(ref buffer,index +10);
            }
			buffer[index] = value;
			itemsCount++;
				
			}
		}
        public void Clear(){


        }
    }

    public class Program{

    public static  void Main(){

        DynamicIntegerArray _intArray=new DynamicIntegerArray();
		_intArray[0]=12;
		 _intArray[1]=211;
		 _intArray[2]=32;
		 _intArray[3]=444;
		 _intArray[4]=4;
		 _intArray[5]=61;
		 _intArray[6]=11;
		 _intArray[7]=99;
		 _intArray[8]=12;
	        int _value=_intArray[8];
             Console.WriteLine(_value);
        Console.WriteLine(_intArray.ItemsCount);
        Console.WriteLine(_intArray.Capacity);
    }

    }
 
}
