# Why did I choose this design?
The main conflict here is C# trying to access its
standard libs when there are none. So this is why
I import the values of the variables into my own
custom structs. Its basically so C# knows that I
want to only want to use the values.