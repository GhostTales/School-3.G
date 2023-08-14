boolean keyLeft = true;
boolean keyRight = true;
String[] questions = {
"Start",
"Hvilket land kommer Usain Bolt fra?\n(A) Jamaica:\n(B) Chad:\n(C) Nigeria:\n(D) Uganda:", "SVAR: Jamaica",
"Hvad er det største land i Afrika?\n(A)egypten\n(B)syd afrika\n(C)Algeriet\n(D)uganda", "SVAR: Algeriet",
"Hvem er den danske udenrigsminister?\n(A)Lars Løkke Rasmussen\n(B)mette frederiksen\n(C)abdi fatah mohamed\n(D)Dan", "SVAR: Lars Løkke Rasmussen",
"Hvilket land har flest mennesker?\n(A)Indien\n(B)Kina\n(C)rusland\n(D)USA", "SVAR: Kina",
"Hvilket år startede 2. verdenskrig?\n(A)1939\n(B)1940\n(C)1945\n(D)1839", "SVAR: 1939",
"Hvad var det første programmeringssprog?\n(A)FORTRAN\n(B)python\n(C)c\n(D)c++", "SVAR: FORTRAN",
"Done" };
int i = 0;

int redteam = 0;
int blueteam = 0;

void setup() {
    size(1000, 700);
}

void draw() {
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

void keyPressed() {

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

        if (key == 'a' && i == 1 || i == 5 || i == 9 || i == 11) {
            if (keyLeft == true && keyRight == false) {
                redteam++;
            } else {
                blueteam++;
            }
            
            if (keyLeft == false && keyRight == true) {
                blueteam++;
            } else {
                redteam++;
            }
        }
        if (key == 'w') { // b
            
        }
        if (key == 's') { // c
            
        }
        if (key == 'd') {
            
        }
    }
  }

}