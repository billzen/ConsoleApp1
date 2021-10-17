using System;
using System.IO;
using System.Threading.Tasks;

public class Example
{
    public static void Main()
    { 

        Task[] tasks = new Task[2];
        String[] files = null;
        String[] dirs = null;
        String docsDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        tasks[0] = Task.Factory.StartNew(() => files = Directory.GetFiles(docsDirectory));
        tasks[1] = Task.Factory.StartNew(() => dirs = Directory.GetDirectories(docsDirectory));

        Task.Factory.ContinueWhenAll(tasks, completedTasks => {
            Console.WriteLine("{0} contains: ", docsDirectory);
            Console.WriteLine("   {0} subdirectories", dirs.Length);
            Console.WriteLine("   {0} files", files.Length);
        })
       // from server 2 message
        // 3 message from server
       // new change from new Branch 2    
       Console.ReadLine();
       Console.ReadLine();


        //1. Local change 11/09/2021 10:28
        //2. Server change 11/09/2021 10:32
        //3. Local change 11/09/2021  10:35
        //4. Local change 11/09/2021  10:45 frpm master2
        //5. Local change 11/09/2021  11:16 from master

        Console.ReadLine();

    }
  
      public void Remootetest1() 
    {
        Console.ReadLine();
    }
    
    public void REmotetest2() 
    {
        Console.ReadLine();
    }
}

