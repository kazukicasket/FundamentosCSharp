namespace FundamentosCSharp;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Digite o seu nome: ");
        string nomeUsuario = Console.ReadLine();
        Console.Write("Agora digite o seu sobrenome: ");
        string sobrenomeUsuario = Console.ReadLine();

        Console.WriteLine("Olá " + nomeUsuario + " " + sobrenomeUsuario + "! Seja muito bem-vindo!");
        Console.WriteLine("Digite o primeiro número: ");
        string primeiroNumero = Console.ReadLine();
        double num1 = Convert.ToDouble(primeiroNumero);
        Console.WriteLine("Digite o segundo número: ");
        string segundoNumero = Console.ReadLine();
        double num2 = Convert.ToDouble(segundoNumero);

        var matematica = new operacoesMatematicas();

        Console.WriteLine($"A soma entre os dois números é: {matematica.Adicao(num1, num2)}");
        Console.WriteLine($"A subtração entre os dois números é: {matematica.Subtrair(num1, num2)}");
        Console.WriteLine($"A multiplicação entre os dois números é: {matematica.Multiplicar(num1, num2)}");

        if (num2 != 0)
        {
            Console.WriteLine($"A divisão entre os dois números é: {matematica.Dividir(num1, num2)}");
        } else
        {
            Console.WriteLine("O denominador é zero!");
        }

        Console.WriteLine($"A média entre os dois números é: {matematica.Adicao(num1, num2) / 2}");
        
        Console.Write("Digite uma ou mais palavras separadas por um espaço: ");
        string palavraOriginal = Console.ReadLine();
        int contador = 0;
        string palavraModificada = "";
        
        foreach (char character in (palavraOriginal + " "))
        {
            if (character != ' ')
            {
                palavraModificada += character;
                contador++;
            } else
            {
                Console.WriteLine($"A palavra {palavraModificada} tem {contador} caracteres.");
                palavraModificada = "";
                contador = 0;
            }
        }
        
        Console.Write("Digite a placa do veículo: ");
        string placaCarro = Console.ReadLine().ToUpper();
        bool placaValida = true;

        if (placaCarro.Length == 7)
        {            
            for (int i = 0; i < 3; i++)
            {
                if (placaCarro[i] < 'A' || placaCarro[i] > 'Z')
                {
                    placaValida = false;
                    break;
                }
            }

            int tempNum = 0;
            string tempString = "";

            for (int i = 3; i < 7; i++) tempString += placaCarro[i];

            if (!int.TryParse(tempString, out tempNum)) placaValida = false;

            if (placaValida)
            {
                Console.WriteLine("Verdadeiro");
            } else
            {
                Console.WriteLine("Falso");
            }
        } else
        {
            Console.WriteLine("Falso");
        }
        
        Console.Write("Digite a data atual (ano, mês, dia, hora, minuto, segundo): ");
        string dataAtual = Console.ReadLine();
        List<int> data = new List<int>();
        string tempData = "";
        
        foreach (char caractere in (dataAtual + ' '))
        {
            if (caractere != ' ')
            {
                tempData += caractere;
            } else
            {
                data.Add(Convert.ToInt32(tempData));
                tempData = "";
            }
        }

        DateTime dataCompleta = new DateTime(data[0], data[1], data[2], data[3], data[4], data[5]);

        Console.WriteLine("Data completa: " + dataCompleta.ToString("F"));
        Console.WriteLine("Data padrão: " + dataCompleta.ToString("d"));
        Console.WriteLine("Hora: " + dataCompleta.ToString("HH:mm:ss"));
        Console.WriteLine("Data: " + dataCompleta.ToString("dd MMMM yyyy"));
    }
}