Main();
static void Main(){
DisplayMainMenu();
int userInput = GetMenuChoice();
while(userInput != 4){
        if(userInput == 1){
            DisplayPlainPizza();
            userInput = GetMenuChoice();
        } else if(userInput == 2){
            DisplayCheesePizza();
            userInput = GetMenuChoice();
        }else if(userInput == 3){
        DisplayPeperoniPizza();
        userInput = GetMenuChoice();
        }
        else{
            System.Console.WriteLine("Invalid Input try again 1-4");
        }

        
    }
        System.Console.WriteLine("Exiting the application! Goodbye");

}
// //end main 

static void DisplayMainMenu(){
    System.Console.WriteLine("Hello! Here are your options\n1: Display a Plain Pizza\n2: Display a Cheese Pizza\n3: Display a Peperoni Pizza\n4: Exit");
}

static int GetMenuChoice(){
    System.Console.WriteLine("Please Enter your selection 1-4");
    int userInput = int.Parse(Console.ReadLine());
    if(userInput >= 1 || userInput <= 4){
        return userInput;
    }else{
        System.Console.WriteLine("Invalid Input, Please try again 1-4");
        return GetMenuChoice();
    }
}

static void DisplayPlainPizza(){
    Random rnd = new Random();
    int rows = rnd.Next(8,13);
    for(int i = rows; i > 0; i--){
        for(int j = 0; j<i; j++)
        {
            Console.Write("*");
        }
        System.Console.WriteLine();
    }
}
static void DisplayCheesePizza(){
    Random rnd = new Random();
    int rows = rnd.Next(8,13);
    for(int i = rows; i > 0; i--){
        for(int j = 0; j<i; j++)
        {
            if(i == rows || j == 0 || j == i-1|| i == 1){
            Console.Write("*");
        }else 
        Console.Write("#");
        }
        System.Console.WriteLine();
    }
    
}
static void DisplayPeperoniPizza(){
    Random rnd = new Random();
    int rows = rnd.Next(8,13);
    for(int i = rows; i > 0; i--){
        for(int j = 0; j<i; j++)
        {
            if(i == rows || j == 0 || j == i-1|| i == 1){
            Console.Write("*");
            }
            else if(rnd.Next(0,5) == 0){
            Console.Write("[]");
        } 
        else{
        Console.Write("#");
    }
            }
}
Console.WriteLine();
}