import sys

pleifer_alph = []
alph_ = "абвгдежзиклмнопрстуфхцчшщьыэюя"

# isAlphFull = bool(int(sys.argv[1]))
# isEncrypt = bool(int(sys.argv[2]))

# key = sys.argv[3]
# inputStr = sys.argv[4]

# if isAlphFull:
#     alph_ = "абвгдежзийклмнопрстуфхцчшщъыьэюя—,?. "
# else:
#     alph_ = "абвгдежзиклмнопрстуфхцчшщьыэюя"


def find_let(arr, item):
    for i in range(len(arr)):
        for j in range(len(arr[i])):
            if arr[i][j] == item:
                return (i, j)
    return (-1, -1)


def create_table(key):
    alph = alph_
    key = [x for x in key]
    for l in key:
        if l in alph:
            alph = alph.replace(l, "")
    table = [["" for _ in range(6)] for _ in range(5)]
    cur_row = 0
    cur_col = 0
    for i in range(len(key)):
        table[cur_row][cur_col] = key[i]
        cur_col += 1
        if cur_col > 5:
            cur_row += 1
            cur_col = 0

    k = 0
    for i in range(len(table)):
        for j in range(len(table[0])):
            if table[i][j] == "":
                table[i][j] = alph[k]
                k += 1
    global pleifer_alph
    pleifer_alph = table.copy()
    print(table)


def split_doubled(text):
    text = [x for x in text]
    for i in range(1, len(text)):
        if text[i] == text[i-1]:
            text.insert(i, "Ф")
    return text


def preapre_text(text):
    for i in range(len(text)):
        if text[i] == "Ь":
            text[i] = "Ъ"
        if text[i] == "Й":
            text[i] = "И"
    text = split_doubled(text)
    if len(text) % 2 != 0:
        text.append("Ф")
    return text


def to_bin(text):
    result = []
    c = ""
    for i in text:
        c += i
        if len(c) == 2:
            result.append(c)
            c = ""
    return result


def pleifer_encrypt(text, key):
    create_table(key)
    text = [i for i in text]
    text = to_bin(preapre_text(text))
    encrypt = ""
    print(text)
    for i in range(len(text)):
        a = text[i][0]
        b = text[i][1]
        cord_a = find_let(pleifer_alph, a)
        cord_b = find_let(pleifer_alph, b)
        # Буквы биграммы в одной строке
        if cord_a[0] == cord_b[0]:
            a = pleifer_alph[cord_a[0]][(cord_a[1]+1) % 6]

            b = pleifer_alph[cord_b[0]][(cord_b[1]+1) % 6]

        # Биграммы в одном столбце
        elif cord_a[1] == cord_b[1]:
            a = pleifer_alph[(cord_a[0]+1) % 5][cord_a[1]]

            b = pleifer_alph[(cord_b[0]+1) % 5][cord_b[1]]

        else:
            a = pleifer_alph[cord_b[0]][cord_a[1]]

            b = pleifer_alph[cord_a[0]][cord_b[1]]
            a, b = b, a
        encrypt += a+b+" "

    return encrypt


def pleifer_decrypt(text, key):
    create_table(key)
    decrypt = ""
    text = text.split(" ")
    #print(text)
    for i in range(len(text)):
        a = text[i][0]
        b = text[i][1]
        cord_a = find_let(pleifer_alph, a)
        cord_b = find_let(pleifer_alph, b)
        # Буквы биграммы в одной строке
        if cord_a[0] == cord_b[0]:
            a = pleifer_alph[cord_a[0]][(cord_a[1]-1) % 6]

            b = pleifer_alph[cord_b[0]][(cord_b[1]-1) % 6]

        # Биграммы в одном столбце
        elif cord_a[1] == cord_b[1]:

            a = pleifer_alph[(cord_a[0]-1) % 5][cord_a[1]]

            b = pleifer_alph[(cord_b[0]-1) % 5][cord_b[1]]

        else:

            a = pleifer_alph[cord_b[0]][cord_a[1]]

            b = pleifer_alph[cord_a[0]][cord_b[1]]

            a, b = b, a

        decrypt += a+b

    return decrypt


# if isEncrypt:
#     print(pleifer_encrypt(inputStr, key))
# else:
#     print(pleifer_decrypt(inputStr, key))

print(pleifer_encrypt("каждаякадкадолжнастоятьнасобственномднищетчк", "самолет"))