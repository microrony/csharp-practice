const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openSpanPosition = input.IndexOf(openSpan);
int closeSpanPosition = input.IndexOf(closeSpan);

openSpanPosition += openSpan.Length;
int quantityValueLength = closeSpanPosition - openSpanPosition;

quantity = input.Substring(openSpanPosition, quantityValueLength);

string openH2 = "<h2>";
int openH2Position = input.IndexOf(openH2);
int outputLength = closeSpanPosition - openH2Position;
outputLength += closeSpan.Length;

output = input.Substring(openH2Position, outputLength).Replace("trade", "reg");

Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Output: {output}");