package pe.edu.pucp.IEPMariaAlvarado.model.bean;
import java.util.ArrayList;
import java.util.Date;

public class Workshop{
	
	private int codWorkshop;
	private int codCourse;
	private int codTeacher;
	private Schedule schedule;
	private ArrayList<Student> students;

    public int getCodWorkshop() {
        return codWorkshop;
    }

    public void setCodWorkshop(int codWorkshop) {
        this.codWorkshop = codWorkshop;
    }

    public int getCodCourse() {
        return codCourse;
    }

    public void setCodCourse(int codCourse) {
        this.codCourse = codCourse;
    }

    public int getCodTeacher() {
        return codTeacher;
    }

    public void setCodTeacher(int codTeacher) {
        this.codTeacher = codTeacher;
    }

    public Schedule getSchedule() {
        return schedule;
    }

    public void setSchedule(Schedule schedule) {
        this.schedule = schedule;
    }

    public ArrayList<Student> getStudents() {
        return students;
    }

    public void setStudents(ArrayList<Student> students) {
        this.students = students;
    }
        
        
	
}