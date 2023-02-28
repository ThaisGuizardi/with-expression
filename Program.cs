
#region Example 01

var objOne = new { A = 1, B = 2 };

var objTwo = objOne with { B = 3 };

Console.WriteLine($"objOne: {objOne}");

Console.WriteLine($"objTwo: {objTwo}");

#endregion

Console.WriteLine("\n");

#region Example 02

Test testOne = new Test(1, 2, 3, 4, 5, 6, 7, 8);

Test testTwo = testOne with { A = 10, C = 30 };

Console.WriteLine($"testOne: {testOne}");

Console.WriteLine($"testTwo: {testTwo}");

#endregion

Console.Read();

record Test(int A, int B, int C, int D, int E, int F, int G, int H);