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


dic = {'а': 1, 'б': 2, 'в': 3, 'г': 4, 'д': 5, 'е': 6, 'ё': 7, 'ж': 8, 'з': 9, 'и': 10, 'й': 11, 'к': 12, 'л': 13, 'м': 14, 'н': 15, 'о': 16, 'п': 17, 'р': 18, 'с': 19, 'т': 20, 'у': 21, 'ф': 22, 'х': 23, 'ц': 24, 'ч': 25, 'ш': 26, 'щ': 27, 'ъ': 28, 'ы': 29, 'ь': 30, 'э': 31, 'ю': 32, 'я': 33, 'А': 34, 'Б': 35, 'В': 36, 'Г': 37, 'Д': 38, 'Е': 39, 'Ё': 40, 'Ж': 41, 'З': 42, 'И': 43, 'Й': 44, 'К': 45, 'Л': 46, 'М': 47, 'Н': 48, 'О': 49, 'П': 50,
       'Р': 51, 'С': 52, 'Т': 53, 'У': 54, 'Ф': 55, 'Х': 56, 'Ц': 57, 'Ч': 58, 'Ш': 59, 'Щ': 60, 'Ъ': 61, 'Ы': 62, 'Ь': 63, 'Э': 64, 'Ю': 65, 'Я': 66, '.': 67, ',': 68, '–': 69, '-': 70, '"': 71, '«': 72, '»': 73, '+': 74, '=': 75, ';': 76, '#': 77, '№': 78, '%': 79, ':': 80, '(': 81, ')': 82, '*': 83, '\\': 84, '/': 85, '|': 86, '0': 87, '1': 88, '2': 89, '3': 90, '4': 91, '5': 92, '6': 93, '7': 94, '8': 95, '9': 96, '!': 97, '?': 98, ' ': 99, '—':100}
#dic = {'а': 1, 'б': 2, 'в': 3, 'г': 4, 'д': 5, 'е': 6, 'ё': 7, 'ж': 8, 'з': 9, 'и': 10, 'й': 11, 'к': 12, 'л': 13, 'м': 14, 'н': 15, 'о': 16, 'п': 17, 'р': 18, 'с': 19, 'т': 20, 'у': 21, 'ф': 22, 'х': 23, 'ц': 24, 'ч': 25, 'ш': 26, 'щ': 27, 'ъ': 28, 'ы': 29, 'ь': 30, 'э': 31, 'ю': 32, 'я': 33}


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


def hash(text, n):
    h = []
    i = 0
    h.append(int(0))
    for char in text:

        h.append(((h[-1]+dic[char])**2) % n)
        i += 1

    print('\nХэш:', h[-1], "\n")
    return h[-1]


def genecp(orig, p, q, e):

    if ayler(p) != p-1:
        print('\nОшибка. p - простое число.\n')
        exit()

    if ayler(q) != q-1:
        print('\nОшибка. q - простое число.\n')
        exit()
    n = p*q
    if(n < len(dic)):
        print('\nОшибка. Слишком малые значение p и q.\n')
        exit()
    print("n = p * q = ", n)
    fin = ayler(n)
    print("fi(n) = ", fin)
    if euclid(e, fin) != 1:
        print('\nОшибка. e - взаимно простое с fi(n).\n')
        exit()
    print("\nОткрытые ключи:\nn: ", n, "\ne: ", e)
    d = e ** (fin - 1) % fin
    print("\nСекретный ключ d:", d)

    hm = hash(orig, n)
    #hm=int(orig)

    sign = (hm**d) % n
    print("Подпись: ", sign)

    return sign


def checkecp(orig, p, q, e, sign):
    if ayler(p) != p-1:
        print('\nОшибка. p - простое число.\n')
        exit()
    if ayler(q) != q-1:
        print('\nОшибка. q - простое число.\n')
        exit()
    n = p*q
    if(n < len(dic)):
        print('\nОшибка. Слишком малые значение p и q.\n')
        exit()
    print("n = p * q = ", n)
    fin = ayler(n)
    print("fi(n) = ", fin)
    if euclid(e, fin) != 1:
        print('\nОшибка. e - взаимно простое с fi(n).\n')
        exit()
    print("\nОткрытые ключи:\nn: ", n, "\ne: ", e)
    d = e ** (fin - 1) % fin
    print("\nСекретный ключ d:", d)

    hm = hash(orig, n)
    #hm=int(orig)

    mate = (sign**e) % n
    if mate == hm:
        return "Подпись верна"
    else:
        return "Подпись НЕ верна"

p = int(sys.argv[1])
q = int(sys.argv[2])
e = int(sys.argv[3])
sign = int(sys.argv[4])
isSign = bool(int(sys.argv[5]))
message_ = sys.argv[6]

if isSign:
    print(genecp(message_, p, q, e))
else:
    print(checkecp(message_, p, q, e, sign))