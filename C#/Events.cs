using System;
                    
public class SearchWindow{ 

    Button _clearButton=new Button();
    TextBox _searchBox=new TextBox();
	public SearchWindow(){
		Action eventObj =new Action(_searchBox.Clear);
		_clearButton.Click+=eventObj;
	}
    public void SimulateClearButtonClick(){
        _clearButton.OnClick();
    }
}
public class Button{
    
    //Event  Click	
	public event Action Click;
    
    public void OnClick(){
		if(this.Click!=null)
            this.Click.Invoke();
        //
    }
}
public class TextBox{

    public void Clear(){
        Console.WriteLine("TextBox Content Cleared");
    }
}
public class Program
{
    public static void Main()
    {
		
        SearchWindow _searchWindow=new SearchWindow();
		
        while(true){
            Console.WriteLine("Press Any Key To Click Clear Button");
            System.Threading.Tasks.Task.Delay(1000).Wait();
            _searchWindow.SimulateClearButtonClick();
        }
    }
}