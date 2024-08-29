Imports System.Math
Imports "Triangle3.c"
DIM r AS DOUBLE
DIM theta AS DOUBLE
DIM phi AS DOUBLE
Function Sphere(ByVal X , ByVal Y , ByVal Z ) As SphereCoordinate
    
    r = Sqrt(X * X + Y * Y + Z * Z)
    theta = Atan2(Y, X)
    phi = Atan2(Sqr(X * X + Y * Y), Z)
  
Byval X = r * SIN(theta) * COS(phi)
Byval Y = r * SIN(theta) * SIN(phi)
Byval Z = r * COS(theta)
Redim X ^ 2 + Y ^ 2 = Z ^ 2
