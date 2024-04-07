namespace Arrays;

internal class Program
{
    static void Main(string[] args)
    {
        const int SizeArray = 4;

        int[] firstArray = new int[SizeArray];
        int[] secondArray = new int[SizeArray];
        int[] thirdArray = new int[SizeArray * 2];


        // Affectaction de valeurs au deux tableau : 
        for (int i = 0; i < SizeArray; i++)
        {
            firstArray[i] = (i + 1) * 2;
            secondArray[i] = (i + 1) * 4;
        }

        // Affectation des valeurs du premier tableaux sur le troisieme : 
        for (int i = 0; i < SizeArray; i++)
            thirdArray[i] = firstArray[i];

        // Affectation des valeurs du second tableaux sur le troisieme : 
        for (int i = 0; i < SizeArray; i++)
            thirdArray[i + SizeArray] = secondArray[i];

        // Affichage des valeurs du troisieme tableau : 
        for (int i = 0; i < SizeArray * 2; i++)
            Console.WriteLine(thirdArray[i]);
    }
}
