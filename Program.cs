using System;

public class Program {
	static void Main(string[]args) {
		int[] numberarray = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
    int result = 0;
    foreach (int i in numberarray) {
      if(i % 2 == 0) {
        result += i;
      }
      else {
        Console.WriteLine("");
      }
    }
    Console.WriteLine(result);
	}
}
