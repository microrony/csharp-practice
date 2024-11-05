﻿using System;

int examAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

Console.WriteLine("Student\t\tGrade\n");

foreach (string name in studentNames)
{
  string currentName = name;

  if (currentName == "Sophia")
  {
    studentScores = sophiaScores;
  }
  else if (currentName == "Andrew")
  {
    studentScores = andrewScores;
  }
  else if (currentName == "Emma")
  {
    studentScores = emmaScores;
  }
  else if (currentName == "Logan")
  {
    studentScores = loganScores;
  }

  int sumAssignmentsScores = 0;

  decimal currentStudentGrade;

  int gradeAssignments = 0;

  foreach (int score in studentScores)
  {
    gradeAssignments++;

    if (gradeAssignments <= examAssignments)
    {
      sumAssignmentsScores += score;
    }
    else
    {
      sumAssignmentsScores += score / 10;
    }
  }

  currentStudentGrade = (decimal)sumAssignmentsScores / examAssignments;

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

  Console.WriteLine($"{currentName}:\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
