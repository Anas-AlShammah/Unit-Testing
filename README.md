# ATM Bank Readme

## Summary

The ATM Bank is a simple console application that simulates the functionality of an ATM machine. It allows users to perform basic operations such as viewing their account balance, depositing money, and withdrawing money. The application keeps track of the account balance and transaction history.

## Visuals

Here is an example of how the ATM Bank application looks when running:
Wellcome to Atm Bank

Your Balance now is $300

- input 1 To Deposit
- input 2 To Withdraw
- input 3 To Exit


## How to Use

To use the ATM Bank application, follow these step-by-step directions:

1. Run the application.
2. You will be presented with a menu that shows your current balance and options to deposit, withdraw, or exit.
3. To view your account balance, simply observe the displayed balance.
4. To deposit money, enter "1" and provide the amount you want to deposit when prompted.
5. To withdraw money, enter "2" and provide the amount you want to withdraw when prompted.
6. Repeat steps 2-5 until you are ready to exit. Enter "3" to exit the application.
7. After exiting, the application will display the transaction history, including the operation number, type (deposit or withdrawal), amount, balance, and date/time of the transaction.

## Additional Details

- The initial account balance is set to $300.
- The application keeps track of transaction records using a list.
- The application throws exceptions in case of invalid operations, such as withdrawing more than the available balance or entering a negative amount.
- Each transaction is recorded with an operation number, type, amount, balance, and timestamp.

## Unit Tests

A unit test project named "TestProject1" is provided to test the functionality of the ATM Bank application. It includes the following tests:

- `ViewBlanceTest`: Tests the `ViewBlance` method to ensure it returns the correct account balance.
- `WithDrawTest`: Tests the `WithDraw` method with various withdrawal amounts, checking if the balance is updated correctly.
- `DepositTest`: Tests the `Deposit` method with various deposit amounts, checking if the balance is updated correctly.


