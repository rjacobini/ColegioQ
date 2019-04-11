package pe.edu.pucp.IEPMariaAlvarado.model.bean;
import java.util.ArrayList;

public class Section{
	private int capacity;
	private char section;
	private ArrayList<Student> students;
	private ArrayList<CourseXSchedule> courses;

    public int getCapacity() {
        return capacity;
    }

    public void setCapacity(int capacity) {
        this.capacity = capacity;
    }

    public char getSection() {
        return section;
    }

    public void setSection(char section) {
        this.section = section;
    }

    public ArrayList<Student> getStudents() {
        return students;
    }

    public void setStudents(ArrayList<Student> students) {
        this.students = students;
    }

    public ArrayList<CourseXSchedule> getCourses() {
        return courses;
    }

    public void setCourses(ArrayList<CourseXSchedule> courses) {
        this.courses = courses;
    }
	
}