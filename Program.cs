using System;
using System.Collections.Generic;

namespace StudentExercise
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("STIZZUDENTS!");
      List<Student> studentsList = new List<Student>();
      List<Exercise> exercisesList = new List<Exercise>();

      Exercise nutshell = new Exercise("nutshell", "react");
      Exercise holidayroad = new Exercise("holiday road", "javascript");
      Exercise planner = new Exercise("urban planner", "C#");
      Exercise fitted = new Exercise("fitted", "html");

      Cohort cohort36 = new Cohort("Cohort 36");
      Cohort cohort37 = new Cohort("Cohort 37");
      Cohort cohort38 = new Cohort("Cohort 38");

      Student willy = new Student("Willy", "Metcalf", "sw3k", "Cohort 37");
      Student audrey = new Student("Audrey", "Borgra", "audbor", "Cohort 37");
      Student kevin = new Student("Kevin", "Kevinson", "kev.dev", "Cohort 37");
      Student james = new Student("James", "Nitz", "nitzle", "Cohort 37");

      Instructor rose = new Instructor("rose", "roseington", "roseallday", "cohort 37", "fashion");
      Instructor chortle = new Instructor("Steve", "Brownlee", "chortlehoort", "cohort 37", "dad jokes");
      Instructor mo = new Instructor("mo", "money", "momo", "cohort 37", "making cheesecake");

      cohort37.addStudent(willy);
      cohort37.addStudent(audrey);
      cohort37.addStudent(kevin);
      cohort37.addStudent(james);
      cohort37.addInstructor(rose);
      cohort37.addInstructor(chortle);
      cohort37.addInstructor(mo);

      chortle.assignExercise(james, planner);
      chortle.assignExercise(james, nutshell);
      rose.assignExercise(kevin, fitted);
      rose.assignExercise(kevin, nutshell);
      mo.assignExercise(willy, holidayroad);
      mo.assignExercise(willy, nutshell);
      rose.assignExercise(audrey, planner);
      rose.assignExercise(audrey, fitted);

      studentsList.Add(willy);
      studentsList.Add(audrey);
      studentsList.Add(james);
      studentsList.Add(kevin);

      exercisesList.Add(nutshell);
      exercisesList.Add(holidayroad);
      exercisesList.Add(fitted);
      exercisesList.Add(planner);

      foreach (Exercise exercise in exercisesList)
      {
        Console.WriteLine($"-------{exercise.Name}-------");
        foreach (Student student in studentsList)
        {
          foreach (Exercise singleExercise in student.Exercises)
          {
            if (singleExercise.Name == exercise.Name)
            {
              Console.WriteLine($"{student.FirstName} {student.LastName}");
              Console.WriteLine($" ");
            }
          }
        }

      }





    }
  }
}
