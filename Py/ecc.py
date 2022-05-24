import math
from sympy import *
import sys

def ecc(p_, a_, b_, Cb_, isEncode, x_, y_, k_, m_, e_):
    action = str(isEncode)

    a = int(a_)
    b = int(b_)
    if (4*(a**3) + 27*(b**2)) == 0:
        print("Параметры не прошли условие (4*(a**3) + 27*(b**2)) != 0.")
        return

    p = int(p_)
    dictionary_x = {}  # Словарь значений x [0;p-1] и значений x^2 % p
    for i in range(p):  # Заполнение словаря
        k = i
        dictionary_x[k] = i**2 % p
    values = dictionary_x.values()  # Значения словаря
    K = 0  # Счётчик порядка эллиптической кривой
    for x in range(p):  # Цикл рассчёта порядка эллиптической кривой
        Y = (x**3 + a*x + b) % p
        if Y in values and Y != 0:
            K = K+2
        elif Y in values and Y == 0:
            K = K+1
    K = K+1  # Добавление точки Омикрон к порядку
    print("Рассчитанный порядок эллиптической кривой: ", K)

    q = find_q(K)
    print("Получаемое q: ", q)

    Cb = int(Cb_)
    if not Cb < q and Cb > 0:  # Проверка параметра
        print("Введите число 0<Cb<q: ")
        return

    koef_a = a
    if action == "encode":
        x1 = int(x_)
        y1 = int(y_)
        array = choice(x1, y1, Cb, p, koef_a)
        x1 = array[0]
        y1 = array[1]
        print("Точка R с координатами: ", x1, y1)
        m = int(m_)
        if not m < p:  # Проверка параметра
            print("Введите число-сообщение m<p: ")
            return

        k = int(k_)
        if not k < q and k > 0:  # Проверка параметра
            print("Введите любое число k в пределах 0<k<q: ")
            return

        array = choice(x1, y1, k, p, koef_a)
        x1 = array[0]
        y1 = array[1]
        print("Точка P с координатами: ", x1, y1)
        e = m*x1 % p
        print("Вычисленное \"e\": ", e)
        print("Зашифровка: ", "((", x1, ";", y1, ")", e, ")")
    if action == "decode":
        x1 = int(x_)
        y1 = int(y_)
        e = int(e_)
        array = choice(x1, y1, Cb, p, koef_a)
        x1 = array[0]
        y1 = array[1]
        m2 = solve_linear_congruence(x1, e, p)
        print("Расшифрованное число-сообщение: ", m2)


def find_q(K):
    array_deliteli = []
    for i in range(2, K):
        if (K % i) == 0:
            array_deliteli.append(i)
    q = 0
    while q == 0:
        param = array_deliteli[-1]
        if isprime(param):
            q = param
        else:
            array_deliteli.pop(-1)
    return q


# Функция для определения действий в зависимости от свойств числа-композиции точки
def choice(x1, y1, Z, p, koef_a):
    if Z % 2 == 1:  # Если число нечётно
        array = func1(x1, y1, Z, p, koef_a)
        x1 = array[0]
        y1 = array[1]
        return [x1, y1]
    if (Z // 2) % 2 == 1:  # Если число чётно, но не является степенью двойки
        array = func2(x1, y1, Z, p, koef_a)
        x1 = array[0]
        y1 = array[1]
        return [x1, y1]
    if (Z // 2) % 2 == 0 and Z % 2 == 0:  # Если число - степень двойки
        array = func3(x1, y1, Z, p, koef_a)
        x1 = array[0]
        y1 = array[1]
        return [x1, y1]


def func1(x1, y1, Cb, p, koef_a):  # Если число нечётно. Пример: Cb=5. 5-1=4. 4//2=2. Вывод: нужно удвоить точку 2 раза и сложить с изначальной
    Cb = Cb - 1
    K = Cb // 2
    a = x1
    b = y1
    for i in range(K):
        array_double = double(x1, y1, p, koef_a)
        x1 = array_double[0]
        y1 = array_double[1]
    array_sum = sum(x1, y1, a, b, p)
    x1 = array_sum[0]
    y1 = array_sum[1]
    return [x1, y1]


def func2(x1, y1, Cb, p, koef_a):  # Если число чётно, но не является степенью двойки. Пример: Cb=6. 6//2=3. 3-1=2. 2//2=1. Вывод: нужно удвоить точку 1 раз, сложить с изначальной и ещё раз удвоить
    Cb = Cb // 2
    Cb = Cb - 1
    K = Cb // 2
    a = x1
    b = y1
    for i in range(K):
        array_double = double(x1, y1, p, koef_a)
        x1 = array_double[0]
        y1 = array_double[1]
    array_sum = sum(x1, y1, a, b, p)
    x1 = array_sum[0]
    y1 = array_sum[1]
    array_double = double(x1, y1, p, koef_a)
    x1 = array_double[0]
    y1 = array_double[1]
    return [x1, y1]


# Если число - степень двойки. Пример: Cb=4. 4//2=2. Вывод: нуэно удвоить точку 2 раза.
def func3(x1, y1, Cb, p, koef_a):
    K = 0
    while Cb != 1:
        Cb = Cb // 2
        K = K + 1
    for i in range(K):
        array_double = double(x1, y1, p, koef_a)
        x1 = array_double[0]
        y1 = array_double[1]
    return [x1, y1]


def double(x1, y1, p, koef_a):  # Функция для удвоения точки
    param1 = 2*y1
    param2 = 3*(x1**2)+koef_a
    lambd = solve_linear_congruence(param1, param2, p)
    x3 = (lambd**2 - 2*x1) % p
    y3 = (lambd*(x1-x3) - y1) % p
    return [x3, y3]
    

def sum(x1,y1,x2,y2, p): #Функция для суммирования точек
    param1 = x2 - x1
    param2 = y2 - y1
    lambd = solve_linear_congruence(param1, param2, p)
    x3 = (lambd**2 - x1 - x2) % p
    y3 = (lambd*(x1-x3) - y1) % p
    return [x3, y3]


# Функция для решения модульных сравненений
def solve_linear_congruence(a, b, m):
    g = math.gcd(a, m)  # НОД a и m
    if b % g:
        raise ValueError("No solutions")
    a, b, m = a//g, b//g, m//g
    return pow(a, -1, m) * b % m  # вычисление


p = sys.argv[1]
a = sys.argv[2]
b = sys.argv[3]
Cb = sys.argv[4]
x = sys.argv[5]
y = sys.argv[6]
k = sys.argv[7]
e = sys.argv[8]
isEnc = sys.argv[9]
message = sys.argv[10]

ecc(p, a, b, Cb, isEnc, x, y, k, message, e)