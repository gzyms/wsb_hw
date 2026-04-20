a = input("podaj pierwszą liczbę działania: ")
a = int(a)
opt = input("podaj operatora działania z podanych (+, -, *, /): ")
b = input("podaj drugą liczbę działania: ")
b = int(b)

if opt=="+":
    c = a + b
    print(f"{a} + {b} = {c}")
elif opt=="-":
    c = a - b
    print(f"{a} - {b} = {c}")
elif opt=="*":
    c = a * b
    print(f"{a} * {b} = {c}")
elif opt=="/":
    c = a / b
    print(f"{a} / {b} = {c}")