int numberOfApples = 12;
decimal pricePerApple = 0.35M;

Console.WriteLine(
    format:"{0} apples cost {1:C}",
    arg0:numberOfApples,
    arg1:pricePerApple*numberOfApples
    );

string formatted = string.Format(
    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple*numberOfApples
    );

Console.WriteLine(formatted);

Console.WriteLine($"{numberOfApples} apples cost {pricePerApple * numberOfApples:C}");