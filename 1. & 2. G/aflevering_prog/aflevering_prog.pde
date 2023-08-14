
int doubles;
float summen;
int find = 4;

void setup() {
       int[] numbers = new int[50];

        for (int i = 0; i < numbers.length; ++i) {
            numbers[i] = round(random(10));
            
        }
        numbers = sort(numbers);
        
        for (int j = 1; j < numbers.length; ++j) {
            if (numbers[j] == numbers[j-1]) {
              doubles++;
              numbers[j-1] = -1;
          }
        }
        
        numbers = reverse(sort(numbers));
        for (int i = 0; i < doubles; ++i) {
          numbers = shorten(numbers);
          
        }
      
        for (int i = 0; i < numbers.length; ++i) {
            summen += numbers[i];
        }
        
        println(numbers);

        for (int i = 0; i < numbers.length; ++i) {
            if (numbers[i] == find) {
              println(find + " er i tabellen");
            } else if (numbers[i] != find)  {
              
            } else {
              println(find + " er ikke i tabellen");
            }
        }

       println("Sum = " + int(summen));
       println("Middel = " + summen/numbers.length);
       println("Min = " + min(numbers));
       println("Max = " + max(numbers));
       println("dubletter = " + doubles);

       numbers = reverse(numbers);
       println(numbers);
       
}