// A boolean is a True or False Value
// A boolean in C# is 8 bits or 1 byte

// declaring a boolean variable by 8 bits or 1 byte

// Declaring a boolean variable
bool myBool;
bool my_bool;
bool MyBool;

// Assigning a value to this variable
myBool = true;
myBool = false;

//declaring and assign in one line
bool coolBool = true;

// re-assigning a value to these variable
coolBool = false;

// Doing boolean logic with these variable
// && and operator
bool trueAndFalse = true && false;
bool trueAndTrue = true && true;
bool falseAndFalse = false && false;

//  || The OR operator
bool trueOrFalse = true || false;
bool trueOrTrue = true || true;
bool falseAndFalse = false || false;

// ! The NOT operator
bool notTrue = !true;
bool notFalse = !false;


Console.Writeline($" true && false: {trueAndFalse}");
Console.Writeline($" true && true: {trueAndTrue}");
Console.Writeline($" false && false: {falseAndFalse}");
Console.Writeline($" true || false: {trueOrFalse}");
Console.Writeline($" true || true: {trueOrTrue}");
Console.Writeline($" false || false: {falseOrFalse}");

