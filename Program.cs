//Задание1
void Numb(int m, int n){
    if (m > n){
        return ;
    }    
    Console.Write($"{m}, ");
    Numb(m + 1, n );
}
Console.Write("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());
Numb(m , n);

//Задание 2
int Akkerman(int m, int n){
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return Akkerman(m - 1, 1);
    if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
    return Akkerman(m, n);
}
Console.Write("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());
Akkerman(m , n);
Console.Write($"Функция Аккермана равно {Akkerman(m, n)} ");

//Задание 3
void Print(int [] N, int i){
    if (i > 0){
        Console.Write(N[i] + " "); 
      	Print(N, i - 1);
    }
    else Console.Write(N[0]);
}
int [] num = {1, 2, 5, 0, 10, 34}; 
Print(num, num.Length - 1);
