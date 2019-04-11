package pe.edu.pucp.IEPMariaAlvarado.model.bean;
import java.util.ArrayList;
public class Teacher extends Person{
	private int codTeacher;
	private ArrayList<CourseXSchedule> courses;
	private ArrayList<Workshop> workshops;

    public int getCodTeacher() {
        return codTeacher;
    }

    public void setCodTeacher(int codTeacher) {
        this.codTeacher = codTeacher;
    }

    public ArrayList<CourseXSchedule> getCourses() {
        return courses;
    }

    public void setCourses(ArrayList<CourseXSchedule> courses) {
        this.courses = courses;
    }

    public ArrayList<Workshop> getWorkshops() {
        return workshops;
    }

    public void setWorkshops(ArrayList<Workshop> workshops) {
        this.workshops = workshops;
    }
	
}