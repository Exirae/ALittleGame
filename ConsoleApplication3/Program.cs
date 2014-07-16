using System;

namespace LinkyWinky
{
    class MainClass
    {
        public static void Main ()
        {

            LinkedList myList = new LinkedList();

            
            
            myList.Append(new Node("microwave for ten seconds,"));

            myList.Prepend(new Node("open the package,"));
            myList.Append(new Node("Ramen Noodle Fun!"));


            myList.Tail.Next = null;
            

            Node current = null;

            for (myList.Reset(); myList.Current != null; myList.Next()) 
            { 
                Console.WriteLine(myList.Current.Value); 


            }
            Console.ReadLine();
         }

    }

    public class LinkedList {
        public Node Head; 
        public Node Tail;

        public LinkedList(string text) : this(new Node(text)) { }

        public LinkedList()
        {
            this.Head = this.currentNode = this.Tail = null;
        }

        
        public LinkedList(Node head) {
            this.Head = this.Tail = this.currentNode = head;
            head.Previous = head.Next = null;
        }


        public Node Current { get {return currentNode; } }
        private Node currentNode;
        public void Next() 
        {
            //if list is empty of at end dont move
            if(currentNode != null){
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

        public void Reset(){
            this.currentNode = this.Head;
        }

        public void Prepend(Node atStart){

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

        public void Append(Node atEnd){

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
        // And Append, and Remove, and RemoveAt
    }

    public class Node {
        public string Value;
        public Node Next;
        public Node Previous;
        public Node(string value){
            this.Value = value;
            this.Next = this.Previous = null;
        }
    }
}
