/*public class Point


{
    public double x,y,z;
    
    public Point()
    {
        x = 0;
        y = 0;
        z = 0;
    }
    public Point(double x, double y, double z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public double FindDistance(Point B)
    {
        return Math.Sqrt(Math.Pow(x - B.x,2) + Math.Pow(y - B.y,2) + Math.Pow(z - B.z,2));
    }

}

Point A = new Point();*/

double FindDistance(double[] A, double[] B)
{
    return Math.Sqrt(Math.Pow(A[0] - B[0],2) + Math.Pow(A[1] - B[1],2) + Math.Pow(A[2] - B[2],2));
}

double[] A = { 3, 6, 8 };
double[] B = { 2, 1, -7 };
Console.WriteLine(String.Format("{0:0.00}",FindDistance(A,B)));

A[0] = 7; A[1] = -5; A[2] = 0;
B[0] = 1; B[1] = -1; B[2] = 9;
Console.WriteLine(String.Format("{0:0.00}",FindDistance(A,B)));