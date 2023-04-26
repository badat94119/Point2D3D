using System;

class Point2D
{
    private int x;
    private int y;

    public Point2D(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public int GetX()
    {
        return x;
    }

    public int GetY()
    {
        return y;
    }

    public void SetX(int x)
    {
        this.x = x;
    }

    public void SetY(int y)
    {
        this.y = y;
    }
}

class Point3D : Point2D
{
    private int z;

    public Point3D(int x, int y, int z) : base(x, y)
    {
        this.z = z;
    }

    public int GetZ()
    {
        return z;
    }

    public void SetZ(int z)
    {
        this.z = z;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Point2D point2d = new Point2D(2, 3);

        if (point2d.GetX() == 2 && point2d.GetY() == 3)
        {
            Console.WriteLine("Test for Point2D passed.");
        }
        else
        {
            Console.WriteLine("Test for Point2D failed.");
        }

        point2d.SetX(4);
        point2d.SetY(5);

        if (point2d.GetX() == 4 && point2d.GetY() == 5)
        {
            Console.WriteLine("Test for Point2D passed.");
        }
        else
        {
            Console.WriteLine("Test for Point2D failed.");
        }

        Point3D point3d = new Point3D(1, 2, 3);

        if (point3d.GetX() == 1 && point3d.GetY() == 2 && point3d.GetZ() == 3)
        {
            Console.WriteLine("Test for Point3D passed.");
        }
        else
        {
            Console.WriteLine("Test for Point3D failed.");
        }

        point3d.SetZ(4);

        if (point3d.GetZ() == 4)
        {
            Console.WriteLine("Test for Point3D passed.");
        }
        else
        {
            Console.WriteLine("Test for Point3D failed.");
        }

        point3d.SetX(5);
        point3d.SetY(6);

        if (point3d.GetX() == 5 && point3d.GetY() == 6 && point3d.GetZ() == 4)
        {
            Console.WriteLine("Test for Point3D passed.");
        }
        else
        {
            Console.WriteLine("Test for Point3D failed.");
        }
    }
}
