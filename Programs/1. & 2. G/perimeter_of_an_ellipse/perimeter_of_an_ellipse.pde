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
  double beregnOmkreds() {
    return Math.PI * (storAkse + lilleAkse) * (1 + (3 * h / (10 + Math.sqrt(4 - 3 * h))));
  } 
  double beregnAreal() {
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