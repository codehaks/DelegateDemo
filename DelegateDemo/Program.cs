
var input = "This is my input text!";

string select=Console.ReadLine();

Func<string,string> method;

switch (select)
{
    case "L":
        method = ConvertToLower;
        break;
    case "U":
        method = ConvertToUpper;
        break;
    case "N":
        method = ConvertToNoSpaces;
        break;
    default:
        method = ConvertToLower;
        break;
}

var output= method(input);

Console.WriteLine(output);


string ConvertToLower(string input)
{
    var output=input.ToLower();
    return output;
}

string ConvertToUpper(string input)
{
    var output = input.ToUpper();
    return output;
}

string ConvertToNoSpaces(string input)
{
    return input.Replace(" ", "");
}

//delegate string ConvertMethod(string input);