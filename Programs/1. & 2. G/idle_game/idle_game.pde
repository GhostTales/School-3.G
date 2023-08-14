import controlP5.*;
ControlP5 gameButton, menuButton;

int frames = 120; 
int timer, seconds, minutes;
float value, lifetimeValue;
float multiCost = 1.3, multiMultiplier = 1;
float multiAmountCost = 1.75, multiAmount = 1.2;
float rebirthMulti = 1, rebirthCost = 100000;
int rebirth;
float clickerCost = 2.1; 
int amountClicker;
boolean statsScreen = false;
PImage gameplayButtons, gameplayButtons1, gameplayButtons2, gameplayButtons3, gameplayButtons4, gameplayButtons5, gameplayButtons6, gameplayButtons7, gameplayButtons8, gameplayButtons9, gameplayButtons10, gameplayButtons11;
JSONObject json;

void setup() {
  frameRate(frames);
  size(450, 720);
  background(0);   
  gameButton = new ControlP5(this);
  menuButton = new ControlP5(this);
  buttons();
  strokeWeight(5);
  stroke(200);
  textAlign(CENTER);
  
//loads saved progress of the game
  json = loadJSONObject("data/saveData.json");

  timer = json.getInt("timer");
  seconds = json.getInt("seconds");
  minutes = json.getInt("minutes");
  value = json.getFloat("value");
  lifetimeValue = json.getFloat("lifetimeValue");
  multiMultiplier = json.getFloat("multiMultiplier");
  multiAmount = json.getFloat("multiAmount");
  rebirthCost = json.getFloat("rebirthCost");
  rebirth = json.getInt("rebirth");
  rebirthMulti = json.getFloat("rebirthMulti");
  multiCost = json.getFloat("multiCost");
  multiAmountCost = json.getFloat("multiAmountCost");
  clickerCost = json.getFloat("clickerCost");
  amountClicker = json.getInt("amountClicker");
  

// Image loading
  gameplayButtons = loadImage("idle_game_buttons.png");
  gameplayButtons1 = loadImage("idle_game_buttons (1).png");
  gameplayButtons2 = loadImage("idle_game_buttons (2).png");
  gameplayButtons3 = loadImage("idle_game_buttons (3).png");
  gameplayButtons4 = loadImage("idle_game_buttons (4).png");
  gameplayButtons5 = loadImage("idle_game_buttons (5).png");
  gameplayButtons6 = loadImage("idle_game_buttons (6).png");
  gameplayButtons7 = loadImage("idle_game_buttons (7).png");
  gameplayButtons8 = loadImage("idle_game_buttons (8).png");
  gameplayButtons9 = loadImage("idle_game_buttons (9).png");
  gameplayButtons10 = loadImage("idle_game_buttons (10).png");
  gameplayButtons11 = loadImage("idle_game_buttons (11).png");
}

void draw() {
  background(0); 
  clock();
  automaticClicker();
  menu();
  textSize(16);
  fill(200);

// max allowed values
  constrain(value, 0, pow(2, 63));
  constrain(multiMultiplier, 0, pow(2, 63));
  constrain(multiAmount, 0, pow(2, 63));
  constrain(rebirthCost, 0, pow(2, 60));
  constrain(multiCost, 0, pow(2, 60));
  constrain(multiAmountCost, 0, pow(2, 60));
  constrain(clickerCost, 0, pow(2, 60));
  if (value >= pow(2, 63) || multiMultiplier >= pow(2, 63) || multiAmount >= pow(2, 63)) {
    text("cheating are we?" + "\n" + "or just to good", width/2, 100);
  }
}

void consolePrint() {
  println("Credits " + nf(value, 0, 2) + " | multi " + nf(multiMultiplier, 0, 2) + " | amount multi " + 
    nf(multiAmount, 0, 2) + " | rebirth multi " + nf(rebirthMulti, 0, 2) + " | rebirth " + rebirth + 
    " | clickers " + amountClicker);
}

void clock() {
  timer = frameCount % frames;
  if (timer >= frames-1) {
    seconds ++;

    //auto saves the game every 10 seconds
    if (seconds == 10) {
      JSONObject json = new JSONObject();
      json.setInt("timer", timer);
      json.setInt("seconds", seconds);
      json.setInt("minutes", minutes);
      json.setFloat("value", value);
      json.setFloat("lifetimeValue", lifetimeValue);
      json.setFloat("multiMultiplier", multiMultiplier);
      json.setFloat("multiAmount", multiAmount);
      json.setFloat("rebirthCost", rebirthCost);
      json.setInt("rebirth", rebirth);
      json.setFloat("rebirthMulti", rebirthMulti);
      json.setFloat("multiCost", multiCost);
      json.setFloat("multiAmountCost", multiAmountCost);
      json.setFloat("clickerCost", clickerCost);
      json.setInt("amountClicker", amountClicker);

      saveJSONObject(json, "data/saveData.json");
    }
  } else if (seconds >= 60) {
    seconds -= 60;
    minutes ++;
  }
  fill(255);
  textSize(16);
  text(nf(minutes, 2, 0) + ":" + nf(seconds, 2, 0) + ":" + nf(timer*10/(frames/10), 2, 0), width/2, 20);
  text("Rebirth  " + rebirth, 125 , 20);
  text("FPS:  " + nf(frameRate,0,1), 320 , 20);
  fill(200, 75);
  rect(width/2-155, -40, 310, 75, 50);
}

