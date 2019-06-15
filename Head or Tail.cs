static void Main(string[] args)
        {
            

            while ( true )
            {
                int N = int.Parse(Console.ReadLine());
                if (N == 0)
                {
                    break;
                }

                string[] numeros = Console.ReadLine().Split(' ');

                List<int> lista = new List<int>();
                for (int i = 0; i < N; i++)
                {
                    lista.Add(int.Parse(numeros[i]));
                }

                int unos = 0, ceros = 0;
                for (int i = 0; i < N; i++)
                {
                    if (lista[i] == 1)
                        unos++;

                    else
                        ceros++;

                }
                Console.WriteLine("Mary won {0} times and John won {1} times", ceros, unos);

            }

            //Console.ReadLine();

        }
