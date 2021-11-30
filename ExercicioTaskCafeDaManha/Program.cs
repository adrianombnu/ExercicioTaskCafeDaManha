using System;
using System.Threading;
using System.Threading.Tasks;

namespace ExercicioTaskCafeDaManha
{
    internal class Program
    {

        public static async Task Main(string[] args)
        {
            /*Dessa forma, como os metódos estão como async e não estou usando await para aguardar, o programa vai finalizar antes de todos os metódos serem executados
            Task task1 = new Task(() => PrepararOvo());
            Task task2 = new Task(() => AquecerFrigideira());
            Task task3 = new Task(() => FritarOvo());
            Task task4 = new Task(() => PrepararHamburguer());
            Task task5 = new Task(() => FritarHamburguer());
            Task task6 = new Task(() => PassarManteiga());
            Task task7 = new Task(() => AdicionarOvo());
            Task task8 = new Task(() => AdicionarHamburguer());
            Task task9 = new Task(() => PrepararCafe());
            Task task10 = new Task(() => FerverAgua());
            Task task11 = new Task(() => PassarCafe());
            Task task12 = new Task(() => ServirCafe());
            Task task13 = new Task(() => ServirLanche());

            task1.Start();
            task2.Start();
            task3.Start();
            task4.Start();
            task5.Start();
            task6.Start();
            task7.Start();
            task8.Start();
            task9.Start();
            task10.Start();
            task11.Start();
            task12.Start();
            task13.Start();
            

            task1.Wait();
            task2.Wait();
            task3.Wait();
            task4.Wait();
            task5.Wait();
            task6.Wait();
            task7.Wait();
            task8.Wait();
            task9.Wait();
            task10.Wait();
            task11.Wait();
            task12.Wait();
            task13.Wait();
            */

            /*
            Console.WriteLine("Iniciando primeiro exemplo");

            //Executando vários metódos sem o uso do await ele finalizado o programa antes de terminar de executar todos os métodos
            PrepararOvo();
            AquecerFrigideira();
            FritarOvo();
            PrepararHamburguer();
            FritarHamburguer();
            PassarManteiga();
            AdicionarOvo();
            AdicionarHamburguer();
            PrepararCafe();
            FerverAgua();
            PassarCafe();
            ServirCafe();
            ServirLanche();


            Console.WriteLine("Iniciando segundo exemplo");

            */
            
            //Executando vários metódos com uso do await
            await PrepararOvo();
            await AquecerFrigideira();
            await FritarOvo();
            await PrepararHamburguer();
            await FritarHamburguer();
            await PassarManteiga();
            await AdicionarOvo();
            await AdicionarHamburguer();
            await PrepararCafe();
            await FerverAgua();
            await PassarCafe();
            await ServirCafe();
            await ServirLanche();

            Console.WriteLine("Iniciando terceiro exemplo");
            
            /*
            //Executa um grupo de tasks em ordem e aguarda até que todas sejam executadas para dar continuidade a execução do código
            var task = new Task[13];
            task[0] = PrepararOvo();
            task[1] = AquecerFrigideira();
            task[2] = FritarOvo();
            task[3] = PrepararHamburguer();
            task[4] = FritarHamburguer();
            task[5] = PassarManteiga();
            task[6] = AdicionarOvo();
            task[7] = AdicionarHamburguer();
            task[8] = PrepararCafe();
            task[9] = FerverAgua();
            task[10] = PassarCafe();
            task[11] = ServirCafe();
            task[12] = ServirLanche();

            Task.WaitAll(task);
            */
        }

        public static async Task PrepararOvo()
        {
            await Task.Delay(2000);
            Console.WriteLine("Preparando o ovo...");
        }

        public static async Task AquecerFrigideira()
        {
            Console.WriteLine("Aquecendo a frigideira");
        }
        public static async Task FritarOvo()
        {
            await Task.Delay(1000);
            Console.WriteLine("Fritando o ovo");
        }

        public static async Task PrepararHamburguer()
        {
            await Task.Delay(3000);
            Console.WriteLine("Preparando o hamburguer...");
        }

        public static async Task FritarHamburguer()
        {
            Console.WriteLine("Fritando o hamburguer");
        }

        public static async Task PrepararPao()
        {
            Console.WriteLine("Preparando o pao...");
        }

        public static async Task PassarManteiga()
        {
            Console.WriteLine("Passando a manteiga");
        }

        public static async Task AdicionarOvo()
        {
            Console.WriteLine("Adicionando o ovo");
        }

        public static async Task AdicionarHamburguer()
        {
            Console.WriteLine("Adicionando o hamburguer");
        }

        public static async Task PrepararCafe()
        {
            Console.WriteLine("Preparando o café...");
        }

        public static async Task FerverAgua()
        {
            Console.WriteLine("Ferver a água");
        }

        public static async Task PassarCafe()
        {
            Console.WriteLine("Passando o café");
        }

        public static async Task ServirCafe()
        {
            Console.WriteLine("Servindo o café...");
        }

        public static async Task ServirLanche()
        {
            Console.WriteLine("Servindo o lanche...");
        }



    }
}
