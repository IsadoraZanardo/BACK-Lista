Character c1 = new Character("Mel");
Character c2 = new Character("Luna");

do
{
    //LIMPARA TELA E INICIAR RODADA
    Console.Clear();
    Console.WriteLine("Nova rodada!\n");

    //ATAQUES
    try
    {
        c1.Attack(c2); //c1 atacar c2
        c2.Attack(c1); //c2 atacar c1
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }

    //RESULTADOS
    Console.WriteLine(c1);
    Console.WriteLine(c2);

    //TRAVAR A TELA
    //fazer com que o usuário precise DIGITAR para ir para a próxima rodada
    Console.WriteLine("Pressione ENTER para continuar");
    Console.ReadLine(); //procura até a quebra de linha, ou seja, a tecla enter

    } while (c1.IsAlive && c2.IsAlive);

if (c1.IsAlive)
    Console.WriteLine($"Parabéns, {c1.Name}! Você ganhou!");

if (c2.IsAlive)
    Console.WriteLine($"Parabéns, {c2.Name}! Você ganhou!");