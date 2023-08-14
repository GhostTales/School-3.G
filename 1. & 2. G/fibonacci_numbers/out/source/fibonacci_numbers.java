import processing.core.*; 
import processing.data.*; 
import processing.event.*; 
import processing.opengl.*; 

import java.util.HashMap; 
import java.util.ArrayList; 
import java.io.File; 
import java.io.BufferedReader; 
import java.io.PrintWriter; 
import java.io.InputStream; 
import java.io.OutputStream; 
import java.io.IOException; 

public class fibonacci_numbers extends PApplet {
  public void setup() {


// fibonacci with math
//    void setup() {
//         long count = 93, num1 = 0, num2 = 1;
//         for (int i = 1; i <= count; ++i) {
//             println(num1+" ");
//             long sumOfPrevTwo = num1 + num2;
//             num1 = num2;
//             num2 = sumOfPrevTwo; 
//         }
//     }


// fibonacci with array
// max size is 93 before it reaches integer limit
// amount is the length of the array and if it is a negative number it gets converted to a positive
// if amount is 1, 2 or 0 prints appropriate places in Fibonacci sequence
// uses round for decimal numbers

// max size of array is 93 before it reaches the limit of a long
// uses round() for decimal numbers
int fibNumbers = -93;

int amount = round(constrain(fibNumbers, 0, 93));

    long[] fib = new long[amount];
if (amount >= 3) {
    fib[1] = fib[2] = 1;
    for (int i = 2; i < amount; ++i) {
        fib[i] = fib[i-1] + fib[i-2];
    } println(fib);
} 

// if amount is 1, 2 or 0 prints appropriate places in Fibonacci sequence
else if (amount == 2) {
    fib[1] = 1;
    println(fib);
} else if (amount == 1) {
    println(fib);
} else if (amount == 0) {
    println("unable");
}
    noLoop();
  }

  static public void main(String[] passedArgs) {
    String[] appletArgs = new String[] { "fibonacci_numbers" };
    if (passedArgs != null) {
      PApplet.main(concat(appletArgs, passedArgs));
    } else {
      PApplet.main(appletArgs);
    }
  }
}
