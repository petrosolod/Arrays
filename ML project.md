<!-- Наразі це дуже складний для мене проект, навіть враховуючи що я дуще щільно його закоментував
Важко зрозуміти вкладений цикл, і складно вільно бачити та відчувати змінні які всюди
переходжу до наступного самостійного завдання, спадіваюсь що коли я буду все робити сам, стане зрозуміліше -->

int examAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

// для того щоб в подальшому на основі імені студента присвоїти іншій змінній оцінку студента,
// я використовую масиви для оцінок кожного студента, а також масив для імен студентів
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] studentScores = new int[10]; // тут я ініціалізую масив для оцінок поточного студента

string currentStudentLetterGrade = ""; // тут я ініціалізую змінну для літерної оцінки поточного студента

Console.WriteLine("Student\t\tGrade\n"); // тут я виводжу заголовок звіту "Student Grade" на консоль

foreach (string name in studentNames) // тут я починаю цикл по іменах студентів (стр 11)
{                                     // для того щоб прив'язати оцінки до окремого студента
    string currentStudent = name; // тут я присвоюю поточному студенту ім'я з масиву імен студентів

    if (currentStudent == "Sophia") // тут я перевіряю, чи поточний студент - Софія
        studentScores = sophiaScores; // якщо студента звати Софія то я присвоюю оцінки Софіі як поточні оцінки

    else if (currentStudent == "Andrew") // тут я перевіряю, чи поточний студент - Ендрю
        studentScores = andrewScores; // якщо студента звати Андрю то я присвоюю оцінки Андрю як поточні оцінки

    else if (currentStudent == "Emma") // тут я перевіряю, чи поточний студент - Емма
        studentScores = emmaScores; // якщо студента звати Емма то я присвоюю оцінки Еммі як поточні оцінки

    else if (currentStudent == "Logan") // тут я перевіряю, чи поточний студент - Логан
        studentScores = loganScores; // якщо студента звати Логант то я присвоюю оцінки Логана як поточні оцінки

    
    int sumAssignmentScores = 0; // тут я створюю змінну для суми оцінок студента

    decimal currentStudentGrade = 0; // тут я створюю змінну для середньої оцінки студента

    int gradedAssignments = 0; 
    // тут я ініціалізую лічильник кількості завдань, для точного обчислення середньої оцінки

    // тут я починаю цикл по оцінках поточного студента
    foreach (int score in studentScores) 
    {
        gradedAssignments += 1; // тут я збільшую лічильник завдань

        if (gradedAssignments <= examAssignments) 
            // тут я перевіряю, чи кількість завдань не перевищує кількість екзаменаційних завдань
            sumAssignmentScores += score; // тут я додаю оцінку за екзамен до суми

        else
            // тут я додаю бонусні бали до суми - бонусні бали дорівнюють 10% від оцінки за екзамен
            sumAssignmentScores += score / 10; 
    }

    currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments; 
    // тут я обчислюю середню оцінку студента

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+"; 

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A"; 

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-"; 

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+"; 

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B"; 

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-"; 

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+"; 

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C"; 

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-"; 

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+"; 

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D"; 

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-"; 

    else
        currentStudentLetterGrade = "F"; 

    //Console.WriteLine("Student\t\tGrade\tLetter Grade\n");
    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}"); 
    // тут я виводжу ім'я студента, середню оцінку та літерну оцінку
}

Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine(); // тут я чекаю на натискання клавіші Enter для продовження
