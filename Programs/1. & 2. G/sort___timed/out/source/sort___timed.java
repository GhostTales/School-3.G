import processing.core.*; 
import processing.data.*; 
import processing.event.*; 
import processing.opengl.*; 

import java.util.HashMap; 
import java.util.ArrayList; 
import java.io.File; 
import java.io.BufferedReader; 
import java.io.PrintWriter; 
import java.io.InputStream; 
import java.io.OutputStream; 
import java.io.IOException; 

public class sort___timed extends PApplet {


int threadCount = 8;

// void setup() {
//      for (int i = 0; i < threadCount; ++i) {
//         thread("test");
//     }
//     noLoop();
// }
      
// void test() {
//  for (int t = 0; t < 100; ++t) {
//         int time = 0;

//         float[] numbers = new float[50];
//         for (int i = 0; i < numbers.length; ++i) {
//             numbers[i] = random(10);
            
//         }

//         time = millis();
//        for (int j = 0; j < 10000000; j++) {

//         numbers = reverse(numbers);
        
//        }
      
//       println(millis() - time);
//        }
// }

public void setup() {
    float[] numbers = new float[50];
        for (int i = 0; i < numbers.length; ++i) {
            numbers[i] = random(10);
            
        }

        Thread[] threads = new Thread[8];
    for(int i = 0; i < 8; i++) {
    threads[i] = new Thread(new Worker(80/8));
    threads[i].start();
        }
    for(int i = 0; i < 8; i++) {
    threads[i].join();
    } 
}

  static public void main(String[] passedArgs) {
    String[] appletArgs = new String[] { "sort___timed" };
    if (passedArgs != null) {
      PApplet.main(concat(appletArgs, passedArgs));
    } else {
      PApplet.main(appletArgs);
    }
  }
}
