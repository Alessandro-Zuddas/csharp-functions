
//Una volta completate queste funzioni di utilità di base, e dato il seguente array di numeri [2, 6, 7, 5, 3, 9] già dichiarato nel vostro codice, 
//si vogliono utilizzare le funzioni per:

int[] numbers = {2, 6, 7, 5, 3, 9};

Console.WriteLine("-Stampare l’array di numeri fornito a video.");
StampaArray(numbers);

Console.WriteLine("-Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato."); //(Verificare che l’array originale non sia stato modificato quindi ristampare nuovamente l’array originale e verificare che sia rimasto [2, 6, 7, 5, 3, 9])
var arrayElevato = ElevaArrayAlQuadrato(numbers); 
StampaArray(arrayElevato);
Console.WriteLine();

Console.WriteLine("-Stampare la somma di tutti i numeri.");
Console.WriteLine(sommaElementiArray(numbers));
Console.WriteLine();

Console.WriteLine("-Stampare la somma di tutti i numeri elevati al quadrato.");
var arrayElevato2 = ElevaArrayAlQuadrato(numbers);
var arraySommato = sommaElementiArray(arrayElevato2);
Console.WriteLine(arraySommato);


/*--------------------------------------------------------------FUNZIONI----------------------------------------------------------------------------------------*/

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
    int[] secondArray = (int[])array.Clone();

    for (int i = 0; i < secondArray.Length; i++)
    {
        secondArray[i] = Quadrato(secondArray[i]);
    }

    return secondArray;
}

int sommaElementiArray(int[] array)
{
    int somma = 0;

    for (int i = 0; i < array.Length; i++)
    {
        somma = somma + array[i];
    }

    return somma;
}