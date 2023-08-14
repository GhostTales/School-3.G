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

public class Space_Alien_Invaders_Shooting_Spaceship_Game extends PApplet {


ControlP5 menu;

int spaceShip_Shot_X = 250, spaceShip_Shot_Y = 650;




boolean collision = false;


public void setup() {
    
    menu = new ControlP5(this);
    buttons();

    rectMode(CENTER);
    ellipseMode(CENTER);
}

public void draw() {
    background(200);
    
    fill(100);

    ellipse(45, 100, 50, 50);
 

    rect(spaceShip_Shot_X, spaceShip_Shot_Y, 30, 30);

    if (dist(20, 650, spaceShip_Shot_X, spaceShip_Shot_Y) <= 40) {
        spaceShip_Shot_X = -250; 
        spaceShip_Shot_Y = -650;
    }

    
    
    spaceShip_Shot_Y -= 2;
    
    

}

public void buttons() {
    
       
}

public void keyPressed() {
    if (key == 'a') {
      println("a");
    } 
    
    else if (key == 'd') {
      println("d");
    } 
    
    else if (key == ' ') {
      println("space");
        if (spaceShip_Shot_Y <= -10 || spaceShip_Shot_X <= -10) {
            spaceShip_Shot_X = 250; 
            spaceShip_Shot_Y = 650;
        }    
    } 
    
}  

  public void settings() {  size(500, 750); }
  static public void main(String[] passedArgs) {
    String[] appletArgs = new String[] { "Space_Alien_Invaders_Shooting_Spaceship_Game" };
    if (passedArgs != null) {
      PApplet.main(concat(appletArgs, passedArgs));
    } else {
      PApplet.main(appletArgs);
    }
  }
}
