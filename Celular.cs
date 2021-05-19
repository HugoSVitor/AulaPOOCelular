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

        public string FazerLigacao()
        {
            string contatos = @"
            
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
                    
                ";

            return contatos;
        }

        public string EnviarMensagem()
        {
            string mensagemEnviada = @"
            
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
                    
                ";

            return mensagemEnviada;
        }
    }
}