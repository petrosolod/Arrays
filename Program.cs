/* 
This C# console application is designed to:
- Use arrays to store student names and assignment scores.
- Use a `foreach` statement to iterate through the student names as an outer program loop.
- Use an `if` statement within the outer loop to identify the current student name and access that student's assignment scores.
- Use a `foreach` statement within the outer loop to iterate though the assignment scores array and sum the values.
- Use an algorithm within the outer loop to calculate the average exam score for each student.
- Use an `if-elseif-else` construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.
- Integrate extra credit scores when calculating the student's final score and letter grade as follows:
    - detects extra credit assignments based on the number of elements in the student's scores array.
    - divides the values of extra credit assignments by 10 before adding extra credit scores to the sum of exam scores.
- use the following report format to report student grades: 

Student         Exam Score      Overall Grade   Extra Credit

Sophia          92.2            95.88   A       92 (3.68 pts)

*/
int examAssignments = 5;

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

// display the header row for scores/grades
Console.Clear(); // тут я очищую консоль
Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n"); // тут я виводжу заголовок звіту на консоль

/*
The outer foreach loop is used to:
- iterate through student names 
- assign a student's grades to the studentScores array
- calculate exam and extra credit sums (inner foreach loop)
- calculate numeric and letter grade
- write the score report information
*/
foreach (string name in studentNames) // тут я починаю зовнішній цикл по іменах студентів
{
    string currentStudent = name; // тут я встановлюю поточного студента

    if (currentStudent == "Sophia") // тут я перевіряю, чи поточний студент - Софія
        studentScores = sophiaScores; // тут я встановлюю оцінки Софії як поточні оцінки

    else if (currentStudent == "Andrew") // тут я перевіряю, чи поточний студент - Ендрю
        studentScores = andrewScores; // тут я встановлюю оцінки Ендрю як поточні оцінки

    else if (currentStudent == "Emma") // тут я перевіряю, чи поточний студент - Емма
        studentScores = emmaScores; // тут я встановлюю оцінки Емми як поточні оцінки

    else if (currentStudent == "Logan") // тут я перевіряю, чи поточний студент - Логан
        studentScores = loganScores; // тут я встановлюю оцінки Логана як поточні оцінки

    int gradedAssignments = 0; // тут я ініціалізую лічильник кількості завдань
    int gradedExtraCreditAssignments = 0; // тут я ініціалізую лічильник кількості додаткових завдань

    int sumExamScores = 0; // тут я ініціалізую суму оцінок за екзамени
    int sumExtraCreditScores = 0; // тут я ініціалізую суму додаткових оцінок

    decimal currentStudentGrade = 0; // тут я ініціалізую середню оцінку поточного студента
    decimal currentStudentExamScore = 0; // тут я ініціалізую середню оцінку за екзамени поточного студента
    decimal currentStudentExtraCreditScore = 0; // тут я ініціалізую середню оцінку за додаткові завдання поточного студента

    /* 
    the inner foreach loop: 
    - sums the exam and extra credit scores
    - counts the extra credit assignments
    */
    foreach (int score in studentScores) // тут я починаю внутрішній цикл по оцінках поточного студента
    {
        gradedAssignments += 1; // тут я збільшую лічильник завдань

        if (gradedAssignments <= examAssignments) // тут я перевіряю, чи кількість завдань не перевищує кількість екзаменаційних завдань
        {
            sumExamScores = sumExamScores + score; // тут я додаю оцінку за екзамен до суми екзаменаційних оцінок
        }

        else
        {
            gradedExtraCreditAssignments += 1; // тут я збільшую лічильник додаткових завдань
            sumExtraCreditScores += score; // тут я додаю оцінку за додаткове завдання до суми додаткових оцінок
        }
    }

    currentStudentExamScore = (decimal)(sumExamScores) / examAssignments; // тут я обчислюю середню оцінку за екзамени поточного студента
    currentStudentExtraCreditScore = (decimal)(sumExtraCreditScores) / gradedExtraCreditAssignments; // тут я обчислюю середню оцінку за додаткові завдання поточного студента

    currentStudentGrade = (decimal)((decimal)sumExamScores + ((decimal)sumExtraCreditScores / 10)) / examAssignments; // тут я обчислюю загальну середню оцінку поточного студента

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+"; // тут я встановлюю літерну оцінку "A+" для середньої оцінки >= 97

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A"; // тут я встановлюю літерну оцінку "A" для середньої оцінки >= 93

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-"; // тут я встановлюю літерну оцінку "A-" для середньої оцінки >= 90

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+"; // тут я встановлюю літерну оцінку "B+" для середньої оцінки >= 87

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B"; // тут я встановлюю літерну оцінку "B" для середньої оцінки >= 83

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-"; // тут я встановлюю літерну оцінку "B-" для середньої оцінки >= 80

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+"; // тут я встановлюю літерну оцінку "C+" для середньої оцінки >= 77

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C"; // тут я встановлюю літерну оцінку "C" для середньої оцінки >= 73

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-"; // тут я встановлюю літерну оцінку "C-" для середньої оцінки >= 70

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+"; // тут я встановлюю літерну оцінку "D+" для середньої оцінки >= 67

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D"; // тут я встановлюю літерну оцінку "D" для середньої оцінки >= 63

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-"; // тут я встановлюю літерну оцінку "D-" для середньої оцінки >= 60

    else
        currentStudentLetterGrade = "F"; // тут я встановлюю літерну оцінку "F" для середньої оцінки < 60

    // Student         Exam Score      Overall Grade   Extra Credit
    // Sophia          92.2            95.88   A       92 (3.68 pts)

    Console.WriteLine($"{currentStudent}\t\t{currentStudentExamScore}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}\t{currentStudentExtraCreditScore} ({(((decimal)sumExtraCreditScores / 10) / examAssignments)} pts)"); // тут я виводжу ім'я студента, середню оцінку за екзамени, загальну середню оцінку, літерну оцінку та середню оцінку за додаткові завдання
}

// required for running in VS Code (keeps the Output windows open to view results)
Console.WriteLine("\n\rPress the Enter key to continue"); // тут я виводжу повідомлення для продовження
Console.ReadLine(); // тут я чекаю на натискання клавіші Enter для продовження
