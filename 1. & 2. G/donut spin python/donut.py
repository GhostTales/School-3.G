import itertools
import time
import math
A, B = 0, 0
print("\x1b[2J", end='')
while True:
    z = [0] * 1760
    b = [' '] * 1760
    for j, i in itertools.product(range(0, 628, 7), range(0, 628, 2)):
        c = math.sin(i)
        d = math.cos(j)
        e = math.sin(A)
        f = math.sin(j)
        g = math.cos(A)
        h = d + 2
        D = 1 / (c * h * e + f * g + 5)
        l = math.cos(i)
        m = math.cos(B)
        n = math.sin(B)
        t = c * h * g - f * e
        x = int(40 + 30 * D * (l * h * m - t * n))
        y = int(12 + 15 * D * (l * h * n + t * m))
        o = int(x + 80 * y)
        N = int(8 * ((f * e - c * d * g) * m - c * d * e - f * g - l * d * n))
        if y < 22 and y > 0 and x > 0 and x < 80 and D > z[o]:
            z[o] = D
            b[o] = ".,-~:;=!*#$@"[max(N, 0)]
    print('\x1b[H', end='')
    for k in range(1761):
        print((b[k] if k % 80 else '\n'), end='')
        A += 0.00004
        B += 0.00002
