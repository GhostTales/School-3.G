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

public class buzzer_quiz extends PApplet {

boolean keyLeft = true;
boolean keyRight = true;
String[] questions = {
"Start",
"Hvilket land kommer Usain Bolt fra? \n(A) Jamaica:\n(B) Chad:\n(C) Nigeria:\n(D) Uganda:", "SVAR: Jamaica",
"Hvad er det største land i Afrika?", "SVAR: Algeriet",
"Hvem er den danske udenrigsminister?", "SVAR: Lars Løkke Rasmussen",
"Hvilket land har flest mennesker?", "SVAR: Kina",
"Hvilket år startede 2. verdenskrig?", "SVAR: 1939",
"Hvad var det første programmeringssprog?", "SVAR: FORTRAN aka FORmula TRANslating system",
"Done" };
int i = 0;

int redteam = 0;
int blueteam = 0;

public void setup() {
    
}

public void draw() {
    background(255);
    textSize(24);
    textAlign(CENTER);
    text("blå hold: " + blueteam + "   |   rød hold: " + redteam, width/2 ,50);
    
    fill(200, 200, 200);
        rect(60, 287, 406, 386, 45);
        rect(534, 287, 406, 386, 45);

    if (keyLeft == false) {
        fill(0, 0, 200);
        rect(534, 287, 406, 386, 45);
        fill(200, 200, 200);
        rect(60, 287, 406, 386, 45);

    } else if (keyRight == false) {
        fill(200, 0, 0);
        rect(60, 287, 406, 386, 45);
        fill(200, 200, 200);
        rect(534, 287, 406, 386, 45);
    }

    textSize(28);
    fill(0);
    textAlign(CENTER);
        if (i < questions.length) {
            text(questions[i], width/2, 100);
        } else {
            i = questions.length -1;
        }

    fill(0);
    textAlign(LEFT);
        textSize(128);
        text("BLUE", 110, 540);
        text("RED", 620, 540);

}

public void keyPressed() {

  if (key == CODED) {
    if (keyCode == LEFT && keyLeft == true) {
      println("Left");
      keyRight = false;
    } 
    if (keyCode == RIGHT && keyRight == true) {
        println("right");
        keyLeft = false;
    }
  } else {
    if (key == ' ') {
        println("space");
        keyLeft = true;
        keyRight = true;
        i++;
    }
        if (key == '½') {
        println("back");
            if (i < 0) {
            i--;
        }
        println(i);
    }
  }

}
  public void settings() {  size(1000, 700); }
  static public void main(String[] passedArgs) {
    String[] appletArgs = new String[] { "buzzer_quiz" };
    if (passedArgs != null) {
      PApplet.main(concat(appletArgs, passedArgs));
    } else {
      PApplet.main(appletArgs);
    }
  }
}
