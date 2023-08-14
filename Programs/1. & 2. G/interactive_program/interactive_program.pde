import controlP5.*;
ControlP5 colorMenu, shapeMenu;

// sætter de forskellige værdier
float red, green, blue, opacity;
int shapeX = width-height/4, shapeY = height/2, speedX, speedY;
int shape = 50;
color rgb;
boolean background = true, shapeBoolean = true;

void setup() {
  size(1280, 720);
  // sætter navnet af canvas
  surface.setTitle("Interactive Color Changer");
  // laver 2 nye controlP5 classes
  colorMenu = new ControlP5(this);
  shapeMenu = new ControlP5(this);
  // kalder void fuctionen menubutton 
  menuButton();
  // sætter ellipse og rect til center mode og text til at align i center
  ellipseMode(CENTER);
  rectMode(CENTER);
  textAlign(CENTER);
  strokeWeight(2);
  // sætter anti-aliasing til 2x istedet for default 1x
  smooth(2);
}

void draw() {

  // sætter background til boolean værdien af toggle background
  // true for at backgroud er sort og false for at den er hvid
  if (background == false) {
    background(230);
    stroke(0);
  } else {
    background(25);
    stroke(230);
  }
  // kalder void functionen shapeDirection
  shapeDirection();


  // laver background til control panel i højre side af canvas
  fill(0);
  rect(width-height/4, height/2, height/2, height);
  fill(230, 75);
  rect(width-height/4, height/2, height/2, height);
  fill(red, green, blue, opacity);
  ellipse(width-height/2 + 182.5, height/2+30, 120, 120);

  // sætter hvilken af de 2 former der skal vises på skærmen
  // true er for rect og false er for ellipse
  if (shapeBoolean == true) {
    rect(shapeX, shapeY, shape, shape);
  } else {
    ellipse(shapeX, shapeY, shape, shape);
  }

  // laver rød, grøn og blå farverne om til hex coden for samme farve
  rgb = color(red, green, blue);
  fill(230);
  textSize(14);
  // sætter hex coden på skærmen
  text("Hex color code #" + hex(rgb, 6), width-height/2 + 182.5, height/8);
}
// sætter de forskellige sliders og toggles ind på canvas
void menuButton() {
  colorMenu.addSlider("red").setPosition(width-height/2 + 90, 125).setSize(25, 125).setRange(0, 255)
    ;
  colorMenu.addSlider("green").setPosition(width-height/2 + 170, 125).setSize(25, 125).setRange(0, 255)
    ;
  colorMenu.addSlider("blue").setPosition(width-height/2 + 250, 125).setSize(25, 125).setRange(0, 255)
    ;
  colorMenu.addSlider("opacity").setPosition(width-height/2 + 90, 280).setSize(185, 25).setRange(0, 100).setValue(100)
    ;
  shapeMenu.addSlider("speedX").setPosition(width-height/2 + 90, 480).setSize(185, 25).setRange(-shape/2, shape/2).setValue(5)
    ;
  shapeMenu.addSlider("speedY").setPosition(width-height/2 + 90, 520).setSize(185, 25).setRange(-shape/2, shape/2).setValue(5)
    ;
  shapeMenu.addSlider("size").setPosition(width-height/2 + 90, 560).setSize(185, 25).setRange(2, height/2).setValue(50)
    ;
  shapeMenu.addToggle("background").setPosition(width-height/2 + 275, height/2).setSize(50, 25).setValue(false)
    ;
  shapeMenu.addToggle("shapeBoolean").setPosition(width-height/2 + 35, height/2).setSize(50, 25).setValue(false).setLabel("shape")
    ;
}

// disse void functioner sætter værdierne af slider og toggle
void red(float valRed) {
  red = valRed;
}
void green(float valGreen) {
  green = valGreen;
}
void blue(float valBlue) {
  blue = valBlue;
}
// bliver ganget med 2.55 fordi max er 255 men skulle have range fra 0-100
void opacity(float valOpacity) {
  opacity = valOpacity * 2.55;
}
void background(boolean valBackground) {
  background = valBackground;
}
void size(int valSize) {
  shape = valSize;
}

// laver en void function shapeDirection
void shapeDirection() {
  // shape movement
  // går så shape kan bevæge sig
  shapeX += speedX;
  shapeY += speedY;

  // shape direction
  // reflektere shape så den får modsat retning når den rammer en væg
  if (shapeX >= width-height/2-shape/2) {
    speedX *= -1;
  } else if (shapeY >= height-shape/2) {
    speedY *= -1;
  } else if (shapeX <= shape/2) {
    speedX *= -1;
  } else if (shapeY <= shape/2) {
    speedY *= -1;
  }

  // off screen bug fix
  // gør så shape ikke kan komme uden for canvas
  if (shapeX > width-height/2-shape/2) {
    shapeX = width-height/2-shape/2;
    // left side
  } else if (shapeY > height-shape/2) {
    shapeY = height-shape/2;
    // bottom
  } else  if (shapeX < shape/2) {
    shapeX = shape/2;
    // right side
  } else if (shapeY < shape/2) {
    shapeY = shape/2;
    // top
  }
}
