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

public class medley_opg_7 extends PApplet {


/*
7 loops
. Create a loop that writes the numbers from 0 to 99 to the console
. Create a loop that writes the numbers from 1 to 10 to console .
. Create a loop that writes the 7 table to the console .
. Create two loops. The first prefix must be chore 5 times. In the body of this loop make
another loop which is repeated 10 times. In the inner forelock, print the product of the two
variables that you use to control your loops to consol. Before you run the program,
what do you expect to see?
*/

public void setup() {

    for (int i = 0; i < 100; ++i) {
    println(i);
    }
    println("_______________________");

    for (int j = 0; j < 11; ++j) {
    println(j);
    }
    println("_______________________");

    for (int t7 = 0; t7 < 11; ++t7) {
    println(t7*7);
    }
    println("_______________________");

    for (int x = 0; x < 5; ++x) {
        for (int y = 0; y < 10; ++y) {
            println(x*y);
        }
    }

    exit();
}





  static public void main(String[] passedArgs) {
    String[] appletArgs = new String[] { "medley_opg_7" };
    if (passedArgs != null) {
      PApplet.main(concat(appletArgs, passedArgs));
    } else {
      PApplet.main(appletArgs);
    }
  }
}
