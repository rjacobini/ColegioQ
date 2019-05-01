/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.inf.MAlvaradoSoft.model.bean;

import java.util.ArrayList;

/**
 *
 * @author alulab14
 */
public class Student extends User {
    private ArrayList<CourseXSchedule> courses;
    private String condition;
    private int _class;
    private int section;

    public Student(ArrayList<CourseXSchedule> courses, String condition, int _class, int section, String name, String firstLastName, String secondLastName, String dni, String adress, int phone, String email, boolean active, int id, String nickname, String password) {
        super(name, firstLastName, secondLastName, dni, adress, phone, email, active, id, nickname, password);
        this.courses = courses;
        this.condition = condition;
        this._class = _class;
        this.section = section;
    }

    

    public Student() {
    }

    public ArrayList<CourseXSchedule> getCourses() {
        return courses;
    }

    public void setCourses(ArrayList<CourseXSchedule> courses) {
        this.courses = courses;
    }

    
    public String getCondition() {
        return condition;
    }

    public void setCondition(String condition) {
        this.condition = condition;
    }

    public int get_Class() {
        return _class;
    }

    public void setClass(int _class) {
        this._class = _class;
    }

    public int getSection() {
        return section;
    }

    public void setSection(int section) {
        this.section = section;
    }
    
}
