using System;

struct Book {
	
	private String title;
	private String author;
	private String subject;
	private int id;
	
	public Book(String title, String author, String subject, int id) {
		this.title = title;
		this.author = author;
		this.subject = subject;
		this.id = id;
	}

	public void setValues(String t, String a, String s, int i) {
		this.title = t;
		this.author = a;
		this.subject = s;
		this.id = i;
	}

	public void display() {	
		Console.WriteLine("Title : {0}", title);
		Console.WriteLine("Author : {0}", author);
		Console.WriteLine("Subject : {0}", subject);
		Console.WriteLine("Book id : {0}", id);
	}

};

public class TestStruct {
	public static void Main(String[] args) {
		Book book1 = new Book("C Programming", "Nuha Ali", "C Programming Tutorial", 6495407);
		Book book2 = new Book();
		
		book2.setValues("Telecom Billing", "Zara Ali", "Telecom Billing Tutorial", 6495700);
		book1.display();
		book2.display();
		Console.ReadKey();
	}
}
