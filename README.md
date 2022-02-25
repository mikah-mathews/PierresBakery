# _Pierre's Bakery_

#### By Mikah Mathews
#### _Terminal Based Application to Buy Pastries_

## Technologies Used
* C#
* .NET
* MStest

## Description

_Welcome to Pierre's Bakery! Come on in and put in an order. Using the terminal, buy bread and pastries and get the price._

## Setup/Installation Requirements

* Clone this repository to your local machine
* Navigate to the {Template.Tests} folder using your terminal.
* To install the project's dependencies, in the terminal type ```dotnet restore```
* Once dependencies are installed, type ```dotnet test``` in the terminal to run the project's tests.
* To run the application navigate to the {Template} folder using the terminal.
* Once in the {Template} folder, type ```dotnet run``` to run the program.

## Known Bugs

* No known bugs at this time.

## License

MIT License

Copyright (c) [2022] [Mikah Mathews](https://github.com/mikah-mathews) 

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

## JS functions
```
loafCount = function(numberOfLoaves){
  let free = Math.floor(numberOfLoaves / 3);
    console.log(free + "free");
    let loavesToPrice = numberOfLoaves - free;
    console.log(loavesToPrice);
    let price = loavesToPrice*5;
    return price;
}
```