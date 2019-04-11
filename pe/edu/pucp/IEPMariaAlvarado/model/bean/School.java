package pe.edu.pucp.IEPMariaAlvarado.model.bean;
import java.util.ArrayList;

public class School{
	private String name;
	private String address;
	private Class classes;
	private ArrayList<Secretary> secretaries;
	private Auxiliar auxiliar;
	private ArrayList<Parent> parents;
	private ArrayList<Teacher> teachers;
	private ExamsRepository exams; 
	private Principal principal;

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getAddress() {
        return address;
    }

    public void setAddress(String address) {
        this.address = address;
    }

    public Class getClasses() {
        return classes;
    }

    public void setClasses(Class classes) {
        this.classes = classes;
    }

    public ArrayList<Secretary> getSecretaries() {
        return secretaries;
    }

    public void setSecretaries(ArrayList<Secretary> secretaries) {
        this.secretaries = secretaries;
    }

    public Auxiliar getAuxiliar() {
        return auxiliar;
    }

    public void setAuxiliar(Auxiliar auxiliar) {
        this.auxiliar = auxiliar;
    }

    public ArrayList<Parent> getParents() {
        return parents;
    }

    public void setParents(ArrayList<Parent> parents) {
        this.parents = parents;
    }

    public ArrayList<Teacher> getTeachers() {
        return teachers;
    }

    public void setTeachers(ArrayList<Teacher> teachers) {
        this.teachers = teachers;
    }

    public ExamsRepository getExams() {
        return exams;
    }

    public void setExams(ExamsRepository exams) {
        this.exams = exams;
    }

    public Principal getPrincipal() {
        return principal;
    }

    public void setPrincipal(Principal principal) {
        this.principal = principal;
    }
	
	
	
	
}