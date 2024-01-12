// ---- C# I (Dor Ben Dor) ----
// Ori Shacham Barr
// -----------------------------

// A - Variables
int x = 1;
int y;
float a, b;
string s;
bool yes = true, no = false;
a = 1.1f;
b = 2.2f;
s = "sure!";
y = x;

// B - Operators
int one = 1;
float two = 2f;
string three = "three";
char four = '4';
bool five = true;

int testOne;
float testTwo;

testOne = one + ((int)two);
testTwo = ((float)one) - two;
testOne = one * ((int)two);
testTwo = ((float)one) / two;
testOne = one % ((int)two);

string ai = "a", bi = "b", si = "c", di = "d";
ai += three + one.ToString();
bi += three + two.ToString();
si += three + four.ToString();
di += three + five.ToString();

// C - Variables and Operators Syntax
string myName = "Ori", welcomeMessage = "Hello, ", lineBreak = "\r\n";
Console.WriteLine(welcomeMessage + myName + lineBreak);

int numberOne = 1 , numberTwo = 2;
Console.WriteLine("The sum is: " + (numberOne + numberTwo));
Console.WriteLine("The quotient is: " + (numberTwo / numberOne));

int numberThree = 3 , numberFour = 4, numberAmount = 4;
float numberSum = (float)numberOne + (float)numberTwo + (float)numberThree + (float)numberFour;
Console.WriteLine("The Average is: " + numberSum / numberAmount + lineBreak);

int incrementNumber = 1;
Console.WriteLine(++incrementNumber);
Console.WriteLine(++incrementNumber);
Console.WriteLine(++incrementNumber);
Console.WriteLine(--incrementNumber);
Console.WriteLine(--incrementNumber);
Console.WriteLine(--incrementNumber);
Console.WriteLine(lineBreak);

// D - Variables: Wild Horses
Console.WriteLine("User defined trip information:");

Console.Write("Please enter the mount's name: ");
string mountName = Console.ReadLine();

Console.Write("Please enter the " + mountName + "'s average speed in miles per hour: ");
int averageMountSpeedInMiles = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the distance to the Southland in kilometers: ");
int distanceToSouthlandInKM = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the distance to the Hinterlands in kilometers: ");
int distanceToHinterlandsInKM = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the amount of miles in a kilometer: ");
float milesPerKilometer = float.Parse(Console.ReadLine());
Console.WriteLine();

//Trip calculation
float distanceToSouthlandInMiles = (float)distanceToSouthlandInKM * milesPerKilometer;
float distanceToHinterlandsInMiles = (float)distanceToHinterlandsInKM * milesPerKilometer;

int hoursToSouthland = (int)(distanceToSouthlandInMiles / averageMountSpeedInMiles);
int hoursToHinterlands = (int)(distanceToHinterlandsInMiles / averageMountSpeedInMiles);
Console.WriteLine("The trip to the Southland takes " + hoursToSouthland + " hours.");
Console.WriteLine("The trip to the Hinterlands takes " + hoursToHinterlands + " hours." + lineBreak);

int hoursInDay = 24;
int daysToSouthland = (int)hoursToSouthland / hoursInDay;
int daysToHinterlands = (int)hoursToHinterlands / hoursInDay;
Console.WriteLine(mountName + " will take " + daysToSouthland + " days to reach the Southland.");
Console.WriteLine(mountName + " will take " + daysToHinterlands + " days to reach the Hinterlands.");