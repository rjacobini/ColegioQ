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
public class Teacher {
    private ArrayList<CourseXSchedule> classes;
    private ArrayList<Workshop> workshops;

    public Teacher() {
    }

    public Teacher(ArrayList<CourseXSchedule> classes, ArrayList<Workshop> workshops) {
        this.classes = classes;
        this.workshops = workshops;
    }

    public ArrayList<CourseXSchedule> getClasses() {
        return classes;
    }

    public void setClasses(ArrayList<CourseXSchedule> classes) {
        this.classes = classes;
    }

    public ArrayList<Workshop> getWorkshops() {
        return workshops;
    }

    public void setWorkshops(ArrayList<Workshop> workshops) {
        this.workshops = workshops;
    }
    
}
