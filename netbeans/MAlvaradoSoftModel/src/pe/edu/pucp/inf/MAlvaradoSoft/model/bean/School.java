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
public class School {
    private String name;
    private String adress;
    private ArrayList<Class> classes;
    private ArrayList<Secretary> secretary;
    private Auxiliar auxiliar;
    private ArrayList<Guardian> guardian;
    private ArrayList<Teacher> teachers;
    private ArrayList<Exam> examens;
    private Principal principal;

    public School(String name, String adress, ArrayList<Class> classes, ArrayList<Secretary> secretary, Auxiliar auxiliar, ArrayList<Guardian> guardian, ArrayList<Teacher> teachers, ArrayList<Exam> examens, Principal principal) {
        this.name = name;
        this.adress = adress;
        this.classes = classes;
        this.secretary = secretary;
        this.auxiliar = auxiliar;
        this.guardian = guardian;
        this.teachers = teachers;
        this.examens = examens;
        this.principal = principal;
    }

    

    public School() {
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getAdress() {
        return adress;
    }

    public void setAdress(String adress) {
        this.adress = adress;
    }

    public ArrayList<Class> getClasses() {
        return classes;
    }

    public void setClasses(ArrayList<Class> classes) {
        this.classes = classes;
    }

    public ArrayList<Secretary> getSecretary() {
        return secretary;
    }

    public void setSecretary(ArrayList<Secretary> secretary) {
        this.secretary = secretary;
    }

    public Auxiliar getAuxiliar() {
        return auxiliar;
    }

    public void setAuxiliar(Auxiliar auxiliar) {
        this.auxiliar = auxiliar;
    }

    public ArrayList<Guardian> getGuardian() {
        return guardian;
    }

    public void setGuardian(ArrayList<Guardian> guardian) {
        this.guardian = guardian;
    }

    public ArrayList<Teacher> getTeachers() {
        return teachers;
    }

    public void setTeachers(ArrayList<Teacher> teachers) {
        this.teachers = teachers;
    }

    public ArrayList<Exam> getExamens() {
        return examens;
    }

    public void setExamens(ArrayList<Exam> examens) {
        this.examens = examens;
    }

    public Principal getPrincipal() {
        return principal;
    }

    public void setPrincipal(Principal principal) {
        this.principal = principal;
    }
    
}
