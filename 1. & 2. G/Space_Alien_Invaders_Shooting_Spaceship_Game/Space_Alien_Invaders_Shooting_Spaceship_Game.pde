import controlP5.*;
ControlP5 menu;

int spaceShip_Shot_X = 250, spaceShip_Shot_Y = 650;

float ell_x1, ell_y1, ell_x2, ell_y2, ell_x3, ell_y3, ell_x4, ell_y4, ell_x5, ell_y5, ell_x6, ell_y6, ell_x7, ell_y7, ell_x8, ell_y8, ell_x9, ell_y9, ell_x10, ell_y10;


boolean collision = false;


void setup() {
    size(500, 750);
    menu = new ControlP5(this);
    buttons();

    rectMode(CENTER);
    ellipseMode(CENTER);
}

void draw() {
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

void buttons() {
    
       
}

void keyPressed() {
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

