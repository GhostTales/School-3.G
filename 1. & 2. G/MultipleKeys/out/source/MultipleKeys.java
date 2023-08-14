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

public class MultipleKeys extends PApplet {

//https://processing.org/discourse/beta/num_1196108305.html
//Kan klare 4 tastetryk. Nogle gange 5 eller 6 på vores arbejdsPC
int nrKeys = 0;
PFont font;
boolean[] downKeys = new boolean[256];

public void setup() {
 
 fill(255);
 font = createFont("Courier", 20);
 textFont(font);
}

public void draw() {
 background(0);
 nrKeys = 0;
 for (int i=0; i<downKeys.length; i++) {
   if (downKeys[i]) {
     nrKeys++;
     text((char)i, 10*nrKeys,height/2);
   }
 }
 text("Nr. of Keys: " + nrKeys, 20,20);
}

public void keyPressed() {
 println(key);
 if (key<256) {
   downKeys[key] = true;
 }
}

public void keyReleased() {
 if (key<256) {
   downKeys[key] = false;  
 }
}
  public void settings() {  size(200,200); }
  static public void main(String[] passedArgs) {
    String[] appletArgs = new String[] { "MultipleKeys" };
    if (passedArgs != null) {
      PApplet.main(concat(appletArgs, passedArgs));
    } else {
      PApplet.main(appletArgs);
    }
  }
}
