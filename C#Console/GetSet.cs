

    
    
 class Person
{
    private string _name;

    public string Name
    {
        get{return _name;}
        set
        {
            if(!string.IsNullOrEmpty(value))
            {
                _name = value;
            }
        }
    }
}


class Short
{
    public string Cut {get; set;}
}