using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Model;



namespace Game_Controller
{
    public class ClassObjects
    {
        public ClassObjects classObjects = new ClassObjects();


    }

    public static class ParseArray
    {




        //splits user input into words and saves them individually in an array

        public static void addToArray(string userCommandCont, List<string> commandList)
        {
            char[] delimiter = { ' ' };
            string[] words = userCommandCont.Split(delimiter);



            //string[] words = userCommandCont.Split(delimiter);
            foreach (string s in words)
            {
                commandList.Add(s);
            }

        }

        public static void StringComparer(List<string> lastCommand, string[] verbs, DungeonRooms<Room> myDungeon)
        {


            bool verbCompare = true;
            int whichVerb = 0;
            
            foreach (string s in verbs)
            {
                verbCompare = lastCommand[0].Equals(s);

                    if (verbCompare == true)
                    {

                        break;
                    }
                        
                whichVerb = whichVerb + 1;

            }
            if (verbCompare == true)
            {
                Console.WriteLine("{0}", verbs.GetValue(whichVerb));

                if (whichVerb == 0)
                {
                    List<string> Foo = new List<string>();
                    Foo = lastCommand;
                    
                    Movement.goDir(Foo, myDungeon);
                }
                
                if (whichVerb == 1)
                {

                }
            }
            else
            {
                Console.WriteLine("huh?");
            }

            whichVerb = 0;
            

        }






    }


    
    
    public static class Movement
    {


        public static void goDir(List<string> lastCommand, DungeonRooms<Room> myDungeon)
        {
        
            int lcIndexCount = lastCommand.Count;
            myDungeon.AddRoomNorth(new RoomNode<Room>(new Room()));
            myDungeon.NextNorth();
            myDungeon.AddCross(new RoomNode<Room>(new Room()));
            myDungeon.Current.Value.doStuff.addToItemList();
            myDungeon.Current.Value.addItemsToRoom();

            ItemOperations testItems = new ItemOperations();
            myDungeon.Current.Value.printItems();
                
                    if (lcIndexCount >= 2 && lastCommand[1].Equals ("NORTH") )
                    {
                        Console.WriteLine("you go {0}", lastCommand[1]);
                        Console.WriteLine();
                        lastCommand.Clear();

                        myDungeon.NextNorth();
                        myDungeon.AddCross(new RoomNode<Room>(new Room()));

                        Console.WriteLine(myDungeon.Current.Value.descript);
                    }

                    else if (lcIndexCount >= 2 && lastCommand[1].Equals("SOUTH"))
                    {
                        Console.WriteLine("you go {0}", lastCommand[1]);
                        Console.WriteLine();
                        lastCommand.Clear();

                        myDungeon.NextSouth();
                        myDungeon.AddCross(new RoomNode<Room>(new Room()));

                        Console.WriteLine(myDungeon.Current.Value.descript);
                    }

                    else if (lcIndexCount >= 2 && lastCommand[1].Equals("East"))
                    {
                        Console.WriteLine("you go {0}", lastCommand[1]);
                        Console.WriteLine();
                        lastCommand.Clear();

                        myDungeon.NextEast();
                        myDungeon.AddCross(new RoomNode<Room>(new Room()));

                        Console.WriteLine(myDungeon.Current.Value.descript);
                    }

                    else if (lcIndexCount >= 2 && lastCommand[1].Equals("West"))
                    {
                        Console.WriteLine("you go {0}", lastCommand[1]);
                        Console.WriteLine();
                        lastCommand.Clear();

                        myDungeon.NextWest();
                        myDungeon.AddCross(new RoomNode<Room>(new Room()));

                        Console.WriteLine(myDungeon.Current.Value.descript);
                    }


                    else
                    {
                        Console.WriteLine("you walk into a wall!");
                    }
                
        }

    }

        public class SomeVars
    {
            public List<string> arrayListVar = new List<string>();
            
            public DungeonRooms<Room> firstDungeon = new DungeonRooms<Room>();
            public string[] verbs = new string[10] { "GO", "GET", "TAKE", "PUT", "DROP", "PUSH", "PULL", "OPEN", "CLOSE", "UNLOCK" };

    }
    
    public class getCommand
    {
        

    }



/*    public class Testy
    {

        public void makinRooms(Movement c)
        {

            c.movingRooms.Append(new Node<Room>(new Room()));

            c.movingRooms.Reset();

        }
    }*/
}
