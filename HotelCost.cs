// OUR APPLICATION WILL ESTIMATE IF SOMEONE's HOTEL STAY IS LIKELY TO BE EXPENSIVE BASED ON THE SEASON AND DAY OF THE WEEKS
// AS WE BOTH KNOW: hotels are usually more expensive during the peak travel season(summer) and on weekends


using System;

class HotelCost 
{
    static void Main()
    {   
        // for the first question we will be asking our user

        Console.WriteLine("In what season are you booking a stay?");
        
        // Picking up the answer user enters 
        string season = Console.ReadLine();

        // For the 2nd question we wil be asking our user

        Console.WriteLine("On the weekend or weeknight?");
        string dayOfWeek = Console.ReadLine();

        // FOR NOW: we would be typing our answrr in lowercases, later on we will cover how we can handle uppercases when user enters them

        // What we did right here is first, create a boolean variable that determines if the season user enterred was summer
        // don't forget: the == in C# checks to see if the value of the left side is equal to that of the right side
        // with what I said, you might be thinking: what about datatypes?..... But You should never forget that C# would throw us an error if we tried
        // comparing 2 different datatypes together(try comparing 1 == "1")... C# throws an error here because its a strongly typed Language unlike JavaScript that still returns us a value(either true or false)


        bool summer = season == "summer";
        // the summer boolean variable will be set to true if the season collected from the user is equal to the string "summer"

        // here also we created another boolean variable 
        // the boolean variable: weekend will be set to true if the dayOfWeek collected from user is equal to the string "weekend"
        bool weekend = dayOfWeek == "weekend";

        // Let's update code to return different statements to the user based upon the combined values of these two booleans with the && operator
        // updating code furher with else if branch

        // C# BRANCHING LOOKS EXACTLY LIKE JAVASCRIPT's BRANCHING
        if(summer && weekend){
            // RUN THIS BRANCH: if both our summer and weekend boolean variables are true. i.e if each of the statements evaluates to true, if so then the entire statement evaluates to true
            Console.WriteLine("Your stay is probably going to be pretty expensice. It's both peak travel AND the weekend.");
        }

        // else if(summer){
        //     // checking if only the summer boolean variable is true
        //     Console.WriteLine("Your stay might be more expensive than normal!");
        // }

        // else if(weekend){
        //     // checking if only the weekend boolean variable is true
        //     Console.WriteLine("Your stay might be more expensive than normal!");
        // }

        else{
            // RUN THIS BRANCH: if our summer or weekend boolean variables are true... i.e if one or both statements is false, run this branch too 
            Console.WriteLine("Your stay might be expensive, but it could be worse!");
        }

        // SO our application keeps moving down the branch to check for all of them conditions above
        // First is if summer and weekend are true, next is if only summer is true(an else if branch), next is if only weekend is true(another else if branch), and lastly if none of the previous conditionals are true, the program
        // will reach the else statement and print our whats in the else statement


    }
}