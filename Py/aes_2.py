import numpy as np
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


def hexv(text):
    return "".join(['{0:02x}'.format(cvalue(dic, k)) for k in text])


def hexup(hext):
    temx = [hext[i:i+2] for i in range(0, len(hext), 2)]
    return "".join([cvalue(idic, int(i, 16)) for i in temx])


def sub_bytes(state):
    horn = []
    for j in state:
        row = []
        for i in j:
            row.append(s_box[i])
        horn.append(np.array(row, dtype=np.uint8))
    return horn


def invsub_bytes(state):
    horn = []
    for j in state:
        row = []
        for i in j:
            row.append(inv_s_box[i])
        horn.append(np.array(row, dtype=np.uint8))
    return horn


def shift_rows(state):
    horn = []
    horn.append(state[0])
    for i in range(1, 4):
        horn.append(np.roll(state[i], -i))
    return horn


def invshift_rows(state):
    horn = []
    horn.append(state[0])
    for i in range(1, 4):
        horn.append(np.roll(state[i], i))
    return horn


def xtime(a):
    if (a & 0x80):
        return (((a << 1) ^ 0x1B) & 0xFF)
    return (a << 1)


def mix_single_column(state, i):
    t = state[0][i] ^ state[1][i] ^ state[2][i] ^ state[3][i]
    u = state[0][i]
    state[0][i] ^= t ^ xtime(state[0][i] ^ state[1][i])
    state[1][i] ^= t ^ xtime(state[1][i] ^ state[2][i])
    state[2][i] ^= t ^ xtime(state[2][i] ^ state[3][i])
    state[3][i] ^= t ^ xtime(state[3][i] ^ u)
    return state


def mix_columns(state):
    for i in range(4):
        mix_single_column(state, i)
    return state


def invmix_columns(state):
    for i in range(4):
        u = xtime(xtime(state[0][i] ^ state[2][i]))
        v = xtime(xtime(state[1][i] ^ state[3][i]))
        state[0][i] ^= u
        state[1][i] ^= v
        state[2][i] ^= u
        state[3][i] ^= v
    mix_columns(state)
    return state


def add_round_key(state, key):

    for i in range(4):
        for j in range(4):
            state[i][j] ^= key[i][j]


def xor_rcon(word, rcon):
    return [word[0] ^ rcon, word[1], word[2], word[3]]


def xor_word(arr1, arr2):
    w = []
    for i in range(4):
        w.append(arr1[i] ^ arr2[i])
    return w


def sub_word(word):
    return [s_box[i] for i in word]


def rot_word(word):
    return [word[1], word[2], word[3], word[0]]


def show_word(word, pref):
    print(pref, " : ", " ".join(['{0:02x}'.format(i) for i in word]))


