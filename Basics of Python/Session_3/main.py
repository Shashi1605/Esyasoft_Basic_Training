import math_function as ma

print("-------Enter Your type of Operation------")
print("Enter 1 for Addition ")
print("Enter 2 for Subtraction ")
print("Enter 3 for multiplication ")
print("Enter 4 for devide ")

op = int(input())



while(1):
    if(op == 1):
        num1 = int(input("Enter your first numeber : "))
        num2 = int(input("Enter your 2nd Number : "))
        print("Addtion of ",num1, " + ", num2," = ", ma.add(num1, num2))
        agin = input("\n Want to calculate again ? (y/n)")
        if(agin == 'y'):
            continue
        else:
            break
    

