/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.inf.MAlvaradoSoft.model.bean;

/**
 *
 * @author alulab14
 */
public class Secretary extends User{

    public Secretary(String name, String firstLastName, String secondLastName, String dni, String adress, int phone, String email, boolean active, int id, String nickname, String password) {
        super(name, firstLastName, secondLastName, dni, adress, phone, email, active, id, nickname, password);
    }

    public Secretary() {
    }
    
    
}
