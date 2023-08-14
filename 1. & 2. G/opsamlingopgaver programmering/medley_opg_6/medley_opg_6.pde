import controlP5.*;
ControlP5 text;

void setup() {
  size(340, 500);
  background(51);
  textAlign(CENTER);
  PFont font = createFont("Arial", 20);
  text = new ControlP5(this);

  text.addTextfield("Username").setPosition(20, 100).setSize(200, 40).setFocus(true).setFont(font).setAutoClear(false);
  text.addTextfield("Heltal1").setPosition(20, 200).setSize(200, 40).setFont(font).setAutoClear(false);
  text.addTextfield("Heltal2").setPosition(20, 300).setSize(200, 40).setFont(font).setAutoClear(false);
  text.addBang("Submit").setPosition(240, 300).setSize(80, 40).getCaptionLabel().align(ControlP5.CENTER, ControlP5.CENTER).setFont(font);    
}
void draw(){}

void Submit() {
  String username = text.get(Textfield.class,"Username").getText();
  float heltal1 = float(text.get(Textfield.class,"Heltal1").getText());
  float heltal2 = float(text.get(Textfield.class,"Heltal2").getText());
  
  if (heltal1 %1 != 0) {
  text.get(Textfield.class,"Heltal1").setText("invalid");
  }
  if (heltal2 %1 != 0) {
  text.get(Textfield.class,"Heltal2").setText("invalid");
  }

  heltal1 = float(text.get(Textfield.class,"Heltal1").getText());
  heltal2 = float(text.get(Textfield.class,"Heltal2").getText());
  
  int product = int(heltal1) * int(heltal2);
  text(username + " your product is " + product, 170, 450);
}
