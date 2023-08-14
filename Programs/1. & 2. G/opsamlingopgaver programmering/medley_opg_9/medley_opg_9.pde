int[][] grid = new int[3][3];
int player = 1;

void setup() {
  println("Player 1 turn");
  size(300, 300);
  for (int i = 0; i < 3; i++) {
    for (int j = 0; j < 3; j++) {
      grid[i][j] = 0;
    }
  }
}

void draw() {
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

void mousePressed() {
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

boolean checkWin() {
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