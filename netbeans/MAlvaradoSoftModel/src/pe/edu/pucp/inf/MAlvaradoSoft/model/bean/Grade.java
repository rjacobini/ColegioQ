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
    private double value;
    private String description;
    private String weight;
    private int codStudent;
    private Date registerDate;

    public Grade(double value, String description, String weight, int codStudent, Date registerDate) {
        this.value = value;
        this.description = description;
        this.weight = weight;
        this.codStudent = codStudent;
        this.registerDate = registerDate;
    }

    public Grade() {
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

    public String getWeight() {
        return weight;
    }

    public void setWeight(String weight) {
        this.weight = weight;
    }

    public int getCodStudent() {
        return codStudent;
    }

    public void setCodStudent(int codStudent) {
        this.codStudent = codStudent;
    }

    public Date getRegisterDate() {
        return registerDate;
    }

    public void setRegisterDate(Date registerDate) {
        this.registerDate = registerDate;
    }
    
}
