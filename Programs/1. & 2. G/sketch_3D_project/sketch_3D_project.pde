int cols, rows;
int scale = 5;
int w = 1000;
int h = 1000;
float fly = 0;
float speedOffset = 0.0023*scale;
float camX = 65, camY, camZ;

int nrKeys = 0;
boolean[] downKeys = new boolean[256];

float[][] terrain;

void setup() {
    size(1280, 720 ,P3D);
    surface.setResizable(true);

// for 2 monitors only with secondary to the right of main monitor
//    surface.setLocation(1920 + 1920/2-width/2, 135);


    frameRate(24);

    cols = w / scale;
    rows = h / scale;
    terrain = new float[cols][rows];
    hint(DISABLE_OPENGL_ERRORS);
    noSmooth();
}

void draw() {

    keyboard();

    fly -= (speedOffset);
   
    terrain();

    background(0);
    stroke(200);
    
    translate(width/2, height/2);
    

    // processing works with radians so radians(); converts from degrees to radians
    // rotate(X,Y,Z) rotates the camera in a 3D space
    rotateX(radians(camX));
    rotateZ(radians(camZ));
    rotateY(radians(camY));

    // Specifies an amount to displace objects within the display window. The x parameter specifies left/right translation, 
    // the y parameter specifies up/down translation, and the z parameter specifies translations toward/away from the screen.
    translate(-w/2, -h/2);
   
    vertex();

    println(frameRate);
}

void terrain() {
        float yOff = fly;
    
    for (int y = 0; y < rows; y++) {
        float xOff = fly;
        for (int x = 0; x < cols; x++) {
            noiseDetail(7, 0.5);
            terrain[x][y] = map(noise(xOff, yOff), 0, 1, -320, 128);
            if (terrain[x][y] <= -150) {
                terrain[x][y] = -150;
            } else {
                
            }

            xOff += speedOffset;
        }
        yOff += speedOffset;
    }
}


void vertex() {
    for (int y = 0; y < rows-1; y++) {
        beginShape(TRIANGLE_STRIP);
        for (int x = 0; x < cols; x++) {
            vertex(x*scale, y*scale, terrain[x][y]);
            vertex(x*scale, (y+1)*scale, terrain[x][y+1]);
// terrain colors   

            int snowDepth = -32, stoneDepth = -64, grassDepth = -91, grassDepth2 = -118, grassDepth3 = -145, sandDepth = -150;
            if (terrain[x][y] > snowDepth) {
                // snow
                fill(200);
                stroke(210);
                strokeWeight(1);
            }   else if (terrain[x][y] > stoneDepth && terrain[x][y] < snowDepth) {
                // stone
                fill(108, 110, 108);
                stroke(118, 120, 118);
                strokeWeight(1);
            }   else if (terrain[x][y] < stoneDepth && terrain[x][y] > grassDepth) {
                // dark grass
                fill(0, 84, 0);
                stroke(0, 94, 0);
                strokeWeight(1);
            }   else if (terrain[x][y] < grassDepth && terrain[x][y] > grassDepth2) {
                // medium grass
                fill(0, 94, 0);
                stroke(0, 104, 0);
                strokeWeight(1);
            }   else if (terrain[x][y] < grassDepth2 && terrain[x][y] > grassDepth3) {
                // light grass
                fill(0, 104, 0);
                stroke(0, 114, 0);
                strokeWeight(1);
            }   else if (terrain[x][y] <= grassDepth3 && terrain[x][y] > sandDepth) {
                // sand
                fill(194, 178, 128);
                stroke(214, 188, 148);
                strokeWeight(1);
            }   else if (terrain[x][y] <= sandDepth) {
                // water
                fill(4, 66, 114);
                //stroke(24, 86, 134);
                strokeWeight(0);
            }
        }
        endShape();
    }

}


void keyboard() {
    nrKeys = 0;
    for (int i=0; i<downKeys.length; i++) {
    if (downKeys[i]) {
     nrKeys++;

     if ((char)i == 'w') { 
        camX -= 1;
      }
      if ((char)i == 'a') { 
        camZ += 1;
      }
      if ((char)i == 's') { 
        camX += 1;
      }
      if ((char)i == 'd') { 
        camZ -= 1;
      }
        if ((char)i == ' ') { 
        fly += (speedOffset);
      }
      

   }
 }
}

void keyPressed() {
 if (key<256) {
   downKeys[key] = true;
 }
}

void keyReleased() {
 if (key<256) {
   downKeys[key] = false;  
 }
}
