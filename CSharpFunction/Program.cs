
int[] arrayDiNumeri = { 2, 6, 7, 5, 3, 9 };
Console.WriteLine("Gli elementi dell'Array sono:");
StampaArrayInteri(arrayDiNumeri);

int quadratoNumero = quadrato(2);
Console.WriteLine(quadratoNumero);


int[] arrayDiNumeriAlQuadrato = elevaArrayAlQuadrato(arrayDiNumeri);
Console.WriteLine("Gli elementi dell'Array elevati al quadrato sono:");
StampaArrayInteri(arrayDiNumeriAlQuadrato);

int sommaElementiArray = sommaArray(arrayDiNumeri);
Console.WriteLine("La somma degli elementi dell'Array originale è:");
Console.WriteLine(sommaElementiArray);

int sommaQuadratoElementiArray = sommaQuadratiElementiArray(arrayDiNumeri);
Console.WriteLine("La somma dei quadrati degli elementi dell'Array  è:");
Console.WriteLine(sommaQuadratoElementiArray);





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
int [] elevaArrayAlQuadrato(int[] array)
{
    int[] copiaArray = (int[])array.Clone();
    for (int i = 0; i < copiaArray.Length; i++)
    {
        copiaArray[i] = quadrato(copiaArray[i]);
    }
    return copiaArray;
}
//

//
int sommaArray(int[] array)
{
    int sommaArray = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sommaArray += array[i];
    }
    return sommaArray;
}
//

int sommaQuadratiElementiArray(int[] array)
{
    int[] copiaArray = (int[])array.Clone();
    int[]arrayElevato = elevaArrayAlQuadrato(copiaArray);
    
    int sommaElementiArray = sommaArray(arrayElevato);
    return  sommaElementiArray;
}