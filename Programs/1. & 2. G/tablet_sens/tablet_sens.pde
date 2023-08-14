
// set your preferred min and max width of tablet area plus the ratio you want
float min = 80, max = 120, ratio = 1.4;




    boolean perfect = false;
    for (float f = min; f <= max; ++f) {
        if (f/ratio == int(f/ratio)) {
            println(f + " x " + f/ratio);
            perfect = true;
        }
    }
    if (perfect != true) {
        println("no perfect values");
    }
    exit();



