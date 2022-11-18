class Node<T> where T : struct
{
    private T value;
    private Node<T> next = null;

    public Node(T value)
    {
        this.SetValue(value);
    }

    public void SetNext(Node<T> next)
    {
        this.next = next;
    }

    public Node<T> Next()
    {
        return this.next;
    }

    public T GetValue()
    {
        return this.value;
    }

    public void SetValue(T value)
    {
        this.value = value;
    }
}
class Queue<T> where T : struct
{
    private Node<T> top = null;
    private int length = 0;

    public void Push(T value)
    {
        Node<T> node = new Node<T>(value);
        if(this.top == null)
        {
            this.top = node;
        }
        else
        {
            Node<T> lastNode = this.GetNode(this.length-1);
            lastNode.SetNext(node);
        }
        this.length++;
    }

    public T Pop()
    {
        Node<T> node = this.top;
        this.top = this.top.Next();
        this.length--;
        return node.GetValue();
    }

    public T Get(int index)
    {
        Node<T> ptr = this.GetNode(index);
        return ptr.GetValue();
    }

    public int GetLength()
    {
        return this.length;
    }

    private Node<T> GetNode(int index)
    {
        Node<T> ptr = this.top;
        while(index > 0)
        {
            ptr = ptr.Next();
            index--;
        }
        return ptr;
    }
}
class Program
{
     static void Main()
    {
        int Num_G = 0;
        char check_rose = 'b';
        Queue<char> queue1 = new Queue<char>();
        char flower = 'a';
        while(flower == 'J'|| flower =='G'|| flower == 'O'|| flower == 'R'|| flower == 'a')
        {
            
            flower = char.Parse(Console.ReadLine());
            
          if(flower == 'J' )
          { 
            
            if(check_rose == flower)
            {
                
                Console.WriteLine("Invalid pattern.");
                check_rose = 'J';
            }
            else 
            {
                queue1.Push(flower);
                check_rose ='b';
            }
          }
            
          if(flower == 'O' )
          { 
            
            if(check_rose == flower)
            {
                
                Console.WriteLine("Invalid pattern.");
                check_rose = 'O';
            }
            else 
            {
                queue1.Push(flower);
                check_rose = 'b';
            }
          }
             
            else if(flower == 'G')
            {
                if(check_rose == flower)
                {
                     Console.WriteLine("Invalid pattern.");  
                     check_rose = 'G';
                }
                
                else if(Num_G <=2)
                {
                    Num_G++;
                    queue1.Push(flower);
                    check_rose = 'b';
                    
                }
                else if(Num_G >2)
                { 
                    Console.WriteLine("Invalid pattern.");
                      
                }                
                
   
            }
            
            else if(flower == 'R')
            {   
               
                if(queue1.GetLength() == 0 )
                {
                   Console.WriteLine("Invalid pattern."); 
                }    
                
               
                else if(queue1.GetLength() >0 )
                {
                      queue1.Push(flower);
                      check_rose = queue1.Get(queue1.GetLength()-2);
           
                }
             
            }
     
        }
         for(int i =0; i< queue1.GetLength(); i++)
        {
            
            Console.Write("{0}",queue1.Get(i),queue1);
        }
    }
}