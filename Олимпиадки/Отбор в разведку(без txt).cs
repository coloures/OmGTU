using System;
class HelloWorld {
  static void Main() {
    int number = Convert.ToInt32(Console.ReadLine());
    int [] array = new int [number];
    Console.WriteLine(dividing(array));
  }
  public static int dividing (int [] array)
  {
      int sum = 0;
      int n = 0;
      int len_n = 0;
      for (; n<array.Length; n+=2)
      {
        len_n++;
      }
      int [] odd = new int [len_n];
      int t=0;
      for(n = 0; n < array.Length; n += 2)
      {
          array[n] = odd[t];
          t++;
      }
      int m = 1;
      int len_m = 0;
      for (; m<array.Length; m+=2)
      {
        len_m++;
      }
      int [] even = new int [len_m];
      t = 0;
      for (m = 1; m < array.Length; m+=2)
      {
          array[m] = even[t];
          t++;
      }
      if(even.Length == 3)
      {
        sum++;  
      }
      if(odd.Length == 3)
      {
        sum++;  
      }
      if(odd.Length <= 3 & even.Length <=3)
      {
          return sum;
      }
      else
      {
          return dividing(even) + dividing(odd) + sum;
      }
      
  }
}
