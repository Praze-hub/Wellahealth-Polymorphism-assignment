using System;

namespace Poly
{
    class Animal{
       public string animalName;
       public string animalGender;
       public int animalAge;


        public virtual void animalSound(){
            Console.WriteLine("This aniaml makes a sound");
        }
    }

    class Dog:Animal{
      
        public  override void animalSound(){
            Console.WriteLine("The dog barks");
        }
    }
    class Frog:Animal{

        public  override void animalSound(){
            Console.WriteLine("The frog crocs");
        }
    }
    class Cat:Animal{
       
        public  override void animalSound(){
            Console.WriteLine("The cat meews");
        }
    }
    class Kitten:Animal{
      
        public  override void animalSound(){
            Console.WriteLine("The kitten makes a sound");
        }
    }
    class Tomcat:Animal{
      
        public  override void animalSound(){
            Console.WriteLine("The tomcat makes a sound");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
     

        Dog myDog = new Dog();
        myDog.animalName = "rita";
        myDog.animalGender = "Female";
        myDog.animalAge = 12;


        Frog myFrog = new Frog();
        myFrog.animalName = "dani";
        myFrog.animalGender = "Male";
        myFrog.animalAge = 10;


        Cat myCat = new Cat();
        myCat.animalName = "gad";
        myCat.animalGender = "male";
        myCat.animalAge = 3;

        Kitten myKitten = new Kitten();
        myKitten.animalName = "tag";
        myKitten.animalGender = "Female";
        myKitten.animalAge = 11;


        Tomcat myTomcat = new Tomcat();
        myTomcat.animalName = "animalGenderrita";
        myTomcat.animalGender = "Female";
        myTomcat.animalAge = 12;
       

          Console.Write("Enter animal:");
          string animal = Console.ReadLine();
          string[] Zoo = {"Dog","Frog","Cat","Kitten","Tomcat"} ;
          foreach(string animals in Zoo){
              if(animal == "Dog"){
                  Console.WriteLine(myDog.animalName);
                  Console.WriteLine(myDog.animalGender);
                  Console.WriteLine(myDog.animalAge);

                  myDog.animalSound();
                  
              }else if(animal == "Frog"){
                  Console.WriteLine(myFrog.animalName);
                  Console.WriteLine(myFrog.animalGender);
                  Console.WriteLine(myFrog.animalAge);
                  myFrog.animalSound();
              
              }else if(animal == "Cat"){
                  Console.WriteLine(myCat.animalName);
                  Console.WriteLine(myCat.animalGender);
                  Console.WriteLine(myCat.animalAge);
                  myCat.animalSound();
              
              }else if(animal == "Kitten"){
                  Console.WriteLine(myKitten.animalName);
                  Console.WriteLine(myKitten.animalGender);
                  Console.WriteLine(myKitten.animalAge);
                  myKitten.animalSound();
              
              }else if(animal == "Tomcat"){
                  Console.WriteLine(myKitten.animalName);
                  Console.WriteLine(myKitten.animalGender);
                  Console.WriteLine(myKitten.animalAge);
                  myTomcat.animalSound();
              }else{
                  Console.WriteLine("This animal does not exist");
              }
              
          }

           
        }
    }
}
