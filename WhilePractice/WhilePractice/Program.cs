/*

int counter = 0;                          //while ile ekrana 10 kere ben bu yazılım işini yaparım yazdıran program. 

while(counter < 10)
{
    Console.WriteLine("Ben bu yazılım işini yaparım");
    counter++;

}

 */

/*

int counter = 1;                           //1 den 20 ye kadar olan sayıları ekrana yazdıran while döngüsü

while (counter <= 20)
{
    Console.WriteLine(counter);
    counter++;

}

*/

/*

int counter = 1;                        //while döngüsü ile 1 ila 20 arasındaki çift sayıları ekrana yazdırma. 

while (counter <= 20) 
{
    if (counter % 2 == 0)
    {
        Console.WriteLine(counter);

    }
    
    counter++;
}

 */

/*

int i = 50 , sum = 0;                       //50 ile 150 arasındaki sayıların toplamını while döngüsü ile ekrana yazdırma. 

while(i <= 150)
{
    sum += i;
    i++;

}
Console.WriteLine($"50 ile 150 arasındaki sayıların toplamı {sum} dur");

*/

int oddNum = 0;                 //1 ile 120 arasındaki tek ve çift sayıların toplamını ayrı ayrı yazdıran program.
int evenNum = 0;
int i = 0;


while  (i <= 120)
{
    if (i % 2 == 0) 
    {
        evenNum += i;
        i++;

    }
    else
    {
        oddNum += i;
        i++;

    }
    
}
Console.WriteLine($"Tek sayıların toplamı {oddNum}");
Console.WriteLine($"Çift sayıların toplamı {evenNum}");