void menu() {
    if(statsScreen == true) {
    fill(230, 90);
    rect(50, 50, width-100, height-100, 28);
    fill(230, 0, 0, 90);
    rect(50, 50, width-100, 50, 50 ,50 ,0 ,0);
    fill(0, 0, 230, 90);
    rect(50, height-100, width-100, 50, 0 ,0 ,50 ,50);
    fill(255);
    text("CLOSE", width/2 , 80);
    text("NEW GAME", width/2 , height-70);
    textAlign(LEFT);
    text(
      "Credits:  " + "\n" +
       nfc((long)value,0) + "\n" +
      
      "Life time Credits:  " + "\n" +
       nfc((long)lifetimeValue,0) + "\n" +
      
      "Rebirths:  " + "\n" +
       rebirth + "\n" +
      
      "Rebirth multiplier:  " + "\n" +
       nf(rebirthMulti,0,2) + "\n" +
      
      "Multiplier:  " + "\n" +
       nf(multiMultiplier,0,2) + "\n" +
      
      "Multiplier buy multi:  " +
       "\n" + nf(multiAmount,0,2) + "\n" +
      
      "Clickers:  " + "\n" +
       amountClicker + "\n" 
      , 60, 125);

    textAlign(CENTER);
    menuButton.show();
    } else {  //gameplay screen
      fill(200);
      line(width, height/2, 0, height/2);
      text("Credits  " + nfc((long)value,0), width/2, height/4);
      buttonProgress();
      menuButton.hide();
  }
}

void automaticClicker() {
    if (amountClicker >= 1) {
    if (timer % 5 == 0) {
      value += 1 * multiMultiplier * rebirthMulti * amountClicker/5;
      lifetimeValue += 1 * multiMultiplier * rebirthMulti * amountClicker/5;
    }
  }
}

void buttons() {
  gameButton.addButton("screen").setPosition(0, 0).setSize(width, height/2).setImage(loadImage("1x1_pixel.png"))
    ;
  gameButton.addButton("Multiplier").setPosition(15, height/3+150).setSize(200, 75).setImage(loadImage("1x1_pixel.png"))
    ;
  gameButton.addButton("autoClicker").setPosition(15, height/3+250).setSize(200, 75).setImage(loadImage("1x1_pixel.png"))
    ;
  gameButton.addButton("stats").setPosition(15, height/3+350).setSize(200, 75).setImage(loadImage("1x1_pixel.png"))
    ;
  gameButton.addButton("Multi Amount").setPosition(width-215, height/3+150).setSize(200, 75).setImage(loadImage("1x1_pixel.png"))
    ;
  gameButton.addButton("Rebirth").setPosition(width-215, height/3+250).setSize(200, 75).setImage(loadImage("1x1_pixel.png"))
    ;
  gameButton.addButton("save").setPosition(width-215, height/3+350).setSize(200, 75).setImage(loadImage("1x1_pixel.png"))
    ;
  menuButton.addButton("Close").setPosition(50, 50).setSize(width-100, 50).setImage(loadImage("1x1_pixel.png"))
    ;
  menuButton.addButton("newGame").setPosition(50, height-100).setSize(width-100, 50).setImage(loadImage("1x1_pixel.png"))
    ;
}

