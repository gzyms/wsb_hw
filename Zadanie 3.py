liczba_ocen = input("Ile ocenek? ")
liczba_ocen = int(liczba_ocen)

lista_ocen = []

i = int(0)
suma_ocen = float(0)

while i < liczba_ocen:
    ii = int(input(f"Podaj {i + 1} ocenę: "))
    if ii >= 1 and ii <= 6:
        lista_ocen.insert(i, ii)
        suma_ocen = suma_ocen + lista_ocen[i]
        i += 1
    else:
        print("Najprawdopobniej wyszedłeś poza skalę ocen, naciśnij enter by kontynuować.")
        input()
        ii = int(input(f"Podaj {i + 1} ocenę: "))

srednia = 0
srednia = round(float(suma_ocen / liczba_ocen), 2)

print(f"Średnia: {srednia}")
if srednia >= 3:
    print("Uczeń zdał! Gratki")
else:
    print("Uczeń nie zdał!")
