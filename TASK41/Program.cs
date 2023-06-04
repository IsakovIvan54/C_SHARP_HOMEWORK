// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4

Console.Write("Введите колчество чисел: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[N];

//int count_req = 0; // cчетчик введенных чисел
int count_unsig = 0; // cчетчик чисел больше нуля

for(int i = 0; i < N; i++){
    Console.Write("Введите число: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
  //  count_req++;
    if(arr[i] > 0){
        count_unsig++;
    }
}

Console.Write($"Количество чисел больше нуля {count_unsig}"); 

