﻿
int[] arrayDiNumeri = { 2, 6, 7, 5, 3, 9 };
StampaArrayInteri(arrayDiNumeri);












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
