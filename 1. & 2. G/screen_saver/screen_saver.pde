float x = 1, y = 1;
int bounce;
int timer;
PImage img;

// bouncer settings
int bouncer = 125;
float speedX = 3.5, speedY = 3.5;

void setup() {
  size(1280, 720);
  surface.setTitle("ScreenBouncer");
  surface.setResizable(true);
  surface.setLocation(550, 135);
  noStroke();
  background(0);
  frameRate(60);
  x = random(width-bouncer);
  y = random(height-bouncer);
  img = loadImage("screen saver logo2.png");
}

void draw() {
  //  display settings
  boolean directionMeter = true;
  boolean bounceCounter = true;

  //code

  if (millis() >= 1) {
    timer = timer + 1 ;
  }

  if (speedX > bouncer) {
    speedX = bouncer;
  } else if (speedY > bouncer) {
    speedY = bouncer;
  }

  boolean up = false, down = false, right = false, left = false;
  fill(200);
  background(0);
  image(img, x, y, bouncer, bouncer);

  x = x + speedX;
  y = y + speedY;


  if (x >= width-bouncer) {
    speedX = -1* speedX;
    println(bounce +1 + "  bounce right   " + "time  " + timer + "  xPos  " + (int) x + "  yPos  " + (int) y);
    right = true;
  } else if (y >= height-bouncer) {
    speedY = -1* speedY;
    println(bounce +1 + "  bounce down    " + "time  " + timer + "  xPos  " + (int) x + "  yPos  " + (int) y);
    down = true;
  } else if (x <= 0) {
    speedX = -1* speedX;
    print(bounce +1 + "  bounce left    " + "time  " + timer + "  xPos  " + (int) x + "  yPos  " + (int) y + "\n");
    left = true;
  } else if (y <= 0) {
    speedY = -1* speedY;
    print(bounce +1 + "  bounce up      " + "time  " + timer + "  xPos  " + (int) x + "  yPos  " + (int) y + "\n");
    up = true;
  }

  //off screen bug fix
  if (x > width) {
    x = width-1;
    //left
  } else if (y > height) {
    y = height-1;
    //down
  } else  if (x < 0) {
    x = 1;
    //right
  } else if (y < 0) {
    y = 1;
    //up
  }

  if (up == true) {
    bounce = bounce + 1;
  } else if (down == true) {
    bounce = bounce + 1;
  } else if (right == true) {
    bounce = bounce + 1;
  } else if (left == true) {
    bounce = bounce + 1;
  }

  if (bounceCounter == true) {
    fill(200);
    if (bounce == 1) {
      textSize(30);
      text(bounce + "  Bounce", width*0.5-60, 30);
    } else if (bounce >= 2) {
      textSize(30);
      text(bounce + "  Bounces", width*0.5-60, 30);
    }
  } else if (bounceCounter == false) {
  }

  if (directionMeter == true) {
    if (down == true) {
      fill(0, 255, 0);
      triangle(width*0.4875, height*0.535, width*0.5125, height*0.535, width*0.5, height*0.575);
      // down
    } else if (up == true) {
      fill(0, 255, 0);
      triangle(width*0.4875, height*0.465, width*0.5125, height*0.465, width*0.5, height*0.425);
      // up
    } else if (left == true) {
      fill(0, 255, 0);
      triangle(width*0.48, height*0.48, width*0.48, height*0.52, width*0.46, height*0.5);
      //left
    } else if (right == true) {
      fill(0, 255, 0);
      triangle(width*0.52, height*0.48, width*0.52, height*0.52, width*0.54, height*0.5);
      //right
    }

    fill(120, 80);
    circle(width*0.5, height*0.5, height*0.042);
    triangle(width*0.52, height*0.48, width*0.52, height*0.52, width*0.54, height*0.5);
    //right
    triangle(width*0.48, height*0.48, width*0.48, height*0.52, width*0.46, height*0.5);
    //left
    triangle(width*0.4875, height*0.535, width*0.5125, height*0.535, width*0.5, height*0.575);
    //down
    triangle(width*0.4875, height*0.465, width*0.5125, height*0.465, width*0.5, height*0.425);
    //up
  } else if (directionMeter == false) {
  }

  if (bounce >= 1000) {
    bounce = 0;
    timer = 0;
    x = random(width-bouncer);
    y = random(height-bouncer);
    fill(0, 0, 255);
    circle(width*0.5, height*0.5, height*0.06);
    
  }
}
