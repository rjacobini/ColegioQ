/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.inf.MAlvaradoSoft.model.bean;

import java.sql.Time;
import java.util.ArrayList;
import java.util.Date;

/**
 *
 * @author alulab14
 */
public class Schedule {
    private ArrayList<Date> days;
    private Time startTime;
    private Time endTime;
    private String classroomName;

    public Schedule(ArrayList<Date> days, Time startTime, Time endTime, String classroomName) {
        this.days = days;
        this.startTime = startTime;
        this.endTime = endTime;
        this.classroomName = classroomName;
    }

    public Schedule() {
    }

    public ArrayList<Date> getDays() {
        return days;
    }

    public void setDays(ArrayList<Date> days) {
        this.days = days;
    }

    public Time getStartTime() {
        return startTime;
    }

    public void setStartTime(Time startTime) {
        this.startTime = startTime;
    }

    public Time getEndTime() {
        return endTime;
    }

    public void setEndTime(Time endTime) {
        this.endTime = endTime;
    }

    public String getClassroomName() {
        return classroomName;
    }

    public void setClassroomName(String classroomName) {
        this.classroomName = classroomName;
    }
    
}
