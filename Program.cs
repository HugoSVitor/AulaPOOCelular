using System;

namespace AulaPOOCelular
{
    class Program
    {
        static int selecaoContato;
        static void Main(string[] args)
        {
            Celular celular1 = new Celular();
            celular1.cor = "Azulão";
            celular1.modelo = "Redmi Note 9";
            celular1.tamanho = 6.53f;
            celular1.ligado = false;

            Console.WriteLine("Você deseja ligar o celular? Ligar = 1  Não Ligar = 2");
            int opcaoLigarCelular = int.Parse(Console.ReadLine());

            do
            {
                if (opcaoLigarCelular == 1)
                {
                    celular1.Ligar();

                    Console.WriteLine(@"
                    __________________________
                    |                        |
                    |                        |
                    |    1- Fazer Ligação    |                 
                    |                        |
                    |                        |
                    |                        |
                    |   2- Enviar Mensagem   |
                    |                        |
                    |                        |
                    |                        |
                    | 3- Mostrar informações |
                    |                        |
                    |                        |
                    |                        |
                    |      4- Desligar       |
                    |                        |
                    |________________________|
                    
                    ");
                    int opcoesCelular = int.Parse(Console.ReadLine());

                    switch (opcoesCelular)
                    {
                        case 1:
                            Console.WriteLine(celular1.FazerLigacao());
                            MostrarLigacao();

                            break;
                        case 2:
                            Console.WriteLine(celular1.EnviarMensagem());
                            MostrarMensagens();
                            break;
                        case 3:
                            Console.WriteLine($"O modelo de seu celular é um {celular1.modelo} , sua cor é {celular1.cor}, com uma tela de {celular1.tamanho} polegadas!");
                            break;
                        case 4:
                            MostrarDesligando();
                            celular1.Desligar();
                            break;
                        default:
                            break;
                    }


                }
                else if (opcaoLigarCelular == 2)
                {
                    celular1.Desligar();
                }
            } while (celular1.ligado);
        }

        static void MostrarLigacao()
        {
            selecaoContato = int.Parse(Console.ReadLine());
            if (selecaoContato == 1)
            {
                Console.WriteLine(@"
                    __________________________
                    |                        |
                    |    Fazendo ligação     |
                    |________________________|                 
                    |                        |
                    |                        |
                    |        Contato:        |
                    |                        |
                    |                        |
                    |        Ordilei:        |
                    |    (11) 98989-2984     |
                    |                        |
                    |                        |
                    |       Chamando...      |
                    |                        |
                    |                        |
                    |                        |
                    |________________________|
                    
                    ");
            }
            else if (selecaoContato == 2)
            {
                Console.WriteLine(@"
                    __________________________
                    |                        |
                    |    Fazendo ligação     |
                    |________________________|                 
                    |                        |
                    |                        |
                    |        Contato:        |
                    |                        |
                    |                        |
                    |     Fernanda SENAI:    |
                    |    (11) 95869-7845     |
                    |                        |
                    |                        |
                    |       Chamando...      |
                    |                        |
                    |                        |
                    |                        |
                    |________________________|
                    
                    ");
            }
            else if (selecaoContato == 3)
            {
                Console.WriteLine(@"
                    __________________________
                    |                        |
                    |    Fazendo ligação     |
                    |________________________|                 
                    |                        |
                    |                        |
                    |        Contato:        |
                    |                        |
                    |                        |
                    |       Sara Gois:       |
                    |    (11) 94397-3783     |
                    |                        |
                    |                        |
                    |       Chamando...      |
                    |                        |
                    |                        |
                    |                        |
                    |________________________|
                    
                    ");
            }
        }

        static void MostrarMensagens()
        {
            selecaoContato = int.Parse(Console.ReadLine());
            if (selecaoContato == 1)
            {
                Console.WriteLine(@"
                    __________________________
                    |                        |
                    |    Fazendo ligação     |
                    |________________________|                 
                    |                        |
                    |                        |
                    |        Contato:        |
                    |                        |
                    |                        |
                    |        Ordilei:        |
                    |    (11) 98989-2984     |
                    |                        |
                    |                        |
                    |   Escreva a Mensagem   |
                    |                        |
                    |                        |
                    |                        |
                    |________________________|
                    
                    ");
                string mensagem = Console.ReadLine();  
                Console.WriteLine("Mensagem enviada!"); 
            }
            else if (selecaoContato == 2)
            {
                Console.WriteLine(@"
                    __________________________
                    |                        |
                    |    Fazendo ligação     |
                    |________________________|                 
                    |                        |
                    |                        |
                    |        Contato:        |
                    |                        |
                    |                        |
                    |     Fernanda SENAI:    |
                    |    (11) 95869-7845     |
                    |                        |
                    |                        |
                    |   Escreva a Mensagem   |
                    |                        |
                    |                        |
                    |                        |
                    |________________________|
                    
                    ");
                string mensagem = Console.ReadLine();  
                Console.WriteLine("Mensagem enviada!");
            }
            else if (selecaoContato == 3)
            {
                Console.WriteLine(@"
                    __________________________
                    |                        |
                    |    Fazendo ligação     |
                    |________________________|                 
                    |                        |
                    |                        |
                    |        Contato:        |
                    |                        |
                    |                        |
                    |       Sara Gois:       |
                    |    (11) 94397-3783     |
                    |                        |
                    |                        |
                    |   Escreva a Mensagem   |
                    |                        |
                    |                        |
                    |                        |
                    |________________________|
                    
                    ");
                string mensagem = Console.ReadLine();  
                Console.WriteLine("Mensagem enviada!");
            }
        }

        static void MostrarDesligando()
        {
            Console.WriteLine(@"
                    _________________________
                    |______|        |       |
                    |      |________|       |
                    |  D            |       |                 
                    |    E          |_______|
                    |      S                |
                    |        L              |
                    |          I            |
                    |            G          |
                    |____          A        |
                    |    |           N      |
                    |    |             D    |
                    |    |_______        O  |
                    |    |     |      ______|
                    |____|     |______|     |
                    |    |        |         |
                    |    |        |         |
                    |____|________|_________|
                    
                    ");
        }
    }
}
