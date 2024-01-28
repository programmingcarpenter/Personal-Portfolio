using System.ComponentModel.Design.Serialization;
using System.Diagnostics;

Console.WriteLine("A game of chance");
Console.WriteLine();
Console.WriteLine("1. Play");
Console.WriteLine("2. Quit");

string userInput = Console.ReadLine();

switch (userInput)
{
    case "1":
        Clear();
        Play();
        break;
    case "2":
        return;
    default:
        Console.WriteLine("Invalid Input. Try Again.");
        break;
}
        
static void Play()
{
    Console.WriteLine("Old Man: Hey! Are you still playing or what?");
    Console.WriteLine("Your mind clears as if it was suddenly shrouded for a moment.");
    Console.WriteLine("You look back down to the table, trying to see what piece he moved from last time.");
    Console.WriteLine();
    Console.WriteLine("1. Move Knight to E5");
    Console.WriteLine("2. Move Bishop to D2");

    string userInput = Console.ReadLine();

    switch (userInput)
    {
        case "1":
            Clear();
            E5();
            break;
        case "2":
            Clear();
            D2();
            break;
        default:
            Console.WriteLine();
            break;
    }
}

static void E5()
{
    Console.WriteLine("The Old Man's grimly face shows a glint of satisfaction.");
    Console.WriteLine("Old Man: I believe that there is Check, mate.");
    Console.WriteLine("He grabs the sack of coins to the side of the board and stands to leave");
    Console.WriteLine();
    Console.WriteLine("1. Stop the Old Man");
    Console.WriteLine("2. Let him walk away");

    string userInput = Console.ReadLine();

    switch(userInput)
    {
        case "1":
            Clear();
            Stop();
            break;
        case "2":
            Clear();
            Stay();
            break;
        default:
            Console.WriteLine();
            break;
        }

    }

static void D2()
{
    Console.WriteLine("The Old Man's wrinkles seems to get deeper as you place the chess piece.");
    Console.WriteLine("He lets out a heavy sigh.");
    Console.WriteLine("Old Man: Check mate. I believe that bag is yours.");
    Console.WriteLine("His eyes point towards a sack of coins to the side as he leans back in his chair.");
    Console.WriteLine();
    Console.WriteLine("1. Ask him to hear you out");
    Console.WriteLine("2. Gloat your victory, repectively");

    string userInput = Console.ReadLine();

    switch (userInput)
    {
        case "1":
            Clear();
            Request();
            break;
        case "2":
            Clear();
            Taunt();
            break;
        default:
            Console.WriteLine();
            break;
    }

}

static void Stop()
{
    Console.WriteLine("Me: Despite that game you never mentioned if you could transport my Party and I across the Lake");
    Console.WriteLine("The Old Man turns grining.");
    Console.WriteLine("Old Man: Well now I could do that if you had the coin.");
    Console.WriteLine("He walks away laughing, swinging the coin purse around it's string.");
    return;
}

static void Stay()
{
    Console.WriteLine("As the Old Man walks away, gauging his profits you slump back in the Chair.");
    Console.WriteLine("Your eyes close as you envision your party scolding you for losing the week's profit.");
    Console.WriteLine("Me: I hope they go easy on me this time.");
    return;
}

static void Request()
{
    Console.WriteLine("Me: So now that I have enough money for a fare, when do we leave?");
    Console.WriteLine("The Old Man eyes drift towards the coins as you push them closer to him.");
    Console.WriteLine("Old Man: Very well mate, was hoping to never go back there again.");
    Console.WriteLine("But there are only some things we always return to. Tell your mates to pack up.");
    return;
}

static void Taunt()
{
    Console.Clear();
    Console.WriteLine("Me: Where is all that gusto from when you suggested the game?");
    Console.WriteLine("The Old Man looks wearily at you with sadness in his eyes.");
    Console.WriteLine("Old Man: When we get there you will learn why we call it, The Graveyard of Pirates.");
    Console.WriteLine("The Old Man snatches the bag and stands to leave.");
    Console.WriteLine("Old Man: Tell your mates we leave before the Fog rolls in.");
    return;
}

static void Clear()
{  
    Console.Clear(); 
}