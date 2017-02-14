# Coin Combo Teller

#### _Tell user which coins make up the amount they want_

#### By _**Alexandra Holcombe && Katy Daviscourt**_

## Description

This web application will tell the user the fewest number of coins (and which denominations) to make up the amount of money the user specifies.

## Setup/Installation Requirements

* Requires DNU, DNX, and Mono
* Clone to local machine
* Use command "dnu restore" in command prompt/shell
* Use command "dnx kestrel" to start server
* Navigate to http://localhost:5004 in web browser of choice

## Specifications

**When the user inputs 1 cent, the program will return 1 penny.**
* Example Input: 1
* Example Output: 1 penny

**When the user inputs 5 cents, the program will return 1 nickel.**
* Example Input: 5
* Example Output: 1 nickel

**When the user inputs 10 cents, the program will return 1 dime.**
* Example Input: 10
* Example Output: 1 dime

**When the user inputs 25 cents, the program will return 1 quarter.**
* Example Input: 25
* Example Output: 1 quarter

**When the user inputs a cent amount that is a multiple of the same type of coin, the program will return multiple of the same coin.**
* Example Input: 50
* Example Output: 2 quarters

**When the user inputs an amount that is not only a multiple of the same type of coin, the program will return a combination of coins that make up that amount, starting with the highest coin denomination.**
* Example Input: 18
* Example Output: 1 dime, 1 nickel, 3 pennies

## Support and contact details

Please contact Allie Holcombe at alexandra.holcombe@gmail.com or Katy Daviscourt at katy.daviscourt@gmail.com with any questions, concerns, or suggestions.

## Technologies Used

This web application uses:
* Nancy
* Mono
* DNVM
* C#
* Razor

### License

*This project is licensed under the MIT license.*

Copyright (c) 2017 **_Alexandra Holcombe & Katy Daviscourt_**
