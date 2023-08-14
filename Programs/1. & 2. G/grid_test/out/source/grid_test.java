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

public class grid_test extends PApplet {


ControlP5 menu;

float valGridSize;
int cols, rows, gridSize;

public void setup() {
    
    surface.setResizable(true);
    menu = new ControlP5(this);
    colorMode(HSB);
    buttons();
}

public void draw() {
    println(frameRate);
    background(gridSize * (255 / 64), gridSize * (255 / 64), gridSize * (255 / 64));
    grid();
    menu();
    stroke(200);
    strokeWeight(0);
}

public void menu() {
    fill(200);
    rect(width / 1.5f, -1, width - width / 1.5f, height + 1);
    menu.setPosition((int)(width / 1.35f), 125);
}

public void grid() {
    
    rows = 0;
    
    int firstColor;
    int secondColor;
    
    while(rows < gridSize - 2) {
        
        if (rows % 2 == 0) {
            firstColor = color(0);
            secondColor = color(220);
        } else {
            firstColor = color(220);
            secondColor = color(0);
        }
        
        cols= 0;
        
        while(cols < gridSize - 2) {
            
           if (cols % 2 == 0) {
                fill(firstColor);
        } else {
                fill(secondColor);
        }

            /*
                    |
                    |
                Y   |
                    | 
                    |____________
                  
                          X
            */

            // The X coords of the rectangle
            float rectX = cols * width / gridSize / 1.5f + width / gridSize / 1.5f;
            // The Y coords of the rectangle
            float rectY = rows * height / gridSize + height / gridSize;

            rect(rectX, rectY, width / gridSize / 1.5f, height / gridSize + 1);
            
            cols += 1;
        }
        
        rows+= 1;
    }
}

public void buttons() {
    menu.addSlider("gridSize").setRange(2, 64).setSize((int)(width * 0.033f),(int)(height * 0.25f)).setLabel("Grid size")
       ;
    }

public void gridSize(int valGridSize) {
    gridSize = valGridSize + 2;
    }
  public void settings() {  size(750, 500); }
  static public void main(String[] passedArgs) {
    String[] appletArgs = new String[] { "grid_test" };
    if (passedArgs != null) {
      PApplet.main(concat(appletArgs, passedArgs));
    } else {
      PApplet.main(appletArgs);
    }
  }
}
