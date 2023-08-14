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

public class aproximate_PI extends PApplet {


ControlP5 button;


float r = 360;

long total = 0, circle = 0; 
int improvements = 0;
double record_PI = 0, pi;
int timer, second, minute, hour, frames = 60;
JSONObject json;

public void setup() {
    
    rectMode(CENTER);
    ellipseMode(CENTER);
    

    button = new ControlP5(this);
    buttons();
    
    translate(width/2, height/2);

    stroke(255);
    strokeWeight(3);
    noFill();
    json = loadJSONObject("data/approxData.json");

    total = json.getLong("total");
    circle = json.getLong("circle");
    improvements = json.getInt("improvements");
    record_PI = json.getDouble("record_PI");
    second = json.getInt("second");
    minute = json.getInt("minute");
    hour = json.getInt("hour");
    prints();

}

public void draw() {

    translate(width/2, height/2);
    background(51);
    stroke(255);
    ellipse(0, 0, r*2, r*2);
    rect(0, 0, r*2, r*2);
    
    for (int i = 0; i < 500000; ++i) {
        
    
    float x = random(-r, r);
    float y = random(-r, r);
    total++;

    double d = (double)x*(double)x + (double)y*(double)y;
    if (d < (double)r*(double)r) {
        circle++;
        stroke(0, 255, 0);
    } else {
        stroke(0, 0, 255);
    }
    
    point(x, y);

    double pi = (double)4 * ((double)circle / (double)total);
    double recordDiff = Math.abs(Math.PI - record_PI);
    double diff = Math.abs(Math.PI - pi);
    
    if (diff < recordDiff) {
        recordDiff = diff;
        record_PI = pi;
        improvements++;
        prints();
    }

    }
    strokeWeight(1);
    
    runtime();
    data();
}

public void save() {
  
  JSONObject json = new JSONObject();

        json.setLong("total", total);
        json.setLong("circle", circle);
        json.setInt("improvements", improvements);
        json.setDouble("record_PI", record_PI);
        json.setInt("second", second);
        json.setInt("minute", minute);
        json.setInt("hour", hour);

      saveJSONObject(json, "data/approxData.json");

}

public void prints() {
        println("best PI = " + record_PI + " | "
         + "real PI = " + (double)Math.PI + " | "
          + "improvements = " + improvements + " | "
           + "off = " + (double)(Math.abs(Math.PI - record_PI)) + " | " 
            + "\n"
             + "circle = " + circle + " | "
              + "total = " + total + " | "
               + "fps = " + frameRate + " | "
                + "frameCount = " + frameCount + " | "
                 + "clock = " + nf(hour(), 2, 0) + ":" + nf(minute(), 2, 0) + ":" + nf(second(), 2, 0) + "/" + nf(day(), 2, 0) + "/" + nf(month(), 2, 0) + " | "
                  + "time calculated = " + nf(hour, 2, 0) + ":" + nf(minute, 2, 0) + ":" + nf(second, 2, 0)
               );
}

public void data() {
  text("best PI = " + record_PI + "\n"
         + "real PI = " + (double)Math.PI + "\n"
          + "improvements = " + improvements + "\n"
           + "off = " + (double)(Math.abs(Math.PI - record_PI)) + "\n"+"\n" 
            + "approx pi = " + (double)4 * ((double)circle / (double)total) + "\n"
            + "circle = " + circle + "\n"
             + "total = " + total + "\n"+"\n"
              + "fps = " + nf(frameRate, 0, 2) + "\n"
               + "clock = " + nf(hour(), 2, 0) + ":" + nf(minute(), 2, 0) + ":" + nf(second(), 2, 0) + "/" + nf(day(), 2, 0) + "/" + nf(month(), 2, 0) + "\n"
                + "time calculated = " + nf(hour, 2, 0) + ":" + nf(minute, 2, 0) + ":" + nf(second, 2, 0), -width/2+20, -height/2+40);

}

public void runtime() {
  timer = frameCount % frames;
  if (timer >= frames-1) {
    second ++;
  }
  if (second >= 60) {
    second -= 60;
    minute ++;
  }
  if (minute >= 60) {
    minute -= 60;
    hour ++;
  }
    //auto saves the progress every 10 second
  if (second == 10) {
    save();
  }
  
}

public void buttons() {
  button.addButton("Reset").setPosition(-width/2+40, -height/2+240).setSize(200, 75)
  ;
}

public void controlEvent(CallbackEvent event) {
  
  if (event.getAction() == ControlP5.ACTION_CLICK) {
    switch(event.getController().getAddress()) {
    case "/Reset":
        total = 0;
        circle = 0; 
        improvements = 0;
        record_PI = 0;
        pi = 0;
        timer = 0; 
        second = 0; 
        minute = 0; 
        hour = 0;
      break;
    }
  }
}
  public void settings() {  size(1280,720);  noSmooth(); }
  static public void main(String[] passedArgs) {
    String[] appletArgs = new String[] { "aproximate_PI" };
    if (passedArgs != null) {
      PApplet.main(concat(appletArgs, passedArgs));
    } else {
      PApplet.main(appletArgs);
    }
  }
}
