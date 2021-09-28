using System;
                    
public class SearchWindow{​​​​​


    Button _clearButton=new Button();
    TextBox _searchBox=new TextBox();
    public void SimulateClearButtonClick(){​​​​​
        _clearButton.OnClick();
    }​​​​​
}​​​​​
public class Button{​​​​​
    
    //Event  Click
    
    public void OnClick(){​​​​​
    
        //
    }​​​​​
}​​​​​
public class TextBox{​​​​​


    public void Clear(){​​​​​
        Console.WriteLine("TextBox Content Cleared");
    }​​​​​
}​​​​​
public class Program
{​​​​​
    public static void Main()
    {​​​​​
        SearchWindow _searchWindow=new SearchWindow();
        while(true){​​​​​
            Console.WriteLine("Press Any Key To Click Clear Button");
            System.Threading.Tasks.Task.Delay(1000).Wait();
            _searchWindow.SimulateClearButtonClick();
        }​​​​​
    }​​​​​
}​​​​​




​[12:32 PM] venu (Guest)
    
using System;


//Publisher
public class SmartDoor{​​​​​


    public void Open(){​​​​​
    OnActionChanged("Open");
    }​​​​​
    public void Close(){​​​​​
    OnActionChanged("Close");
    }​​​​​
    
    //Events (Distributor Object)
    public event Action<string> OnAction=null; 
     
    private void OnActionChanged(string status){​​​​​
        
        if(OnAction!=null){​​​​​
            //Publisher Notifying the Distributor
            OnAction.Invoke(status);
        }​​​​​
    }​​​​​


}​​​​​


//Subscriber
public class EuroVigilanceSystem{​​​​​


    //Publisher Ref
    SmartDoor _smartDoor;
    
    public EuroVigilanceSystem(SmartDoor _doorRef){​​​​​
      _smartDoor=_doorRef;    
        //Distributor Object
        Action<string> _eventHadnlerAddress=new Action<string>(Notify);
        //Set Distributor Object @Publisher
        _smartDoor.OnAction+=_eventHadnlerAddress;
    }​​​​​
    //Event Handler 
    public void Notify(string doorStatus){​​​​​
    
        Console.WriteLine("Door Status :{​​​​​0}​​​​​",doorStatus);
    }​​​​​


}​​​​​


public class Program{​​​​​
    
    public static void Main(){​​​​​
    
        SmartDoor _publisher=new  SmartDoor();
        EuroVigilanceSystem _subscriber=new EuroVigilanceSystem(_publisher);
        _publisher.Open();
        _publisher.Close();
        
    }​​​​​
    
}​​​​​









