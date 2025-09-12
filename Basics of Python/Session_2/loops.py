fruits = ["Apple", "Banana", "Graps", 4, "Shashi"]

#For loop
# x = 10
# for i in range(x):
#     print(i)

#Break and Continue
for i in fruits:
    if i == 4:
        break
    elif i == "Banana":
        continue
    else:
        print(i)
