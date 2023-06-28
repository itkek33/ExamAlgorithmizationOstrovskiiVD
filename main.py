import random

marks = 0
for i in range(3):
    a1 = random.randint(1,24)
    a2 = random.randint(1, 24)
    a3 = random.randint(1, 24)
    answ = input(f"Введите число номер {i+1} ")

    if answ == a1 or answ == a2 or answ == a3:
        marks = marks + 1
    print(f"{a1} {a2} {a3}")

if marks == 0:
    print("Вы проиграли")
elif marks >=2:
    print("Вы выиграли")