def key_expansion(key, Nr, Nb, Nk):
    w = []
    for i in range(Nk):
        w.append([key[4*i], key[4*i+1], key[4*i+2], key[4*i+3]])

    for i in range(Nk, Nb*(Nr+1)):
        temp = w[i-1]

        if i % Nk == 0:
            temp = xor_rcon(sub_word(rot_word(temp)), r_con[i//Nk])
        elif Nk > 6 and i % Nk == 4:
            temp = sub_word(temp)
        w.append(xor_word(temp, w[i-Nk]))
    return(np.array(w).reshape(-1, 4, 4))


r_con = (
    0x00, 0x01, 0x02, 0x04, 0x08, 0x10, 0x20, 0x40,
    0x80, 0x1B, 0x36, 0x6C, 0xD8, 0xAB, 0x4D, 0x9A,
    0x2F, 0x5E, 0xBC, 0x63, 0xC6, 0x97, 0x35, 0x6A,
    0xD4, 0xB3, 0x7D, 0xFA, 0xEF, 0xC5, 0x91, 0x39,
)

s_box = (
    0x63, 0x7C, 0x77, 0x7B, 0xF2, 0x6B, 0x6F, 0xC5, 0x30, 0x01, 0x67, 0x2B, 0xFE, 0xD7, 0xAB, 0x76,
    0xCA, 0x82, 0xC9, 0x7D, 0xFA, 0x59, 0x47, 0xF0, 0xAD, 0xD4, 0xA2, 0xAF, 0x9C, 0xA4, 0x72, 0xC0,
    0xB7, 0xFD, 0x93, 0x26, 0x36, 0x3F, 0xF7, 0xCC, 0x34, 0xA5, 0xE5, 0xF1, 0x71, 0xD8, 0x31, 0x15,
    0x04, 0xC7, 0x23, 0xC3, 0x18, 0x96, 0x05, 0x9A, 0x07, 0x12, 0x80, 0xE2, 0xEB, 0x27, 0xB2, 0x75,
    0x09, 0x83, 0x2C, 0x1A, 0x1B, 0x6E, 0x5A, 0xA0, 0x52, 0x3B, 0xD6, 0xB3, 0x29, 0xE3, 0x2F, 0x84,
    0x53, 0xD1, 0x00, 0xED, 0x20, 0xFC, 0xB1, 0x5B, 0x6A, 0xCB, 0xBE, 0x39, 0x4A, 0x4C, 0x58, 0xCF,
    0xD0, 0xEF, 0xAA, 0xFB, 0x43, 0x4D, 0x33, 0x85, 0x45, 0xF9, 0x02, 0x7F, 0x50, 0x3C, 0x9F, 0xA8,
    0x51, 0xA3, 0x40, 0x8F, 0x92, 0x9D, 0x38, 0xF5, 0xBC, 0xB6, 0xDA, 0x21, 0x10, 0xFF, 0xF3, 0xD2,
    0xCD, 0x0C, 0x13, 0xEC, 0x5F, 0x97, 0x44, 0x17, 0xC4, 0xA7, 0x7E, 0x3D, 0x64, 0x5D, 0x19, 0x73,
    0x60, 0x81, 0x4F, 0xDC, 0x22, 0x2A, 0x90, 0x88, 0x46, 0xEE, 0xB8, 0x14, 0xDE, 0x5E, 0x0B, 0xDB,
    0xE0, 0x32, 0x3A, 0x0A, 0x49, 0x06, 0x24, 0x5C, 0xC2, 0xD3, 0xAC, 0x62, 0x91, 0x95, 0xE4, 0x79,
    0xE7, 0xC8, 0x37, 0x6D, 0x8D, 0xD5, 0x4E, 0xA9, 0x6C, 0x56, 0xF4, 0xEA, 0x65, 0x7A, 0xAE, 0x08,
    0xBA, 0x78, 0x25, 0x2E, 0x1C, 0xA6, 0xB4, 0xC6, 0xE8, 0xDD, 0x74, 0x1F, 0x4B, 0xBD, 0x8B, 0x8A,
    0x70, 0x3E, 0xB5, 0x66, 0x48, 0x03, 0xF6, 0x0E, 0x61, 0x35, 0x57, 0xB9, 0x86, 0xC1, 0x1D, 0x9E,
    0xE1, 0xF8, 0x98, 0x11, 0x69, 0xD9, 0x8E, 0x94, 0x9B, 0x1E, 0x87, 0xE9, 0xCE, 0x55, 0x28, 0xDF,
    0x8C, 0xA1, 0x89, 0x0D, 0xBF, 0xE6, 0x42, 0x68, 0x41, 0x99, 0x2D, 0x0F, 0xB0, 0x54, 0xBB, 0x16,
)

inv_s_box = (
    0x52, 0x09, 0x6A, 0xD5, 0x30, 0x36, 0xA5, 0x38, 0xBF, 0x40, 0xA3, 0x9E, 0x81, 0xF3, 0xD7, 0xFB,
    0x7C, 0xE3, 0x39, 0x82, 0x9B, 0x2F, 0xFF, 0x87, 0x34, 0x8E, 0x43, 0x44, 0xC4, 0xDE, 0xE9, 0xCB,
    0x54, 0x7B, 0x94, 0x32, 0xA6, 0xC2, 0x23, 0x3D, 0xEE, 0x4C, 0x95, 0x0B, 0x42, 0xFA, 0xC3, 0x4E,
    0x08, 0x2E, 0xA1, 0x66, 0x28, 0xD9, 0x24, 0xB2, 0x76, 0x5B, 0xA2, 0x49, 0x6D, 0x8B, 0xD1, 0x25,
    0x72, 0xF8, 0xF6, 0x64, 0x86, 0x68, 0x98, 0x16, 0xD4, 0xA4, 0x5C, 0xCC, 0x5D, 0x65, 0xB6, 0x92,
    0x6C, 0x70, 0x48, 0x50, 0xFD, 0xED, 0xB9, 0xDA, 0x5E, 0x15, 0x46, 0x57, 0xA7, 0x8D, 0x9D, 0x84,
    0x90, 0xD8, 0xAB, 0x00, 0x8C, 0xBC, 0xD3, 0x0A, 0xF7, 0xE4, 0x58, 0x05, 0xB8, 0xB3, 0x45, 0x06,
    0xD0, 0x2C, 0x1E, 0x8F, 0xCA, 0x3F, 0x0F, 0x02, 0xC1, 0xAF, 0xBD, 0x03, 0x01, 0x13, 0x8A, 0x6B,
    0x3A, 0x91, 0x11, 0x41, 0x4F, 0x67, 0xDC, 0xEA, 0x97, 0xF2, 0xCF, 0xCE, 0xF0, 0xB4, 0xE6, 0x73,
    0x96, 0xAC, 0x74, 0x22, 0xE7, 0xAD, 0x35, 0x85, 0xE2, 0xF9, 0x37, 0xE8, 0x1C, 0x75, 0xDF, 0x6E,
    0x47, 0xF1, 0x1A, 0x71, 0x1D, 0x29, 0xC5, 0x89, 0x6F, 0xB7, 0x62, 0x0E, 0xAA, 0x18, 0xBE, 0x1B,
    0xFC, 0x56, 0x3E, 0x4B, 0xC6, 0xD2, 0x79, 0x20, 0x9A, 0xDB, 0xC0, 0xFE, 0x78, 0xCD, 0x5A, 0xF4,
    0x1F, 0xDD, 0xA8, 0x33, 0x88, 0x07, 0xC7, 0x31, 0xB1, 0x12, 0x10, 0x59, 0x27, 0x80, 0xEC, 0x5F,
    0x60, 0x51, 0x7F, 0xA9, 0x19, 0xB5, 0x4A, 0x0D, 0x2D, 0xE5, 0x7A, 0x9F, 0x93, 0xC9, 0x9C, 0xEF,
    0xA0, 0xE0, 0x3B, 0x4D, 0xAE, 0x2A, 0xF5, 0xB0, 0xC8, 0xEB, 0xBB, 0x3C, 0x83, 0x53, 0x99, 0x61,
    0x17, 0x2B, 0x04, 0x7E, 0xBA, 0x77, 0xD6, 0x26, 0xE1, 0x69, 0x14, 0x63, 0x55, 0x21, 0x0C, 0x7D,
)


def show_state(state, pref):
    print(pref, " : ")
    for r in state:
        print(['{0:02x}'.format(i) for i in r])


def g_mix(text, keyhex):
    if type(text) != str:
        print("Текст должен быть строкой.")
        exit()
    if type(keyhex) != str:
        print("Ключ должен быть строкой.")
        exit()
    if len(text) != 32:
        print("Длина блока текста должна быть 128 бит.")
        exit()
    if len(keyhex) == 64:
        Nr = 14
        Nk = 8
    elif len(keyhex) == 32:
        Nr = 10
        Nk = 4
    else:
        print("Длина ключа должна быть 128 или 256 бит.")
        exit()

    key = key_expansion(key_slice(keyhex), Nr, 4, Nk)

    jerk = key_slice(text)

    state = np.transpose(np.array(jerk, dtype=np.uint8).reshape(4, 4))

    add_round_key(state, np.transpose(key[0]))

    for i in range(1, Nr):
        state = sub_bytes(state)
        state = shift_rows(state)
        state = mix_columns(state)
        add_round_key(state, np.transpose(key[i]))

    state = sub_bytes(state)
    state = shift_rows(state)
    add_round_key(state, np.transpose(key[Nr]))

    return "".join(['{0:02x}'.format(i) for i in np.transpose(state).flatten()])


def g_unmix(text, keyhex):
    if type(text) != str:
        print("Текст должен быть строкой.")
        exit()
    if type(keyhex) != str:
        print("Ключ должен быть строкой.")
        exit()
    if len(text) != 32:
        print("Длина блока текста должна быть 128 бит.")
        exit()
    if len(keyhex) == 64:
        Nr = 14
        Nk = 8
    elif len(keyhex) == 32:
        Nr = 10
        Nk = 4
    else:
        print("Длина ключа должна быть 128 или 256 бит.")
        exit()

    key = key_expansion(key_slice(keyhex), Nr, 4, Nk)

    jerk = key_slice(text)

    state = np.transpose(np.array(jerk, dtype=np.uint8).reshape(4, 4))

    add_round_key(state, np.transpose(key[Nr]))

    for i in reversed(range(1, Nr)):
        state = invshift_rows(state)
        state = invsub_bytes(state)
        add_round_key(state, np.transpose(key[i]))
        state = invmix_columns(state)

    state = invshift_rows(state)
    state = invsub_bytes(state)
    add_round_key(state, np.transpose(key[0]))

    return "".join(['{0:02x}'.format(i) for i in np.transpose(state).flatten()])


def xrand(n):
    x = ""
    if n % 2 != 0:
        n -= 1
        x += "0"
    for i in range(int(n/2)):
        x += '{0:02x}'.format(np.random.randint(1, 33))
    return x


def padding(hext):
    l = len(hext)
    freak = l % 32
    if freak > 0:
        hext += xrand(32-freak)
    return ([hext[i:i+32] for i in range(0, len(hext), 32)], l)


def key_slice(hext):

    return ([int(hext[i:i+2], 16) for i in range(0, len(hext), 2)])


dic = {'а': 1, 'б': 2, 'в': 3, 'г': 4, 'д': 5, 'е': 6, 'ё': 7, 'ж': 8, 'з': 9, 'и': 10, 'й': 11, 'к': 12, 'л': 13, 'м': 14, 'н': 15, 'о': 16, 'п': 17, 'р': 18, 'с': 19, 'т': 20, 'у': 21, 'ф': 22, 'х': 23, 'ц': 24, 'ч': 25, 'ш': 26, 'щ': 27, 'ъ': 28, 'ы': 29, 'ь': 30, 'э': 31, 'ю': 32, 'я': 33, 'А': 34, 'Б': 35, 'В': 36, 'Г': 37, 'Д': 38, 'Е': 39, 'Ё': 40, 'Ж': 41, 'З': 42, 'И': 43, 'Й': 44, 'К': 45, 'Л': 46, 'М': 47, 'Н': 48, 'О': 49, 'П': 50,
       'Р': 51, 'С': 52, 'Т': 53, 'У': 54, 'Ф': 55, 'Х': 56, 'Ц': 57, 'Ч': 58, 'Ш': 59, 'Щ': 60, 'Ъ': 61, 'Ы': 62, 'Ь': 63, 'Э': 64, 'Ю': 65, 'Я': 66, '.': 67, ',': 68, '–': 69, '-': 70, '"': 71, '«': 72, '»': 73, '+': 74, '=': 75, ';': 76, '#': 77, '№': 78, '%': 79, ':': 80, '(': 81, ')': 82, '*': 83, '\\': 84, '/': 85, '|': 86, '0': 87, '1': 88, '2': 89, '3': 90, '4': 91, '5': 92, '6': 93, '7': 94, '8': 95, '9': 96, '!': 97, '?': 98, ' ': 99, '—': 100}

idic = upsidedown(dic)


def encryptmessage(orig, keykey):
    orighex=hexv(orig)
    #keyhex=hexv(keykey)

    # orighex = "00112233445566778899aabbccddeeff"
    # keyhex = "000102030405060708090a0b0c0d0e0f"

    keyhex = keykey

    (arrayhex, l) = padding(orighex)
    simp = ""
    for i in range(len(arrayhex)):
        g = g_mix(arrayhex[i], keyhex)
        simp += g
    #print("\nЗашифрованный текст: ", "".join(simp))

    return "".join(simp)


def decryptmessage(orig, keykey):
    #keyhex = hexv(keykey)
    keyhex = keykey

    (arrayhex, l) = padding(orig)
    simp = ""
    for i in range(len(arrayhex)):
        g = g_unmix(arrayhex[i], keyhex)
        simp += g
    simp = hexup(simp)
    #print("\nРасшифрованный текст: ", "".join(simp))

    return "".join(simp)


key = sys.argv[1]
isEncrypt = bool(int(sys.argv[2]))
inputStr = sys.argv[3]


if isEncrypt:
    print(encryptmessage(inputStr, key))
else:
    print(decryptmessage(inputStr, key))
