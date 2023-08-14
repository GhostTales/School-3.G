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

public class medley_opg_8 extends PApplet {
  public void setup() {
/*
8 Arrays
. Hvad er et array ?
. Hvordan opretter/erklarer man et array?
. Hvordan tilgår man elementerne i et array?

. Opret single array af typen int med en storrelse på 10.
. Sat manuelt vardierne 4,8,10,9,3,5,1,6,7,2 ind i dit array.
. Byt om på vardierne på index 3 og index 7.
. Lav en for-lokke som udskriver dit array til consol. ( du kan finde storrelse på et array ved:
arrayNavn.Length )
. Brug forlokke når du beregner summen af alle elementer i array, og udskriv resultat til consol.
. Opret nu et todimensionelt 5x6 heltals array
. Lav nu to indlejrede forlokker som fylder array med random vardier mellem 1 og 65535.
(udskriv array til console)
*/
 
 
 int[] numbers = {4,8,10,9,3,5,1,6,7,2};
    println(numbers);
    println("____________");

int temp = numbers[7];
numbers[7] = numbers[3];
numbers[3] = temp;
println(numbers);
println("____________");

int sum = 0;
for (int i = 0; i < numbers.length; ++i) {
    println(numbers[i]);
    sum += numbers[i];
}
println("summen er " + sum);
println("____________");

int[][] arr2D = new int[5][6];

for (int i = 0; i < arr2D.length; ++i) {
    for (int j = 0; j < arr2D[i].length; ++j) {
        arr2D[i][j] = round(random(1, 65535));
        print(arr2D[i][j] + " ");
    }
    println();
}


exit();
    noLoop();
  }

  static public void main(String[] passedArgs) {
    String[] appletArgs = new String[] { "medley_opg_8" };
    if (passedArgs != null) {
      PApplet.main(concat(appletArgs, passedArgs));
    } else {
      PApplet.main(appletArgs);
    }
  }
}
