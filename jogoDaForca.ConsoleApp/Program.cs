/*
    # REQUISITOS
    1. Ao iniciar o jogo, deve ser selecionada uma palavra aleatória à partir de uma lista.
    2. O jogador poderá chutar a palavra secreta letra por letra, cada letra certa deverá ser apresentada,
    assim como as letras erradas.
    3. O jogador poderá cometer até cinco erros, caso erre pela quinta vez, ou acerte a palavra a partida
    acaba.
    4. Deve-se apresentar um desenho da forca sendo atualizado a cada erro.
*/

using System.Security.Cryptography;

string[] palavras = [
    "ABACATE",
    "ABACAXI",
    "ACEROLA",
    "ACAI",
    "ARACA",
    "BACABA",
    "BACURI",
    "BANANA",
    "CAJA",
    "CAJU",
    "CARAMBOLA",
    "CUPUACU",
    "GRAVIOLA",
    "GOIABA",
    "JABUTICABA",
    "JENIPAPO",
    "MACA",
    "MANGABA",
    "MANGA",
    "MARACUJA",
    "MURICI",
    "PEQUI",
    "PITANGA",
    "PITAYA",
    "SAPOTI",
    "TANGERINA",
    "UMBU",
    "UVA",
    "UVAIA"
];

int indiceAleatorio = RandomNumberGenerator.GetInt32(palavras.Length);
string palavraSecreta = palavras[indiceAleatorio];

char[] letrasCorretas = new char[palavraSecreta.Length];

//for inicial que mostra em tela apenas o -
for (int contadorLetras = 0; contadorLetras < palavraSecreta.Length; contadorLetras++)
{
    letrasCorretas[contadorLetras] = '_';
    //Console.Write(letrasCorretas[contadorLetras]);
}

int contadorErros = 0;

bool jogadorAcertou = false;
bool jogadorPerdeu = false;

// entrando no loop 
while (true) // ! valor de negação
{
    Console.Clear();

    Console.WriteLine("#####################################");
    Console.WriteLine("##        JOGO DA FORCA            ##");
    Console.WriteLine("#####################################");
    Console.WriteLine($"Erros cometidos: {contadorErros} erros.");
    Console.Write($"Chutes: ");

        // laço para percorrer os espaços do array da palavra secreta
    for (int contadorLetras = 0; contadorLetras < palavraSecreta.Length; contadorLetras++)
    {
        //letrasCorretas[contadorLetras] = '_';
        Console.Write(letrasCorretas[contadorLetras]);
    }

    Console.WriteLine("\n-------------------------------------");
    if (contadorErros == 0)
    {
        Console.WriteLine(@" ___________        ");
        Console.WriteLine(@" |/        |        ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@"_|____              ");    
    } else if (contadorErros == 1)
    {
        Console.WriteLine(@" ___________        ");
        Console.WriteLine(@" |/        |        ");
        Console.WriteLine(@" |         o        ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@"_|____              ");    
    } else if (contadorErros == 2)
    {
        Console.WriteLine(@" ___________        ");
        Console.WriteLine(@" |/        |        ");
        Console.WriteLine(@" |         o        ");
        Console.WriteLine(@" |         |        ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@"_|____              ");    
    } else if (contadorErros == 3)
    {
        Console.WriteLine(@" ___________        ");
        Console.WriteLine(@" |/        |        ");
        Console.WriteLine(@" |         o        ");
        Console.WriteLine(@" |        /|        ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@"_|____              ");    
    }else if (contadorErros == 4)
    {
        Console.WriteLine(@" ___________        ");
        Console.WriteLine(@" |/        |        ");
        Console.WriteLine(@" |         o        ");
        Console.WriteLine(@" |        /|\       ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@"_|____              ");    
    }
    else if (contadorErros == 5)
    {
        Console.WriteLine(@" ___________        ");
        Console.WriteLine(@" |/        |        ");
        Console.WriteLine(@" |         o        ");
        Console.WriteLine(@" |        /|\       ");
        Console.WriteLine(@" |        /         ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@"_|____              ");    
    }
     else if (contadorErros == 6)
    {
        Console.WriteLine(@" ___________        ");
        Console.WriteLine(@" |/        |        ");
        Console.WriteLine(@" |         |        ");
        Console.WriteLine(@" |         o        ");
        Console.WriteLine(@" |        /|\       ");
        Console.WriteLine(@" |        / \       ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@"_|____              ");    
    }

    Console.WriteLine("-------------------------------------");

    if (jogadorAcertou)
    {
        Console.WriteLine("Parabéns, você acertou a palavra!");
        Console.WriteLine($"A palavra era {palavraSecreta}");
        break;
    }
    else if(jogadorPerdeu)
    {
        Console.WriteLine("Que pena, você usou todas as suas tentativas!");

        break;
    }



    Console.Write("\n\nDigite uma letra: ");
    //recebendo e guardando o caractere na variavel
    char chute = Convert.ToChar(Console.ReadLine());

    
    bool letraFoiEncontrada = false;

    for (int contadorPalavraSecreta = 0; contadorPalavraSecreta < palavraSecreta.Length; contadorPalavraSecreta++)
    {
        char letraSecretaAtual = palavraSecreta[contadorPalavraSecreta];
        
        if  (chute == letraSecretaAtual)
        {   
            letrasCorretas[contadorPalavraSecreta] = chute;
            letraFoiEncontrada = true;
        }
    }

    if (!letraFoiEncontrada)
    {
        contadorErros++;
    }

    // mudando a condição de vitoria
    string letrasCorretasCompletas = string.Join("", letrasCorretas);

    if (palavraSecreta == letrasCorretasCompletas)
    {

        jogadorAcertou = true;
    }

    if (contadorErros > 5)
    {
        jogadorPerdeu = true;
    }

}

Console.WriteLine("\nClique ENTER para sair...");
Console.ReadLine();
