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

public class array_2d_printing extends PApplet {


    int size = 5;

public void setup() {
    frameRate(5);
    
    surface.setResizable(true);
    
 
}

public void draw() {
    int cols = width;
    int rows = height;
    fill(200);

    float[][] numbers = new float[cols][rows];
    int pixels = 0;
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < cols; j++) {
            
            rect(i * size, j * size, size, size);
            pixels++;   
        }
    }
    println("squares loaded = " + pixels/(size*size) + " | square root = " + sqrt(pixels/(size*size))); 
}



  public void settings() {  size(500,500);  noSmooth(); }
  static public void main(String[] passedArgs) {
    String[] appletArgs = new String[] { "array_2d_printing" };
    if (passedArgs != null) {
      PApplet.main(concat(appletArgs, passedArgs));
    } else {
      PApplet.main(appletArgs);
    }
  }
}
