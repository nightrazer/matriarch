#Returns the sum of num1 and num2
def add(num1, num2):
    return num1 + num2

#subtraction
def add(num1, num2):
    return num1 - num2

#multiplication
def add(num1, num2):
    return num1 * num2

#divide
def add(num1, num2):
    return num1 / num2


def main():
    operation = input("What do you want to do? + or - or * or / ")
    if(operation != '+' and operation != '-' and operation != '*' and operation != '/'):
        #invalid operation
        print("You must enter a vaild operation")
    else:
        num1 = input("Enter num1: ")
        num2 = input("Enter num2: ")
        if(operation == '+'):
            print(add(var1,var2))
        elif(operation == '/'):
            print(div(var1, var2))
        elif(operation == '-'):
            print(sub(var1, var2))
        else:
            print(mul(var1, var2))

main()
