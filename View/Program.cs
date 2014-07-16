using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Controller;

namespace View
{
    class MainClass
    {
        public static void Main()
        {

            /*LinkedList<string> myList = new LinkedList<string>();


            myList.Append(new Node<string>("microwave for ten seconds,"));

            myList.Prepend(new Node<string>("open the package,"));
            myList.Append(new Node<string>("Ramen Noodle Fun!"));
            myList.Append(new Node<string>("extra node"));
            myList.Append(new Node<string>("second extra node"));


            myList.Tail.Next = null;


            myList.Reset();
            myList.RemoveAt(3);


            myList.PrintList();

            myList.Reset();


            Console.ReadLine();

            LinkedList<Room> myDungeon = new LinkedList<Room>();
            myDungeon.Append(new Node<Room>(new Room()));
            
            myDungeon.Reset();
            myDungeon.Current.Value.RoomOneItems();
            myDungeon.Current.Value.RoomOneDes();
            
            
            myDungeon.Append(new Node<Room>(new Room()));
            myDungeon.Next();
            myDungeon.Current.Value.RoomTwoItems();
            myDungeon.Current.Value.RoomTwoDes();
            
            
            myDungeon.Append(new Node<Room>(new Room()));
            myDungeon.Next();
            myDungeon.Current.Value.RoomThreeItems();
            myDungeon.Current.Value.RoomThreeDes();
            
            myDungeon.Append(new Node<Room>(new Room()));
            myDungeon.Next();
            myDungeon.Current.Value.RoomTwoItems();
            myDungeon.Current.Value.RoomOneDes();
            
            
            myDungeon.Append(new Node<Room>(new Room()));
            myDungeon.Next();
            myDungeon.Current.Value.RoomOneItems();
            myDungeon.Current.Value.RoomTwoDes();
            
            
            myDungeon.Reset();
             */
            /*

                        int tics = 0;

                        for (Node<Room> Current = myDungeon.Head; Current != null; Current = Current.Next)
                        {
                            for (int i = 0; i < Current.Value.Items.Length; i++)
                            {
                                if (tics % 3 == 0){
                                    Console.Clear();
                                    Console.WriteLine(Current.Value.descript);
                                }

                                Console.WriteLine(Current.Value.Items[i]);
                                Console.ReadLine();
                                tics = tics + 1;
                            }

                        }*/



            /*ViewStuffs NewView = new ViewStuffs();
            Testy testicles = new Testy();




            while (1 == 1)
            {
                NewView.getCommand();
                testicles.move.ParseCommand.userCommandCont = NewView.userCommand;
                testicles.makinRooms(); 
                testicles.move.ParseCommand.addToArray();
                //ParseCommand.printLastCommand();
                testicles.move.goDir();
                Console.WriteLine("press any key...");
                Console.ReadLine();
                Console.Clear();
            }
*/
            ViewStuffs newView = new ViewStuffs();
            SomeVars someVars = new SomeVars();
            while (1 == 1)
            {



                newView.getCommand();
                
                ParseArray.addToArray(newView.userCommand, someVars.arrayListVar);
                ParseArray.StringComparer(someVars.arrayListVar, someVars.verbs, someVars.firstDungeon);
                Movement.goDir(someVars.arrayListVar, someVars.firstDungeon);
                Console.ReadLine();
            }
        }

    }



    public class ViewStuffs
    {
        public string userCommand;

        public void getCommand()
        {

            
            Console.WriteLine("what do you want to do?");
             userCommand = Console.ReadLine();
            userCommand = userCommand.ToUpper();
            

        }

    }
}
