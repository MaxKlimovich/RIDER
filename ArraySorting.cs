// int[] arr = { 13, 25, 38, 54, 15, 26, 76, 84, 92 };
//
// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//
//     Console.WriteLine();
// }
//
// void SelectionSort(int[] arr)
// {
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         int minPosition = i;
//         for (int j = i + 1; j < arr.Length; j++)
//         {
//             if (arr[j] < arr[minPosition])
//             {
//                 minPosition = j;
//             }
//         }
//
//         int temp = arr[i];
//         arr[i] = arr[minPosition];
//         arr[minPosition] = temp;
//     }
// }
//
// PrintArray(arr);
// SelectionSort(arr);
// PrintArray(arr);