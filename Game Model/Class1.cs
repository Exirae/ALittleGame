using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Game_Model
{
       public class LinkList<T>
    {
        public Node<T> Head;
        public Node<T> Tail;

        public LinkList(T valueOf) : this(new Node<T>(valueOf)) { }

        public LinkList()
        {
            this.Head = this.currentNode = this.Tail = null;
        }


        public LinkList(Node<T> head)
        {
            this.Head = this.Tail = this.currentNode = head;
            head.Previous = head.Next = null;
        }


        public Node<T> Current { get { return currentNode; } }
        private Node<T> currentNode;
        public void Next()
        {
            //if list is empty of at end dont move
            if (currentNode != null)
            {
                currentNode = Current.Next;
            }


        }
        public void Previous()
        {
            if (currentNode != null)
            {
                currentNode = currentNode.Previous;
            }
        }

        public void Reset()
        {
            this.currentNode = this.Head;
        }

        public void Prepend(Node<T> atStart)
        {

            if (Head == null)
            {
                Head = Tail = currentNode = atStart;
            }
            else
            {
                Head.Previous = atStart;
                atStart.Next = Head;
                atStart.Previous = null;
                Head = atStart;
            }

        }

        public void Append(Node<T> atEnd)
        {

            if (Tail == null)
            {
                Head = Tail = currentNode = atEnd;
            }
            else
            {
                Tail.Next = atEnd;
                atEnd.Previous = Tail;
                atEnd.Next = null;
                Tail = atEnd;
            }


        }


        public void Remove(Node<T> toRemove)
        {
            Node<T> temp = toRemove;
            
            if (toRemove != null)
            {
                if (Head != Tail)
                {
                    if (toRemove == Head)
                    {
                        toRemove = toRemove.Next;
                        Head = toRemove;
                        toRemove.Previous = null;
                    }

                    else if (toRemove == Tail)
                    {
                        toRemove = toRemove.Previous;
                        Tail = toRemove;
                        toRemove.Next = null;
                    }

                    else
                    {

                        toRemove.Next.Previous = toRemove.Previous;
                        toRemove.Previous.Next = toRemove.Next;
                        Reset();


                    }
                }

                else
                {
                    toRemove = Head = Tail = null;
                    Console.WriteLine("head = tail");
                }
            }

            else
            {
                Console.WriteLine("current node is null");
            }
        }



        public void RemoveAt(int nodeNumber)
        {
            int startNode;

            Reset();

            for (startNode = 0; startNode != nodeNumber; ++startNode)
            {
                Next();
            }

            Remove(currentNode);

        }




        public void PrintList()
        {
            for (Reset(); Current != null; Next())
            {
                Console.WriteLine(Current.Value);


            }
        }
    }



    // And Append, and Remove, and RemoveAt


    public class Node<T>
    {
        public T Value;
        public Node<T> Next;
        public Node<T> Previous;
        public Node(T value)
        {
            this.Value = value;
            this.Next = this.Previous = null;
        }
    }

    public class Room
    {
        public int stringNum;
        int itemIndex;
        public string descript;
        public string description;
        public ArrayList itemsRoom = new ArrayList();
        public Items Stuff = new Items();
        public ItemOperations doStuff = new ItemOperations();
        ArrayList priItemsRoom = new ArrayList();


        public Room()
        {
            description = (descript);
            ArrayList itemsRoom = new ArrayList();

        }

        public void addItemsToRoom()
        {

            itemIndex = 0;

            priItemsRoom.Add(doStuff.ItemListPublic[itemIndex]);
            itemsRoom = priItemsRoom;


        }

            public void printItems()
            {
                foreach (Items i in itemsRoom)
                {
                    Console.WriteLine("you see a {0} on the floor", i.itemName);
                }
            }
        





    }

    public class Items
    {
        public string itemName;
        public int itemNum;

    }
    
    public class ItemOperations
    {
        
        public ArrayList ItemListPublic = new ArrayList();
        Items potion = new Items();
        Items treasureChest = new Items();
        

        
        
        
        
        public void addToItemList()
        {
            ArrayList ItemList = new ArrayList();
            ItemList.Add(potion);
            potion.itemName = ("potion");
            potion.itemNum = 1;


            ItemList.Add(treasureChest);
            treasureChest.itemName = ("chest");
            ItemListPublic = ItemList;
            treasureChest.itemNum = 2;

        }

    }

    public class Character
    {
        public string name;
        public ArrayList inventory;
    }



    public class DungeonRooms<T>
    {
        public RoomNode<T> Head;
        public RoomNode<T> Current { get { return currentNode; } }
        private RoomNode<T> currentNode;

        public DungeonRooms(T valueOf) : this(new RoomNode<T>(valueOf)) { }

        public DungeonRooms()
        {
            this.Head = this.currentNode = null;
        }


        public DungeonRooms(RoomNode<T> head)
        {
            this.Head = this.currentNode = head;
            head.North = head.South = head.East = head.West = null;
        }



        
        
        public void NextNorth()
        {
            //if list is empty of at end dont move
            if (currentNode != null)
            {
                currentNode = currentNode.North;
            }
        }

        public void NextSouth()
        {
            //if list is empty of at end dont move
            if (currentNode != null)
            {
                currentNode = currentNode.South;
            }
        }

        public void NextWest()
        {
            //if list is empty of at end dont move
            if (currentNode != null)
            {
                currentNode = currentNode.West;
            }
        }

        public void NextEast()
        {
            //if list is empty of at end dont move
            if (currentNode != null)
            {
                currentNode = currentNode.East;
            }
        }


        public void Reset()
        {
            this.currentNode = this.Head;
        }

        public void AddRoomNorth (RoomNode<T> newRoom)
        {

                Current.North = newRoom;
                newRoom.South = Current;
            

        }

        public void AddRoomSouth(RoomNode<T> newRoom)
        {

                Current.South = newRoom;
                newRoom.North = Current;
        }

        public void AddRoomEast(RoomNode<T> newRoom)
        {

            Current.East = newRoom;
            newRoom.West = Current;
        }

        public void AddRoomWest(RoomNode<T> newRoom)
        {

            Current.West = newRoom;
            newRoom.East = Current;
        }

        public void AddCross(RoomNode<T> newRoom)
        {
            if(Current.North == null){
                AddRoomNorth(newRoom);

            }

            if (Current.South == null)
            {
                AddRoomSouth(newRoom);
            }

            if (Current.East == null)
            {
                AddRoomEast(newRoom);
            }

            if (Current.West == null)
            {
                AddRoomWest(newRoom);
            }
        }

    }


    public class RoomNode<T>
    {
        public T Value;
        public RoomNode<T> North;
        public RoomNode<T> South;
        public RoomNode<T> East;
        public RoomNode<T> West;
        public RoomNode(T value)
        {
            this.Value = value;
            this.North = this.South = this.East = this.West = null;
        }
    }


      


        
    



}

