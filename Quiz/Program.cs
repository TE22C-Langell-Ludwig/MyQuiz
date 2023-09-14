//Strings and ints

int points = 0;
int right = 0;

//Här ligger all kod

Console.WriteLine("Question 1: ");
string answer = Console.ReadLine(). ToLower();
if (answer == "yes"){
    Console.WriteLine("wow you are stupid that is the wrong answer, you lose!");

}
else if(answer == "no"){
    Console.WriteLine("Nice job i can tell that you're a real swede");
    points += 12;
    right++;
}
else{
    Console.WriteLine("That was not one of the options given to you, so you forfeit the question");
}

Console.WriteLine($"Question 2: ");


Console.WriteLine($"Question 3: ");

if (right == 1){
    Console.WriteLine($"you completed this quiz with only {right} questions right and {points} point better luck next time");
}
else if(right == 2){
    Console.WriteLine($"Nice you ended the quiz with {right} questions right and {points} points you almost got the highest score");
}
else if(right == 3){
    Console.WriteLine($"WOW you ended the quiz with {right} questions right and {points} points you got the highest score 100IQ moves!");
}
Console.ReadLine();