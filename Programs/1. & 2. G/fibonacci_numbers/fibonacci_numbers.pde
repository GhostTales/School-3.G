

// fibonacci with math
//    void setup() {
//         long count = 93, num1 = 0, num2 = 1;
//         for (int i = 1; i <= count; ++i) {
//             println(num1+" ");
//             long sumOfPrevTwo = num1 + num2;
//             num1 = num2;
//             num2 = sumOfPrevTwo; 
//         }
//     }


// fibonacci with array
// max size is 93 before it reaches integer limit
// amount is the length of the array and if it is a negative number it gets converted to a positive
// if amount is 1, 2 or 0 prints appropriate places in Fibonacci sequence
// uses round for decimal numbers

// max size of array is 93 before it reaches the limit of a long
// uses round() for decimal numbers
int fibNumbers = 93;

int amount = round(constrain(fibNumbers, -93, 93));
if (amount < 0) {
    amount = amount * (-1);
}
// amount is the length of the array and if it is a negative number, it gets converted to a positive

    long[] fib = new long[amount];
if (amount >= 3) {
    fib[1] = fib[2] = 1;
    for (int i = 2; i < amount; ++i) {
        fib[i] = fib[i-1] + fib[i-2];
    } println(fib);
} 

// if amount is 1, 2 or 0 prints appropriate places in Fibonacci sequence
else if (amount == 2) {
    fib[1] = 1;
    println(fib);
} else if (amount == 1) {
    println(fib);
} else if (amount == 0) {
    println("unable, array cant be 0 in length");
}
