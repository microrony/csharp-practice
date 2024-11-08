string message = "What is the value <span>between the tags</span>?";

string openSpan = "<span>";
string closeSpan = "</span>";

int openSpanPosition = message.IndexOf(openSpan);
int closeSpanPosition = message.IndexOf(closeSpan);
openSpanPosition += openSpan.Length;

int length = closeSpanPosition - openSpanPosition;

Console.WriteLine(message.Substring(openSpanPosition, length));