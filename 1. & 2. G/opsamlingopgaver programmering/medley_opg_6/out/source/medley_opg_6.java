import processing.core.*; 
import processing.data.*; 
import processing.event.*; 
import processing.opengl.*; 

import controlP5.*; 

import java.util.HashMap; 
import java.util.ArrayList; 
import java.io.File; 
import java.io.BufferedReader; 
import java.io.PrintWriter; 
import java.io.InputStream; 
import java.io.OutputStream; 
import java.io.IOException; 

public class medley_opg_6 extends PApplet {


ControlP5 text;

public void setup() {
  
  background(51);
  textAlign(CENTER);
  PFont font = createFont("Arial", 20);
  text = new ControlP5(this);

  text.addTextfield("Username").setPosition(20, 100).setSize(200, 40).setFocus(true).setFont(font).setAutoClear(false);
  text.addTextfield("Heltal1").setPosition(20, 200).setSize(200, 40).setFont(font).setAutoClear(false);
  text.addTextfield("Heltal2").setPosition(20, 300).setSize(200, 40).setFont(font).setAutoClear(false);
  text.addBang("Submit").setPosition(240, 300).setSize(80, 40).getCaptionLabel().align(ControlP5.CENTER, ControlP5.CENTER).setFont(font);    
}
public void draw(){}

public void Submit() {
  String username = text.get(Textfield.class,"Username").getText();
  float heltal1 = PApplet.parseFloat(text.get(Textfield.class,"Heltal1").getText());
  float heltal2 = PApplet.parseFloat(text.get(Textfield.class,"Heltal2").getText());
  
  if (heltal1 %1 != 0) {
  text.get(Textfield.class,"Heltal1").setText("invalid");
  }
  if (heltal2 %1 != 0) {
  text.get(Textfield.class,"Heltal2").setText("invalid");
  }

  heltal1 = PApplet.parseFloat(text.get(Textfield.class,"Heltal1").getText());
  heltal2 = PApplet.parseFloat(text.get(Textfield.class,"Heltal2").getText());
  
  int product = PApplet.parseInt(heltal1) * PApplet.parseInt(heltal2);
  text(username + " your product is " + product, 170, 450);
}
  public void settings() {  size(340, 500); }
  static public void main(String[] passedArgs) {
    String[] appletArgs = new String[] { "medley_opg_6" };
    if (passedArgs != null) {
      PApplet.main(concat(appletArgs, passedArgs));
    } else {
      PApplet.main(appletArgs);
    }
  }
}
