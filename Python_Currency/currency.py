# User input for which currency
print("Which of the following currency do you have?")
print("Please enter the corresponding number:")
print("1. US dollar")
print("2. Euro")
print("3. Japanese Yen")
print("4. British Pound")
print("5. Canadian Dollar")
user_currency = int(input(""))

if user_currency < 1 or user_currency > 5:
    print("Invalid Input. Please try again.")
    exit()
    

print()
convert_to = int(input("Which currency do you want to convert to? "))
amount = float(input("What is the amount of that currency you have? "))
print()

# 1 USD
def usd_function(convert, amount):
    if convert == 2:
        answer = amount * 0.92
    elif convert == 3:
        answer = amount * 151.50
    elif convert == 4:
        answer = amount * 0.79
    elif convert == 5:
        answer = amount * 1.36
    return answer

# 2 Euro
def euro_function(convert, amount):
    if convert == 1:
        answer = amount * 1.08
    elif convert == 3:
        answer = amount * 164.17
    elif convert == 4:
        answer = amount * 0.86
    elif convert == 5:
        answer = amount * 1.47
    return answer

# 3 Japanese Yen
def yen_function(convert, amount):
    if convert == 1:
        answer = amount * 0.0066
    elif convert == 2:
        answer = amount * 0.0061
    elif convert == 4:
        answer = amount * 0.0052
    elif convert == 5:
        answer = amount * 0.0090
    return answer

# 4 British Pound
def pound_function(convert, amount):
    if convert == 1:
        answer = amount * 1.26
    elif convert == 2:
        answer = amount * 1.17
    elif convert == 3:
        answer = amount * 191.50
    elif convert == 5:
        answer = amount * 1.72
    return answer

# 5 Canadian Dollar
def cad_function(convert, amount):
    if convert == 1:
        answer = amount * 0.74
    elif convert == 2:
        answer = amount * 0.68
    elif convert == 3:
        answer = amount * 0.0090
    elif convert == 4:
        answer = amount * 0.58
    return answer

if user_currency == convert_to:
    print(f"{amount:.2f}")
elif user_currency == 1:
    result = usd_function(convert_to, amount)
    user_currency = "US Dollars"
elif user_currency == 2:
    result = euro_function(convert_to, amount)
    user_currency = "Euro"
elif user_currency == 3:
    result = yen_function(convert_to, amount)
    user_currency = "Japanese Yen"
elif user_currency == 4:
    result = pound_function(convert_to, amount)
    user_currency = "British Pounds"
elif user_currency == 5:
    result = cad_function(convert_to, amount)
    user_currency = "Canadian Dollars"
else:
    print("Invalid inputs please try again.")

if convert_to == 1:
    convert_to = "US Dollar"
elif convert_to == 2:
    convert_to = "Euro"
elif convert_to == 3:
    convert_to = "Japanese Yen"
elif convert_to == 4:
    convert_to = "British Pound"
elif convert_to == 5:
    convert_to = "Canadian Dollar"

print(f"The Given {amount:.2f} {user_currency} is equal to {result:.2f} {convert_to}.")
