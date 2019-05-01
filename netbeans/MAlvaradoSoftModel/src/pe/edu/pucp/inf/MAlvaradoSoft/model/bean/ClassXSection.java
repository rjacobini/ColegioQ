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
public class ClassXSection {
    private int capacity;
    private int id;
    private ArrayList<Student> students;
    private ArrayList<CourseXSchedule> courses;
    private int _class;
    private char section;

    public ClassXSection() {
    }

    public ClassXSection(int capacity, ArrayList<Student> students, ArrayList<CourseXSchedule> courses, int _class, char section) {
        this.capacity = capacity;
        this.students = students;
        this.courses = courses;
        this._class = _class;
        this.section = section;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    
    
    public int getCapacity() {
        return capacity;
    }

    public void setCapacity(int capacity) {
        this.capacity = capacity;
    }

    public ArrayList<Student> getStudents() {
        return students;
    }

    public void setStudents(ArrayList<Student> students) {
        this.students = students;
    }

    public ArrayList<CourseXSchedule> getCourses() {
        return courses;
    }

    public void setCourses(ArrayList<CourseXSchedule> courses) {
        this.courses = courses;
    }

    public int get_Class() {
        return _class;
    }

    public void setClass(int _class) {
        this._class = _class;
    }

    public char getSection() {
        return section;
    }

    public void setSection(char section) {
        this.section = section;
    }
    
}
