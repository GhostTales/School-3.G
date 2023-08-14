
int threadCount = 8;

void setup() {
     for (int i = 0; i < threadCount; ++i) {
        thread("test");
    }
    noLoop();
}
      
void test() {
 for (int t = 0; t < 100; ++t) {
        int time = 0;

        float[] numbers = new float[50];
        for (int i = 0; i < numbers.length; ++i) {
            numbers[i] = random(10);
            
        }

        time = millis();
       for (int j = 0; j < 10000000; j++) {

        numbers = reverse(numbers);
        
       }
      
      println(millis() - time);
       }
}
