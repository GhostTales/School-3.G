float yLeft = 300, yRight = 300, yBouncer;
float xLeft = 40, xRight = 1220, xBouncer;
int nrKeys;
boolean[] downKeys = new boolean[256];
int scoreRight, scoreLeft;
int bouncer = 40;
float speedX, speedY;
float random1 = 4;
float random2 = 5.5;
int num = 30;
float mx[] = new float[num];
float my[] = new float[num];


void setup() {
  size(1280, 720);
  surface.setTitle("AdvancedPong");
  surface.setLocation(550, 135);
  noStroke();
  frameRate(120);
  xBouncer = width/2;
  yBouncer = height/2;
  speedX = random(random1, random2);
  speedY = random(random1, random2);
  
  ellipseMode(CENTER);
  textAlign(CENTER);
 
}

void draw() {
  background(0);
  println("frame  " + frameCount + "  xPos  " + (int) xBouncer + " yPos  " + (int) yBouncer + "   speedX  " + speedX + "  speedY  " + speedY);
  
  update();

  fill(200);
  
  textSize(40);
  text("score", width/2, 50);
  stroke(200, 50);
  line(width/2, height, width/2, 0);
  strokeWeight(10);
  noStroke();

//players
  rect(xLeft, yLeft, 20, 100);
  rect(xRight, yRight, 20, 100);
  ellipse(xBouncer, yBouncer, bouncer, bouncer);
  
}

void update () {
//movement keys
  nrKeys = 0;
  for (int i=0; i<downKeys.length; i++) {
    if (downKeys[i]) {
      nrKeys++;
      //left player
      if ((char)i == 's') { //down
        yLeft = (yLeft + 4) % height;
      }
      if ((char)i == 'w') { //up
        yLeft = (yLeft - 4) % height;
      }
      //right player
      if ((char)i == 'æ') { //down
        yRight = (yRight + 4) % height;
      }
      if ((char)i == 'å') { //up
        yRight = (yRight - 4) % height;
      }

    }
  }

//bouncer movement
  xBouncer = xBouncer + speedX;
  yBouncer = yBouncer + speedY;

  //bouncer direction
  if (xBouncer >= width) {
    speedX *= -1;
  } else if (yBouncer >= height) {
    speedY *= -1;
  } else if (xBouncer <= 0) {
    speedX *= -1;
  } else if (yBouncer <= 0) {
    speedY *= -1;
  }

//off screen bug fix
  if (xBouncer > width) {
    xBouncer = width-1;
    //left side
  } else if (yBouncer > height) {
    yBouncer = height-1;
    //bottom
  } else  if (xBouncer < 0) {
    xBouncer = 1;
    //right side
  } else if (yBouncer < 0) {
    yBouncer = 1;
    //top
  }

//scoreBoard
  if (xBouncer >= 1270) {
    scoreLeft = scoreLeft + 1;
    text(scoreLeft, width/2 - 100, 50);
    textSize(15);
    text("player 1", width/2 - 100, 65);
    xBouncer = width/2;
    yBouncer = height/2;
    speedX = random(random1, random2);
    speedY = random(random1, random2);
    speedX *= -1;
    speedY *= -1;
  } else if (xBouncer <= 10) {
    scoreRight = scoreRight + 1;
    text(scoreRight, width/2 + 100, 50);
    textSize(15);
    text("player 2", width/2 + 100, 65);
    xBouncer = width/2;
    yBouncer = height/2;
    speedX = random(random1, random2);
    speedY = random(random1, random2);
  } else {
    text(scoreLeft, width/2 - 100, 50);
    text(scoreRight, width/2 + 100, 50);
    textSize(15);
    text("player 1", width/2 - 100, 65);
    text("player 2", width/2 + 100, 65);
    textSize(40);
  }

//collision detection
  if (xBouncer >= 1200 && yBouncer >= yRight-10 && yBouncer <= (yRight + 120)) {
    speedX *= -1;
  }
  if (xBouncer <= 75 && yBouncer >= yLeft-10 && yBouncer <= (yLeft + 120)) {
    speedX *= -1;
  }

//players offscreen fix
   if (yLeft >= height-100)  {
    yLeft = height-100;
  } else if (yLeft <= 0) {
    yLeft = 0;
    }
  if (yRight >= height-100) {
    yRight = height-100;
  } else if (yRight <= 0) {
    yRight = 0;
    }

//win condition
  if (scoreLeft >= 20 || scoreRight >= 20) {
  if ((int)scoreLeft >= 20) {
    scoreLeft = 20;
    scoreRight = 0;
    text("Player 1 has won", width/2, 150);
    text("Click UP arrow for new game", width/2, 600);
    }
  if ((int)scoreRight >= 20) {
    scoreLeft = 0;
    scoreRight = 20;
    text("Player 2 has won", width/2, 150);
    text("Click UP arrow for new game", width/2, 600);
    }
  }
//bouncer trail
  int which = frameCount % num;
  mx[which] = xBouncer;
  my[which] = yBouncer;
  fill(150);
  for (int i = 0; i < num; i++) {
    // which+1 is the smallest (the oldest in the array)
    int index = (which+1 + i) % num;
    ellipse(mx[index], my[index], i, i);

  }
}

  
void keyPressed() {
  if (key<256) {
    downKeys[key] = true;
  }
//restart game
  if (key == CODED) {
    if (keyCode == UP) {
      scoreLeft = 0;
      scoreRight = 0;
      xBouncer = width/2;
      yBouncer = height/2;
      yLeft = 300;
      yRight = 300;
      delay(1000);
    }
  }
}

void keyReleased() {
  if (key<256) {
    downKeys[key] = false;
  }
}
