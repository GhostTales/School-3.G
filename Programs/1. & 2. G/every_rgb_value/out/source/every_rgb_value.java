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

public class every_rgb_value extends PApplet {
  public void setup() {



// for (int r = 16; r < 235; ++r) {
//     for (int g = 16; g < 235; ++g) {
//         for (int b = 16; b < 235; ++b) { 
//             println("rgb: " + r + ", " + g + ", " + b);
//         }
//     }
// }
// exit();


    int seconds = 0, minutes = 0;
  float timer = frameCount % frameRate;
  if (timer >= frameRate-1) {
    seconds ++;

    } else if (seconds >= 60) {
    seconds = 0;
    minutes ++;
  }

  println(minutes + ":" + seconds);
    noLoop();
  }

  static public void main(String[] passedArgs) {
    String[] appletArgs = new String[] { "every_rgb_value" };
    if (passedArgs != null) {
      PApplet.main(concat(appletArgs, passedArgs));
    } else {
      PApplet.main(appletArgs);
    }
  }
}
