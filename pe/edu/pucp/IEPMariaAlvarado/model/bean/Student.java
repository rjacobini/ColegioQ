package pe.edu.pucp.IEPMariaAlvarado.model.bean;
import java.util.ArrayList;

public class Student extends Person{
	private int codStudent;
	private ArrayList <CourseXSchedule> courses;
	private Condition condition;
	private int grade;
	private char section;
}