using System;

namespace Rev_CReverse
{
    class Program
    {
        static String ReverseCase(String input){
            
            char [] cArray = new char[input.Length]; //create a char array to store the string and traverse through it later
            cArray = input.ToCharArray();    //store the string into the char array
            for(int i =0 ; i<input.Length; i++){
                if(Char.IsLower(cArray[i]) ){ //create a for loop to iterate through the char array and check with if statement if the char in that index is lowercase or uppercase
                    cArray[i] = Char.ToUpper(cArray[i]); //if the if statement is true change the char in the index to uppercase
                }
                else if(Char.IsUpper(cArray[i])){
                    cArray[i] = Char.ToLower(cArray[i]); //change the value in the index to lowercase
                }
            }
            for(int i =0 ; i<cArray.Length; i++){
                Console.Write(cArray[i]); //write in the console the result of the char array
            }
            return null;
        }
        static void Main(string[] args)
        {
            ReverseCase("\nHappy Birthday"); // --> "hAPPY bIRTHDAY"

            ReverseCase("\nMANY THANKS"); //--> "many thanks"

            ReverseCase("\nsPoNtAnEoUs"); // --> "SpOnTaNeOuS"

            Console.Write("\nIf you want to try your own word type 'Y':  ");
            string answer = Console.ReadLine();
            Boolean run = true;
            
            if(answer == "y" || answer == "Y"){
                while(run){
                    Console.Write("Type in your word: ");
                    string userIn = Console.ReadLine();
                    string resp;
                    ReverseCase(userIn);

                    Console.Write("\nWould you like to conitnue? (y/n): ");

                    resp = Console.ReadLine();

                    if(resp == "n" || resp == "N")
                        run = false;
                }
            }
            Console.Write("Thank You for participating");
        }
    }
}
