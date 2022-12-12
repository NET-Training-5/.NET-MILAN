using System;
class Room
{
    double R_length;
    double R_width;
    public double Length
    {
        get
        {
            return R_length;
        }
        set
        {
            R_length = value < 0 ? -value : value;
        }
    }
    public double width
    {
        get
        {
            return R_width;
        }
        set
        {
            R_width = value < 0 ? -value : value;
        }
    }
    public void DisplayDimension()
    {
        Console.WriteLine("The length of room is :" + Length + "and the width of room is :" + width);

    }
    
}
class AreaOfRoom : Room
{
    string Color;
    public AreaOfRoom(string c, double l, double w)
    {
        Length = l;
        width = w;
        Color = c;
    }
    public double Area()
    {
        return Length * width;
    }
    public void DisplayColor()
    {
        Console.WriteLine("The color of room is :" + Color);
    }
}