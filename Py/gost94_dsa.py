import sys

def cvalue(d, value):
    if value in d:
        return d[value]
    else:
        print(value, " нет в словаре.")
        exit()


def upsidedown(d):
    h = {}
    for k, v in d.items():
        h[v] = k
    return h


#dic = {'а': 1, 'б': 2, 'в': 3, 'г': 4, 'д': 5, 'е': 6, 'ё': 7, 'ж': 8, 'з': 9, 'и': 10, 'й': 11, 'к': 12, 'л': 13, 'м': 14, 'н': 15, 'о': 16, 'п': 17, 'р': 18, 'с': 19, 'т': 20, 'у': 21, 'ф': 22, 'х': 23, 'ц': 24, 'ч': 25, 'ш': 26, 'щ': 27, 'ъ': 28, 'ы': 29, 'ь': 30, 'э': 31, 'ю': 32, 'я': 33, 'А': 34, 'Б': 35, 'В': 36, 'Г': 37, 'Д': 38, 'Е': 39, 'Ё': 40, 'Ж': 41, 'З': 42, 'И': 43, 'Й': 44, 'К': 45, 'Л': 46, 'М': 47, 'Н': 48, 'О': 49, 'П': 50,
#       'Р': 51, 'С': 52, 'Т': 53, 'У': 54, 'Ф': 55, 'Х': 56, 'Ц': 57, 'Ч': 58, 'Ш': 59, 'Щ': 60, 'Ъ': 61, 'Ы': 62, 'Ь': 63, 'Э': 64, 'Ю': 65, 'Я': 66, '.': 67, ',': 68, '–': 69, '-': 70, '"': 71, '«': 72, '»': 73, '+': 74, '=': 75, ';': 76, '#': 77, '№': 78, '%': 79, ':': 80, '(': 81, ')': 82, '*': 83, '\\': 84, '/': 85, '|': 86, '0': 87, '1': 88, '2': 89, '3': 90, '4': 91, '5': 92, '6': 93, '7': 94, '8': 95, '9': 96, '!': 97, '?': 98, ' ': 99}
dic = {'а': 1, 'б': 2, 'в': 3, 'г': 4, 'д': 5, 'е': 6, 'ж': 7, 'з': 8, 'и': 9, 'й': 10, 'к': 11, 'л': 12, 'м': 13, 'н': 14, 'о': 15, 'п': 16, 'р': 17, 'с': 18, 'т': 19, 'у': 20, 'ф': 21, 'х': 22, 'ц': 23, 'ч': 24, 'ш': 25, 'щ': 26, 'ъ': 27, 'ы': 28, 'ь': 29, 'э': 30, 'ю': 31, 'я': 32}

idic = upsidedown(dic)


def ayler(n):
    f = n
    if n % 2 == 0:
        while n % 2 == 0:
            n = n // 2
        f = f // 2
    i = 3
    while i*i <= n:
        if n % i == 0:
            while n % i == 0:
                n = n // i
            f = f // i
            f = f * (i-1)
        i = i + 2
    if n > 1:
        f = f // n
        f = f * (n-1)
    return f


def euclid(a, b):
    while a != b:
        if a > b:
            a = a - b
        else:
            b = b - a
    return a


def hash(text, p, q):
    h = []
    i = 0
    h.append(int(0))
    for char in text:

        h.append(((h[-1]+dic[char])**2) % p)
        i += 1
    if h[-1] % q == 0:
        t = 1
    else:
        t = h[-1]
    print('\nХэш:', t)
    return t


def gencp(orig, p, q, a, x, k):

    if ayler(p) != p-1:
        print('\nОшибка. p - простое число.\n')

    if ayler(q) != q-1 or (p-1) % q != 0:
        print('\nОшибка. q - простое число, сомножитель p-1.\n')

    if a <= 1 or a >= p-1 or a**q % p != 1:
        print(f'Ошибка, a должно быть в интервале (1;{p-1}) и (a**q % p) = 1.')

    if x >= q:
        print('\nОшибка. x меньше q.\n')

    if k >= q:
        print('\nОшибка. k меньше q.\n')

    y = a**x % p
    print("\ny: ", y)

    print("\nОткрытые ключи:\np: ", p, "\nq: ", q, "\na: ", a)
    print("\nСекретный ключ x:", x)

    #hm = hash(orig, p, q)
    #hm = 4
    r = (a**k % p) % q
    if r == 0:
        print("Ошибка. r=0. Смените k.")
        exit()
    s = (x*r + k*hm) % q
    print("Подпись: ", r % (2**256), " , ", s % (2**256))

    return r % (2**256), s % (2**256)


def checkcp(orig, p, q, a, x, k, r, s):

    if ayler(p) != p-1:
        print('\nОшибка. p - простое число.\n')

    if ayler(q) != q-1 or (p-1) % q != 0:
        print('\nОшибка. q - простое число, сомножитель p-1.\n')

    if a <= 1 or a >= p-1 or a**q % p != 1:
        print(f'Ошибка, a должно быть в интервале (1;{p-1}) и (a**q % p) = 1.')

    if x >= q:
        print('\nОшибка. x меньше q.\n')

    if k >= q:
        print('\nОшибка. k меньше q.\n')

    y = a**x % p
    print("\ny: ", y)

    print("\nОткрытые ключи:\np: ", p, "\nq: ", q, "\na: ", a)
    print("\nСекретный ключ x:", x)

    hm = hash(orig, p, q)

    if r == 0:
        print("Ошибка. r=0. Смените k.")

    hm = hash(orig, p, q)

    v = (hm**(q-2)) % q
    z1 = (s * v) % q
    z2 = ((q - r) * v) % q
    u = ((a**z1 * y**z2) % p) % q
    print(f'v: {v}', f'z1: {z1}', f'z2: {z2}', f'u: {u}', sep='\n')
    if u == r:
        return "Подпись верна"

    else:
        return "Подпись НЕ верна"

p = int(sys.argv[1])
q = int(sys.argv[2])
a = int(sys.argv[3])
x = int(sys.argv[4])
k = int(sys.argv[5])
r = int(sys.argv[6])
s = int(sys.argv[7])

isSign = bool(int(sys.argv[8]))
message_ = sys.argv[9]

if isSign:
    print(gencp(message_, p, q, a, x, k))
else:
    print(checkcp(message_, p, q, a, x, k, r, s))