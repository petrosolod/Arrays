/*
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
//fraudulentOrderIDs[3] = "D000";

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
*/

// Також можна використовувати інший вид масивів, приводжу нижче приклад

string[] fraudulentOrderIDs = ["A123", "B456", "C789"];

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

// Якщо в першому варіанті ми вказували розмір масиву, то в другому варіанті ми вказуємо його елементи
// Якщо вказати розмір масиву, то масив буде містити порожні елементи, якщо вказати елементи,
// то масив буде містити тільки вказані елементи

// Далі у нас буде ітерація за допомогою циклу foreach (зрозуміти б це скоріше)

string[] names = { "Rowena", "Robin", "Bao" };
foreach (string name in names)
{
    Console.WriteLine(name);
}

// Цикл foreach використовується для ітерації по кожному елементу масиву,
// використовуючи тимчасову змінну, яку ви вказуєте в операторі foreach (у цьому випадку name).
// Це дозволяє вам виконувати дії з кожним елементом масиву, не вказуючи індекси.

int sum  = 0;
int[] inventory = [
    50,100,150,200,250,300
    ];
    foreach (int item in inventory) {

        if ( item > 10){
            sum += 1;
            // Подивимось скількі ітерацій пройде цикл
        }

        else if (item == 400) {
            Console.WriteLine($"Item found! That's {item}");
            break; 
            // Ця задумка з оператором if і break просто мій спосіб показати, 
            // що можна використовувати ці оператори в циклах
        }
        Console.WriteLine($"show me magic: {item}");
    }
Console.WriteLine($"Цикл пройшов {sum} ітерацій");
