
int[] arrayDiNumeri = { 2, 6, 7, 5, 3, 9 };
StampaArrayInteri(arrayDiNumeri);

int quadratoNumero = quadrato(2);
Console.WriteLine(quadratoNumero);


int[] arrayDiNumeriAlQuadrato = elevaArrayAlQuadrato(arrayDiNumeri);
StampaArrayInteri(arrayDiNumeriAlQuadrato);








// --------------- DICHIARAZIONE DELLE FUNZIONI ------------------------
// Creo una funzione che stampa in console un array di interi
void StampaArrayInteri(int[] arrayInteri)
{
    Console.Write("[");

    for (int i = 0; i < arrayInteri.Length; i++)
    {
        if (i == arrayInteri.Length - 1)
        {
            Console.Write(arrayInteri[i]);
        }
        else
        {
            Console.Write(arrayInteri[i] + ", ");
        }
    }

    Console.WriteLine("]");
}
//



//
int quadrato(int numero)
{
    int quadrato = numero * numero;
    return quadrato;
}
//







//
int elevaArrayAlQuadrato(int[] array)
{
    int[] copiaArray = (int[])array.Clone();
    for (int i = 0; i < copiaArray.Length; i++)
    {
        copiaArray[i] = copiaArray[i] * copiaArray[i];
    }
    return copiaArray;
}
//