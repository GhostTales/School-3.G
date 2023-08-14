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

public class fuzzbizz extends PApplet {
  public void setup() {


    for (int i = 0; i <= 100; ++i) {
        
        if (i%3 == 0 && i%5 == 0) {
            println("FuzzBizz");
        }
        else if (i%3 == 0) {
            println("Fuzz");
        }
        else if (i%5 == 0) {
            println("Bizz");
        }
        else {
            println(i);
        }

    }
    exit();


    noLoop();
  }

  static public void main(String[] passedArgs) {
    String[] appletArgs = new String[] { "fuzzbizz" };
    if (passedArgs != null) {
      PApplet.main(concat(appletArgs, passedArgs));
    } else {
      PApplet.main(appletArgs);
    }
  }
}
