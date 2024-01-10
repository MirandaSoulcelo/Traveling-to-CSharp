// Fazendo uma matriz[4, 4] que aceita a entrada do Usuário para preenchimento de dados.

string[,] matriz = new string[4,4];
int x, y;

for(x = 0; x < 4; x++)
{
    for(y = 0; y < 4; y++)
    {
       matriz[x, y] = (Console.ReadLine());
      
    }   
}
Console.WriteLine();

for(x = 0; x < 4; x++)
{
    for(y = 0; y < 4; y++)
    {
        
        Console.Write(matriz[x, y] + "   ");
        
    }
    Console.WriteLine();
}

Console.ReadKey();