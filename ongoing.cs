using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		
		
		
	}
}

public class Student
{
	//Fields
	private string fullName;

	private string course;

	private string email;

	private int phoneNumber;

	private Subject subject;

	private University university;
	
//getters e setters
	public string FullName { get => fullName; set => fullName = value;}
	public string Course { get => course; set => course = value;}
	public string Email { get => email; set => email = value;}
	public int PhoneNumber { get => phoneNumber; set => phoneNumber = value;}
	public Subject Subject { get => subject; set => subject = value;}
	public University University { get => university; set => university = value;}
	

	private static int studentsNumber = 0; //Contador de estudantes
	public Student() //Primeiro construtor
	{
		this.fullName = null;
		this.course = null;
		this.email = null;
		this.phoneNumber = 0;
		studentsNumber++;
	}

	public Student(string fullName, string course, Subject subject, University university, string email, int phoneNumber) //Construtor com parametros
	{
		this.fullName = fullName;
		this.course = course;
		this.subject = subject;
		this.university = university;
		this.email = email;
		this.phoneNumber = phoneNumber;
	}

	public void StudentInfo() //Método para mostrar informação do estudante matriculado
	{
		Console.WriteLine("Name:" + this.fullName);
		Console.WriteLine("Course:" + this.course);
		Console.WriteLine("Subject:" + this.subject);
		Console.WriteLine("University:" + this.university);
		Console.WriteLine("Email:" + this.email);
		Console.WriteLine("Phone number:" + this.phoneNumber);
	}
		
} 

public class StudentTest
{
	
	private static List<Student> students = new List<Student>();

    public static List<Student> Students { get => students; }

    public static void CreateStudents()
    {
        Student student1 = new Student("Gustavo", "DS", Subject.Portuguese, University.USP, "juicewrld@gmail.com", 1166699966);
        Student student2 = new Student("Maria", "Engenharia Civil", Subject.Spanish, University.Harvard, "maria@gmail.com", 1155544433);
        Student student3 = new Student("João", "Medicina", Subject.Math, University.Stanford, "joao@gmail.com", 1122211100);

        students.Add(student1);
        students.Add(student2);
        students.Add(student3);
    }
		
		
	
}
public enum Subject //Enumerations
{
	Math,
	Science,
	History,
	Spanish,
	Portuguese
}

public enum University
{
	Stanford,
	USP,
	Harvard,
}
