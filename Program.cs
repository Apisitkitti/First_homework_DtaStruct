
using System;
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
        DataPrint(queue1);
         
    }
    static void DataPrint(Queue<char> queue1)
    {
        for(int i =0; i< queue1.GetLength(); i++)
        {
            
            Console.Write("{0}",queue1.Get(i),queue1);
        }
    }
}