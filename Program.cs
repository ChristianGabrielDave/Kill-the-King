using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Kill_the_King_V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartScreen();
        }

        static void StartScreen()
        {
            string Title = @"
             ____  __.___.____    .____      ______________ ______________  ____  __.___ _______    ________ 
            |    |/ _|   |    |   |    |     \__    ___/   |   \_   _____/ |    |/ _|   |\      \  /  _____/ 
            |      < |   |    |   |    |       |    | /    ~    \    __)_  |      < |   |/   |   \/   \  ___ 
            |    |  \|   |    |___|    |___    |    | \    Y    /        \ |    |  \|   /    |    \    \_\  \
            |____|__ \___|_______ \_______ \   |____|  \___|_  /_______  / |____|__ \___\____|__  /\______  /
                    \/           \/       \/                 \/        \/          \/           \/        \/ 
            ";
            Console.WriteLine($"{Title}");
            Console.WriteLine("\n\n\t\t\t\t\t===== PRESS ENTER TO START =====\n");
            Console.ReadLine();
            KillTheKing();
        }

        static void KillTheKing()
        {
            Console.Clear();

            string HeadLine = "Heiter Kingdom | 2XXX";
            Console.SetCursorPosition(50,3);
            for (int i = 0; i < HeadLine.Length; i++) 
            {
                Console.Write(HeadLine[i]);
                Thread.Sleep(100);
            }
            Console.WriteLine("\n\n");

            string Body = "\t King Felix Polinar has announced that starting tomorrow, 11th of September the Heiter Kingdom shall be divided" +
                          "\n into to two, where the Northern Part will be the true 'Heiter Kingdom'. And the Southern Part will be allocated to all" +
                          "\n citizens that are not included in the high class, being left with no government recognition or protection. Henry, who" +
                          "\n has heard of this news is angered, and quickly rushes to the King's Castle with the plan of assassination.";

            for (int i = 0;i < Body.Length;i++)
            {
                Console.Write(Body[i]);
                Thread.Sleep(55);
            }
            Console.ReadLine();
            CastleGate();
        }

        static void CastleGate()
        {
            Label:
            Console.Clear();

            Console.SetCursorPosition(30, 3);
            string SubTitle = "Henry arrives at the Castle Gate.";
            for (int i = 0; i < SubTitle.Length; i++)
            {
                Console.Write(SubTitle[i]);
                Thread.Sleep(45);
            }
            Console.WriteLine("\n\n");
            Console.WriteLine("\t\t{TELEPORTAION MAGIC}\t{SECRET MESSAGE}\n");
            Console.WriteLine("\t\t{TANK}\t\t\t{PROTEST}");

            Console.Write("\n\nEnter Action: "); string UserAction = Console.ReadLine();

            string[] action = {"TELEPORTATION MAGIC","TANK","PROTEST","SECRET MESSAGE"};

            if (UserAction.ToUpper() == action[0] || UserAction == "1") {TeleportationMagic();}
            else if (UserAction.ToUpper() == action[3] || UserAction == "2") {SecretMessage();}
            else if (UserAction.ToUpper() == action[1] || UserAction == "3") {Tank();}
            else if (UserAction.ToUpper() == action[2] || UserAction == "4") {Protest();}
            else {goto Label;}
        }

        static void TeleportationMagic()
        {
            Console.Clear();

            string Location1 = "Castle Gate";
            string Description = "Henry takes a step back, puts his hands together and closes his eyes. With his inner voice he begins to chant                     ";
            string Lanuae = "lanuae me regi";
            string MeRegi = "LANUAE ME REGI!";
            string LanuaeMeRegi = @"
             ___                                                                                                                    ___   ___   ___  
            (   )                                                                                                             .-.  (   ) (   ) (   ) 
             | |    .---.   ___ .-.    ___  ___    .---.    .--.      ___ .-. .-.     .--.      ___ .-.      .--.     .--.   ( __)  | |   | |   | |  
             | |   / .-, \ (   )   \  (   )(   )  / .-, \  /    \    (   )   '   \   /    \    (   )   \    /    \   /    \  (''')  | |   | |   | |  
             | |  (__) ; |  |  .-. .   | |  | |  (__) ; | |  .-. ;    |  .-.  .-. ; |  .-. ;    | ' .-. ;  |  .-. ; ;  ,-. '  | |   | |   | |   | |  
             | |    .'`  |  | |  | |   | |  | |    .'`  | |  | | |    | |  | |  | | |  | | |    |  / (___) |  | | | | |  | |  | |   | |   | |   | |  
             | |   / .'| |  | |  | |   | |  | |   / .'| | |  |/  |    | |  | |  | | |  |/  |    | |        |  |/  | | |  | |  | |   | |   | |   | |  
             | |  | /  | |  | |  | |   | |  | |  | /  | | |  ' _.'    | |  | |  | | |  ' _.'    | |        |  ' _.' | |  | |  | |   | |   | |   | |  
             | |  ; |  ; |  | |  | |   | |  ; '  ; |  ; | |  .'.-.    | |  | |  | | |  .'.-.    | |        |  .'.-. | '  | |  | |   |_|   |_|   |_|  
             | |  ' `-'  |  | |  | |   ' `-'  /  ' `-'  | '  `-' /    | |  | |  | | '  `-' /    | |        '  `-' / '  `-' |  | |   .-.   .-.   .-.  
            (___) `.__.'_. (___)(___)   '.__.'   `.__.'_.  `.__.'    (___)(___)(___) `.__.'    (___)        `.__.'   `.__. | (___) (   ) (   ) (   ) 
                                                                                                                     ( `-' ;        '-'   '-'   '-'  
                                                                                                                      `.__.                          
            ";
            string buffer = "                         ";
            string DescCont1 = "\t A flash of white light can be seen where Henry was, guards around the outer fences of the castle" +
                               "\n rush to the scene, just to find that no one was there.";
            string Location2 = "Castle Courtroom";
            string DesCont2 = "\t A guard screams at the top of her lungs, reaching the hallways. The two guards outside the door of" +
                              "\n the courtroom, immediately opens the door in response. Just to be shocked at what they see...";
            string DesCont3 = "\t Henry has teleported inside King Felix, merging their bodies as one, killing the both of them.";

            string FAIL = @"
            __/\\\\\\\\\\\\\\\_____/\\\\\\\\\_____/\\\\\\\\\\\__/\\\_____________        
            _\/\\\///////////____/\\\\\\\\\\\\\__\/////\\\///__\/\\\_____________       
              _\/\\\______________/\\\/////////\\\_____\/\\\_____\/\\\_____________      
               _\/\\\\\\\\\\\_____\/\\\_______\/\\\_____\/\\\_____\/\\\_____________     
                _\/\\\///////______\/\\\\\\\\\\\\\\\_____\/\\\_____\/\\\_____________    
                 _\/\\\_____________\/\\\/////////\\\_____\/\\\_____\/\\\_____________   
                  _\/\\\_____________\/\\\_______\/\\\_____\/\\\_____\/\\\_____________  
                   _\/\\\_____________\/\\\_______\/\\\__/\\\\\\\\\\\_\/\\\\\\\\\\\\\\\_ 
                    _\///______________\///________\///__\///////////__\///////////////__       
            ";


            Console.SetCursorPosition(5, 3);
            for (int i = 0; i < Location1.Length; i++)
            {
                Console.Write(Location1[i]);
                Thread.Sleep(100);
            }
            Console.SetCursorPosition(10, 6);
            for (int i = 0; i < Description.Length; i++)
            {
                Console.Write(Description[i]);
                Thread.Sleep(55);
            }



            Console.Clear();
            Console.SetCursorPosition(50, 8);
            for (int i = 0; i < Lanuae.Length; i++)
            {
                Console.Write(Lanuae[i]);
                Thread.Sleep(100);
            }
            Console.Clear();
            Console.SetCursorPosition(50, 8);
            for (int i = 0; i < MeRegi.Length; i++)
            {
                Console.Write(MeRegi[i]);
                Thread.Sleep(75);
            }
            Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(0, 8);
            Console.WriteLine(LanuaeMeRegi);
            for (int i = 0; i < buffer.Length; i++)
            {
                Console.Write(buffer[i]);
                Thread.Sleep(75);
            }
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.White;



            Console.Clear();
            Console.SetCursorPosition(5, 3);
            Console.WriteLine(Location1);
            Console.SetCursorPosition(10, 6);
            for (int i = 0; i < DescCont1.Length; i++)
            {
                Console.Write(DescCont1[i]);
                Thread.Sleep(55);
            }

            Console.Clear();
            Console.SetCursorPosition(5, 3);
            for (int i = 0; i < Location2.Length; i++)
            {
                Console.Write(Location2[i]);
                Thread.Sleep(100);
            }
            Console.SetCursorPosition(10, 6);
            for (int i = 0; i < DesCont2.Length; i++)
            {
                Console.Write(DesCont2[i]);
                Thread.Sleep(55);
            }

            Console.Clear();
            Console.SetCursorPosition(5, 3);
            Console.WriteLine(Location2);
            Console.SetCursorPosition(10, 6);
            for (int i = 0; i < DesCont3.Length; i++)
            {
                Console.Write(DesCont3[i]);
                Thread.Sleep(85);
            }
            for (int i = 0; i < buffer.Length; i++)
            {
                Console.Write(buffer[i]);
                Thread.Sleep(75);
            }

            Label:

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red; Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(FAIL);
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(25, 12);
            Console.WriteLine("\tSpellcasting Skill Isue");

            Console.WriteLine("\n\n\t\t\t{RETRY}\t\t\t\t{EXIT}");
            string UserAction = Console.ReadLine();

            string[] action = {"RETRY","EXIT"};
            if (UserAction.ToUpper() == action[0] || UserAction.ToUpper() == "R") {CastleGate();}
            else if (UserAction.ToUpper() == action[1] || UserAction.ToUpper() == "E") {Console.ReadLine();}
            else {goto Label;}
        }

        static void Tank()
        {
            Console.Clear();

            string Location1 = "Castle Gate";
            string Location2 = "Castle Courtroom";

            string Henry = "Henry";
            string Charles = "Charles";

            string Dialouge1 = ": Hello? Henry? What do you need?";
            string Dialouge2 = ": Charles, bring the tank to the King's Castle.";
            string Dialouge3 = ": Why?";
            string Dialouge4 = ": Have you seen the announcement? Let's kill the King.";
            string Dialouge5 = ": Give me 30 minutes.";

            string Description = "Henry reaches into his pocket and grabs his phone.";
            string DescCont1 = "\t Henry is laying on the ground, when it starts to shake. Henry stands up and looks around." +
                               "\n Behind Henry he sees the tank approaching at top speed, with no signs of slowing down.         ";
            string DesCont2 = "\t Charles shouts 'HENRY JUMP ON WE'RE CHARGING WITH FULL FORCE!!!'              ";
            string DesCont3 = "\t Henry jumps on the tank, and they run over the castle gate and the guards defending it. Some guards are" +
                              "\n running for their lives as Henry shoots them with the tank. Henry shoots the castle doors, and the tank busts through" +
                              "\n the wall. The tank speeds through the hallway, as it approaches the end, Henry shoots the courtroom doors killing the" +
                              "\n two guards guarding it.               ";
            string DesCont4 = "\t The tank enters the courtroom and rolls over King Felix, killing him.";

            string buffer = "                         ";

            string Phone = @"
                         _.._           
                  __.-----------.__    
                .'//   .------.   \\`,  
               : :'  .'.  :;  ,`.  `; ; 
              /; ;  /  T. $$ ,P  \  : : 
             /: :  ;    T.:;,P    :  ; ;
             )| | :      `  '      ; | |
             `j | :.--------------.: | |
              ; ; |     Calling    | : :
              ; ; |     Charles    | : :
              | | |                | | |
              | | | Speaker   End  | | |
              : : |    0       1   | ; ;
              : : :________________: ; ;
               ; ;__    _...._    __: : 
               | ;   -./ ,--, \,-   : | 
               | '._   \ ;  : /   _.' | 
               :  __`-. `.  ,' .-'__  
                ;`.__> `.J__L.' <__.':  
                ;.--._   .--.   _.--,:  
                |`.__.' `.__.' `.__.'|  
                |.--._   .--.   _.--,|  
                |`.__.' `.__.' `.__.'|  
                |.--._   .--.   _.--,|  
                ;`.__.' `.__.' `.__.':  
               : .--._   .--.   _.--, ; 
               ; `.__.' `.__.' `.__.' : 
               ;                      : 
               '--..__          __..--' 
                      ---------       
            ";

            string ThirtyMinutes = @"
                __  _       ___      ___ __ __       _ ___ __ _ 
                __)/ \   |V| | |\|| | | |_ (_    |  |_| | |_ |_)
                __)\_/   | |_|_| ||_| | |____)   |__| | | |__| \
            ";

            string SUCCESS = @"
                _____/\\\\\\\\\\\____/\\\________/\\\________/\\\\\\\\\________/\\\\\\\\\__/\\\\\\\\\\\\\\\_____/\\\\\\\\\\\_______/\\\\\\\\\\\___        
                ___/\\\/////////\\\_\/\\\_______\/\\\_____/\\\////////______/\\\////////__\/\\\///////////____/\\\/////////\\\___/\\\/////////\\\_       
                  __\//\\\______\///__\/\\\_______\/\\\___/\\\/_____________/\\\/___________\/\\\______________\//\\\______\///___\//\\\______\///__      
                   ___\////\\\_________\/\\\_______\/\\\__/\\\______________/\\\_____________\/\\\\\\\\\\\_______\////\\\___________\////\\\_________     
                    ______\////\\\______\/\\\_______\/\\\_\/\\\_____________\/\\\_____________\/\\\///////___________\////\\\___________\////\\\______    
                     _________\////\\\___\/\\\_______\/\\\_\//\\\____________\//\\\____________\/\\\_____________________\////\\\___________\////\\\___
                      __/\\\______\//\\\__\//\\\______/\\\___\///\\\___________\///\\\__________\/\\\______________/\\\______\//\\\___/\\\______\//\\\__  
                       _\///\\\\\\\\\\\/____\///\\\\\\\\\/______\////\\\\\\\\\____\////\\\\\\\\\_\/\\\\\\\\\\\\\\\_\///\\\\\\\\\\\/___\///\\\\\\\\\\\/___ 
                        ___\///////////________\/////////___________\/////////________\/////////__\///////////////____\///////////_______\///////////_____
            ";

            string Tank1 = @"
                        __.---.___
                    ___/__\_O_/___\___
                   /___\__________/___\
                   |===|\________/|===|
            _______|===|__________|===|______
            ";

            string Tank2 = @"
                        __.---.___
                    ___/__\_O_/___\___
                   /___\__________/___\
                   |___|\________/|___|
            _______|___|__________|___|______
            ";
            string Tank3 = @"
                          _____
                  !      /-----\============@
                  |_____/_______\_____
                 /____________________\
                 \+__+__+__+__+__+__+_/
            ";
            const string Tank4 = @"
                          _____
                  !      /-----\============@
                  |_____/_______\_____
                 /____________________\
                 \__+__+__+__+__+__+__/
            ";

            Console.SetCursorPosition(5, 3);
            for (int i = 0; i < Location1.Length; i++)
            {
                Console.Write(Location1[i]);
                Thread.Sleep(100);
            }
            Console.SetCursorPosition(10, 6);
            for (int i = 0; i < Description.Length; i++)
            {
                Console.Write(Description[i]);
                Thread.Sleep(55);
            }


            Console.Clear();
            Console.WriteLine("\n");
            Console.WriteLine(Phone);
            for (int i = 0; i < buffer.Length; i++)
            {
                Console.Write(buffer[i]);
                Thread.Sleep(75);
            }



            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(5, 3);
            for (int i = 0; i < Charles.Length; i++)
            {
                Console.Write(Charles[i]);
                Thread.Sleep(50);
            }
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < Dialouge1.Length; i++)
            {
                Console.Write(Dialouge1[i]);
                Thread.Sleep(50);
            }
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(5, 6);
            for (int i = 0; i < Henry.Length; i++)
            {
                Console.Write(Henry[i]);
                Thread.Sleep(50);
            }
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < Dialouge2.Length; i++)
            {
                Console.Write(Dialouge2[i]);
                Thread.Sleep(50);
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(5, 9);
            for (int i = 0; i < Charles.Length; i++)
            {
                Console.Write(Charles[i]);
                Thread.Sleep(50);
            }
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < Dialouge3.Length; i++)
            {
                Console.Write(Dialouge3[i]);
                Thread.Sleep(50);
            }
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(5, 12);
            for (int i = 0; i < Henry.Length; i++)
            {
                Console.Write(Henry[i]);
                Thread.Sleep(50);
            }
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < Dialouge4.Length; i++)
            {
                Console.Write(Dialouge4[i]);
                Thread.Sleep(50);
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(5, 15);
            for (int i = 0; i < Charles.Length; i++)
            {
                Console.Write(Charles[i]);
                Thread.Sleep(50);
            }
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < Dialouge5.Length; i++)
            {
                Console.Write(Dialouge5[i]);
                Thread.Sleep(50);
            }


            Console.Clear();
            Console.SetCursorPosition(0, 8);
            Console.WriteLine(ThirtyMinutes);
            for (int i = 0; i < buffer.Length; i++)
            {
                Console.Write(buffer[i]);
                Thread.Sleep(75);
            }

            Console.Clear();
            Console.SetCursorPosition(5, 3);
            Console.WriteLine(Location1);
            Console.SetCursorPosition(10, 6);
            for (int i = 0; i < DescCont1.Length; i++)
            {
                Console.Write(DescCont1[i]);
                Thread.Sleep(55);
            }
            for (int i = 1; i <= 6; i++)
            {
                Console.Clear();
                Console.Write(Tank1); Thread.Sleep(100);
                Console.Clear();
                Console.Write(Tank2); Thread.Sleep(100);
            }
            Console.Clear();
            Console.SetCursorPosition(10, 6);
            for (int i = 0; i < DesCont2.Length; i++)
            {
                Console.Write(DesCont2[i]);
                Thread.Sleep(20);
            }
            Console.Clear();
            Console.SetCursorPosition(10, 6);
            for (int i = 0; i < DesCont3.Length; i++)
            {
                Console.Write(DesCont3[i]);
                Thread.Sleep(55);
            }

            for (int i = 1; i <= 6; i++)
            {
                Console.Clear();
                Console.Write(Tank3); Thread.Sleep(100);
                Console.Clear();
                Console.Write(Tank4); Thread.Sleep(100);
            }

            Console.Clear();
            Console.SetCursorPosition(5, 3);
            for (int i = 0; i < Location2.Length; i++)
            {
                Console.Write(Location2[i]);
                Thread.Sleep(100);
            }
            Console.SetCursorPosition(10, 6);
            for (int i = 0; i < DesCont4.Length; i++)
            {
                Console.Write(DesCont4[i]);
                Thread.Sleep(85);
            }
            for (int i = 0; i < buffer.Length; i++)
            {
                Console.Write(buffer[i]);
                Thread.Sleep(75);
            }

            Label:

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Cyan; Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(SUCCESS);
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(55, 12);
            Console.WriteLine("Congrats, you've SUCCESSFULLY killed the King.");

            Console.WriteLine("\n\n\t\t\t\t\t\t\t{RETRY}\t\t\t\t{EXIT}");
            string UserAction = Console.ReadLine();

            string[] action = { "RETRY", "EXIT" };
            if (UserAction.ToUpper() == action[0] || UserAction.ToUpper() == "R") { CastleGate(); }
            else if (UserAction.ToUpper() == action[1] || UserAction.ToUpper() == "E") { Console.ReadLine(); }
            else {goto Label;}
        }

        static void Protest() 
        {
            Console.Clear();

            string Location1 = "Castle Gate";
            string Description = "\t Henry grabs a stick and cardboard, he nails them together and grabs a pen from his pocket." +
                                 "\n Henry writes on the sign, and holds it up. He takes a big breath, and shouts:     ";

            string NO = @"
                  _   _    ____  
                 | \ | |  / __ \ 
                 |  \| | | |  | |
                 | . ` | | |  | |
                 | |\  | | |__| |
                 |_| \_|  \____/                                                                                     
            ";
            string TO = @"
                  _______    ____  
                 |__   __|  / __ \ 
                    | |    | |  | |
                    | |    | |  | |
                    | |    | |__| |
                    |_|     \____/ 
            ";
            string SPLIT = @"
                   _____   _____    _        _____   _______ 
                  / ____| |  __ \  | |      |_   _| |__   __|
                 | (___   | |__) | | |        | |      | |   
                  \___ \  |  ___/  | |        | |      | |   
                  ____) | | |      | |____   _| |_     | |   
                 |_____/  |_|      |______| |_____|    |_|   
            ";

            string DesCon1 = " over and over.          ";
            string DesCon2 = " \t The guards comes over and arrests Henry...";
            string buffer = "                         ";

            string FAIL = @"
            __/\\\\\\\\\\\\\\\_____/\\\\\\\\\_____/\\\\\\\\\\\__/\\\_____________        
            _\/\\\///////////____/\\\\\\\\\\\\\__\/////\\\///__\/\\\_____________       
              _\/\\\______________/\\\/////////\\\_____\/\\\_____\/\\\_____________      
               _\/\\\\\\\\\\\_____\/\\\_______\/\\\_____\/\\\_____\/\\\_____________     
                _\/\\\///////______\/\\\\\\\\\\\\\\\_____\/\\\_____\/\\\_____________    
                 _\/\\\_____________\/\\\/////////\\\_____\/\\\_____\/\\\_____________   
                  _\/\\\_____________\/\\\_______\/\\\_____\/\\\_____\/\\\_____________  
                   _\/\\\_____________\/\\\_______\/\\\__/\\\\\\\\\\\_\/\\\\\\\\\\\\\\\_ 
                    _\///______________\///________\///__\///////////__\///////////////__       
            ";

            Console.SetCursorPosition(5, 3);
            for (int i = 0; i < Location1.Length; i++)
            {
                Console.Write(Location1[i]);
                Thread.Sleep(100);
            }
            Console.SetCursorPosition(10, 6);
            for (int i = 0; i < Description.Length; i++)
            {
                Console.Write(Description[i]);
                Thread.Sleep(55);
            }

            for (int i = 1; i <= 3; i++)
            {
                Console.Clear();
                Console.Write(NO); Thread.Sleep(750);
                Console.Write(TO); Thread.Sleep(750);
                Console.Write(SPLIT); Thread.Sleep(750);
                
                for (int j = 1; j <= i ; j++) { Thread.Sleep(300); }
            }

            Console.Clear() ;

            Console.SetCursorPosition(10, 6);
            for (int i = 0; i < DesCon1.Length; i++)
            {
                Console.Write(DesCon1[i]);
                Thread.Sleep(55);
            }

            Console.Clear();
            Console.SetCursorPosition(5, 3);
            for (int i = 0; i < Location1.Length; i++)
            {
                Console.Write(Location1[i]);
                Thread.Sleep(100);
            }
            Console.SetCursorPosition(10, 6);
            for (int i = 0; i < DesCon2.Length; i++)
            {
                Console.Write(DesCon2[i]);
                Thread.Sleep(85);
            }
            for (int i = 0; i < buffer.Length; i++)
            {
                Console.Write(buffer[i]);
                Thread.Sleep(75);
            }

            Label:

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red; Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(FAIL);
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(25, 12);
            Console.WriteLine("\tGAME TITLE!!! GAME TITLE!!!");

            Console.WriteLine("\n\n\t\t\t{RETRY}\t\t\t\t{EXIT}");
            string UserAction = Console.ReadLine();

            string[] action = { "RETRY", "EXIT" };
            if (UserAction.ToUpper() == action[0] || UserAction.ToUpper() == "R") { CastleGate(); }
            else if (UserAction.ToUpper() == action[1] || UserAction.ToUpper() == "E") { Console.ReadLine(); }
            else { goto Label; }
        }

        static void SecretMessage()
        {
            Console.Clear();

            string Location1 = "Castle Gate";
            string Description = "\t Henry grabs a pen and paper from his pocket, he writes on it and folds it into a paper" +
                                 "\n plane. Henry backs ups and throws the paper plane.";
            string DesCont1 = "\t The paper plane flies through the courtroom window, and hits King Felix's head. King Felix," +
                              "\n confused, grabs the paper plane, opens it and reads it.          ";
            string DesCont2 = "\t Guards gathers at the castle gate, and sees Henry sitting down, waiting for the King. Henry " +
                              "\n stands up and takes a fighting stance...";
            string DesCont3 = "\t Henry gets shot by a guard...";
            string buffer = "                         ";

            string PaperPlane1 = @"                                                          
                                                                         ~           ....:-=*: ~     
                                        ~                                     ...::-:-----:::.      
                                                    ~                  ~..:-=-::.. .-=-...:-.       
                                                                 ...-+=:....   ..++:..   .-.    ~    
                                                        .....:=+:.        ...:+=:.      .=.         
                             ~      ~            ...:-::=-.           ...:=--.         .=. ~         
                                           ..:--::-.......:---::...::=+++-..          .-.           
                                   ~...=*+++=-:...............   .:-=-:..:.          .-.          ~  
                                 .-+..                       ..=--=..    .:.        .::.            
                       ~   ..::=:.                      ...:=--:.         .-.      .::. ~            
                       ..::-:.                       ..:---::..            .-.     ::.              
                   ..--:...                       ..----:..                 .-.   ::.               
                .-=:...                        .:=::=:...                    .-. :-.                
                 .:-=-.....               ...--::-:.                          .:::     ~             
                       ..:--:::..      ..:--::-:.                            .:-:.                  
                             ..:::--::--::-:..                            .:-:..                    
                          ~        .:=:+=:.                            .:-:.                        
                                    .-:=-:--++-:.                    .=-.                 ~          
                    ~               .::--:::::::--=+=::....      ..--..     ~                        
                             ~      .:=--::::::--==:. ..:-::-:.:--.   ~                              
                                    .:+--::::-=-:.          .....                                   
                        ~            :+=::-==:.       ~                                              
                                   ~ .==-+:                                                         
                                     .--.  ~
            ";
            string PaperPlane2 = @"
                                                                         ~           ....:-=*:      ~
                                                     ~                        ...::-:-----:::.~      
                                           ~                           ~..:-=-::.. .-=-...:-.       
                               ~                                 ...-+=:....   ..++:..   .-.        
                                       ~                .....:=+:.        ...:+=:.      .=.            ~    
                                 ~               ...:-::=-.           ...:=--.         .=.~         
                                           ..:--::-.......:---::...::=+++-..          .-.     ~         
                        ~          ~...=*+++=-:...............   .:-=-:..:.          .-.            
                                 .-+..                       ..=--=..    .:.        .::.  ~          
                           ..::=:.                      ...:=--:.         .-.      .::.            ~       
                ~      ..::-:.                       ..:---::..            .-.     ::.  ~            
                   ..--:...                       ..----:..                 .-.   ::.               
                .-=:...                        .:=::=:...                    .-. :-.                
                ~.:-=-.....               ...--::-:.                          .:::       ~            
                       ..:--:::..      ..:--::-:.                            .:-:.                  
                      ~      ..:::--::--::-:..                            .:-:.. ~                   
                                    .:=:+=:.                            .:-:.         ~               
                      ~             .-:=-:--++-:.                    .=-.                 ~     
                             ~      .::--:::::::--=+=::....      ..--.. ~                        
                                    .:=--::::::--==:. ..:-::-:.:--.~        ~                        
                        ~           .:+--::::-=-:.          .....  ~                     ~                                
                             ~       :+=::-==:.    ~                     ~                           
                                     .==-+:                                                         
                                ~    .--.
            ";

            string Letter = @"
                  .-.---------------------------------.-.
                  ((o))                                   )
                   \U/_______          _____         ____/
                     |                                  |
                     |    come mit me                   |
                     |             kaslte gayte         |
                     |                                  |
                     |                                  |
                     |                                  |
                     |         imma kill u              |
                     |              uwu                 |
                     |                                  |
                     |                      -Henry      |
                     |                                  |
                     |____    _______    __  ____    ___|
                    /A\                                  \
                   ((o))                                  )
                    '-'----------------------------------'
            ";

            string BANG = @"
                .______        ___      .__   __.   _______  __  
                |   _  \      /   \     |  \ |  |  /  _____||  | 
                |  |_)  |    /  ^  \    |   \|  | |  |  __  |  | 
                |   _  <    /  /_\  \   |  . `  | |  | |_ | |  | 
                |  |_)  |  /  _____  \  |  |\   | |  |__| | |__| 
                |______/  /__/     \__\ |__| \__|  \______| (__) 
            ";

            string FAIL = @"
            __/\\\\\\\\\\\\\\\_____/\\\\\\\\\_____/\\\\\\\\\\\__/\\\_____________        
            _\/\\\///////////____/\\\\\\\\\\\\\__\/////\\\///__\/\\\_____________       
              _\/\\\______________/\\\/////////\\\_____\/\\\_____\/\\\_____________      
               _\/\\\\\\\\\\\_____\/\\\_______\/\\\_____\/\\\_____\/\\\_____________     
                _\/\\\///////______\/\\\\\\\\\\\\\\\_____\/\\\_____\/\\\_____________    
                 _\/\\\_____________\/\\\/////////\\\_____\/\\\_____\/\\\_____________   
                  _\/\\\_____________\/\\\_______\/\\\_____\/\\\_____\/\\\_____________  
                   _\/\\\_____________\/\\\_______\/\\\__/\\\\\\\\\\\_\/\\\\\\\\\\\\\\\_ 
                    _\///______________\///________\///__\///////////__\///////////////__       
            ";

            Console.SetCursorPosition(5, 3);
            for (int i = 0; i < Location1.Length; i++)
            {
                Console.Write(Location1[i]);
                Thread.Sleep(100);
            }
            Console.SetCursorPosition(10, 6);
            for (int i = 0; i < Description.Length; i++)
            {
                Console.Write(Description[i]);
                Thread.Sleep(55);
            }
            for (int i = 0; i < buffer.Length; i++)
            {
                Console.Write(buffer[i]);
                Thread.Sleep(75);
            }

            for (int i = 1; i <= 6; i++)
            {
                Console.Clear();
                Console.Write(PaperPlane1); Thread.Sleep(100);
                Console.Clear();
                Console.Write(PaperPlane2); Thread.Sleep(100);
            }

            Console.Clear();
            Console.SetCursorPosition(10, 6);
            for (int i = 0; i < DesCont1.Length; i++)
            {
                Console.Write(DesCont1[i]);
                Thread.Sleep(55);
            }

            Console.Clear();
            Console.Write(Letter); Console.ReadLine();

            Console.Clear();
            Console.SetCursorPosition(5, 3);
            for (int i = 0; i < Location1.Length; i++)
            {
                Console.Write(Location1[i]);
                Thread.Sleep(100);
            }
            Console.SetCursorPosition(10, 6);
            for (int i = 0; i < DesCont2.Length; i++)
            {
                Console.Write(DesCont2[i]);
                Thread.Sleep(55);
            }
            for (int i = 0; i < buffer.Length; i++)
            {
                Console.Write(buffer[i]);
                Thread.Sleep(75);
            }

            Console.Clear();
            Console.Write(BANG);
            Thread.Sleep(50);

            Console.Clear();
            Console.Clear();
            Console.SetCursorPosition(5, 3);
            Console.Write(Location1);
            Console.SetCursorPosition(10, 6);
            for (int i = 0; i < DesCont3.Length; i++)
            {
                Console.Write(DesCont3[i]);
                Thread.Sleep(85);
            }
            for (int i = 0; i < buffer.Length; i++)
            {
                Console.Write(buffer[i]);
                Thread.Sleep(75);
            }

            Label:

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red; Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(FAIL);
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(25, 12);
            Console.WriteLine("\tAdd some stat points to intelligence next time.");

            Console.WriteLine("\n\n\t\t\t{RETRY}\t\t\t\t{EXIT}");
            string UserAction = Console.ReadLine();

            string[] action = { "RETRY", "EXIT" };
            if (UserAction.ToUpper() == action[0] || UserAction.ToUpper() == "R") { CastleGate(); }
            else if (UserAction.ToUpper() == action[1] || UserAction.ToUpper() == "E") { Console.ReadLine(); }
            else { goto Label; }
        }
    }
}
