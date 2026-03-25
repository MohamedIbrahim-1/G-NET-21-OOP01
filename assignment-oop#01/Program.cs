namespace assignment_oop_01;
public static class Program{
    static void Main(string[] args){

        #region Question-part1-01
        //Explain with code example how class and struct behave differently
        /*
          class : 
             - Stored on the heap
             - Supports inheritance
             - Assigned by reference 
             - reference type
             - Copies the reference
             - null by default
             - complex data type (more than 4 fields)

          Struct :
             - Stored on the stack 
             - no Supports inheritance 
             - small data type (2-4 fields)
             - short lived
             - value type
             - Copies the data
             - default construvtor      
             - not null if nalable
        */

        //------------------------Code----------------------------

        /* 

         PointClass pointClass1 = new PointClass { X=260 };
         PointClass pointClassnow = pointClass1 ;
         pointClassnow.X = 10;

         Console.WriteLine(pointClass1.X);

         PointStract pointStruct = new PointStract { Y = 50 };
         PointStract pointStructnow = pointStruct;
         pointStructnow.Y = 20;

         Console.WriteLine(pointStruct.Y);
         Console.WriteLine(pointStructnow.Y);

         */

        #endregion

        #region Question-part1-02
        // Explain the difference between public and private access modifiers with an example

        /*
            public : can be accessed from anywhere in the code
            private : can only be accessed within the class or struct it is declared in
        */

        //Animals animals = new Animals();

        //animals.
        //No fields can be called here because their type is private.


        //Console.WriteLine(animals.soundd);
        //Here, a function of type public can be called.

        #endregion

        #region Question-part1-03+04
        // Describe the steps to create and use a class library in Visual Studio.
        // What is a class library? Why do we use class libraries?
        /*
            what the class library?
            create project next to now project 
        */

        /*
        
        Its benefit: Instead of creating multiple classes,
        it creates a class library for similar classes and copies it as needed,
        instead of creating a new class each time.

        */

        /*
        Construction steps : 
            1- Right-click on Solution
            2- click Add
            3- click new project
            4- Type:class library 
        */

        #endregion

    }
}