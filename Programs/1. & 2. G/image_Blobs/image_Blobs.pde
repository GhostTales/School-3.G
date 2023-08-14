//video blobs
import processing.video.*;

Movie video;

int rows, cols; 
float speed;
color pixelColor;


//PImage image;

void setup() {

   // program resolution is 32 by 9
    size(1920, 540);
    frameRate(30);
    noStroke();
    noSmooth();
    rectMode(CENTER);

    video = new Movie(this, "video3.mp4");
    video.loop();
    
}

void draw() {
     
    //PImage image = loadImage("neonCity.jpg");
    image(video, width/2, 0, width/2, height);
    
    blocks();

    println(frameRate);

    fill(140, 150);
    rect(0, height, width*2, 10);
    
    fill(255, 0, 0);
    
    rect(0, height, width/video.duration() * video.time()*2, 10, 90);
    text(int(video.time()) + " / " + int(video.duration()), 10, height - 10); 
    video.speed(speed);
    speed = 1;
    
}

void movieEvent(Movie m) {
  m.read();
}

void keyPressed() {
    if (key == 'a') {
        speed = 0.25;
      
    } 
    
    else if (key == 'd') {
        speed = 15;
      
    } 
    
    
}  

void blocks() {
    
    rows = 0;

    while(rows < width/2) {
        
        
        cols = 0;
        
        while(cols < height) {
            color pixelColor = get(rows + width/2, cols);
            fill(pixelColor);
            rect(rows, cols, random(1.5, 3), random(1.5, 3));
            // random(0, 12), random(0, 12)
            cols += 2;
        }
        
        rows += 2;
    }
    
}