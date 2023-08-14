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

public class perimeter_of_an_ellipse extends PApplet {

class Ellipse {
  double storAkse, lilleAkse, h;
  double omkreds, areal;

  Ellipse(double storAkse, double lilleAkse){

  // Set the semi-major and semi-minor axes
  this.storAkse = storAkse;
  this.lilleAkse = lilleAkse;
  
  // Calculate the value of h
  this.h = Math.pow(storAkse - lilleAkse, 2) / Math.pow(storAkse + lilleAkse, 2);
  }
  // Calculate the omkreds of the ellipse
  // with Ramanujan formula
  public double beregnOmkreds() {
    return Math.PI * (storAkse + lilleAkse) * (1 + (3 * h / (10 + Math.sqrt(4 - 3 * h))));
  } 
  public double beregnAreal() {
    return Math.PI * storAkse * lilleAkse;
  }
}


// cirkel
// trekant
// firkant
// polygon
// femkant
// trapez
// drage

// samme formel
// parallelogram
// rectangel
// kvadrat
// rhompe
public void setup() {
Ellipse minEllipse = new Ellipse(1,1);
double areal = minEllipse.beregnAreal();
double omkreds = minEllipse.beregnOmkreds();
println(areal);
println(omkreds);


}

  static public void main(String[] passedArgs) {
    String[] appletArgs = new String[] { "perimeter_of_an_ellipse" };
    if (passedArgs != null) {
      PApplet.main(concat(appletArgs, passedArgs));
    } else {
      PApplet.main(appletArgs);
    }
  }
}
