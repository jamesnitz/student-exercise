using System;
using System.Collections.Generic;
using System.Linq;

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
      Exercise pushups = new Exercise("pushups", "athletics");

      Cohort cohort36 = new Cohort("Cohort 36");
      Cohort cohort37 = new Cohort("Cohort 37");
      Cohort cohort38 = new Cohort("Cohort 38");

      Student willy = new Student("Willy", "Metcalf", "sw3k", cohort37);
      Student audrey = new Student("Audrey", "Borgra", "audbor", cohort37);
      Student kevin = new Student("Kevin", "Kevinson", "kev.dev", cohort37);
      Student james = new Student("James", "Nitz", "nitzle", cohort37);
      Student cooper = new Student("Cooper", "Cooperson", "coop", cohort38);
      Student slacker = new Student("slacker", "Slackerson", "slack", cohort38);
      Student john = new Student("john", "johnson", "jj", cohort36);

      Instructor rose = new Instructor("rose", "roseington", "roseallday", cohort37, "fashion");
      Instructor chortle = new Instructor("Steve", "Brownlee", "chortlehoort", cohort37, "dad jokes");
      Instructor mo = new Instructor("mo", "money", "momo", cohort37, "making cheesecake");
      Instructor andy = new Instructor("andy", "anderson", "slackhandle1", cohort38, "coding");
      List<Instructor> instructorList = new List<Instructor>(){
        rose,
        chortle,
        mo,
        andy
      };
      List<Cohort> cohortList = new List<Cohort>(){
        cohort37,
        cohort36,
        cohort37
      };



      cohort36.addStudent(john);
      cohort37.addStudent(willy);
      cohort37.addStudent(audrey);
      cohort37.addStudent(kevin);
      cohort37.addStudent(james);
      cohort37.addInstructor(rose);
      cohort37.addInstructor(chortle);
      cohort37.addInstructor(mo);
      cohort38.addInstructor(andy);

      chortle.assignExercise(james, planner);
      chortle.assignExercise(james, nutshell);
      rose.assignExercise(kevin, fitted);
      rose.assignExercise(kevin, nutshell);
      mo.assignExercise(willy, holidayroad);
      mo.assignExercise(willy, nutshell);
      mo.assignExercise(willy, pushups);
      rose.assignExercise(audrey, planner);
      rose.assignExercise(audrey, fitted);

      studentsList.Add(willy);
      studentsList.Add(audrey);
      studentsList.Add(james);
      studentsList.Add(kevin);
      studentsList.Add(cooper);
      studentsList.Add(slacker);
      studentsList.Add(john);

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

      //List JAVASCRIPT EXERCISES
      var javascriptExercises = exercisesList.Where(exercise =>
      {
        return exercise.Language == "javascript";
      }).ToList();
      foreach (var exercise in javascriptExercises)
      {
        Console.WriteLine($"{exercise.Name} is written in JavaScript");
      }
      //List students in a particular cohort EXERCISES
      var cohort38Students = studentsList.Where(student =>
      {
        return student.Cohort == cohort38;
      }).ToList();
      foreach (var student in cohort38Students)
      {
        Console.WriteLine($"{student.FirstName} is in Cohort 38!");
      }
      //List instructors in a particular cohort EXERCISES
      var instructorsInCohort38 = instructorList.Where(instructor =>
      {
        return instructor.Cohort == cohort38;
      }).ToList();
      foreach (var instructor in instructorsInCohort38)
      {
        Console.WriteLine($"{instructor.FirstName} is in Cohort 38!");
      }
      //Sort students by last name
      var studentsSortedByLastName = studentsList.OrderBy(student => student.LastName).ToList();
      foreach (var student in studentsSortedByLastName)
      {
        Console.WriteLine($"{student.FirstName} {student.LastName}");
      }
      //students not working on anything
      var studentsNotWorking = studentsList.Where(student =>
      {
        return student.Exercises == null || student.Exercises.Count() == 0;
      });
      foreach (var student in studentsNotWorking)
      {
        Console.WriteLine($"{student.FirstName} {student.LastName} isnt working on anything");
      }
      //Sort students by who's doing the most exercise
      var overAchiever = studentsList.OrderByDescending(student => student.Exercises.Count()).ToList().FirstOrDefault();
      Console.WriteLine($"{overAchiever.FirstName} {overAchiever.LastName} has the most exercises ");

      var groups = studentsList.GroupBy(student => student.Cohort.Name);

      foreach (var group in groups)
      {
        Console.WriteLine($"There are {group.Count()} in {group.Key}");

      }


    }

  }
}
