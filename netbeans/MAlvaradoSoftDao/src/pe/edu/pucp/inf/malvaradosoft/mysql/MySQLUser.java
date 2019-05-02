/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.inf.malvaradosoft.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import pe.edu.pucp.inf.MAlvaradoSoft.model.bean.User;
import pe.edu.pucp.inf.malvaradosoft.config.DBManager;
import pe.edu.pucp.inf.malvaradosoft.dao.DAOUser;

/**
 *
 * @author alulab14
 */
public class MySQLUser implements DAOUser{

    @Override
    public ArrayList<User> queryAll() {
        ArrayList<User> users = new ArrayList<User>();
        try{
            DBManager dbManager= DBManager.getDbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            String sql = "SELECT * FROM User";
            Statement st = con.createStatement();
            ResultSet rs = st.executeQuery(sql);
            
            while(rs.next()){
                User u = new User();
                u.setId(rs.getInt("id"));           
                users.add(u);
            }
            con.close();
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return users;
        
    }

    @Override
    public int insert(User user) {
        int result = 0;
        try{
            DBManager dbManager = DBManager.getDbManager();
            Connection con = DriverManager.getConnection(
            dbManager.getUrl(), 
            dbManager.getUser(), 
            dbManager.getPassword());
            CallableStatement cs = con.prepareCall("" + "{call insertStudent(?,?,?,?,?,?,?,?,?,?)}");
            cs.setInt(1, user.getId());
            cs.setString(2, user.getName());
            cs.setString(3, user.getFirstLastName());
            cs.setString(4, user.getSecondLastName());
            cs.setString(5, user.getDni());
            cs.setString(6, user.getAdress());
            cs.setInt(7, user.getPhone());
            cs.setString(8, user.getEmail());
            cs.setString(9, user.getUserName());
            cs.setString(10, user.getPassword());
            
            result = cs.executeUpdate();
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return result;
        
    }

    @Override
    public int update(User user) {
        int result = 0;
        try{
            DBManager dbManager = DBManager.getDbManager();
            Connection con = DriverManager.getConnection(
            dbManager.getUrl(), 
            dbManager.getUser(), 
            dbManager.getPassword());
            CallableStatement cs = con.prepareCall(""
                    + "{call updateUser(?,?,?,?,?,?,?,?,?,?)}");
            cs.setInt(1, user.getId());
            cs.setString(2, user.getName());
            cs.setString(3, user.getFirstLastName());
            cs.setString(4, user.getSecondLastName());
            cs.setString(5, user.getDni());
            cs.setString(6, user.getAdress());
            cs.setInt(7, user.getPhone());
            cs.setString(8, user.getEmail());
            cs.setString(9, user.getUserName());
            cs.setString(10, user.getPassword());
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return result;
    }

    @Override
    public int delete(User user) {
        int result= 0;
        try{
            DBManager dbManager= DBManager.getDbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            CallableStatement cs = con.prepareCall(""
                    + "{call deleteUser(?)}");
            cs.setInt(1, user.getId());
            result= cs.executeUpdate();
            con.close();            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return result;
        
    }
    
}
