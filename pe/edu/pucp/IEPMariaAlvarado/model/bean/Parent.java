package pe.edu.pucp.IEPMariaAlvarado.model.bean;
import java.util.ArrayList;

public class Parent extends Person{
	private int codParent;
	private ArrayList<Student> students;

    public int getCodParent() {
        return codParent;
    }

    public void setCodParent(int codParent) {
        this.codParent = codParent;
    }

    public ArrayList<Student> getStudents() {
        return students;
    }

    public void setStudents(ArrayList<Student> students) {
        this.students = students;
    }
        
        
}