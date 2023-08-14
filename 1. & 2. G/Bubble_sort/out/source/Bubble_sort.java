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

public class Bubble_sort extends PApplet {

// Bubble sort
// https://www.youtube.com/watch?v=67k3I2GxTH8

float[] values;
int i = 0;
int j = 0;


public void setup() {
    
    values = new float[width];
    for (int i = 0; i < values.length; ++i) {
        values[i] = random(height);
    }

}

public void draw() {
    background(50);
    for (int n = 0; n < 2; n++) {
    if (i < values.length) {
         for (int j = 0; j < values.length-i-1; ++j){
            float a = values[j];
            float b = values[j+1]; 
            if (a > b) {
                swap(values, j, j+1);
                }
            }
        
    } else {
        println("finished");
        noLoop();
        }
        i++;
    }
    for (int i = 0; i < values.length; ++i) {
        stroke(255);
        line(i, height, i, height - values[i]);
    }
}

public void swap(float[] arr, int a, int b) {
    float temp = arr[a];
    arr[a] = arr[b];
    arr[b] = temp;

}
  public void settings() {  size(1280, 720); }
  static public void main(String[] passedArgs) {
    String[] appletArgs = new String[] { "Bubble_sort" };
    if (passedArgs != null) {
      PApplet.main(concat(appletArgs, passedArgs));
    } else {
      PApplet.main(appletArgs);
    }
  }
}
