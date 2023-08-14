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

public class fractals extends PApplet {

//fractals

float angle = radians(0);

public void setup() {
        
    surface.setResizable(true);

    
}

public void draw() {

    
    angle += 0.001f;
      

    background(51);
    stroke(200);

  
    int len = 150;
    int shape = 4;
    translate(width/2-len/2, height/2+len/2);

    for (int i = 0; i < shape; ++i) {
        branch(len);
        rotate(radians(360/shape));
    }

}


public void branch(float length) {
     line(0, 0, 0, -length);
     translate(0, -length);
     if (length > 1) {
        
        push();
            rotate(angle);
            branch(length*0.67f);
        pop();

        push();
            rotate(-angle);
            branch(length*0.67f);    
        pop();
        
     }
}   

  public void settings() {  size(800, 800 ,P3D);  noSmooth(); }
  static public void main(String[] passedArgs) {
    String[] appletArgs = new String[] { "fractals" };
    if (passedArgs != null) {
      PApplet.main(concat(appletArgs, passedArgs));
    } else {
      PApplet.main(appletArgs);
    }
  }
}
