/*---------------------------------------------
整理自用 C# WinForm 常用Ui组件
适用版本：.Net 4.6 (32、64位)
设计：Song Qiao Ke  
          Email: Qiaoke_Song@163.com
          QQ：2452243110
最后更新：2018.2.23
-----------------------------------------------*/


using System;
using System.Drawing;

public struct Vector
{
    double _x, _y;

    public Vector(double x, double y)
    {
        _x = x; _y = y;
    }
    public Vector(PointF pt)
    {
        _x = pt.X;
        _y = pt.Y;
    }
    public Vector(PointF st, PointF end)
    {
        _x = end.X - st.X;
        _y = end.Y - st.Y;
    }

    public double X
    {
        get { return _x; }
        set { _x = value; }
    }

    public double Y
    {
        get { return _y; }
        set { _y = value; }
    }

    public double Magnitude
    {
        get { return Math.Sqrt(X * X + Y * Y); }
    }

    public static Vector operator +(Vector v1, Vector v2)
    {
        return new Vector(v1.X + v2.X, v1.Y + v2.Y);
    }

    public static Vector operator -(Vector v1, Vector v2)
    {
        return new Vector(v1.X - v2.X, v1.Y - v2.Y);
    }

    public static Vector operator -(Vector v)
    {
        return new Vector(-v.X, -v.Y);
    }

    public static Vector operator *(double c, Vector v)
    {
        return new Vector(c * v.X, c * v.Y);
    }

    public static Vector operator *(Vector v, double c)
    {
        return new Vector(c * v.X, c * v.Y);
    }

    public static Vector operator /(Vector v, double c)
    {
        return new Vector(v.X / c, v.Y / c);
    }

    public double CrossProduct(Vector v)
    {
        return _x * v.Y - v.X * _y;
    }

    public double DotProduct(Vector v)
    {
        return _x * v.X + _y * v.Y;
    }

    public static bool IsClockwise(PointF pt1, PointF pt2, PointF pt3)
    {
        Vector V21 = new Vector(pt2, pt1);
        Vector v23 = new Vector(pt2, pt3);
        return V21.CrossProduct(v23) < 0;
    }

    public static bool IsCCW(PointF pt1, PointF pt2, PointF pt3)
    {
        Vector V21 = new Vector(pt2, pt1);
        Vector v23 = new Vector(pt2, pt3);
        return V21.CrossProduct(v23) > 0;
    }

    public static double DistancePointLine(PointF pt, PointF lnA, PointF lnB)
    {
        Vector v1 = new Vector(lnA, lnB);
        Vector v2 = new Vector(lnA, pt);
        v1 /= v1.Magnitude;
        return Math.Abs(v2.CrossProduct(v1));
    }
    
    public void Rotate(int Degree)
    {
        double radian = Degree * Math.PI / 180.0;
        double sin = Math.Sin(radian);
        double cos = Math.Cos(radian);
        double nx = _x * cos - _y * sin;
        double ny = _x * sin + _y * cos;
        _x = nx;
        _y = ny;
    }

    public PointF ToPointF()
    {
        return new PointF((float)_x, (float)_y);
    }
}
