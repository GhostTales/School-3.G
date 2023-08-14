import processing.core.*; 
import processing.data.*; 
import processing.event.*; 
import processing.opengl.*; 

import processing.video.*; 

import java.util.HashMap; 
import java.util.ArrayList; 
import java.io.File; 
import java.io.BufferedReader; 
import java.io.PrintWriter; 
import java.io.InputStream; 
import java.io.OutputStream; 
import java.io.IOException; 

public class image_Blobs extends PApplet {

//video blobs


Movie video;

int rows, cols; 
float speed;
int pixelColor;


//PImage image;

public void setup() {

   // program resolution is 32 by 9
    
    frameRate(30);
    noStroke();
    
    rectMode(CENTER);

    video = new Movie(this, "video3.mp4");
    video.loop();
    
}

public void draw() {
     
    //PImage image = loadImage("neonCity.jpg");
    image(video, width/2, 0, width/2, height);
    
    blocks();

    println(frameRate);

    fill(140, 150);
    rect(0, height, width*2, 10);
    
    fill(255, 0, 0);
    
    rect(0, height, width/video.duration() * video.time()*2, 10, 90);
    text(PApplet.parseInt(video.time()) + " / " + PApplet.parseInt(video.duration()), 10, height - 10); 
    video.speed(speed);
    speed = 1;
    
}

public void movieEvent(Movie m) {
  m.read();
}

public void keyPressed() {
    if (key == 'a') {
        speed = 0.25f;
      
    } 
    
    else if (key == 'd') {
        speed = 15;
      
    } 
    
    
}  

public void blocks() {
    
    rows = 0;

    while(rows < width/2) {
        
        
        cols = 0;
        
        while(cols < height) {
            int pixelColor = get(rows + width/2, cols);
            fill(pixelColor);
            rect(rows, cols, random(1.5f, 3), random(1.5f, 3));
            // random(0, 12), random(0, 12)
            cols += 2;
        }
        
        rows += 2;
    }
    
}
  public void settings() {  size(1920, 540);  noSmooth(); }
  static public void main(String[] passedArgs) {
    String[] appletArgs = new String[] { "image_Blobs" };
    if (passedArgs != null) {
      PApplet.main(concat(appletArgs, passedArgs));
    } else {
      PApplet.main(appletArgs);
    }
  }
}
