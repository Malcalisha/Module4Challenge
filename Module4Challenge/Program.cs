 usingSystem;
 class DadJokesProgram{
 static void Main(){
 string[]dadJokes={
 "Why don't skeletons fight each other? They don't have the guts.",
 "What do you call cheese that isn't yours? Nacho cheese.",
 "Why did the scarecrow win an award? Because he was outstanding in his field.",
 "What do you call fake spaghetti? Animpasta.",
 "Why do seagulls fly over the ocean? Because if they flew over the bay,they'd be bagels.",
 "I'm on a whiskey diet. I've lost three days already.",
 "I used to play piano by ear, but now I use my hands.",
 "Did you hear about the claustrophobic astronaut? He needed a little space.",
 "Why don’t scientists trust atoms? Because they make up everything.",
 "Why did the mathbook look sad? Because it had too many problems.",
 "I told my wife she was drawing her eyebrows too high. She looked surprised.",
 "I'm reading a book on anti-gravity. It's impossible to put down."
 };
 
 Random rnd=new Random();
 string userResponse;

 do{
intjoke1Index=rnd.Next(0,12);
intjoke2Index;

 do{
 joke2Index=rnd.Next(0,12);
 } while(joke2Index==joke1Index);

 Console.WriteLine(dadJokes[joke1Index]);
 Console.WriteLine(dadJokes[joke2Index]);

 Console.Write("Do you want to see more Dad jokes? (yes/no):");
 userResponse=Console.ReadLine().ToLower();

 }while(userResponse=="yes");

 Console.WriteLine("Thank you for enjoying the jokes! Goodbye!");
 }
 }