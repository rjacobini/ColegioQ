/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.inf.malvaradosoft.dao;

import java.util.ArrayList;
import pe.edu.pucp.inf.MAlvaradoSoft.model.bean.User;

/**
 *
 * @author alulab14
 */
public interface DAOUser {
    ArrayList <User> queryAll();
    int insert(User user);
    int update(User user);
    int delete(User user);
}
