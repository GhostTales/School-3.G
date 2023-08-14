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

public class tablet_sens extends PApplet {
  public void setup() {

// set your preferred min and max width of tablet area plus the ratio you want
float min = 80, max = 120, ratio = 1.41f;




    boolean perfect = false;
    for (float f = min; f <= max; ++f) {
        if (f/ratio == PApplet.parseInt(f/ratio)) {
            println(f + " x " + f/ratio);
            perfect = true;
        }
    }
    if (perfect == false) {
        println("no perfect values");
    }
    exit();



    noLoop();
  }

  static public void main(String[] passedArgs) {
    String[] appletArgs = new String[] { "tablet_sens" };
    if (passedArgs != null) {
      PApplet.main(concat(appletArgs, passedArgs));
    } else {
      PApplet.main(appletArgs);
    }
  }
}
