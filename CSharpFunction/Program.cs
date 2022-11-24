//PROGRAMMA PRINCIPALE-------------------------------------------------------------------------------------------------
Console.WriteLine("TASK1");
Console.WriteLine("");

int[] arrayDiNumeri = { 2, 6, 7, 5, 3, 9 };
Console.WriteLine("Gli elementi dell'Array originale sono:");
StampaArrayInteri(arrayDiNumeri);

Console.WriteLine("_______________________________________________________________________");

Console.WriteLine("TASK2");
Console.WriteLine("");
int[] arrayDiNumeriAlQuadrato = elevaArrayAlQuadrato(arrayDiNumeri);
Console.WriteLine("Gli elementi dell'Array elevati al quadrato sono:");
StampaArrayInteri(arrayDiNumeriAlQuadrato);

Console.WriteLine("");

Console.WriteLine("Gli elementi dell'Array originale sono rimasti:");
StampaArrayInteri(arrayDiNumeri);

Console.WriteLine("_______________________________________________________________________");

Console.WriteLine("TASK3");
Console.WriteLine("");

int sommaElementiArray = sommaArray(arrayDiNumeri);
Console.WriteLine("La somma degli elementi dell'Array originale è:");
Console.WriteLine(sommaElementiArray);

Console.WriteLine("_______________________________________________________________________");

Console.WriteLine("TASK4");
Console.WriteLine("");

int sommaQuadratoElementiArray = sommaQuadratiElementiArray(arrayDiNumeri);
Console.WriteLine("La somma dei quadrati degli elementi dell'Array  è:");
Console.WriteLine(sommaQuadratoElementiArray);
Console.WriteLine("");

Console.WriteLine("_______________________________________________________________________");
//---------------------------------------------------------------------------------------------------------------------




// --------------- DICHIARAZIONE DELLE FUNZIONI -----------------------------------------------------------------------
// Creo una funzione che stampa in console un array di interi.
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

// Creo una funzione che stampa il quadrato di un numero dato. 
int quadrato(int numero)
{
    int quadrato = numero * numero;
    return quadrato;
}
//

// Creo una funzione che calcola il quadrato di ogni elemento dell'Array.
int[] elevaArrayAlQuadrato(int[] array)
{
    int[] copiaArray = (int[])array.Clone();
    for (int i = 0; i < copiaArray.Length; i++)
    {
        copiaArray[i] = quadrato(copiaArray[i]);
    }
    return copiaArray;
}
//

// Creo una funzione che somma gli elementi di un Array.
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

//Creo una funzione che somma i quadrati degli elementi dell'Array.
int sommaQuadratiElementiArray(int[] array)
{
    int[] copiaArray = (int[])array.Clone();
    int[] arrayElevato = elevaArrayAlQuadrato(copiaArray);

    int sommaElementiArray = sommaArray(arrayElevato);
    return sommaElementiArray;
}
//---------------------------------------------------------------------------------------------------------------------