using System;

class Program {
    static void SelectionSort(int[] arr) {
        for (int i = 0; i < arr.Length - 1; i++) {
            int minIndex = i;
            for (int j = i + 1; j < arr.Length; j++) {
                if (arr[j] < arr[minIndex]) {
                    minIndex = j;
                }
            }
            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }
    }

    static void Main() {
        Console.Write("Cuantos numeros vas a ingresar? ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        Console.WriteLine("Ingresa los " + n + " numeros:");
        for (int i = 0; i < n; i++)
            arr[i] = int.Parse(Console.ReadLine());

        SelectionSort(arr);

        Console.Write("Arreglo ordenado: ");
        foreach (int num in arr)
            Console.Write(num + " ");
    }
}
