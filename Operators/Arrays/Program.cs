string[] names; // can reference any size array of strings

// allocating memory for four strings in an array
names = new string[4];
// storing items at index positions
names[0] = "Kate";
names[1] = "Jack";
names[2] = "Rebecca";
names[3] = "Tom";

string[] names2 = new[] { "Kate", "Jack", "Rebecca", "Tom" };


// looping through the names
for (int i = 0; i < names.Length; i++)
{
    // output the item at index position i
    WriteLine(names[i]);
};


//multi-dimensionals arrays

string[,] grid1 = new[,]
{
    { "Alpha", "Beta", "Gamma", "Delta" },
{ "Anne", "Ben", "Charlie", "Doug" },
{ "Aardvark", "Bear", "Cat", "Dog" }
};


WriteLine($"Lower bound of the first dimension is: {grid1.GetLowerBound(0)}");
WriteLine($"Upper bound of the first dimension is: {grid1.GetUpperBound(0)}");
WriteLine($"Lower bound of the first dimension is: {grid1.GetLowerBound(1)}");
WriteLine($"Upper bound of the first dimension is: {grid1.GetUpperBound(1)}");

for(int row = 0; row <= grid1.GetUpperBound(0); row++)
{
    for(int col = 0; col<= grid1.GetUpperBound(1); col++)
    {
        WriteLine($"Row {row}, column {col}: {grid1[row,col]} ");
    }
}