# Change the first number in parentheses
import sys

sys.set_int_max_str_digits(100000)


fib = [0] * (100 + 3)
fib[1] = fib[2] = 1
for i in range(2, len(fib)):
    fib[i] = fib[i - 1] + fib[i - 2]
    print(f'[{i - 2}]({len(str(fib[i - 2]))})  {fib[i - 2]}')
