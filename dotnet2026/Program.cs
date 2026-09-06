// 1. Write a C# code to accept two integers and check whether they are equal or not.
Console.WriteLine ("Enter a first integer: ");
int num1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Enter second integer: ");
int num2 = Convert.ToInt32 (Console.ReadLine());
if 
(num1 == num2){
    Console.WriteLine("The two integers are equal");

}
else
{
   Console.WriteLine ("The two inegers are not equal");
}

// 2. Write a C# Sharp program to check whether a given number is positive or negative.
Console.WriteLine ("Enter a number: ");
int number = Convert.ToInt32 (Console.ReadLine());

if 
(number > 0){
    Console.WriteLine("Given number is positive");

}
else
{
   Console.WriteLine ("Given number is negative");
}

// 3. Write a C# Sharp program to accept a person's height in centimeters and categorize them according to their height.
Console. WriteLine ("Enter a person height in centimeters: ");
double height = Convert. ToDouble(Console.ReadLine());
if (height < 120)
{
    Console. WriteLine ("Person height is too small ");
}
else if(height <= 180)
{
    Console. WriteLine ("Person height is small ");
}
else
{
    Console. WriteLine ("Person height is tall ");
}

//4. Write a C# Sharp program to find the largest of three numbers.
Console. WriteLine ("Enter a first number: ");
int num1 = Convert. ToInt32(Console.ReadLine());
Console. WriteLine ("Enter a second number: ");
int num2 = Convert. ToInt32(Console.ReadLine());
Console. WriteLine ("Enter a third number: ");
int num3 = Convert. ToInt32(Console.ReadLine());

if (num1 >= num2 && num1 >= num3)
{
    Console. WriteLine ("The Largest number is   " +num1);
}
else if(num2 >= num1 && num2 >= num3)
{
    Console. WriteLine ("Thw Largest number is  " +num2);
}
else
{
    Console. WriteLine ("The Largest number is  " +num3);
}

//5. Write a C# Sharp program to read roll no, name and marks of three subjects and calculate the total, percentage and division.
Console. WriteLine("Enter your rollno: ");
int rollno = Convert. ToInt32(Console.ReadLine());
Console. WriteLine("Enter your name: ");
string name = Console.ReadLine();
Console. WriteLine("Enter your marks of subject1: ");
int subject1 = Convert. ToInt32(Console.ReadLine());
Console. WriteLine("Enter your marks of subject2: ");
int subject2 = Convert. ToInt32(Console.ReadLine());
Console. WriteLine("Enter your marks of subject3: ");
int subject3 = Convert. ToInt32(Console.ReadLine());
double total = subject1+ subject2 + subject3;
double percentage = ((total/300)* 100);

Console.WriteLine("Roll no: " +rollno);
Console.WriteLine("Name: " +name);
Console.WriteLine("Total Marks: "+ total);
Console.WriteLine("Percentage: "+percentage +"%");
if (percentage >= 90)
{
    Console.WriteLine("Division: First");
}
else if (percentage >= 75)
{
    Console.WriteLine("Division: Second");
}
else if (percentage >= 65)
{
    Console.WriteLine("Division: Third");
}
else if (percentage >= 50)
{
    Console.WriteLine("Division: Fourth");
}
else
{
    Console.WriteLine("Division: Fail");
}

/*6. Write a program that checks a customer's eligibility for a discount based on their membership level and purchase amount.
membership levels (Gold 5%, Silver 10%, Platinum 20%) discount(if purchase amount < 100 no discount , more than 100 apply discount)*/
Console. WriteLine("Enter your membership (Gold, Silver, Platinum): ");
string membership = Console.ReadLine();
Console. WriteLine("Enter your purchase amount : ");
double purchaseamount = Convert.ToDouble(Console.ReadLine());
double discount = 0;

if (purchaseamount < 100)
{
    Console.WriteLine(" No discount");
}
else if (membership == "Gold")
{
    discount = purchaseamount * 0.05;
}
else if (membership == "Silver")
{
    discount = purchaseamount * 0.10;
}
else if (membership == "Platinum")
{
    discount = purchaseamount * 0.20;
}
else
{
    Console.WriteLine("Invalid Membership");
}
double finalamount = purchaseamount - discount;
Console.WriteLine("Purchase Amount: $"+ purchaseamount);
Console.WriteLine("Discount: $"+ discount);
Console.WriteLine("Final Amount: $"+ finalamount);

//7. Write a switch statement that takes an integer variable representing a day of the week (1 for Monday, 2 for Tuesday, etc.) and prints the corresponding day name.
Console.WriteLine("Enter a number from 1 to 7:");
int day = Convert.ToInt32(Console.ReadLine());
switch(day)
{
    case 1: Console.WriteLine("Monday") ;
    break;

    case 2: Console.WriteLine("Tuesday") ;
    break;

    case 3: Console.WriteLine("Wednesday") ;
    break;

    case 4: Console.WriteLine("Thursday") ;
    break;

    case 5: Console.WriteLine("Friday") ;
    break;

    case 6: Console.WriteLine("Saturday") ;
    break;

    case 7: Console.WriteLine("Sunday") ;
    break;

    default : Console.WriteLine("Invalid day");
    break;
}

//8. Write a program in C# Sharp to display the first 10 natural numbers using for loop.
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}
//9. Write a C# Sharp program to find the sum of the first 10 natural numbers using for loop.
int sum = 0;
for (int i = 1; i <= 10; i++)
{
    sum = sum + i;
}
Console.WriteLine("The sum of first 10 natural numbers is: " + sum);

//9. Write a program that takes a positive integer input from the user and calculates the sum of its digits using a loop.
Console.WriteLine("Enter a positive integer:");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (number > 0)
{
    int digit = number % 10;
    sum = sum + digit;
    number = number / 10;
}
Console.WriteLine("Sum of the digits is: " + sum);

//11. Write a program that uses a while loop to calculate the sum of all integers from 1 to 100.
int count = 1;
int sum = 0;
while (count <= 100)
{
    sum = sum + count;
    count++;
}
Console.WriteLine("The sum of integers from 1 to 100 is: " + sum);

//12. using do while loop, Create a game where the user has to guess a randomly generated number between 1 and 100. The program should tell the user if their guess is too high or too low and continue until they guess correctly
Console.WriteLine("Enter a random number between 1 and 100:");
int randomNumber = Convert.ToInt32(Console.ReadLine());

int guess;

do
{
    Console.WriteLine("Guess a number between 1 and 100:");
    guess = Convert.ToInt32(Console.ReadLine());

    if (guess > randomNumber)
    {
        Console.WriteLine("Too high! Try again.");
    }
    else if(guess < randomNumber);
    {
        Console.WriteLine("Too low! Try again.");
    }

} while (guess != randomNumber);

//13.using while loop, Write a program that counts down from a user specified number to zero.
Console.WriteLine("Enter a number:");
int number = Convert.ToInt32(Console.ReadLine());
while (number >= 0)
{
    Console.WriteLine(number);
    number--;
}

//14. Write a program that prints the multiplication table from 1 to 10 using nested for loops.
for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine(i + " x " + j + " = " + (i * j));
    }

    Console.WriteLine();
}





