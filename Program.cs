// See https://aka.ms/new-console-template for more information

using static Maths.Functions;  //importing my functions class
while (true) {
    Menu();
    var choice = Convert.ToInt32(Console.ReadLine());
    switch (choice) {
        case 1:
            Console.WriteLine("Easy mode selected\n");
            AskQuestion(1,10);
            break;
        case 2:
            Console.WriteLine("Medium mode selected\n");
            AskQuestion(1,25);
            break;
        case 3:
            Console.WriteLine("Hard mode selected\n");
            AskQuestion(1,50);
            break;
        case 4:
            Environment.Exit(0);  
            break;
        default:
            Console.WriteLine("Invalid choice, enter 1, 2 or 3.\n");
            break;
    }
}
