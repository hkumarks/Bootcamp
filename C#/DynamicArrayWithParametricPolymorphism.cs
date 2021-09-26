using System;

public static class Array{
	public static void Resize<T>(ref T[] buffer, int newSize){
		T[] temp= new T[newSize];
		
		for(int i=0; i<buffer.Length; i++){
			temp[i]=buffer[i];
		}
		
		buffer=temp;
	}	
}

public class DynamicIntegerArray<T>{
   
        private T[] buffer=new T[5];
		private int itemCount;
	
		public int Capacity{
			get {return buffer.Length;}
		} 
		
		public int ItemsCount{
			get {return itemCount;}
		}
	
		public T this[int index]{
			get{ return buffer[index]; }
			
			set {
				if(index>=buffer.Length){
					Array.Resize<T>(ref buffer,buffer.Length+1);
				}
				
				buffer[index] = value;
				itemCount+=1; 
			}
		}
		       
        public void Clear(){
       
       
        }
    }

public class Program{
        
    public static  void Main(){
        
        DynamicIntegerArray<int> _intArray=new DynamicIntegerArray<int>();
        _intArray[0]=10;
		_intArray[1]=20;
		_intArray[2]=30;
		_intArray[3]=40;
		_intArray[4]=50;
		_intArray[5]=60;
		_intArray[6]=70;
		_intArray[7]=80;
		_intArray[8]=90;
        
        
        int _value=_intArray[8];
		Console.WriteLine(_value);
		
		Console.WriteLine(_intArray.ItemsCount);
        Console.WriteLine(_intArray.Capacity);
		
		 DynamicIntegerArray<string> charArray=new DynamicIntegerArray<string>();
        charArray[0]="a";
		charArray[1]="b";
		charArray[2]="c";
		charArray[3]="d";
		charArray[4]="5";
		
		string _val=charArray[2];
		Console.WriteLine(_val);
    }
        
    }
