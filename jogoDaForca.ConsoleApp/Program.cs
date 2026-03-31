/*
    # REQUISITOS
    1. Ao iniciar o jogo, deve ser selecionada uma palavra aleatória à partir de uma lista.
    2. O jogador poderá chutar a palavra secreta letra por letra, cada letra certa deverá ser apresentada,
    assim como as letras erradas.
    3. O jogador poderá cometer até cinco erros, caso erre pela quinta vez, ou acerte a palavra a partida
    acaba.
    4. Deve-se apresentar um desenho da forca sendo atualizado a cada erro.
*/

string palavraSecreta = "ABACATE";

char[] letrasCorretas = new char[7];

//for inicial que mostra em tela apenas o -
for (int contadorLetras = 0; contadorLetras < 7; contadorLetras++)
{
    letrasCorretas[contadorLetras] = '_';
    //Console.Write(letrasCorretas[contadorLetras]);
}

bool jogadorAcertou = false;

// entrando no loop 
while (!jogadorAcertou) // ! valor de negação
{
    Console.Clear();

    // laço para percorrer os espaços do array da palavra secreta
    for (int contadorLetras = 0; contadorLetras < 7; contadorLetras++)
    {
        //letrasCorretas[contadorLetras] = '_';
        Console.Write(letrasCorretas[contadorLetras]);
    }

    Console.Write("\n\nDigite uma letra: ");
    //recebendo e guardando o caractere na variavel
    char chute = Convert.ToChar(Console.ReadLine());

    
    for (int contadorPalavraSecreta = 0; contadorPalavraSecreta < palavraSecreta.Length; contadorPalavraSecreta++)
    {
        char letraSecretaAtual = palavraSecreta[contadorPalavraSecreta];
        
        if  (chute == letraSecretaAtual)
        {
            letrasCorretas[contadorPalavraSecreta] = chute;
        }
    }

    // mudando a condição de vitoria
    string letrasCorretasCompletas = string.Join("", letrasCorretas);

    if (palavraSecreta == letrasCorretasCompletas)
    {
        jogadorAcertou = true;
        Console.WriteLine("Parabéns, você acertou a palavra!");
        Console.WriteLine($"A palavra era {palavraSecreta}");
    }

}

Console.WriteLine("\nClique ENTER para sair...");
Console.ReadLine();
