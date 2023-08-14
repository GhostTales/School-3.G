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

public class diff_polynomium_regner extends PApplet {
  public void setup() {

// Load the local file 'data.txt' and initialize a new InputStream
InputStream input = createInput("data.txt");

String content = "";

try {
  int data = input.read();
  while (data != -1) {
    content += data;
    data = input.read();
  }
}
catch (IOException e) {
  e.printStackTrace();
}
finally {
  try {
    input.close();
  } 
  catch (IOException e) {
    e.printStackTrace();
  }
}

println(content);
    noLoop();
  }

  static public void main(String[] passedArgs) {
    String[] appletArgs = new String[] { "diff_polynomium_regner" };
    if (passedArgs != null) {
      PApplet.main(concat(appletArgs, passedArgs));
    } else {
      PApplet.main(appletArgs);
    }
  }
}
