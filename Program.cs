
void StampaArray(int[] array)
{
    Console.WriteLine(arrayToString(array));
}

string arrayToString(int[] array)
{
    var result = "[";

    for (int i = 0; i < array.Length; i++)
    {
        result += array[i].ToString();

        if (i < array.Length - 1)
        {
            result += ", ";
        }
    }

    result += "]";

    return result;
}

int Quadrato(int numero)
{
    return numero * numero;
}

int[] ElevaArrayAlQuadrato(int[] array)
{
    //preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato.
    //Attenzione: è importante restituire un nuovo array, e non modificare l’array come parametro della funzione! 
    //Vi ricordate perchè? Pensateci (vedi slide)
    return null;
}

int sommaElementiArray(int[] array)
{
    //preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.
    return 0;
}