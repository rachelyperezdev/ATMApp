# ATM Withdrawal Module

This project is an ASP.NET Core MVC application designed to simulate an ATM's cash withdrawal functionality. The application allows users to withdraw money and configure the dispensation mode of the ATM. There are three dispensation modes, each providing a different way of dispensing cash.

## Features

1. Cash Withdrawal
* Users can input the amount they wish to withdraw.
* The system validates the input based on the selected dispensation mode.
* The system displays the denominations dispensed.

2. Dispensation Mode Configuration
* Users can select from three different dispensation modes.
* The selected mode is saved and persists across each withdraw.
* The default mode is set to the most efficient dispensation mode.

## Dispensation Modes

1. Mode 1: 200 and 1000 Denominations Only
  * Dispenses only 200 and 1000 denomination bills.
  * Example: Withdrawing 800 would dispense 4 bills of 200.

2. Mode 2: 100 and 500 Denominations Only
  * Dispenses only 100 and 500 denomination bills.
  * Example: Withdrawing 800 would dispense 1 bill of 500 and 3 bills of 100.

3. Mode 3: Efficient Mode
  * Dispenses the least number of bills using 100, 200, 500, and 1000 denominations.
  * Example: Withdrawing 800 would dispense 1 bill of 500, 1 bill of 200, and 1 bill of 100.

## Validation

* The withdrawal amount must be a whole number and in multiples that match the available denominations.
* The system provides feedback if the amount cannot be dispensed with the current mode's denominations.

## Getting started

### Prerequisites

* [.Net Core SDK](https://dotnet.microsoft.com/en-us/download)
* [Visual Studio](https://visualstudio.microsoft.com/) or any preferred IDE for ASP.NET Core development
