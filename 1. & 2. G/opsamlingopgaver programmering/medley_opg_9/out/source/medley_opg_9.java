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

public class medley_opg_9 extends PApplet {

int[][] grid = new int[3][3];
int player = 1;

public void setup() {
  println("Player 1 turn");
  
  for (int i = 0; i < 3; i++) {
    for (int j = 0; j < 3; j++) {
      grid[i][j] = 0;
    }
  }
}

public void draw() {
  strokeWeight(2);
  for (int i = 0; i < 3; i++) {
    for (int j = 0; j < 3; j++) {
      rect(i*100, j*100, 100, 100);
      if (grid[i][j] == 1) {
        line(i*100+25, j*100+25, i*100+75, j*100+75);
        line(i*100+75, j*100+25, i*100+25, j*100+75);
      } else if (grid[i][j] == 2) {
        ellipse(i*100+50, j*100+50, 50, 50);
      }
    }
  }
  if(checkWin()){
   println("Player " + (1 + player % 2) + " has won");
   delay(1000);
   for (int i = 0; i < 3; i++) {
    for (int j = 0; j < 3; j++) {
      grid[i][j] = 0;
    }
  }
  println("Player " + player + " turn");
}
}

public void mousePressed() {
  int x = mouseX / 100;
  int y = mouseY / 100;
  if (grid[x][y] == 0) {
    grid[x][y] = player;
    if (player == 1) {
      player = 2;
      println("Player 2 turn");
    } else {
      player = 1;
      println("Player 1 turn");
    }
  }
}

public boolean checkWin() {
  // check rows
  for (int i = 0; i < 3; i++) {
    if (grid[i][0] == grid[i][1] && grid[i][1] == grid[i][2] && grid[i][0] != 0) {
      return true;
    }
  }
  
  // check columns
  for (int j = 0; j < 3; j++) {
    if (grid[0][j] == grid[1][j] && grid[1][j] == grid[2][j] && grid[0][j] != 0) {
      return true;
    }
  }
  
  // check diagonals
  if (grid[0][0] == grid[1][1] && grid[1][1] == grid[2][2] && grid[0][0] != 0) {
    return true;
  }
  if (grid[0][2] == grid[1][1] && grid[1][1] == grid[2][0] && grid[0][2] != 0) {
    return true;
  }
  return false;
}
  public void settings() {  size(300, 300); }
  static public void main(String[] passedArgs) {
    String[] appletArgs = new String[] { "medley_opg_9" };
    if (passedArgs != null) {
      PApplet.main(concat(appletArgs, passedArgs));
    } else {
      PApplet.main(appletArgs);
    }
  }
}
