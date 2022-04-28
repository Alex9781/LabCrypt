import sys

def obmen(n, a, k, yb):
    	# n=int(input("\nВведите n: "))
	# a=int(input("Введите a: "))
	if a>=n or a<=1:
		print("\nОшибка. 1 < a < n.")
		# exit()
	# k=int(input("Введите Ka: "))
	if k<=2 or k>=n-1:
		print("\nОшибка. 2 < k < n-1.")
		# exit()
	ya=(a**k)%n
	if ya==1:
		print("Ошибка. Открытый ключ не может быть равен 1.")
		# exit()
	# print("\nYa:", ya)
	# yb=int(input("\nВведите полученный yb: "))
	if yb>=n or yb==1:
		print("Ошибка. Открытый ключ не может быть больше модуля n и равным 1.")
		# exit()
	Key=(yb**k)%n

	print("\nСекретный ключ К: ", Key)

	return ya, Key

n = int(sys.argv[1])
a = int(sys.argv[2])
k = int(sys.argv[3])
yb = int(sys.argv[4])

print(obmen(n, a, k, yb))