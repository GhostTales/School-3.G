//fractals

float angle = radians(0);

void setup() {
        size(800, 800 ,P3D);
    surface.setResizable(true);

    noSmooth();
}

void draw() {

    
    angle += 0.001;
      

    background(51);
    stroke(200);

  
    int len = 150;
    int shape = 4;
    translate(width/2-len/2, height/2+len/2);

    for (int i = 0; i < shape; ++i) {
        branch(len);
        rotate(radians(360/shape));
    }

}


void branch(float length) {
     line(0, 0, 0, -length);
     translate(0, -length);
     if (length > 1) {
        
        push();
            rotate(angle);
            branch(length*0.67);
        pop();

        push();
            rotate(-angle);
            branch(length*0.67);    
        pop();
        
     }
}   

