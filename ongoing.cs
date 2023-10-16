using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		Student student = new Student();
		student.FullName = "John Doe";
		
	}
}

public class Student
{
	private string fullName;

	private string course;

	private string email;

	private int phoneNumber;

	private Subject subject;

	private University university;
	
//getters e setters fazer todos
	
	 public string FullName { get => fullName; set => fullName = value;}

	private static int studentsNumber = 0;
	public Student()
	{
		this.fullName = null;
		this.course = null;
		this.email = null;
		this.phoneNumber = 0;
		studentsNumber++;
	}

	public Student(string fullName, string course, Subject subject, University university, string email, int phoneNumber)
	{
		this.fullName = fullName;
		this.course = course;
		this.subject = subject;
		this.university = university;
		this.email = email;
		this.phoneNumber = phoneNumber;
	}

	public void StudentInfo()
	{
		Console.WriteLine("Name:" + this.fullName);
		Console.WriteLine("Course:" + this.course);
		Console.WriteLine("Subject:" + this.subject);
		Console.WriteLine("University:" + this.university);
		Console.WriteLine("Email:" + this.email);
		Console.WriteLine("Phone number:" + this.phoneNumber);
	}
		
} 
public enum Subject
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