void buttonProgress() {
      fill(255);
      if (pow(multiCost, 2.5) > value) {
        image(gameplayButtons11,15, height/3+150);
        text(nf(value/pow(multiCost, 2.5)*100, 0, 1) + "%", 115, height/3+200);
        rect(25, height/3+210, constrain(value/pow(multiCost, 2.5)*180, 1, 180), 5 , 20);
      } else{
        image(gameplayButtons1,15, height/3+150);
        text(nf(value/pow(multiCost, 2.5)*100, 0, 1) + "%", 115, height/3+200);
        rect(25, height/3+210, constrain(value/pow(multiCost, 2.5)*180, 0, 180), 5 , 20);
      }
      if (pow(clickerCost, 4) > value) {
        image(gameplayButtons8,15, height/3+250);
        text(nf(value/pow(clickerCost, 4)*100, 0, 1) + "%", 115, height/3+300);
        rect(25, height/3+310, constrain(value/pow(clickerCost, 4)*180, 1, 180), 5 , 20);
      } else{
        image(gameplayButtons3,15, height/3+250);
        text(nf(value/pow(clickerCost, 4)*100, 0, 1) + "%", 115, height/3+300);
        rect(25, height/3+310, constrain(value/pow(clickerCost, 4)*180, 0, 180), 5 , 20);
      }
      if (statsScreen == false) {
        image(gameplayButtons5, 15, height/3+350);
      }
      if (pow(multiAmountCost, 3) > value) {
        image(gameplayButtons7, width-215, height/3+150);
        text(nf(value/pow(multiAmountCost, 3)*100, 0, 1) + "%", width-115, height/3+200);
        rect(width-205, height/3+210, constrain(value/pow(multiAmountCost, 3)*180, 1, 180), 5 , 20);
      } else{
        image(gameplayButtons2,width-215, height/3+150);
        text(nf(value/pow(multiAmountCost, 3)*100, 0, 1) + "%", width-115, height/3+200);
        rect(width-205, height/3+210, constrain(value/pow(multiAmountCost, 3)*180, 0, 180), 5 , 20);
      }
      if (rebirthCost> value) {
        image(gameplayButtons10, width-215, height/3+250);
        text(nf(value/rebirthCost*100, 0, 1) + "%", width-115, height/3+300);
        rect(width-205, height/3+310, constrain(value/rebirthCost*180, 1, 180), 5 , 20);
      } else{
        image(gameplayButtons6,width-215, height/3+250);
        text(nf(value/rebirthCost*100, 0, 1) + "%", width-115, height/3+300);
        rect(width-205, height/3+310, constrain(value/rebirthCost*180, 0, 180), 5 , 20);
      }
      fill(150, 75);
      noStroke();
      rect(25, height/3+208, 180, 10 , 20);
      rect(25, height/3+308, 180, 10 , 20);
      rect(width-205, height/3+208, 180, 10 , 20);
      rect(width-205, height/3+308, 180, 10 , 20);
      image(gameplayButtons4, width-215, height/3+350);
      stroke(200);
      
}

void controlEvent(CallbackEvent event) {
  
  if (event.getAction() == ControlP5.ACTION_CLICK) {
    switch(event.getController().getAddress()) {
    case "/screen":
      value += 1 * multiMultiplier * rebirthMulti;
      lifetimeValue += 1 * multiMultiplier * rebirthMulti;
      consolePrint();
      break;

    case "/Multiplier":
      if (value >= pow(multiCost, 2.5)) {
        value -= pow(multiCost, 2.5);
        multiMultiplier += multiAmount;
        multiCost *= 1.25;
        consolePrint();
      } else {
        println("not enough Credits - " + pow(multiCost, 2.5) + " needed");
      }
      break;

    case "/Multi Amount":
      if (value >= pow(multiAmountCost, 3)) {
        value -= pow(multiAmountCost, 3);
        multiAmount *= 1.131;
        multiAmountCost *= 1.2;
        consolePrint();
      } else {
        println("not enough Credits - " + pow(multiAmountCost, 3) + " needed");
      }
      break;

    case "/autoClicker":
      if (value >= pow(clickerCost, 4)) {
        value -= pow(clickerCost, 4);
        clickerCost *= 1.3;
        amountClicker ++;
        consolePrint();
      } else {
        println("not enough Credits - " + pow(clickerCost, 4) + " needed");
      }
      break;

    case "/save":
    
      JSONObject json = new JSONObject();
      json.setInt("timer", timer);
      json.setInt("seconds", seconds);
      json.setInt("minutes", minutes);
      json.setFloat("value", value);
      json.setFloat("lifetimeValue", lifetimeValue);
      json.setFloat("multiMultiplier", multiMultiplier);
      json.setFloat("multiAmount", multiAmount);
      json.setFloat("rebirthCost", rebirthCost);
      json.setInt("rebirth", rebirth);
      json.setFloat("rebirthMulti", rebirthMulti);
      json.setFloat("multiCost", multiCost);
      json.setFloat("multiAmountCost", multiAmountCost);
      json.setFloat("clickerCost", clickerCost);
      json.setInt("amountClicker", amountClicker);

      saveJSONObject(json, "data/saveData.json");
      break;

    case "/stats":
      gameButton.hide();
      statsScreen = true;
      
      break;

    case "/Rebirth":
      if (value >= rebirthCost) {
        value -= multiAmountCost;
        rebirthCost *= pow(2, 1.65) ;
        rebirthMulti *= 1.8;
        rebirth ++;
        value = 0; 
        multiCost = 1.3; 
        multiMultiplier = 1; 
        multiAmountCost = 1.75; 
        multiAmount = 1.2;
        amountClicker = 0;
        clickerCost = 2.1;
        consolePrint();
      } else {
        println("not enough Credits - " + rebirthCost + " needed");
      }
      break;

    case "/Close":
      gameButton.show();
      statsScreen = false;
      break;
    
    case "/newGame":
      gameButton.show();
      statsScreen = false;
      
      timer = 0; 
      seconds = 0; 
      minutes = 0;
      value = 0; 
      lifetimeValue = 0;
      multiCost = 1.3; 
      multiMultiplier = 1;
      multiAmountCost = 1.75; 
      multiAmount = 1.2;
      rebirthMulti = 1; 
      rebirthCost = 100000;
      rebirth = 0;
      clickerCost = 2.1; 
      amountClicker = 0;
      break;
    }
  }
}