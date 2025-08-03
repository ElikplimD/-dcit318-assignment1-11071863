public static class TriangleTypeIdentifier
{
    public static bool IsTriangle(double a, double b, double c)
    {
        // Triangle inequality theorem
        return (a + b > c) && (a + c > b) && (b + c > a);
    }

    public static string GetTriangleType(double a, double b, double c)
    {
        if (!IsTriangle(a, b, c))
            return "Not a triangle";

        if (a == b && b == c)
            return "Equilateral";
        else if (a == b || b == c || a == c)
            return "Isosceles";
        else
            return "Scalene";
    }
}