package pe.edu.pucp.IEPMariaAlvarado.model.bean;
import java.util.ArrayList;

public class CourseXSchedule{
	private int codCourseXSchedule;
	private Schedule schedule;
	private ArrayList<Grade> grades;
	private int codTeacher;
	private Course course;
	private char section;

    public int getCodCourseXSchedule() {
        return codCourseXSchedule;
    }

    public void setCodCourseXSchedule(int codCourseXSchedule) {
        this.codCourseXSchedule = codCourseXSchedule;
    }

    public Schedule getSchedule() {
        return schedule;
    }

    public void setSchedule(Schedule schedule) {
        this.schedule = schedule;
    }

    public ArrayList<Grade> getGrades() {
        return grades;
    }

    public void setGrades(ArrayList<Grade> grades) {
        this.grades = grades;
    }

    public int getCodTeacher() {
        return codTeacher;
    }

    public void setCodTeacher(int codTeacher) {
        this.codTeacher = codTeacher;
    }

    public Course getCourse() {
        return course;
    }

    public void setCourse(Course course) {
        this.course = course;
    }

    public char getSection() {
        return section;
    }

    public void setSection(char section) {
        this.section = section;
    }
	
        
}