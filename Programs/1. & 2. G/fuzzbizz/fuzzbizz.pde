

    for (int i = 0; i <= 100; ++i) {
        
        if (i%3 == 0 && i%5 == 0) {
            println("FuzzBizz");
        }
        else if (i%3 == 0) {
            println("Fuzz");
        }
        else if (i%5 == 0) {
            println("Bizz");
        }
        else {
            println(i);
        }

    }
    exit();


