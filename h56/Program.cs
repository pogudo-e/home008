int m = 4;
int n = 4;

int[,] array = new int[m,n];

for(int i = 0; i < m; i++){
    for(int j = 0; j < n; j++){
        array[i,j] = new Random().Next(0, 10);
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine("");
}

void Por(int[,] array){
    int retur = 40;
    int str = 0;
    for(int i = 0; i < m; i++){
       int ans = 0; 
        for(int j = 0; j < n; j++){
            ans += array[i,j];
        }
        if (ans < retur){
           retur = ans;
           str = i+1;
        }
    }
    Console.WriteLine($"{str} строка имеет наименьшую сумму элементов");

}

Por(array);