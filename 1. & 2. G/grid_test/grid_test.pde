import controlP5.*;
ControlP5 menu;

float valGridSize;
int cols, rows, gridSize;

void setup() {
    size(750, 500);
    surface.setResizable(true);
    menu = new ControlP5(this);
    colorMode(HSB);
    buttons();
}

void draw() {
    println(frameRate);
    background(gridSize * (255 / 64), gridSize * (255 / 64), gridSize * (255 / 64));
    grid();
    menu();
    stroke(200);
    strokeWeight(0);
}

void menu() {
    fill(200);
    rect(width / 1.5, -1, width - width / 1.5, height + 1);
    menu.setPosition((int)(width / 1.35), 125);
}

void grid() {
    
    rows = 0;
    
    color firstColor;
    color secondColor;
    
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
            float rectX = cols * width / gridSize / 1.5 + width / gridSize / 1.5;
            // The Y coords of the rectangle
            float rectY = rows * height / gridSize + height / gridSize;

            rect(rectX, rectY, width / gridSize / 1.5, height / gridSize + 1);
            
            cols += 1;
        }
        
        rows+= 1;
    }
}

void buttons() {
    menu.addSlider("gridSize").setRange(2, 64).setSize((int)(width * 0.033),(int)(height * 0.25)).setLabel("Grid size")
       ;
    }

void gridSize(int valGridSize) {
    gridSize = valGridSize + 2;
    }
