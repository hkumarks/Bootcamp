using System;

public static class Array{
	public static void Resize(ref int[] buffer, int newSize){
		int[] temp= new int[newSize];
		
		for(int i=0; i<buffer.Length; i++){
			temp[i]=buffer[i];
		}
		
		buffer=temp;
	}	
}

public class DynamicIntegerArray{
   
        private int[] buffer=new int[5];
		private int itemCount;
	
		public int Capacity{
			get {return buffer.Length;}
		} 
		
		public int ItemsCount{
			get {return itemCount;}
		}
	
		public int this[int index]{
			get{ return buffer[index]; }
			
			set {
				if(index>=buffer.Length){
					Array.Resize(ref buffer,buffer.Length+1);
				}
				
				buffer[index] = value;
				itemCount+=1; 
			}
		}
		
        public void Set_Item(int index,int item){
       		if(index>=buffer.Length){
				Array.Resize(ref buffer,buffer.Length+1);
			}
			buffer[index]=item;
			itemCount+=1;
        }
       
        public int Get_Item(int index){
       
            return buffer[index];
        }
       
        public void Clear(){
       
       
        }
    }

public class Program{
        
    public static  void Main(){
        
        DynamicIntegerArray _intArray=new DynamicIntegerArray();
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
    }
        
    }
