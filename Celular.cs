using System;

namespace AulaPOOCelular
{
    public class Celular
    {
        static int selecaoContato;
        public string cor;
        public string modelo;
        public float tamanho;
        public bool ligado;

        public bool Ligar()
        {
            ligado = true;

            return ligado;
        }
        public bool Desligar()
        {
            ligado = false;

            return ligado;
        }

        public void FazerLigacao()
        {
            Console.WriteLine( @"
            
                    __________________________
                    |                        |
                    |     Fazer Ligação      |
                    |                        |                 
                    |------------------------|
                    |       Contatos:        |
                    |                        |
                    |      1- Ordilei:       |
                    |    (11) 98989-2984     |
                    |                        |
                    |    2- Fernanda SENAI   |
                    |    (11) 95869-7845     |
                    |                        |
                    |      3- Sara Gois      |
                    |    (11) 94397-3783     |
                    |                        |
                    |   Escolha um contato   |
                    |________________________|
                    
                ");
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
                    |       Discando...      |
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
                    |       Discando...      |
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
                    |       Discando...      |
                    |                        |
                    |                        |
                    |                        |
                    |________________________|
                    
                    ");
            }    
                
        }

        public void EnviarMensagem()
        {
            Console.WriteLine(  @"
            
                    __________________________
                    |                        |
                    |    Enviar Mensagem     |
                    |                        |                 
                    |------------------------|
                    |       Contatos:        |
                    |                        |
                    |      1- Ordilei:       |
                    |    (11) 98989-2984     |
                    |                        |
                    |    2- Fernanda SENAI   |
                    |    (11) 95869-7845     |
                    |                        |
                    |      3- Sara Gois      |
                    |    (11) 94397-3783     |
                    |                        |
                    |   Escolha um contato   |
                    |________________________|
                    
                ");
            selecaoContato = int.Parse(Console.ReadLine());
            if (selecaoContato == 1)
            {
                Console.WriteLine(@"
                    __________________________
                    |                        |
                    |    Enviar Mensagem     |
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
                    |    Enviar Mensagem     |
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
                    |    Enviar Mensagem     |
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
    }
}