public class Shape
{
    private string _color;

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public Shape(string color)
    {
        SetColor(color);
    }

    //An abstract method would make more sense here, but the instructions said to use a virtual method
    public virtual double GetArea()
    {
        return 0;
    }
}

