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

public class orthello_game extends PApplet {

int[][] grid = new int[8][9]; // Creates a 2D integer array called grid with size 8 by 9
int gridSize = 100; // Initializes a globals variable called gridSize and sets it to 100
int player = 1; // Creates a global variable called player and set to 1
int white, black; // creates 2 integer variables black and white, with no value


public void setup() { // creates the setup function
   // sets the size of the processing window to be 800 pixels wide and 850 tall
  textAlign(CENTER); // makes all the text align to the center
  textSize(18); // Sets the size of the text to 18
  for (int i = 0; i < 8; i++) { // creates a for loop with variable i, going from 0 to 8
    for (int j = 0; j < 8; j++) { // creates a for loop with variable j, going from 0 to 8
      grid[i][j] = 0; // loops thru the 2D grid array with i for 1st dimension and j for 2nd dimension
                      // the sets the elements equal to 0
    }
  }
  grid[4][3] = 1; // sets the element at position 4,3 to equal 1
  grid[3][4] = 1; // sets the element at position 3,4 to equal 1
  grid[4][4] = 2; // sets the element at position 4,4 to equal 2
  grid[3][3] = 2; // sets the element at position 3,3 to equal 2

  for (int i = 0; i < 8; ++i) { // creates a for loop with variable i, going from 0 to 8
    grid[i][8] = 9; // sets the elements at position i,8 to equal 9, this is to allow space at the bottom of 
                    //window to display info, without getting an indexOutOfArray error when clicked on by user
  }
}

public void draw() { // creates the main draw function where the program runs in
  background(51); // sets the background color of the window to 51
  fill(0, 144, 103); // fills objects with the rgb color 0, 144, 103
  drawGrid(); // calls the function drawGrid()
  countPieces(); // calls the function countPieces():

  if (player == 1) { // if the variable player is equal to 1 place text "Blacks turn" at location 400, 830
    text("Blacks turn", 400, 830);
  } else { // else if the variable player is not equal to 1 place text "Whites turn" at location 400, 830
    text("Whites turn", 400, 830);
  }
}

public void boardState() { //creates the function called BoardState()
  for (int i = 0; i < 8; i++) { // creates 2 for loops with variables i and j which go in range 0 to 8
    for (int j = 0; j < 8; j++) {
      print(grid[j][i] + " "); // prints the value of the element at position j,i in the grid array follow by a space to the console
    }
    println(); // prints a newline to the console every increment of i
  }
      /* how it will look in console
        0 0 0 0 0 0 0 0
        0 0 0 0 0 0 0 0
        0 0 0 0 0 0 0 0
        0 0 0 2 1 0 0 0
        0 0 0 1 2 0 0 0
        0 0 0 0 0 0 0 0
        0 0 0 0 0 0 0 0
        0 0 0 0 0 0 0 0
       */
}

public void drawGrid() { // creates the function drawGrid()
  strokeWeight(2); // sets the width of object borders to 2 pixels
  for (int i = 0; i < 8; i++) { // creates 2 for loops with variables i and j which go in range 0 to 8
    for (int j = 0; j < 8; j++) {
      rect(i*gridSize, j*gridSize, gridSize, gridSize); // places rectangles in a grid formation with location
                                                        // i times by the global variable gridSize, then does the same with j
                                                        // then it sets the width and height of the rectangle to gridSize
      if (grid[i][j] == 1) { // if variable at position i,j in grid equals 1
        fill(0); // fill objects with color 0 or black
        stroke(0); // sets object borders with color 0 or black
        ellipse(i*gridSize+gridSize/2, j*gridSize+gridSize/2, 75, 75); // places an ellipse on the screen at location i times 
                                                                       // gridSize+gridSize then does same with j, with width and height 75
        fill(0, 144, 103); // fills objects with the rgb color 0, 144, 103
      } else if (grid[i][j] == 2) {
        fill(255); // fill objects with color 255 or white
        stroke(255); // sets object borders with color 255 or white
        ellipse(i*gridSize+gridSize/2, j*gridSize+gridSize/2, 75, 75); // places an ellipse on the screen at location i times 
                                                                       // gridSize+gridSize then does same with j, with width and height 75
        fill(0, 144, 103); // fills objects with the rgb color 0, 144, 103
        stroke(0); // sets object borders with color 0 or black
      }
    }
  }
}

public void mousePressed() { //creates a function with an event that listens for if the mouse is pressed
  int x = mouseX / gridSize; // creates the integer x with the x-acis value of the mouse divided by gridSize
  int y = mouseY / gridSize; // creates the integer y with the y-acis value of the mouse divided by gridSize

  if (grid[x][y] == 0) { // if position x,y in the grid array equals 0
    grid[x][y] = player; // then grid(x,y) equals the global player integer
    flankCheck(x, y); // calls the flankCheck function and gives it the variables x and y
    if (player == 1) { // if player equals 1
      player = 2; // then set the variable player to 2
      boardState(); // call boardState function
      println("Player 2 turn"); // prints to console that it is player 2's turn
    } else { // else if player does not equal 1
      player = 1; // set variable player to 1
      boardState(); // call boardState function
      println("Player 1 turn"); // prints to console that it is player 1's turn
    }
  }
}

public void flankCheck(int x, int y) { // creates the function flankCheck() which takes the integers x and y
  for (int i = -1; i <= 1; i++) { // create a for loop with variable i in the range -1 to 1
    for (int j = -1; j <= 1; j++) { // create a for loop with variable j in the range -1 to 1
      if (i == 0 && j == 0) continue; // if both i and j equal 0 then continue with rest of function

      int opponent; // creates integer called opponent with no value
      if (player == 1) { // if player equal 1 then set opponent to 2
        opponent = 2;
      } else { // else set opponent to 1
        opponent = 1;
      }
      boolean foundOpponent = false; // create the boolean foundOpponent and sets it to false
      int tempX = x + i; // creates variable tempX and sets it to x + i
      int tempY = y + j; // creates variable tempY and sets it to y + j

      while (tempX >= 0 && tempX < 8 && tempY >= 0 && tempY < 8 && grid[tempX][tempY] == opponent) { // while tempX is greater then or equal 0 
                                                                                                    // and less then 8, and tempY i greater then
                                                                                                    // or equal 0 and less ten 8,
                                                                                                    // and grid position tempX, tempY equals opponent
        tempX += i; // tempX equals tempX + i
        tempY += j; // tempY equals tempY + j
        foundOpponent = true; // foundOpponent is set to true
      }

      if (foundOpponent && tempX >= 0 && tempX < 8 && tempY >= 0 && tempY < 8 && grid[tempX][tempY] == player) { // if foundOpponent and tempX is 
                                                                                                  // greater then or equal 0 and tempX is less then 8, 
                                                                                                  // and tempY i greater then or equal 0 and less ten 8,
                                                                                                  // and grid position tempX, tempY equals player
        tempX -= i; // tempX equals tempX - i
        tempY -= j; // tempY equals tempY - j
        while (tempX != x || tempY != y) { // while tempX does not equal x or tempY does not equal y
          grid[tempX][tempY] = player; // grid position tempX, tempY equals player
          tempX -= i; // tempX equals tempX - i
          tempY -= j; // tempY equals tempY - j
        }
      }
    }
  }
}

public void countPieces() { // function that counts the amount of black and white pieces
  fill(255); // fills all objects with the color white
  text("White pieces = " + white, 200, 830); // places the text for white pieces and the amount of them at the coordinates 200, 830
  text("Black pieces = " + black, 600, 830); // places the text for black pieces and the amount of them at the coordinates 600, 830
  int white = 0; // creates the integer white and sets it to 0
  int black = 0; // creates the integer black and sets it to 0
  for (int i = 0; i < 8; ++i) { // a loop that goes from 0 to 8
    for (int j = 0; j < 8; ++j) { // a loop that goes from 0 to 8
      if (grid[i][j] == 2) { // if the the value in the grid at location i, j from the loops equals 2 then white increases by 1
        white++;
      } else if (grid[i][j] == 1) { // else if the the value in the grid at location i, j from the loops equals 1 then black increases by 1
        black++;
      }
    }
  }
  this.white = white; // creates a new local variable white
  this.black = black; // creates a new local variable black
  if ((white + black) == 64) { // if white + black equals 64 then the game is over
    String winner; // creates string variable winner with no values
    if (white == black) { // if white and black is the same value then the game ends in a draw
      winner = "Draw";
    } else if (white < black) { // if black is more then white then black has won
      winner = "black has won";
    } else { // if none of the above that means white is bigger then black and white has won
      winner = "white has won";
    }
    fill(100, 200, 100); // fills all objects with the color 100, 200, 100
    rect(210, 310, 380, 180); // creates the rect with the dimensions 380 x 180 at the coordinates 210, 310
    fill(0); // fills all objects with the color black
    text(winner, 400, 400); // places text at 400, 400 with the content of the winner variable

    fill(255); // fills all objects with the color white
    rect(325, 425, 150, 50); // creates the rect with the dimensions 150 x 50 at the coordinates 325, 425
    if (mousePressed) { // if the mouse is pressed and the mouseX position is more then 325 and less then 475, and the mouseY position is more then 425
                        // and less then 475
      if (mouseX>325 && mouseX <325+150 && mouseY>425 && mouseY <425+50) {
        println("The mouse is pressed and over the button"); // prints "The mouse is pressed and over the button" on a new line if the above is true 
        restart(); // calls the function called restart()
      }
    } 
    fill(0); // fills all objects with the color black
    text("Restart", 400, 455); // places the text "Restart" at 400, 455 
    fill(255); // fills all objects with the color white
  }
}

public void restart() { // creates a function called restart that resets all values
  player = 1; // sets the player to 1
  for (int i = 0; i < 8; i++) { // goes thru the 2D array grid at sets all values to 0
    for (int j = 0; j < 8; j++) {
      grid[i][j] = 0;
    }
  }
  grid[4][3] = 1; // sets the element at position 4,3 to equal 1
  grid[3][4] = 1; // sets the element at position 3,4 to equal 1
  grid[4][4] = 2; // sets the element at position 4,4 to equal 2
  grid[3][3] = 2; // sets the element at position 3,3 to equal 2

  for (int i = 0; i < 8; ++i) { // creates a for loop with variable i, going from 0 to 8
    grid[i][8] = 9; // sets the elements at position i,8 to equal 9, this is to allow space at the bottom of 
                    //window to display info, without getting an indexOutOfArray error when clicked on by user
  }
}
  public void settings() {  size(800, 850); }
  static public void main(String[] passedArgs) {
    String[] appletArgs = new String[] { "orthello_game" };
    if (passedArgs != null) {
      PApplet.main(concat(appletArgs, passedArgs));
    } else {
      PApplet.main(appletArgs);
    }
  }
}
