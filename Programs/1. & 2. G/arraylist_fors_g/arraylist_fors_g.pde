




 for (int t = 0; t < 10; ++t) {
        IntList numbers;
        numbers = new IntList();
        int time = 0;

        for (int i = 0; i < 100; ++i) {
        numbers.append(round(random(100)));
    

        time = millis();
            for (int j = 0; j < 1000000; j++) {
            numbers.reverse();
       }

    }
        
      println(millis() - time);
 }