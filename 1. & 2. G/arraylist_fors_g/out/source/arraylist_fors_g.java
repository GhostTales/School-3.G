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

public class arraylist_fors_g extends PApplet {
  public void setup() {





 for (int t = 0; t < 10; ++t) {
        IntList numbers;
        numbers = new IntList();
        int time = 0;

        for (int i = 0; i < 100; ++i) {
        numbers.append(round(random(100)));
    

        time = millis();
            for (int j = 0; j < 1000000; j++) {
            numbers.reverse();
       }

    }
        
      println(millis() - time);
 }
    noLoop();
  }

  static public void main(String[] passedArgs) {
    String[] appletArgs = new String[] { "arraylist_fors_g" };
    if (passedArgs != null) {
      PApplet.main(concat(appletArgs, passedArgs));
    } else {
      PApplet.main(appletArgs);
    }
  }
}
