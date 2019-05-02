/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.inf.MAlvaradoSoft.model.bean;

import java.util.Date;

/**
 *
 * @author alulab14
 */
public class Grade {
    private int idGrade;
    private double value;
    private String description;
    private double weight;
    private int idStudent;
    private Date registerDate;
    private int idCourseSchedule;

    public Grade(double value, String description, double weight, int codStudent, Date registerDate) {
        this.value = value;
        this.description = description;
        this.weight = weight;
        this.idStudent = codStudent;
        this.registerDate = registerDate;
        this.idCourseSchedule= idCourseSchedule;
    }

    public Grade() {
    }

    public int getIdGrade() {
        return idGrade;
    }

    public void setIdGrade(int idGrade) {
        this.idGrade = idGrade;
    }

    public int getIdCourseSchedule() {
        return idCourseSchedule;
    }

    public void setIdCourseSchedule(int idCourseSchedule) {
        this.idCourseSchedule = idCourseSchedule;
    }

    public double getValue() {
        return value;
    }

    public void setValue(double value) {
        this.value = value;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public double getWeight() {
        return weight;
    }

    public void setWeight(double weight) {
        this.weight = weight;
    }

    public int getIdStudent() {
        return idStudent;
    }

    public void setIdStudent(int idStudent) {
        this.idStudent = idStudent;
    }

    public Date getRegisterDate() {
        return registerDate;
    }

    public void setRegisterDate(Date registerDate) {
        this.registerDate = registerDate;
    }
    
}
