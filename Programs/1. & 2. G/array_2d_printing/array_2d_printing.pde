
    int size = 5;

void setup() {
    frameRate(5);
    size(500,500);
    surface.setResizable(true);
    noSmooth();
 
}

void draw() {
    int cols = width;
    int rows = height;
    fill(200);

    float[][] numbers = new float[cols][rows];
    int pixels = 0;
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < cols; j++) {
            
            rect(i * size, j * size, size, size);
            pixels++;   
        }
    }
    println("squares loaded = " + pixels/(size*size) + " | square root = " + sqrt(pixels/(size*size))); 
}



