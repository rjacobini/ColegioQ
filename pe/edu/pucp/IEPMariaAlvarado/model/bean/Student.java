package pe.edu.pucp.IEPMariaAlvarado.model.bean;
import java.util.ArrayList;

public class Student extends Person{
	private int codStudent;
	private ArrayList <CourseXSchedule> courses;
	private Condition condition;
	private int grade;
	private char section;

    public int getCodStudent() {
        return codStudent;
    }

    public void setCodStudent(int codStudent) {
        this.codStudent = codStudent;
    }

    public ArrayList<CourseXSchedule> getCourses() {
        return courses;
    }

    public void setCourses(ArrayList<CourseXSchedule> courses) {
        this.courses = courses;
    }

    public Condition getCondition() {
        return condition;
    }

    public void setCondition(Condition condition) {
        this.condition = condition;
    }

    public int getGrade() {
        return grade;
    }

    public void setGrade(int grade) {
        this.grade = grade;
    }

    public char getSection() {
        return section;
    }

    public void setSection(char section) {
        this.section = section;
    }
        
        
}