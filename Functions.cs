namespace Maths;
public abstract class Functions
{ public static int RandomNumbers(int upper,int lower)
    {
        Random random = new Random();
        return random.Next(upper, lower);
    }
public static  int Answer(char sign,int x, int y)
    {
        return  (sign switch
        {
            '+' => x + y,
            '-' => x - y,
            '*' => x * y,
            _ => 0
        });
      }
   public static void Menu()
    {
        Console.WriteLine("\nWelcome to Maths Tester Pro\nSelect a difficulty\n1) Easy\n2) Medium\n3) Hard\n4) Exit\n");
    }
   public static char GenerateChar()
    {
        Random random = new Random();
      char[] operators= {'+','-','*'};
      int n = random.Next(operators.Length);
      return operators[n];
    }
    public static  void AskQuestion(int min, int max)
    {
         int answer,score=0,lives,questions;
    if (max==10)
    {
        questions = 5;
        lives=3;
        for(int i=1;i<=questions;i++){
            int no1= RandomNumbers(min,max);
           int no2= RandomNumbers(min,max);
            if(lives<1){
                Console.WriteLine("Out of lives, game over!");
                break;}
            char op=GenerateChar();
            if(i<questions){
            if(lives>1) {
                Console.WriteLine("Question " +i+ " of "+questions+". You have "+lives+" lives remaining\nWhat is  "+no1+ "  "+op+ "  "+no2+ "?");
            }else{
                Console.WriteLine("Question" +i+ " of  "+questions+".  You have  "+lives+ "  life remaining\nWhat is "+no1+ "  "+op+ "  "+no2+ "?");
            }}else{no1=RandomNumbers(max,max*2);
                no2=RandomNumbers(max,max*2);
                if(lives>1) {
                    Console.WriteLine("Question "+questions+ " of 5. You have "+lives+" lives remaining\nChallenge question\n\nWhat is  "+no1+ "  "+op+ "  "+no2+ "?");
                 
                }
                else
                {
                    Console.WriteLine("Question "+questions+ " of 5. You have "+lives+" life remaining\nChallenge question\n\nWhat is "+no1+ "  "+op+ "  "+no2+ "?");
                }
                
            }
            answer = Convert.ToInt32(Console.ReadLine());
            if(Answer(op,no1,no2)==answer){
                Console.WriteLine("Correct!\n");
                score++;}
            else{
                Console.Write("Incorrect!! The correct answer was  " );
                Console.WriteLine(Answer(op,no1,no2));
                lives--;}}
        Console.Write("Test complete. You scored "+score+ " / "+questions+" Your grade is :  " );
        Console.WriteLine(Grade((score*100)/5));
        Console.WriteLine("\n\nWish to start again?");
      
    }
    if(max==25)
    {
        questions = 10;
        lives=2;
        for(int i=1;i<=questions;i++){
            int no1= RandomNumbers(min,max);
            int no2= RandomNumbers(min,max);
            if(lives<1){
                Console.WriteLine("Out of lives, game over!");
                break;}
            char op=GenerateChar();
            if(i<questions){
                if(lives>1) {
                    Console.WriteLine("Question " +i+ " of "+questions+". You have "+lives+" lives remaining\nWhat is  "+no1+ "  "+op+ "  "+no2+ "?");
                }else{
                    Console.WriteLine("Question " +i+ " of "+questions+". You have "+lives+ "  life remaining\nWhat is "+no1+ "  "+op+ "  "+no2+ "?");
                }}else{no1=RandomNumbers(max,max*2);
                no2=RandomNumbers(max,max*2);
                if(lives>1) {
                    Console.WriteLine("Question "+questions+ " of "+questions+". You have "+lives+" lives remaining\nChallenge question\n\nWhat is  "+no1+ "  "+op+ "  "+no2+ "?");
                 
                }
                else
                {
                    Console.WriteLine("Question "+questions+ " of  "+questions+". You have "+lives+" life remaining\nChallenge question\n\nWhat is "+no1+ "  "+op+ "  "+no2+ "?");
                }}

            answer = Convert.ToInt32(Console.ReadLine());
            if(Answer(op,no1,no2)==answer){
                Console.WriteLine("Correct!\n");
                score++;}
            else{
                Console.Write("Incorrect!! The correct answer was  " );
                Console.WriteLine(Answer(op,no1,no2));
                lives--;}}
        Console.Write("Test complete. You scored "+score+ " / "+questions+" Your grade is :  " );
        Console.WriteLine(Grade((score*100)/10));

        Console.WriteLine("\n\nWish to start again?");
    }
    
    else if(max==50)
    {
        questions = 15;lives=1;
        
        for(int i=1;i<=questions;i++){
            int no1= RandomNumbers(min,max);
            int no2= RandomNumbers(min,max);
            if(lives<1){
                Console.WriteLine("Out of lives, game over!");
                break;
            }
            char op=GenerateChar();
            if(i<questions)
            {
                Console.WriteLine("Question " +i+ " of "+questions+". You have "+lives+ "  life remaining\nWhat is "+no1+ "  "+op+ "  "+no2+ "?");
            }
            else{
                no1=RandomNumbers(max,max*2);
                no2=RandomNumbers(max,max*2);
                if(lives>1) {
                    Console.WriteLine("Question "+questions+ " of "+questions+". You have "+lives+" lives remaining\nChallenge question\n\nWhat is  "+no1+ "  "+op+ "  "+no2+ "?");
                 
                }
                else
                {
                    Console.WriteLine("Question "+questions+ " of "+questions+". You have "+lives+" life remaining\nChallenge question\n\nWhat is "+no1+ "  "+op+ "  "+no2+ "?");
                }
                
            }
            answer = Convert.ToInt32(Console.ReadLine());
            if(Answer(op,no1,no2)==answer){
                Console.WriteLine("Correct!\n");
                score++;}
            else{
                Console.Write("Incorrect!! The correct answer was  " );
                Console.WriteLine(Answer(op,no1,no2));
                lives--;}
            
        }
        Console.Write("Test complete. You scored "+score+ " / "+questions+" Your grade is :  " );
        Console.WriteLine(Grade((score*100)/15));
        Console.WriteLine("\n\nWish to start again?");
    }
    }
  public static string Grade(int score)
    {
        string gr="";
        switch (score) {
            case var i when i>=80 && i<=100:
               gr="High distinction";
                break;
             case var i when i>=70 && i<80:
                 gr = "Distinction";
                break;
            case var i when i>=60 && i<70:
                gr = "Credit";
                break;
            case var i when i>=50 && i<60:
                gr = "Pass";
                break;
            case var i when i>=0 && i<50:
                gr = "Fail";
                break;
        }
        return gr;
    }
  }