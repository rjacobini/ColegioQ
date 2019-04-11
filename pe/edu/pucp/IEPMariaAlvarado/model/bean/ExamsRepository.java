package pe.edu.pucp.IEPMariaAlvarado.model.bean;
import java.util.ArrayList;

public class ExamsRepository{
	private int codRepository;
	private ArrayList<Exam> exams; 

    public int getCodRepository() {
        return codRepository;
    }

    public void setCodRepository(int codRepository) {
        this.codRepository = codRepository;
    }

    public ArrayList<Exam> getExams() {
        return exams;
    }

    public void setExams(ArrayList<Exam> exams) {
        this.exams = exams;
    }
	
        
}