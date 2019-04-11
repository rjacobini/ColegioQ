package pe.edu.pucp.IEPMariaAlvarado.model.bean;
import java.util.ArrayList;
import java.util.Date;

public class Schedule{
	private ArrayList<Date> days;
	private Date startTime;
	private Date endTime;
	private String classRoom;

    public ArrayList<Date> getDays() {
        return days;
    }

    public void setDays(ArrayList<Date> days) {
        this.days = days;
    }

    public Date getStartTime() {
        return startTime;
    }

    public void setStartTime(Date startTime) {
        this.startTime = startTime;
    }

    public Date getEndTime() {
        return endTime;
    }

    public void setEndTime(Date endTime) {
        this.endTime = endTime;
    }

    public String getClassRoom() {
        return classRoom;
    }

    public void setClassRoom(String classRoom) {
        this.classRoom = classRoom;
    }
        
        
}