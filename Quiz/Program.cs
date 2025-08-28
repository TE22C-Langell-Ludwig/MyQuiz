//Strings and ints

int points = 0;
int right = 0;

//Här ligger all kod

Console.WriteLine("Question 1: ");
Console.WriteLine("who won the 2022 world cup, Argentina, France or Japan");
string answer = Console.ReadLine(). ToLower();
if (answer == "argentina"){
    Console.WriteLine("That's correct, Wow you know so much so i guess you enjoy watching football");
    points += 12;
    right++;
}
else if(answer == "france" || answer == "fapan"){
    Console.WriteLine("close but that was not the right answere");

}
else{
    Console.WriteLine("That was not one of the options given to you, so you forfeit the question");
}

Console.WriteLine($"Question 2: ");
Console.WriteLine("Could you teach me jappanese");
string answer2 = Console.ReadLine(). ToLower();
if (answer2 == "yes"){
    Console.WriteLine("Oh cool, we'll take that later");
    points += 12;
    right++;
}
else if(answer2 == "no"){
    Console.WriteLine("damn i guess im out of luck");
    points += 12;
    right++;
}
else{
    Console.WriteLine("That was not one of the options given to you, so you forfeit the question");
}

Console.WriteLine($"Question 3: ");
Console.WriteLine("What is the Swedish national dish");
string answer3 = Console.ReadLine(). ToLower();
if (answer3 == "stockholm"){
    Console.WriteLine("Nice thats wrong");
    points += 12;
    right++;
}
else{
    Console.WriteLine("That was the right answer");
}

Console.WriteLine($"Question 4: ");
Console.WriteLine("What is jimmie åkersoons favourite food?");
Console.WriteLine("Meatballs");
Console.WriteLine("Liquorice");
string answer4 = Console.ReadLine(). ToLower();
if (answer4 == "meatballs"){
    Console.WriteLine("Nice thats correct");
    points += 12;
    right++;
}
else{
    Console.WriteLine("That was the wrong answere");
}

Console.ReadLine();















if (right == 1){
    Console.WriteLine($"you completed this quiz with only {right} questions right and {points} points better luck next time");
}
else if(right == 2){
    Console.WriteLine($"Nice you ended the quiz with {right} questions right and {points} points you almost got the highest score");
}
else if(right == 3){
    Console.WriteLine($"WOW you ended the quiz with {right} questions right and {points} points you got the highest score 100IQ moves!");
}

Console.ReadLine();
