using System.Diagnostics;

namespace ProjectCreator
{

    class Program
    {
        static async Task Main(string[] _)
        {

            Console.WriteLine("Enter Type:  ");
            Console.WriteLine("React | Next | Spring");

            var Project = Console.ReadLine();
            if (Project == null) return;


            if (Project.Equals("React"))
            {
                Thread.Sleep(1000);

                Process.Start("cmd.exe", "npx nano-react-app myapp");
                await DB.DB.GetDB("npx nano-react-app myapp");
            }

            if (Project.Equals("Next"))
            {

                Thread.Sleep(1000);
                Process.Start("cmd.exe","npx npx create-next-app myapp");
                await DB.DB.GetDB("npx npx create-next-app myapp");
            }

            if (Project.Equals("Spring"))
            {

                Thread.Sleep(1000);
                Process.Start("cmd.exe", "spring init --dependencies=web,data-jpa myproject");
                await DB.DB.GetDB("spring init --dependencies=web,data-jpa myproject");
            }

        }

    }
    
}