package pe.edu.pucp.IEPMariaAlvarado.model.bean;
public class Exam{
	private int codExam;
	private int codCourse;
	private String description;
	private String state;

    public int getCodExam() {
        return codExam;
    }

    public void setCodExam(int codExam) {
        this.codExam = codExam;
    }

    public int getCodCourse() {
        return codCourse;
    }

    public void setCodCourse(int codCourse) {
        this.codCourse = codCourse;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public String getState() {
        return state;
    }

    public void setState(String state) {
        this.state = state;
    }
        
        
}