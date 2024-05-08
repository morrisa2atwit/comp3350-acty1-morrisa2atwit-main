# In-class Activity

## Introduction

This activity has you getting started with F# programming.

- Due: End of lecture
- Deliverables: Commit and push to Github.

## Part A

We just moved to overseas, and all the temperatures are in Celcius! We will be writing a program
that converts temperatures in Celcius to temperatures in Farenheit, and also prints what it feels
like.

To run the program, open a terminal and type the following command:

    dotnet run

and you will get the following output.

    -15.00 in Celcius is 0.00
    10.00 in Celcius is 0.00
    30.00 in Celcius is 0.00

### cToF

Reads a temperature in Celcius (in float format), and converts it into Farenheit. This will be the
equation in `fToC` but in reverse.

Add documentation to the function, and add code to get the function to work correctly. I have provided
some sample code to help you get started.

### Completion

Once implemented correctly, you'll get the following output:

    -15.00 in Celcius is 5.00
    10.00 in Celcius is 50.00
    30.00 in Celcius is 86.00

Commit your code to git and push to github using the commit message "Completed cToF"