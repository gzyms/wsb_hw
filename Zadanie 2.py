opt = input("Wybierz jednostkę wejściowej wartości (c / f): ")
a = input("Podaj wartość wejściową: ")
a = float(a)

if opt=="c":
    b = round((a - 32) * (5/9), 2)
    print(f"({a} - 32) * (5/9) = {b}")
elif opt=="f":
    b = round((a * 1.8) + 32, 2)
    print(f"({a} * 1.8) + 32 = {b}")