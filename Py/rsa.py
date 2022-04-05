import sys


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


def sflex(number):
    return len(str(number))


def find_d_point(a, b, m):
    fim = ayler(m)
    x = (a**(fim-1)) % m
    return x


def vzone(string, dic):
    return [cvalue(dic, i) for i in string]


def upzone(string, u):
    numarray = []
    for i in range(0, len(string), u):
        checkZero = 0
        str_num = ""
        for j in range(u):
            if int(string[i+j]) > 0 and checkZero == 0:
                str_num += string[i+j]
                checkZero = 1
            elif int(string[i+j]) >= 0 and checkZero > 0:
                str_num += string[i+j]
        numarray.append(int(str_num))
    return numarray


def encrypt(array, e, u, v):
    enc = ""
    for x in array:
        y = (x**e) % v
        if sflex(y) < u:
            k = u-sflex(y)
            while k > 0:
                enc += "0"
                k -= 1
            enc += str(y)
        elif sflex(y) == u:
            enc += str(y)

    # x = array
    # y = (x**e) % v
    # if sflex(y) < u:
    #     k = u-sflex(y)
    #     while k > 0:
    #         enc += "0"
    #         k -= 1
    #     enc += str(y)
    # elif sflex(y) == u:
    #     enc += str(y)
    return enc


def decrypt(array, idic, d, v):
    dec = ""
    for x in array:
        y = (x**d) % v
        dec += cvalue(idic, y)
    return dec


dic = {'а': 1, 'б': 2, 'в': 3, 'г': 4, 'д': 5, 'е': 6, 'ё': 7, 'ж': 8, 'з': 9, 'и': 10, 'й': 11, 'к': 12, 'л': 13, 'м': 14, 'н': 15, 'о': 16, 'п': 17, 'р': 18, 'с': 19, 'т': 20, 'у': 21, 'ф': 22, 'х': 23, 'ц': 24, 'ч': 25, 'ш': 26, 'щ': 27, 'ъ': 28, 'ы': 29, 'ь': 30, 'э': 31, 'ю': 32, 'я': 33, 'А': 34, 'Б': 35, 'В': 36, 'Г': 37, 'Д': 38, 'Е': 39, 'Ё': 40, 'Ж': 41, 'З': 42, 'И': 43, 'Й': 44, 'К': 45, 'Л': 46, 'М': 47, 'Н': 48, 'О': 49, 'П': 50,
       'Р': 51, 'С': 52, 'Т': 53, 'У': 54, 'Ф': 55, 'Х': 56, 'Ц': 57, 'Ч': 58, 'Ш': 59, 'Щ': 60, 'Ъ': 61, 'Ы': 62, 'Ь': 63, 'Э': 64, 'Ю': 65, 'Я': 66, '.': 67, ',': 68, '–': 69, '-': 70, '"': 71, '«': 72, '»': 73, '+': 74, '=': 75, ';': 76, '#': 77, '№': 78, '%': 79, ':': 80, '(': 81, ')': 82, '*': 83, '\\': 84, '/': 85, '|': 86, '0': 87, '1': 88, '2': 89, '3': 90, '4': 91, '5': 92, '6': 93, '7': 94, '8': 95, '9': 96, '!': 97, '?': 98, ' ': 99, '—': 100}


idic = upsidedown(dic)


def encryptmessage(orig, p, q, e):

    if ayler(p) != p-1:
        print('\nОшибка. p - простое число.\n')

    if ayler(q) != q-1:
        print('\nОшибка. q - простое число.\n')

    n = p*q
    if(n < len(dic)):
        print('\nОшибка. Слишком малые значение p и q.\n')

    #print("n = p * q = ", n)
    fin = ayler(n)
    #print("fi(n) = ", fin)
    finflex = sflex(n)

    if euclid(e, fin) != 1:
        print('\nОшибка. e - взаимно простое с fi(n).\n')

    #print("\nОткрытые ключи:\nn: ", n, "\ne: ", e)
    d = find_d_point(e, 1, fin)
    #print("\nСекретный ключ d:", d)

    origv = vzone(orig, dic)
    #origv = int(orig)

    cry = encrypt(origv, e, finflex, n)
    #print("\nЗашифрованный текст: ", cry)

    return "".join(cry)


def decryptmessage(orig, p, q, e):

    if ayler(p) != p-1:
        print('\nОшибка. p - простое число.\n')

    if ayler(q) != q-1:
        print('\nОшибка. q - простое число.\n')

    n = p*q
    if(n < len(dic)):
        print('\nОшибка. Слишком малые значение p и q.\n')

    #print("n = p * q = ", n)
    fin = ayler(n)
    #print("fi(n) = ", fin)
    finflex = sflex(n)

    if euclid(e, fin) != 1:
        print('\nОшибка. e - взаимно простое с fi(n).\n')

    #print("\nОткрытые ключи:\nn: ", n, "\ne: ", e)
    d = find_d_point(e, 1, fin)
    #print("\nСекретный ключ d:", d)

    origv = vzone(orig, dic)
    cry = encrypt(origv, e, finflex, n)
    #print("\nЗашифрованный текст: ", cry)
    if len(orig) % finflex != 0:
        print("Ошибка. Длина шифртекста не кратна количесту цифр в n.")

    origcz = upzone(orig, finflex)
    cry = decrypt(origcz, idic, d, n)
    #print("\nРасшифрованный текст: ", cry)

    return "".join(cry)


p = int(sys.argv[1])
q = int(sys.argv[2])
e = int(sys.argv[3])
isEncrypt = bool(int(sys.argv[4]))
inputStr = sys.argv[5]

if isEncrypt:
    print(encryptmessage(inputStr, p, q, e))
else:
    print(decryptmessage(inputStr, p, q, e))
