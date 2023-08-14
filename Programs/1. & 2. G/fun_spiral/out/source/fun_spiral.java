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

public class fun_spiral extends PApplet {

int cursorSize = 60, radius = 75;
float mx[] = new float[cursorSize];
float my[] = new float[cursorSize];
float innerColorSpeed = 0.2f, thisColor;
float xBall, yBall, speedX, speedY;
float random1 = 4, random2 = 6;
PImage cursor;
int timer, seconds;
int frames = 120;


public void setup() {
  
  frameRate(frames);
  textAlign(CENTER);
  ellipseMode(CENTER);
  imageMode(CENTER);
  noStroke();
  noCursor();
  surface.setResizable(true);
  colorMode(HSB);
  cursor = loadImage("cursor.png");
  speedX = random(random1, random2);
  speedY = random(random1, random2);
  xBall = width/2; yBall = height/2;
}



public void draw()  {
  background(0);
  timer = frameCount % frames;
  if (timer >= frames-1) {
    seconds ++;
  }
  fill(200);
  textSize(24);
  text(nf(seconds,2,0) + ":" + nf(timer*10/(frames/10) ,2,0), width/2, 40);
  fill(100,360,360);
  text((int)frameRate + " FPS" , 80 , 40);
  println(mouseX + "  mouseX - " + mouseY +  "  mouseY | " + (int)thisColor + " color  | " 
  + radius + "  size | " + nf(speedX,0,2) + " speedX - speedY " + nf(speedY,0,2) + " | FPS " + (int)frameRate);

//rainbow color
  thisColor = (thisColor + innerColorSpeed) % 300;
  fill(thisColor, 360, 360, 50);

//cursor trail
    int which = frameCount % cursorSize;
  mx[which] = mouseX;
  my[which] = mouseY;
  for (int i = 0; i < cursorSize; i++) {
    // which+1 is the smallest (the oldest in the array)
    int index = (which+1 + i) % cursorSize;
    ellipse(mx[index], my[index], i, i);
  }
  cursor.resize(cursorSize+5,cursorSize+5);
  image(cursor, mouseX, mouseY);

//ball movement
  xBall += speedX;
  yBall += speedY;

  //ball direction
  if (xBall >= width-radius/2) {
    speedX = random(random1, random2);
    speedX *= -1;
  } else if (yBall >= height-radius/2) {
    speedY = random(random1, random2);
    speedY *= -1;
  } else if (xBall <= 0+radius/2) {
    speedX = -random(random1, random2);
    speedX *= -1;
  } else if (yBall <= 0+radius/2) {
    speedY = -random(random1, random2);
    speedY *= -1;
  }

//cursor collision
  if(dist(xBall,yBall,mouseX,mouseY) <= (radius/2 + cursorSize/2) && mouseX > xBall && speedX > 0) {
      speedX = random(random1, random2);
      speedX *= -1;
    }else if(dist(xBall,yBall,mouseX,mouseY) <= (radius/2 + cursorSize/2) && mouseX < xBall && speedX < 0) {
      speedY = -random(random1, random2);
      speedX *= -1;
    }else if(dist(xBall,yBall,mouseX,mouseY) <= (radius/2 + cursorSize/2) && mouseY > yBall && speedY > 0) {
      speedX = random(random1, random2);
      speedY *= -1;
    }else if(dist(xBall,yBall,mouseX,mouseY) <= (radius/2 + cursorSize/2) && mouseY < yBall && speedY < 0) {
      speedY = -random(random1, random2);
      speedY *= -1;
    }

//Ball
    fill(200);
  ellipse(xBall,yBall, radius, radius);
  if (radius <= 2) {
    radius = 2;
  } else if(radius >= 500)  {
    radius = 500;
  }


//off screen bug fix
  if (xBall > width-radius/2) {
    xBall = width-radius/2;
    //left side
  } else if (yBall > height-radius/2) {
    yBall = height-radius/2;
    //bottom
  } else  if (xBall < radius/2) {
    xBall = radius/2;
    //right side
  } else if (yBall < radius/2) {
    yBall = radius/2;
    //top
  }

}

public void keyPressed() {
  if (key == CODED) {
    if (keyCode == UP) {
      radius += 1;
    } else if (keyCode == DOWN) {
      radius += 1;
    } 
  }
}
  public void settings() {  size(1280,720); }
  static public void main(String[] passedArgs) {
    String[] appletArgs = new String[] { "fun_spiral" };
    if (passedArgs != null) {
      PApplet.main(concat(appletArgs, passedArgs));
    } else {
      PApplet.main(appletArgs);
    }
  }
}
